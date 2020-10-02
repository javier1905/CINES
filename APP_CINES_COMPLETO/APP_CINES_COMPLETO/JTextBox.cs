using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_CINES_COMPLETO
{
    public partial class JTextBox : TextBox
    {
        private bool texto;
        private bool enteros;
        private bool decimales;
        private bool hora;
        private bool comas;
        public JTextBox()
        {
            InitializeComponent();            
            this.KeyPress += new KeyPressEventHandler(JTextBox_KeyPress);
            texto = true;
            enteros = false;
            decimales = false;
            hora = false;
            comas = false;
            this.MaxLength = 10;
        }

        private void JTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(texto){if(!Char.IsLetter(e.KeyChar)){if(!Char.IsSeparator(e.KeyChar)&& !Char.IsControl(e.KeyChar)){e.Handled = true;}}}
            if(enteros){ if (!Char.IsNumber(e.KeyChar)&& !Char.IsControl(e.KeyChar)){ e.Handled = true; }}
            if(decimales)
            {
                if (Char.IsPunctuation(e.KeyChar) && comas == false) { e.KeyChar = '.'; comas = true; }
                else if (comas && Char.IsPunctuation(e.KeyChar)) { e.Handled = true; }
                if(Char.IsControl(e.KeyChar) && this.Text.IndexOf('.') == this.Text.Length-1) { comas = false; }
                if(Char.IsLetter(e.KeyChar)|| Char.IsSeparator(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; }
            }
            if(hora)
            {
               if(!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
               {
                    e.Handled = true;
               }
               if(Char.IsNumber(e.KeyChar))
               {
                    if(this.Text.Length==0 && (!e.KeyChar.Equals('1') && !e.KeyChar.Equals('2')))
                    {
                        e.Handled = true;                       
                    }
                    if (this.Text.Length == 1)
                    {
                        if(Convert.ToInt32(e.KeyChar.ToString()) > 4 && this.Text=="2")
                        {
                            e.Handled = true;
                        }
                    }
                        if (this.Text.Length == 2)
                    {
                        if(Convert.ToInt32(e.KeyChar.ToString())>5)
                        {
                            e.Handled = true;                            
                        }
                        else
                        {
                            string lala = this.Text;
                            this.Text = lala + ":" + e.KeyChar;
                            e.Handled = true;
                            this.Select(4, this.Text.Length);
                        }                       
                    }                   
               }
               if(this.Text.Length == 4 && Char.IsControl(e.KeyChar))
               {
                    string lolo = this.Text.Remove(3);
                    this.Text = lolo;
                    this.Select(4, this.Text.Length);
                }
            }
        }
        public bool Ptexto { get => texto; set => texto = value; }
        public bool Penteros { get => enteros; set => enteros = value; }
        public bool Pdecimales { get => decimales; set => decimales = value; }
        public bool Phora { get => hora; set => hora = value; }
    }
}
