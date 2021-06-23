namespace Lncodes.Tutorial.Facade
{
    public class RegulerFacade : Inventory
    {
        public override T UseSkillBook<T>(int playerSkillPoint)
        {
            var selectedSkillBookType = typeof(T);
            var skillBook = _skillBookCollection[selectedSkillBookType];
            if (!skillBook.TryUse(playerSkillPoint))
                return null;
            _weaponCollection.Remove(selectedSkillBookType);
            return skillBook as T;
        }

        public override T UseArmor<T>(int playerStreangth)
        {
            var selectedArmorType = typeof(T);
            var armor = _armorCollection[selectedArmorType];
            if (!armor.TryUse(playerStreangth))
                return null;
            _weaponCollection.Remove(selectedArmorType);
            return armor as T;
        }

        public override T UseWeapon<T>(PlayerClassTypes playerClass)
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