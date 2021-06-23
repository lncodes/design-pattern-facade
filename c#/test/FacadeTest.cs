using Xunit;

namespace Lncodes.Tutorial.Facade.Test
{
    public sealed class FacadeTest
    {
        [Theory]
        [ClassData(typeof(WeaponsTheoryData))]
        public void Use_Weapon_AreNotNull<T>(T weapon, PlayerClassTypes playerClass) where T : Weapons
        {
            var facade = new Facade();
            var result = facade.UseWeapon<T>(playerClass);
            Assert.NotNull(result);
        }

        [Theory]
        [ClassData(typeof(SkillBookTheoryData))]
        public void Use_SkillBook_AreNotNull<T>(T skillBook, int playerSkillPoint) where T : SkillBook
        {
            var facade = new Facade();
            var result = facade.UseSkillBook<T>(playerSkillPoint);
            Assert.NotNull(result);
        }

        [Theory]
        [ClassData(typeof(ArmorsTheoryData))]
        public void Use_Armor_AreNotNull<T>(T armor, int playerStrength) where T : Armors
        {
            var facade = new Facade();
            var result = facade.UseArmor<T>(playerStrength);
            Assert.NotNull(result);
        }
    }
}
