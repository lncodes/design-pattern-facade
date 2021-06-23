using Xunit;

namespace Lncodes.Tutorial.Facade.Test
{
    public sealed class ArmorsTheoryData : TheoryData<Armors, int>
    {
        public ArmorsTheoryData()
        {
            Add(new LightArmor(), 10);
            Add(new HeavyArmor(), 20);
        }
    }
}
