
namespace MoreFluentAndApplySingleton.ImprovedVersion
{
    public partial class MainPage
    {
        public string GetTitle
        {
            get
            {
                return _driver.Title;
            }
        }
    }
}
