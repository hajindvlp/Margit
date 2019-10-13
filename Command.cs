using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Margit.Commands
{
    class Commands
    {
        public static RoutedUICommand ExitCommand = new RoutedUICommand("Exit Command",
                                                                        "ExitCmd",
                                                                        typeof(Commands));
        public static RoutedUICommand SaveCommand = new RoutedUICommand("Save Command",
                                                                        "SaveCmd",
                                                                        typeof(Commands));
        public static RoutedUICommand SaveAsCommand = new RoutedUICommand("Save As Command",
                                                                        "Save As Cmd",
                                                                        typeof(Commands));
        public static RoutedUICommand OpenCommand = new RoutedUICommand("Open Command",
                                                                        "OpenCmd",
                                                                        typeof(Commands));
    }
}
