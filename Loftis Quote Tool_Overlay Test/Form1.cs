namespace Loftis_Quote_Tool_Overlay_Test
{
    public partial class Form1 : Form
    {

        // Declare the buttons at the class level
        private Button btnMaterial = new Button();
        private Button btnThickness = new Button();
        private Button btnScale = new Button();
        private Button btnQuantity = new Button();

        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            this.TopMost = true;  // This line will keep the form on top of other windows
        }

        private void InitializeButtons()
        {
            // Set properties for btnMaterial
            btnMaterial.Text = "Material ✓";
            btnMaterial.Location = new Point(10, 10);
            btnMaterial.Size = new Size(120, 30);
            this.Controls.Add(btnMaterial);

            // Set properties for btnThickness
            btnThickness.Text = "Thickness ✓";
            btnThickness.Location = new Point(10, 50);
            btnThickness.Size = new Size(120, 30);
            this.Controls.Add(btnThickness);

            // Set properties for btnScale
            btnScale.Text = "Scale ✓";
            btnScale.Location = new Point(10, 90);
            btnScale.Size = new Size(120, 30);
            this.Controls.Add(btnScale);

            // Set properties for btnQuantity
            btnQuantity.Text = "Quantity ✓";
            btnQuantity.Location = new Point(10, 130);
            btnQuantity.Size = new Size(120, 30);
            this.Controls.Add(btnQuantity);

            // Attach event handlers
            btnMaterial.Click += (sender, e) => RecordStep("Material");
            btnThickness.Click += (sender, e) => RecordStep("Thickness");
            btnScale.Click += (sender, e) => RecordStep("Scale");
            btnQuantity.Click += (sender, e) => RecordStep("Quantity");
        }

        private void RecordStep(string step)
        {
            // Logic for recording the steps goes here
            Console.WriteLine($"{step} step recorded.");
        }
    }


}