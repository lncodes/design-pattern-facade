using Xunit;

namespace Lncodes.Tutorial.Facade.Test
{
    public sealed class SkillBookTheoryData : TheoryData<SkillBook, int>
    {
        public SkillBookTheoryData()
        {
            Add(new CyrotherapySkillBook(), 5);
            Add(new SabotageSkillBook(), 10);
        }
    }
}
