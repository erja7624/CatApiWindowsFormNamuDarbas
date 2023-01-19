using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ApiClient;

namespace CatAPI
{
    public partial class MainForm : Form
    {
        Helpers cache = new Helpers();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cache.SaveCatsToCache();
            cache.backedUpCatList = Helpers.BackUpCats(cache.cachedCatList);

            comboBox1.DataSource = cache.cachedCatList;
            comboBox1.DisplayMember = "name";

            listBox1.DataSource = cache.cachedCatList;
            listBox1.DisplayMember = "name";

            comboBox2.Items.Add("child_friendly");
            comboBox2.Items.Add("grooming");
            comboBox2.Items.Add("health_issues");
            comboBox2.Items.Add("energy_level");
            comboBox2.Items.Add("intelligence");
            comboBox2.Items.Add("vocalisation");
        }

        private void buttonRandomPicture_Click(object sender, EventArgs e)
        {
            List<ImageModel> images = ApiHelper.GetRandomImage();
            foreach (var image in images)
            {
                pictureBox1.ImageLocation = image.url;
            }
        }

        private void buttonResetList_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            comboBox1.DataSource = null;
            comboBox1.DataSource = cache.backedUpCatList;
            comboBox1.DisplayMember = "name";

            listBox1.DataSource = cache.backedUpCatList;
            listBox1.DisplayMember = "name";
        }

        private void buttonToUpperCase_Click(object sender, EventArgs e)
        {
            Helpers.MakeUpperCase(cache.cachedCatList);
            listBox1.DataSource = null;
            listBox1.DataSource = cache.cachedCatList;
            listBox1.DisplayMember = "name";
        }

        private void buttonToLowerCase_Click(object sender, EventArgs e)
        {
            Helpers.MakeLowerCase(cache.cachedCatList);
            listBox1.DataSource = null;
            listBox1.DataSource = cache.cachedCatList;
            listBox1.DisplayMember = "name";
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //When user double clicks on the selected item - take the selected cat object out of the list box
                CatModel selectedCat = (CatModel)listBox1.SelectedItem;
                //Create an instance of the CatInfo form
                CatInfo catInfoInstance = new CatInfo();
                //Send the name to the CatInfo's public name property, because text box is private
                catInfoInstance = selectedCat;
                //Simulate the dialog box
                DialogResult result = catInfoInstance.ShowDialog();
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CatModel selectedCatId = (CatModel)comboBox1.SelectedItem;
            List<ImageModel> images = ApiHelper.GetBreedImage(selectedCatId.id);
            foreach (var image in images)
            {
                pictureBox1.ImageLocation = image.url;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cache.cachedCatList = Helpers.FilteringByQuality(cache.cachedCatList, comboBox2.SelectedItem.ToString());
            // Paduoda backedup lista, ji isfiltruoja pagal norima parametra ir atvaizduoja
            cache.filteredList = Helpers.FilteringByQuality(cache.backedUpCatList, comboBox2.SelectedItem.ToString());
            listBox1.DataSource = null;
            listBox1.DataSource = cache.filteredList;
            listBox1.DisplayMember = "name";
        }

    }
}
