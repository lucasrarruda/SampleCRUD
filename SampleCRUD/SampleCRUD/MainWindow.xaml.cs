using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using SampleCRUD.View.Views;
using System;
using Windows.Foundation;
using Windows.Graphics;
using Windows.UI.ViewManagement;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleCRUD
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private AppWindow _appWindow;
        public MainWindow()
        {
            this.InitializeComponent();
            InitializeWindow();

            rootFrame.Navigate(typeof(MenuView));
        }

        private void InitializeWindow()
        {
            ExtendsContentIntoTitleBar = true;

            IntPtr hWnd = WindowNative.GetWindowHandle(this);
            WindowId windowId = Win32Interop.GetWindowIdFromWindow(hWnd);
            _appWindow = AppWindow.GetFromWindowId(windowId);

            if (_appWindow != null)
            {
                _appWindow.Resize(new SizeInt32(350, 340));
            }
        }
    }
}
