using System;
using System.Collections.Generic;

namespace Lncodes.Tutorial.Facade
{
    public sealed class SingeltonFacade
    {
        private Dictionary<Type, Armors> _armorCollection = new Dictionary<Type, Armors>();
        private Dictionary<Type, Weapons> _weaponCollection = new Dictionary<Type, Weapons>();
        private Dictionary<Type, SkillBook> _skillBookCollection = new Dictionary<Type, SkillBook>();

        #region Singelton
        private static readonly Lazy<SingeltonFacade> _instance = new Lazy<SingeltonFacade>(CreateInstance);

        private SingeltonFacade() 
        {
            _armorCollection.Add(typeof(HeavyArmor), new HeavyArmor());
            _armorCollection.Add(typeof(LightArmor), new LightArmor());

            _skillBookCollection.Add(typeof(SabotageSkillBook), new SabotageSkillBook());
            _skillBookCollection.Add(typeof(CyrotherapySkillBook), new CyrotherapySkillBook());

            _weaponCollection.Add(typeof(Bow), new Bow());
            _weaponCollection.Add(typeof(Sword), new Sword());
        }

        public static SingeltonFacade CreateInstance() =>
            new SingeltonFacade();

        public static SingeltonFacade GetInstance() =>
            _instance.Value;
        #endregion

        public T UseSkillBook<T>(int playerSkillPoint) where T : SkillBook
        {
            var selectedSkillBookType = typeof(T);
            var skillBook = _skillBookCollection[selectedSkillBookType];
            if (!skillBook.TryUse(playerSkillPoint))
                return null;
            _weaponCollection.Remove(selectedSkillBookType);
            return skillBook as T;
        }

        public T UseArmor<T>(int playerStreangth) where T : Armors
        {
            var selectedArmorType = typeof(T);
            var armor = _armorCollection[selectedArmorType];
            if (!armor.TryUse(playerStreangth))
                return null;
            _weaponCollection.Remove(selectedArmorType);
            return armor as T;
        }

        public T UseWeapon<T>(PlayerClassTypes playerClass) where T : Weapons
        {
            var selectedWeaponType = typeof(T);
            var weapon = _weaponCollection[selectedWeaponType];
            if (!weapon.TryUse(playerClass))
                return null;
            _weaponCollection.Remove(selectedWeaponType);
            return weapon as T;
        }
    }
}
