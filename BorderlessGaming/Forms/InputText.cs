using System.ComponentModel;

namespace BorderlessGaming.Forms
{
    public partial class InputText : Form
    {
        public InputText()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get => Text.Trim();
            set => Text = value.Trim();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Input
        {
            get => txtInput.Text.Trim();
            set => txtInput.Text = value.Trim();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Instructions
        {
            get => lblInstructions.Text.Trim();
            set => lblInstructions.Text = value.Trim();
        }

        private void frmInputText_Shown(object sender, EventArgs e)
        {
            txtInput.Focus();
        }
    }
}