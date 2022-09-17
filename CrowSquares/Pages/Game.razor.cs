using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CrowSquares.Pages
{
    public class GameBase :  ComponentBase
    {
        public string Color = "blue";
        public string RowStyle = "";

        public void ChangeColor()
        {
            if(Color == "blue")
            {
                Color = "red";
                return;
            }

            Color = "blue";
            return;
        }
    }
}
