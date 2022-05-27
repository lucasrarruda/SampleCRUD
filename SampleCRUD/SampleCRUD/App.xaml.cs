﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using SampleCRUD.View.Views;
using SampleCRUD.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleCRUD
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            ConfigureServices();

            this.InitializeComponent();
        }

        private void ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddTransient<MenuViewModel>();
            services.AddTransient<CreateViewModel>();
            services.AddTransient<ReadViewModel>();
            services.AddTransient<UpdateViewModel>();
            services.AddTransient<DeleteViewModel>();

            Ioc.Default.ConfigureServices(services.BuildServiceProvider());
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();

            Frame rootFrame = new Frame();
            //rootFrame.Navigated += OnNavigated;
            //rootFrame.NavigationFailed += OnNavigationFailed;

            m_window.Content = rootFrame;

            rootFrame.Navigate(typeof(MenuView), args.Arguments);

            m_window.Activate();
        }


        private Window m_window;
    }
}
