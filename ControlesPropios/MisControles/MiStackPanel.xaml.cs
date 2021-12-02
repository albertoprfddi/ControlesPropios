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

namespace ControlesPropios.MisControles
{
    /// <summary>
    /// Lógica de interacción para MiStackPanel.xaml
    /// </summary>
    public partial class MiStackPanel : UserControl
    {
        public StackPanel StPnPrincipal=new StackPanel();
        public string orientacionLetra { get; set; }
        private Orientation orientacionPedida=Orientation.Horizontal;
        private Orientation orientacionContraria=Orientation.Vertical;
        public int maxCeldas { get; set; }
        private int numElementos;
        private StackPanel StPnActual;
        public MiStackPanel()
        {
            InitializeComponent();
            if (orientacionLetra=="V")
            {
                orientacionPedida= Orientation.Vertical;
                orientacionContraria = Orientation.Horizontal;
            }
            StPnPrincipal.Orientation= orientacionContraria;
            StackPanel StPnSecundario = new StackPanel();
            StPnSecundario.Orientation= orientacionPedida;
            StPnPrincipal.Children.Add(StPnSecundario);
            StPnActual = StPnSecundario;
        }
        public void aniadir(UIElement elemento)
        {
            if (numElementos == maxCeldas)
            {
                StackPanel StPnSecundario=new StackPanel();
                StPnSecundario.Orientation = orientacionPedida;
                StPnPrincipal.Children.Add(StPnSecundario);
                StPnActual=StPnSecundario;
                numElementos=0;
            }
            StPnActual.Children.Add(elemento);
            numElementos++;
        }
    }
}
