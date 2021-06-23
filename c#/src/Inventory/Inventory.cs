using System;
using System.Collections.Generic;
using System.Text;

namespace Lncodes.Tutorial.Facade
{
    public abstract class Inventory
    {
        protected readonly Dictionary<Type, Armors> _armorCollection = new Dictionary<Type, Armors>();
        protected readonly Dictionary<Type, Weapons> _weaponCollection = new Dictionary<Type, Weapons>();
        protected readonly Dictionary<Type, SkillBook> _skillBookCollection = new Dictionary<Type, SkillBook>();

        public Inventory()
        {
            _armorCollection.Add(typeof(HeavyArmor), new HeavyArmor());
            _armorCollection.Add(typeof(LightArmor), new LightArmor());

            _skillBookCollection.Add(typeof(SabotageSkillBook), new SabotageSkillBook());
            _skillBookCollection.Add(typeof(CyrotherapySkillBook), new CyrotherapySkillBook());

            _weaponCollection.Add(typeof(Bow), new Bow());
            _weaponCollection.Add(typeof(Sword), new Sword());
        }

        public abstract T UseArmor<T>(int playerStreangth) where T : Armors;

        public abstract T UseSkillBook<T>(int playerSkillPoint) where T : SkillBook;

        public abstract T UseWeapon<T>(PlayerClassTypes playerClass) where T : Weapons;
    }
}
