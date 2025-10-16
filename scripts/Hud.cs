using Godot;

public partial class Hud : CanvasLayer
{
    private const string PlayerStatsSingletonPath = "/root/PlayerStats";
    private AudioStreamPlayer _storeSound;
    public override void _Ready()
    {
        _storeSound = GetNode<AudioStreamPlayer>("StoreSound");
    }
    public override void _Process(double delta)
    {
        var PlayerStats = GetNode<PlayerStats>(PlayerStatsSingletonPath);
        if (PlayerStats == null)
        {
            return;
        }
        var TotalMsg = GetNode<Label>("TotalSteak");
        TotalMsg.Text = $"Steak : {PlayerStats.UserSteaks:0}";
        TotalMsg.Show();
    }
    private void OnCursorButtonPressed()
    {
        var PlayerStats = GetNode<PlayerStats>(PlayerStatsSingletonPath);
        _storeSound.Play();
        if (PlayerStats.UserSteaks - PlayerStats.CursorWorkerCost >= 0)
        {
            PlayerStats.UserSteaks -= PlayerStats.CursorWorkerCost;
            PlayerStats.CursorWorkerCost += PlayerStats.CursorWorkerCost * 0.2f;
            PlayerStats.CursorBaseWorker += 1;
            PlayerStats.UpdateProducePerSec();
            var PerSecMsg = GetNode<Label>("SteakPerSec");
            PerSecMsg.Text = $"Steak Per Second : {PlayerStats.ProducePerSec:0}";
            var CursorButtonWorkerCost = GetNode<Button>("CursorButton");
            CursorButtonWorkerCost.Text = $"Cursor \n{PlayerStats.CursorWorkerCost:0}";
        }
        else
        {
            var Toast = GetNode<Toast>("Toast");
            Toast.ShowToast("Not Enough Steaks");
        }
    }
    private void OnChefButtonPressed()
    {
        var PlayerStats = GetNode<PlayerStats>(PlayerStatsSingletonPath);
        _storeSound.Play();
        if (PlayerStats.UserSteaks - PlayerStats.ChefWorkerCost >= 0)
        {
            PlayerStats.UserSteaks -= PlayerStats.ChefWorkerCost;
            PlayerStats.ChefWorkerCost += PlayerStats.ChefWorkerCost * 0.2f;
            PlayerStats.ChefBaseWorker += 1;
            PlayerStats.UpdateProducePerSec();
            var PerSecMsg = GetNode<Label>("SteakPerSec");
            PerSecMsg.Text = $"Steak Per Second : {PlayerStats.ProducePerSec:0}";
            var ChefButtonWorkerCost = GetNode<Button>("ChefButton");
            ChefButtonWorkerCost.Text = $"Chef \n{PlayerStats.ChefWorkerCost:0}";
        }
        else
        {
            var Toast = GetNode<Toast>("Toast");
            Toast.ShowToast("Not Enough Steaks");
        }
    }
    private void OnFarmButtonPressed()
    {
        var PlayerStats = GetNode<PlayerStats>(PlayerStatsSingletonPath);
        _storeSound.Play();
        if (PlayerStats.UserSteaks - PlayerStats.FarmWorkerCost >= 0)
        {
            PlayerStats.UserSteaks -= PlayerStats.FarmWorkerCost;
            PlayerStats.FarmWorkerCost += PlayerStats.FarmWorkerCost * 0.2f;
            PlayerStats.FarmBaseWorker += 1;
            PlayerStats.UpdateProducePerSec();
            var PerSecMsg = GetNode<Label>("SteakPerSec");
            PerSecMsg.Text = $"Steak Per Second : {PlayerStats.ProducePerSec:0}";
            var FarmButtonWorkerCost = GetNode<Button>("FarmButton");
            FarmButtonWorkerCost.Text = $"Farm \n{PlayerStats.FarmWorkerCost:0}";
        }
        else
        {
            var Toast = GetNode<Toast>("Toast");
            Toast.ShowToast("Not Enough Steaks");
        }
    }
}
