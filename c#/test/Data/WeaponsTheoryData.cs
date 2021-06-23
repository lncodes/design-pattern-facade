using Xunit;

namespace Lncodes.Tutorial.Facade.Test
{
    public sealed class WeaponsTheoryData : TheoryData<Weapons, PlayerClassTypes>
    {
        public WeaponsTheoryData()
        {
            Add(new Bow(), PlayerClassTypes.Ranger);
            Add(new Sword(), PlayerClassTypes.Knight);
        }
    }
}
