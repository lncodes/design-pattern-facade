namespace Lncodes.Tutorial.Facade
{
    public sealed class Sword : Weapons
    {
        protected override PlayerClassTypes RequiredClass => PlayerClassTypes.Knight;
    }
}
