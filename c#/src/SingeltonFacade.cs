using System;

namespace Lncodes.Tutorial.Facade
{
    public sealed class SingeltonFacade : RegulerFacade
    {
        #region Singelton
        private static readonly Lazy<SingeltonFacade> _instance = new Lazy<SingeltonFacade>(CreateInstance);

        private SingeltonFacade() { }

        public static SingeltonFacade CreateInstance() =>
            new SingeltonFacade();

        public static SingeltonFacade GetInstance() =>
            _instance.Value;
        #endregion
    }
}
