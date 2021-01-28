using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPCustomKeyboard.keys;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UWPCustomKeyboard
{
    public sealed partial class Keyboard : UserControl
    {
        private const int MAX_KEY = 12; // maximum amount of key a row can hold

        private List<String> firstRow = new List<String>();
        private List<String> secondRow = new List<String>();
        private List<String> thirdRow = new List<String>();

        public Keyboard()
        {
            this.InitializeComponent();

            // register first row keys
            // TODO: use key model (shift, caplock etc...)
            // Also multilingual support required
            this.firstRow.Add("q");
            this.firstRow.Add("w");
            this.firstRow.Add("e");
            this.firstRow.Add("r");
            this.firstRow.Add("t");
            this.firstRow.Add("y");
            this.firstRow.Add("u");
            this.firstRow.Add("i");
            this.firstRow.Add("o");
            this.firstRow.Add("p");

            // register second row keys
            this.secondRow.Add("a");
            this.secondRow.Add("s");
            this.secondRow.Add("d");
            this.secondRow.Add("f");
            this.secondRow.Add("g");
            this.secondRow.Add("h");
            this.secondRow.Add("j");
            this.secondRow.Add("k");
            this.secondRow.Add("l");
            this.secondRow.Add("-");

            // register third row keys
            this.thirdRow.Add("z");
            this.thirdRow.Add("x");
            this.thirdRow.Add("c");
            this.thirdRow.Add("v");
            this.thirdRow.Add("b");
            this.thirdRow.Add("n");
            this.thirdRow.Add("m");
            this.thirdRow.Add(",");
            this.thirdRow.Add(".");
            this.thirdRow.Add("?");

            // loaded callback
            this.Loaded += Keyboard_Loaded;
        }

        /// <summary>
        /// Listen to Keyboard load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keyboard_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var item in this.firstRow)
            {
                var key = new Key();

                // TODO: use 0.25 because 4 row but in other language maybe not 4 rows
                // To be refactor
                key.Build(new Size(this.ActualWidth / 12, this.ActualHeight * 0.25), item);
                this.FirstRow.Children.Add(key);
            }

            // backspace key
            var backspace = new Key();
            backspace.Build(new Size((this.ActualWidth * 2 / 12), this.ActualHeight * 0.25), "Backspace");
            this.FirstRow.Children.Add(backspace);

            foreach(var item in this.secondRow)
            {
                var key = new Key();
                key.Build(new Size(this.ActualWidth / 12, this.ActualHeight * 0.25), item);
                this.SecondRow.Children.Add(key);
            }

            // enter key
            var enter = new Key();
            enter.Build(new Size((this.ActualWidth * 1.7 / 12), this.ActualHeight * 0.25), "Enter");
            this.SecondRow.Children.Add(enter);

            foreach(var item in this.thirdRow)
            {
                var key = new Key();
                key.Build(new Size(this.ActualWidth / 12, this.ActualHeight * 0.25), item);
                this.ThirdRow.Children.Add(key);
            }

            // space key
            var space = new Key();
            space.Build(new Size(this.ActualWidth * 6 / 12, this.ActualHeight * 0.25), "Spacebar");
            this.ForthRow.Children.Add(space);
        }
    }
}
