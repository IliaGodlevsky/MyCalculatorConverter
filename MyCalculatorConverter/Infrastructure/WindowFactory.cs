﻿using MyСalculatorConverter.Infrastructure.Abstraction;

using System.Windows;

namespace MyСalculatorConverter.Infrastructure
{
    internal sealed class WindowFactory : IWindowFactory
    {
		public Window CreateWindow(WindowCreationOptions options)
		{
			return new Window()
			{
				WindowStartupLocation = WindowStartupLocation.CenterOwner,
				Title = options.Title,
				Width = options.WindowSize.Size.Width,
				Height = options.WindowSize.Size.Height,
				Owner = Application.Current.MainWindow
			};
		}
	}
}
