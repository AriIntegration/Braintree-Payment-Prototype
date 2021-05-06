using Braintree;
using System;
using System.Windows.Forms;

namespace TestPayPalIntegration
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            CreateCustomer();
            MakePayment();
        }

        private Boolean CreateCustomer()
        {
            var gateway = GetBraintreeGateway();
            var customer = new CustomerRequest
            {
                Id = txtMemberNumber.Text,
                FirstName = txtCardholderName.Text,
                LastName = txtCardholderName.Text,
                Email = "theemailaddress@gmail.com",
            };

            Result<Customer> result = gateway.Customer.Create(customer);

            return result.IsSuccess();
        }

        private void MakePayment()
        {
            var gateway = GetBraintreeGateway();
            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal(txtAmount.Text.ToString()),
                CustomerId = txtMemberNumber.Text,
                OrderId = txtOrderID.Text,
                CreditCard = new TransactionCreditCardRequest
                {
                    CardholderName = txtCardholderName.Text,
                    Number = txtCardNumber.Text,
                    ExpirationMonth = nudExpMonth.Value.ToString(),
                    ExpirationYear = nudExpYear.Value.ToString(),
                    CVV = txtCVV.Text,
                },
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };

            Result<Transaction> result = gateway.Transaction.Sale(request);
            if (result.IsSuccess())
            {
                // See result.Target for details
                rtbStatusInfo.Text += "Amount: " + result.Target.Amount.ToString() + System.Environment.NewLine;
                rtbStatusInfo.Text += "Status: " + result.Target.Status.ToString() + System.Environment.NewLine;
                rtbStatusInfo.Text += "Processor Response Code: " + result.Target.ProcessorResponseCode.ToString() + System.Environment.NewLine;
                rtbStatusInfo.Text += "Processor Response Text: " + result.Target.ProcessorResponseText.ToString() + System.Environment.NewLine;
                rtbStatusInfo.Text += "Processor Authorization Code: " + result.Target.ProcessorAuthorizationCode.ToString() + System.Environment.NewLine;
                rtbStatusInfo.Text += "Transaction Id: " + result.Target.Id.ToString() + System.Environment.NewLine;
            }
            else
            {
                // Handle errors
                rtbStatusInfo.Text += "Message: " + result.Message.ToString() + System.Environment.NewLine;
            }
        }

        private BraintreeGateway GetBraintreeGateway()
        {
            var gateway = new BraintreeGateway
            {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = "yhtkwj4r48jzkkjj",
                PublicKey = "986ss9kysc73c4rw",
                PrivateKey = "29052237552a1bae8d5557a3cff333de"
            };

            return gateway;
        }

        private void lnkClearRTB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtbStatusInfo.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtAmount.Text = "";
            txtMemberNumber.Text = "";
            txtCardholderName.Text = "";
            txtCardNumber.Text = "";
            txtCVV.Text = "";
            rtbStatusInfo.Text = "";
            nudExpMonth.Text = DateTime.Now.ToString("MM");
            nudExpYear.Text = DateTime.Now.ToString("yyyy");
        }
    }
}
