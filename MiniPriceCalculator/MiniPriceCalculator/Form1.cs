using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPriceCalculator
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'priceTablesDataSet1.Quality' table. You can move, or remove it, as needed.
            this.qualityTableAdapter.Fill(this.priceTablesDataSet1.Quality);
            // TODO: This line of code loads data into the 'priceTablesDataSet.BasicPrice' table. You can move, or remove it, as needed.
            this.basicPriceTableAdapter.Fill(this.priceTablesDataSet.BasicPrice);

        }
    }
}
