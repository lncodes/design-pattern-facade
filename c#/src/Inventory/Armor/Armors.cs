namespace Lncodes.Tutorial.Facade
{
    public abstract class Armors
    {
        public abstract int RequiredStrength { get; }

        public bool TryUse(int playerStreangth) =>
            playerStreangth >= RequiredStrength;
    }
}
