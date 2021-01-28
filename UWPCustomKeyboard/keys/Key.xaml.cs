using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace UWPCustomKeyboard.keys
{
    public sealed partial class Key : UserControl, IKey
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="container"></param>
        public Key()
        {
            this.InitializeComponent();
        }

        public bool IsShift { get; set; }
        public bool IsCaplock { get; set; }

        /// <summary>
        /// builder function
        /// </summary>
        /// <param name="measure"></param>
        /// <param name="label"></param>
        public void Build(Size size, string label)
        {
            // set size
            this.Root.Width = size.Width;
            this.Root.Height = size.Height;

            // set label
            this.Root.Content = label;
        }
    }
}
