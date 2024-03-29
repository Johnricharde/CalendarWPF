﻿using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace CalendarWPF.UserControls
{
    /// <summary>
    /// Interaction logic for MenuButton.xaml
    /// </summary>
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
        public static readonly DependencyProperty CaptionProperty = DependencyProperty.
            Register("Caption", typeof(string), typeof(MenuButton));
        
        
        public FontAwesome.WPF.FontAwesomeIcon Icon
        {
            get { return (FontAwesome.WPF.FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty = DependencyProperty.
            Register("Icon", typeof(FontAwesome.WPF.FontAwesomeIcon), typeof(MenuButton));

    }
}
