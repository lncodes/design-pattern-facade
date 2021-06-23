namespace Lncodes.Tutorial.Facade
{
    public sealed class Bow : Weapons
    {
        protected override PlayerClassTypes RequiredClass => PlayerClassTypes.Ranger;
    }
}
