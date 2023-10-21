using System.Windows;

namespace _02350SuperSimpleMVVMDemo.View
{
    /// <summary>
    /// This is the "Code-Behind" file of the MainWindow. When following the MVVM architectural pattern (in its purest version), this file should be empty.
    /// This class is partial and contains part of the MainWindows code, with the XAML code being the other half.
    /// 
    /// Data used in the View (Window) should be supplied by the ViewModel with observable properties that are bound to visual elements in the View.
    /// Interactions initiated by the View should be supplied by the ViewModel with observable commands that are bound to the visual elements (that can be invoked) in the View (for instance a Button).
    /// 
    /// Try to keep your Code-Behind files empty, otherwise you might have violated the MVVM pattern, and for instance used Event Handlers instead of Commands (which should be in ViewModels).
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
