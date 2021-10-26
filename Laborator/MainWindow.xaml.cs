using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vlad_Paltineanu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DoughnutMachine myDoughnutMachine;
        private int mRaisedGlazed;
        private int mRaisedSugar;
        private int mFilledLemon;
        private int mFilledChocolate;
        private int mFilledVanilla;
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    private void frmMain_Loaded(object sender, RoutedEventArgs e)
    {
        myDoughnutMachine = new DoughnutMachine();
        myDoughNutMachine.DoughNutComplete += new DoughnutMachine.DoughnutCompleteDelegate(DoughnutCompleteHandler);

    }

    private void glazedToolStripMenuItem_Click(object sender, RoutedEventArgs 0)
    {
        glazedToolStripMenuItem.IsChecked = true;
        sugarToolStripMenuItem.IsChecked = false;
        myDoughnutMachine.MakeDoughnuts(DoughnutType.Glazed);
    }

    private void sugarToolStripMenuItem_Click(object sender, RoutedEventArgs)
    {
        glazedToolStripMenuItem.IsChecked = false;
        sugarToolStripMenuItem.IsChecked = true;
        myDoughnutMachine.MakeDoughnuts(DoughnutType.Sugar);
    }

    private void DoughnutCompleteHandler()
    {
        switch (myDoughnutMachine.Flavor)
        {
            case DoughnutType.Glazed:
                mRaisedGlazed++;
                txt.GlazedRaised.Text = mRaisedGlazed.ToString();
                break;

        }
    }
}
