using System;
using System.Windows.Forms;
using ApiClient;

namespace CatAPI
{
    public partial class CatInfo : Form
    {
        public CatInfo()
        {
            InitializeComponent();
        }

        private void CatInfo_Load(object sender, EventArgs e)
        {
            CatInfoTextField.Text = ($" Cat breed ID: {Id}{Environment.NewLine}" +
                $" Cat breed name: {Name}{Environment.NewLine}" +
                $" Cfa url: {Cfa_url}{Environment.NewLine}" +
                $" Vetstreet url: {Vetstreet_url}{Environment.NewLine}" +
                $" Vcahospitals url: {Vcahospitals_url}{Environment.NewLine}" +
                $" Temperament: {Temperament}{Environment.NewLine}" +
                $" Origin: {Origin}{Environment.NewLine}" +
                $" Country codes: {Country_codes}{Environment.NewLine}" +
                $" Country code: {Country_code}{Environment.NewLine}" +
                $" Description: {Description}{Environment.NewLine}" +
                $" Life span: {Life_span}{Environment.NewLine}" +
                $" Indoor: {Indoor}{Environment.NewLine}" +
                $" Lap: {Lap}{Environment.NewLine}" +
                $" Alt names: {Alt_names}{Environment.NewLine}" +
                $" Adaptability: {Adaptability}{Environment.NewLine}" +
                $" Affection level: {Affection_level}{Environment.NewLine}" +
                $" Child friendly: {Child_friendly}{Environment.NewLine}" +
                $" Dog friendly: {Dog_friendly}{Environment.NewLine}" +
                $" Energy level: {Energy_level}{Environment.NewLine}" +
                $" Grooming: {Grooming}{Environment.NewLine}" +
                $" Health issues: {Health_issues}{Environment.NewLine}" +
                $" Intelligence: {Intelligence}{Environment.NewLine}" +
                $" Shedding level: {Shedding_level}{Environment.NewLine}" +
                $" Social needs: {Social_needs}{Environment.NewLine}" +
                $" Stranger friendly: {Stranger_friendly}{Environment.NewLine}" +
                $" Vocalisation: {Vocalisation}{Environment.NewLine}" +
                $" Experimental: {Experimental}{Environment.NewLine}" +
                $" Hairless: {Hairless}{Environment.NewLine}" +
                $" Natural: {Natural}{Environment.NewLine}" +
                $" Rare: {Rare}{Environment.NewLine}" +
                $" Rex: {Rex}{Environment.NewLine}" +
                $" Suppressed tail: {Suppressed_tail}{Environment.NewLine}" +
                $" Short legs: {Short_legs}{Environment.NewLine}" +
                $" Wikipedia url: {Wikipedia_url}{Environment.NewLine}" +
                $" Hypoallergenic: {Hypoallergenic}{Environment.NewLine}" +
                $" Reference image id: {Reference_image_id}{Environment.NewLine}" +
                $" Cat friendly: {Cat_friendly}{Environment.NewLine}" +
                $" Bidability: {Bidability}{Environment.NewLine}");
        }

        //conversion operator
        public static implicit operator CatInfo(CatModel v)
        {
            CatInfo detailedCatInfo = new CatInfo();
            detailedCatInfo.Id = v.id;
            detailedCatInfo.Name = v.name;
            detailedCatInfo.Cfa_url = v.cfa_url;
            detailedCatInfo.Vetstreet_url = v.vetstreet_url;
            detailedCatInfo.Vcahospitals_url = v.vcahospitals_url;
            detailedCatInfo.Temperament = v.temperament;
            detailedCatInfo.Origin = v.origin;
            detailedCatInfo.Country_codes = v.country_codes;
            detailedCatInfo.Country_code = v.country_code;
            detailedCatInfo.Description = v.description;
            detailedCatInfo.Life_span = v.life_span;
            detailedCatInfo.Indoor = v.indoor;
            detailedCatInfo.Lap = v.lap;
            detailedCatInfo.Alt_names = v.alt_names;
            detailedCatInfo.Adaptability = v.adaptability;
            detailedCatInfo.Affection_level = v.affection_level;
            detailedCatInfo.Child_friendly = v.child_friendly;
            detailedCatInfo.Dog_friendly = v.dog_friendly;
            detailedCatInfo.Energy_level = v.energy_level;
            detailedCatInfo.Grooming = v.grooming;
            detailedCatInfo.Health_issues = v.health_issues;
            detailedCatInfo.Intelligence = v.intelligence;
            detailedCatInfo.Shedding_level = v.shedding_level;
            detailedCatInfo.Social_needs = v.social_needs;
            detailedCatInfo.Stranger_friendly = v.stranger_friendly;
            detailedCatInfo.Vocalisation = v.vocalisation;
            detailedCatInfo.Experimental = v.experimental;
            detailedCatInfo.Hairless = v.hairless;
            detailedCatInfo.Natural = v.natural;
            detailedCatInfo.Rare = v.rare;
            detailedCatInfo.Rex = v.rex;
            detailedCatInfo.Suppressed_tail = v.suppressed_tail;
            detailedCatInfo.Short_legs = v.short_legs;
            detailedCatInfo.Wikipedia_url = v.wikipedia_url;
            detailedCatInfo.Hypoallergenic = v.hypoallergenic;
            detailedCatInfo.Reference_image_id = v.reference_image_id;
            detailedCatInfo.Cat_friendly = v.cat_friendly;
            detailedCatInfo.Bidability = v.bidability;
            return detailedCatInfo;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Cfa_url { get; set; }
        public string Vetstreet_url { get; set; }
        public string Vcahospitals_url { get; set; }
        public string Temperament { get; set; }
        public string Origin { get; set; }
        public string Country_codes { get; set; }
        public string Country_code { get; set; }
        public string Description { get; set; }
        public string Life_span { get; set; }
        public int Indoor { get; set; }
        public int Lap { get; set; }
        public string Alt_names { get; set; }
        public int Adaptability { get; set; }
        public int Affection_level { get; set; }
        public int Child_friendly { get; set; }
        public int Dog_friendly { get; set; }
        public int Energy_level { get; set; }
        public int Grooming { get; set; }
        public int Health_issues { get; set; }
        public int Intelligence { get; set; }
        public int Shedding_level { get; set; }
        public int Social_needs { get; set; }
        public int Stranger_friendly { get; set; }
        public int Vocalisation { get; set; }
        public int Experimental { get; set; }
        public int Hairless { get; set; }
        public int Natural { get; set; }
        public int Rare { get; set; }
        public int Rex { get; set; }
        public int Suppressed_tail { get; set; }
        public int Short_legs { get; set; }
        public string Wikipedia_url { get; set; }
        public int Hypoallergenic { get; set; }
        public string Reference_image_id { get; set; }
        public int? Cat_friendly { get; set; }
        public int? Bidability { get; set; }
    }
}
