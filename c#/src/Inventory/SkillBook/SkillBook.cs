namespace Lncodes.Tutorial.Facade   
{
    public abstract class SkillBook
    {
        protected abstract int RequiredSkillPoint { get; }

        public bool TryUse(int playerSkillPoint) =>
            playerSkillPoint.Equals(RequiredSkillPoint);
    }
}
