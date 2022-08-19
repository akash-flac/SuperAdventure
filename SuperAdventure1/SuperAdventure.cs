using Engine; 
namespace SuperAdventure1;

public partial class SuperAdventure : Form
{
    private Player _player;

    public SuperAdventure()
    {
        InitializeComponent();

        Location location = new(1, "Home", "This is your house.");
        _player = new Player(10, 10, 20, 0, 1); 

        lblHitPoints.Text = _player.CurrentHitPoints.ToString();
        lblGold.Text = _player.Gold.ToString();
        lblExperience.Text = _player.ExperiencePoints.ToString();
        lblLevel.Text = _player.Level.ToString();
    }

    private void button6_Click(object sender, EventArgs e)
    {

    }

    private void btnusePotion_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}