﻿using WinUIEx;

namespace Rebound.TrustedPlatform;

public partial class App : Application
{
    public static WindowEx m_window;

    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        m_window = new MainWindow();
        m_window.Show();
    }
}

