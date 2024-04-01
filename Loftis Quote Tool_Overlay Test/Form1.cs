namespace Loftis_Quote_Tool_Overlay_Test
{
    public partial class Form1 : Form
    {

        // Declare the buttons at the class level
        private Button btnSubmit = new Button();
        private TextBox txtInput = new TextBox();
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
            // Set properties for the new text box
            txtInput.Location = new Point(10, 10);
            txtInput.Size = new Size(120, 20);
            this.Controls.Add(txtInput);

            // Set properties for the new button
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new Point(140, 10);
            btnSubmit.Size = new Size(80, 30);
            this.Controls.Add(btnSubmit);

            // Adjust the locations of the existing buttons to make room for the new controls
            btnMaterial.Location = new Point(10, 90);
            btnThickness.Location = new Point(10, 130);
            btnScale.Location = new Point(10, 170);
            btnQuantity.Location = new Point(10, 210);

            // Attach event handlers to the new button
            btnSubmit.Click += (sender, e) => SubmitText();

            // Set properties for btnMaterial
            btnMaterial.Text = "Material ✓";
            btnMaterial.Location = new Point(10, 90);
            btnMaterial.Size = new Size(120, 30);
            this.Controls.Add(btnMaterial);

            // Set properties for btnThickness
            btnThickness.Text = "Thickness ✓";
            btnThickness.Location = new Point(10, 130);
            btnThickness.Size = new Size(120, 30);
            this.Controls.Add(btnThickness);

            // Set properties for btnScale
            btnScale.Text = "Scale ✓";
            btnScale.Location = new Point(10, 170);
            btnScale.Size = new Size(120, 30);
            this.Controls.Add(btnScale);

            // Set properties for btnQuantity
            btnQuantity.Text = "Quantity ✓";
            btnQuantity.Location = new Point(10, 210);
            btnQuantity.Size = new Size(120, 30);
            this.Controls.Add(btnQuantity);

            // Attach event handlers
            btnMaterial.Click += (sender, e) => {
                RecordStep("Material");
                ChangeButtonColor(btnMaterial); // Call the method to change color
            };
            btnThickness.Click += (sender, e) => {
                RecordStep("Thickness");
                ChangeButtonColor(btnThickness); // Call the method to change color
            };
            btnScale.Click += (sender, e) => {
                RecordStep("Scale");
                ChangeButtonColor(btnScale); // Call the method to change color
            };
            btnQuantity.Click += (sender, e) => {
                RecordStep("Quantity");
                ChangeButtonColor(btnQuantity); // Call the method to change color
            };
        }

        private void SubmitText()
        {
            // Logic for what happens when the submit button is clicked
            // For example, print the text from the text box to the console
            Console.WriteLine("Submitted text: " + txtInput.Text);
        }

        private void RecordStep(string step)
        {
            // Logic for recording the steps goes here
            Console.WriteLine($"{step} step recorded.");
        }

        private void ChangeButtonColor(Button button)
        {
            // Change the background color of the button
            button.BackColor = Color.LightGreen; // Or any color you choose
        }

    }


}