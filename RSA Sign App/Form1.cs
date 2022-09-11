namespace RSA_Sign_App
{
    public  enum HashValues
    {
            SHA1,
            SHA512,
            SHA256
        }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCbobox();
        }

       private void LoadCbobox()
        {
            cboRsaSHAkey.Items.Clear();
            cboRsaSHAkey.DataSource = Enum.GetValues(typeof(HashValues));
        }

        private void btnBrowsePrivateKey_Click(object sender, EventArgs e)
        {
  
            txtPrivateKeyLocation.Text = OpenDialog();
        }

        private void btnPublicKey_Click(object sender, EventArgs e)
        {
          
            txtPublicKeyLocation.Text = OpenDialog();
        }


        private string OpenDialog()
        {
            OpenFileDialog btndialog = new OpenFileDialog();
            btndialog.ShowDialog();
            btndialog.InitialDirectory = @"C:\";
            btndialog.RestoreDirectory = true;
            btndialog.DefaultExt = ".PEM";
            btndialog.Title = "Browse for key";
            btndialog.CheckFileExists = true;
            btndialog.CheckPathExists = true;

            return btndialog.FileName;
        }
    }
}