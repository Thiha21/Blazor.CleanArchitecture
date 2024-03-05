using MudBlazor;

namespace Blazor.CleanArchitecture.Web.Shared
{
    public partial class MainLayout
    {
        bool open = false;
        bool dense = false;
        bool preserveOpenState = false;

        void ToggleDrawer()
        {
            open = !open;
        }
    }
}
