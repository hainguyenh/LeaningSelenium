namespace MoreFluentAndApplySingleton.ImprovedVersion
{
    public partial class PracticePage
    {
        public string GetTitle => WrappedDriver.Title;
    }
}
