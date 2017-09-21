/*
 * Name: Anju Chawla
 * Date: September 21, 2017
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2_Thursday
{
    /// <summary>
    /// This application allows a member to sign in and look at the 
    /// various promotions available in the various departments.
    /// The form can be cleared and printed.
    /// </summary>
    public partial class frmPromotions : Form
    {
        /// <summary>
        /// The constructor of the class makes a call to the designer code
        /// </summary>

        public frmPromotions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The actions to be performed when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPromotions_Load(object sender, EventArgs e)
        {
            StartUp();
        }

        /// <summary>
        /// Actions to be performed to be performed when form is loaded
        /// and cleared
        /// </summary>
        private void StartUp()
        {
            //disable all input except name and member id
            //making output controls invisible
            grpDepartment.Enabled = false;
            picDepartment.Visible = false;
            chkImageVisible.Enabled = false;
            rtbWelcome.Visible = false;
            txtPromotion.Visible = false;

        }
        /// <summary>
        /// Displays a welcome message with member name and id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //check name and member id have been provided
            if (txtName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please input your name", "Missing Name");
                txtName.Focus();
            }
            else if (mtxMemberId.Text.Length != 5)
            {
                MessageBox.Show("Please input your member id", "Missing Memeber Id");
                mtxMemberId.Focus();
            }
            else
            {
                //disable the sign in and the input controls
                btnSignIn.Enabled = false;
                grpInput.Enabled = false;
                //enable other inputs and make output controls visible
                grpDepartment.Enabled = true;
                chkImageVisible.Enabled = true;
                rtbWelcome.Visible = true;
                txtPromotion.Visible = true;


                //display a welcome message
                rtbWelcome.Text = "Welcome " + txtName.Text + Environment.NewLine +
                    "Member ID:" + mtxMemberId.Text;
            }


        }
        /// <summary>
        /// This brings the form back to its start default stage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //enable inputs, make outputs invisible, clear user inputs

            grpInput.Enabled = true;
            txtName.Clear();
            mtxMemberId.Clear();
            chkImageVisible.Checked = false;
            rdoClothing.Checked = true;
            rdoClothing.Checked = false;
            btnSignIn.Enabled = true;
            txtName.Focus();
            StartUp();


        }
        /// <summary>
        /// Display the promotion in the Clothing Department
        /// Display the image if the user has chosen to do so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoClothing_CheckedChanged(object sender, EventArgs e)
        {
            txtPromotion.Text = "30% off clearance items";
            picDepartment.Image = Lesson2_Thursday.Properties.Resources.clothing;

        }
        /// <summary>
        /// Sets the visibility of the picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            //set the visibility of the picture box
            picDepartment.Visible = chkImageVisible.Checked;
        }
        /// <summary>
        /// Preview the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }
    }
}
