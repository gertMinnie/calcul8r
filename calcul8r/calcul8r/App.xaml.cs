using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace calcul8re
{
    public partial class App : Application
    {
        public App()
        {
            try
            {
                initCalculator();
            }
            catch (Exception)
            {
                MainPage.DisplayAlert("Alert", "well crap dude", "OK");
                throw;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private static void initCalculator()
        {
            //STYLING START

            var greyButton = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#757575") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.FromHex("#FFFF00") },
                    new Setter { Property = Button.CornerRadiusProperty, Value = 0 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }
                }
            };
            var darkGreyButton = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#616161") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.FromHex("#FFFF00") },
                    new Setter { Property = Button.CornerRadiusProperty, Value = 0 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }
                }
            };
            var yellowButton = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#FFFF00") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.FromHex("#757575") },
                    new Setter { Property = Button.CornerRadiusProperty, Value = 0 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }
                }
            };

            //STYLING END

            var grid = new Grid { RowSpacing = 1, ColumnSpacing = 1 };
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var calcField = new Label
            {
                Text = "0",
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.End,
                TextColor = Color.Yellow,
                FontSize = 60
            };
            grid.Children.Add(calcField, 0, 0);
            Grid.SetColumnSpan(calcField, 4);

            grid.Children.Add(new Button { Text = "7", Style = greyButton }, 0, 1);
            grid.Children.Add(new Button { Text = "8", Style = greyButton }, 1, 1);
            grid.Children.Add(new Button { Text = "9", Style = greyButton }, 2, 1);
            grid.Children.Add(new Button { Text = "/", Style = yellowButton }, 3, 1);
            grid.Children.Add(new Button { Text = "4", Style = greyButton }, 0, 2);
            grid.Children.Add(new Button { Text = "5", Style = greyButton }, 1, 2);
            grid.Children.Add(new Button { Text = "6", Style = greyButton }, 2, 2);
            grid.Children.Add(new Button { Text = "*", Style = yellowButton }, 3, 2);
            grid.Children.Add(new Button { Text = "1", Style = greyButton }, 0, 3);
            grid.Children.Add(new Button { Text = "2", Style = greyButton }, 1, 3);
            grid.Children.Add(new Button { Text = "3", Style = greyButton }, 2, 3);
            grid.Children.Add(new Button { Text = "-", Style = yellowButton }, 3, 3);
            grid.Children.Add(new Button { Text = "+", Style = yellowButton }, 3, 4);
            grid.Children.Add(new Button { Text = "C", Style = darkGreyButton }, 0, 5);

            var zeroButton = new Button { Text = "0", Style = greyButton };
            grid.Children.Add(zeroButton, 0, 4);
            Grid.SetColumnSpan(zeroButton, 3);

            var equalsButton = new Button { Text = "=", Style = yellowButton };
            grid.Children.Add(equalsButton, 1, 5);
            Grid.SetColumnSpan(equalsButton, 3);
        }
    }
}
