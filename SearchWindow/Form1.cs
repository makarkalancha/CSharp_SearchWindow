using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SearchWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addToList();
        }
        private List<ListOf> l = new List<ListOf>();
        

        private void listView1_SelectedIndexChanged(object sender,System.EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count <= 0)
                return;
            
            int selNdx = this.listView1.SelectedIndices[0];
            label1.Text = listView1.Items[selNdx].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListOf m in l)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                listViewItem1.Text = m.docket_number;
                listViewItem1.SubItems.Add(m.idmatter);
                listViewItem1.SubItems.Add(m.matter_type);
                listViewItem1.SubItems.Add(m.name);
                listViewItem1.SubItems.Add(m.record_id);
                listView1.Items.Add(listViewItem1);
            }
        }

        public void addToList()
        {
            l.Add(new ListOf("RIC-MISC-CA-000001", "202c344e-4f66-f589-b8bb-4d127180ea86", "MISC",
                "TEST", "35dc3981-dff6-2b3f-6970-4d1271b806e3"));
            l.Add(new ListOf("CAR-MISC-PT-000001", "9298c73a-ffdb-e018-35e6-4b852cc5534d", "MISC",
                "CINV - CIAG", "f30802f1-267f-697b-ff2c-4b852c1d0460"));
            l.Add(new ListOf("PAN-MISC-GR-000001", "85ef5539-bd42-3c53-4b17-4b8652252e7a", "MISC",
                "OPNV - OPAG", "f32ceee4-1a21-9e12-abd8-4b8652ab00e5"));
            l.Add(new ListOf("VAC-MISC-XX-000002", "a5b5085e-6fe5-7b03-92e6-4b98dbd718dc", "MISC",
                "Liste des boutiques et des points de vente Vacheron Constantin (03/2010)",
                "f40ef783-bd2a-1c29-f1ad-4b98db4b96ae"));
            l.Add(new ListOf("CAR-MISC-GB-000003", "b2fbb5c2-b83f-d01a-1cae-4c1a3c787a93", "MISC",
                "SANTOS 100 - difficulty in authentification of Cartier watches",
                "fc000b48-fc29-c5f3-3a3f-4c1a3c737244"));
            l.Add(new ListOf("CAR-MISC-US-000003", "88fe6cf4-e918-94c3-2c12-4bffd1b65032", "MISC",
                "Cartier / US Customs - McCarter & English - STACEY HALLERMAN",
                "fcf70e85-240c-b6af-bb9c-4bffd161a6b8"));
        }
    }
}
