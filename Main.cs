namespace TempalteContoler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private int curr_x;
        private int curr_y;
        private bool isWndMove;

        private void BtnTitleForm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Tag.ToString())
            {
                case "Close":
                    Application.Exit();
                    break;

                case "Size":
                    if (WindowState == FormWindowState.Normal)
                        this.WindowState = FormWindowState.Maximized;
                    else
                        this.WindowState = FormWindowState.Normal;
                    break;

                case "Minimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        #region Form move 

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.curr_x = e.X;
                this.curr_y = e.Y;
                this.isWndMove = true;
            }
        }

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isWndMove)
                this.Location = new Point(this.Left + e.X - this.curr_x, this.Top + e.Y - this.curr_y);
        }

        private void PanelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.isWndMove = false;
        }

        #endregion

        private void BtnClick_Click(object sender, EventArgs e)
        {
            LabResult.Text = EditSearch.Texts;
        }
    }
}