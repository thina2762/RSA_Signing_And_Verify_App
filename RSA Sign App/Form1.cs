using RSA_Sign_App.Interface;

namespace RSA_Sign_App
{
    public enum HashValues
    {
        SHA1,
        SHA512,
        SHA256
     
    }
    public partial class Form1 : Form
    {
        private readonly IEncryption _EncryptionManager;
        public Form1(IEncryption EncryptionManager)
        {
            _EncryptionManager = EncryptionManager;
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

        private void btnGenerateSign_Click(object sender, EventArgs e)
        {
            //get all value 

            string strBaseStringValue = txtBaseString.Text;
            string strprivatekeyLocation = txtPrivateKeyLocation.Text;
            string strHashalg = cboRsaSHAkey.Text;

            // validate the  field values.
            if (strBaseStringValue == "Place Your Base String Here" || strBaseStringValue == "")
            {
                MessageBox.Show("Base String Column cannot be empty");
                return;
            }
            if (strprivatekeyLocation == "Private Locations" || strprivatekeyLocation == "")
            {
                MessageBox.Show("Please select a valid Private key locations");
                return;
            }
            // get Signature
            txtSignature.Text = _EncryptionManager.GenerateRSASignature(strBaseStringValue, strprivatekeyLocation, strHashalg);

        }

        private void btnVerifySign_Click(object sender, EventArgs e)
        {
            // get relavent values
            string strSignature = txtSignature.Text;
            string strBaseStringValue = txtBaseString.Text;
            string strPublickeyLocations = txtPublicKeyLocation.Text;
            string strHashalg = cboRsaSHAkey.Text;

            // Validate each field
            if (strBaseStringValue == "Place Your Base String Here" || strBaseStringValue == "")
            {
                MessageBox.Show("Base String Column cannot be empty");
                return;
            }
            if (strSignature == "Place Your Signature Here (If any)" || strSignature == "")
            {
                MessageBox.Show("signature Column cannot be empty");
                return;
            }
            if (strPublickeyLocations == "Public Locations" || strPublickeyLocations == "")
            {
                MessageBox.Show("Please select a valid Public key locations");
                return;
            }

            // get verification result 

            var IsValid = _EncryptionManager.VerifySigning(strSignature, strBaseStringValue, strPublickeyLocations, strHashalg);

            if (IsValid)
            {
                MessageBox.Show("This is a valid Signature. Hence you can trust the sender");
            }
            else
            {
                MessageBox.Show("Oh No this not  a valid signature.Please Don't Trust the sender");
            }

         
        }
    }
}