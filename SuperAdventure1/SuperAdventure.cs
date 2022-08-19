using Engine; 
namespace SuperAdventure1;

public partial class SuperAdventure : Form
{
    private Player _player; 
     
    public SuperAdventure()
    {
        InitializeComponent();

        _player = new Player
        {
            CurrentHitPoints = 10,
            MaximumHitPoints = 10,
            Gold = 20,
            ExperiencePoints = 0,
            Level = 1
        };

        lblHitPoints.Text = _player.CurrentHitPoints.ToString();
        lblGold.Text = _player.Gold.ToString();
        lblExperience.Text = _player.ExperiencePoints.ToString();
        lblLevel.Text = _player.Level.ToString();
    }

    
}