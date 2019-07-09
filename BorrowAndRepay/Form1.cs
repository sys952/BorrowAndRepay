using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Person Me, Friend;
        int control;
        int money;

        public void updateInfo()
        {
            myMoneyLabel.Text = Convert.ToString(Me.getMoney());
            friendMoneyLabel.Text = Convert.ToString(Friend.getMoney());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control = 0;
            money = int.Parse(moneyInput.Text);
            Me.Action(Me, Friend, money, control);
            updateInfo();
        }

        private void repayB_Click(object sender, EventArgs e)
        {
            control = 1;
            money = int.Parse(moneyInput.Text);
            Me.Action(Me, Friend, money, control);
            updateInfo();
        }

        private void confirmB_Click(object sender, EventArgs e)
        {
            Me = new Person(myNameInput.Text, 20000);
            Friend = new Person(friendNameInput.Text, 100000);
            money = 0;
            myNameLabel.Text = Me.getName();
            friendNameLabel.Text = Friend.getName();
            updateInfo();
            borrowB.Enabled = true;
            repayB.Enabled = true;
        }
    }
}
