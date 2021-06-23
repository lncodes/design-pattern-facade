namespace Lncodes.Tutorial.Facade
{
    public abstract class Weapons
    {
        protected abstract PlayerClassTypes RequiredClass { get; }

        public bool TryUse(PlayerClassTypes playerClass) =>
            playerClass.Equals(RequiredClass);
    }
}