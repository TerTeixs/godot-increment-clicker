using Godot;

[GlobalClass]
public partial class PlayerStats : Node
{
    // User
    [Export]
    public float UserSteaks { get; set; } = 0;
    [Export]
    public float ClickPower { get; set; } = 1;
    [Export]
    public float ClickPowerInc { get; set; } = 1;
    [Export]
    public float ClickPowerMore { get; set; } = 1;
    [Export]
    public float ProducePerSec { get; set; } = 0;
    [Export]
    public float ProduceInc { get; set; } = 1;
    [Export]
    public float ProduceMore { get; set; } = 1;
    [Export]
    public float AllMultiplier { get; set; } = 1;
    // Store (THIS CODE IS SO STUPID BUT I M TOO LAZY TO FIGURE godot c# class bullshit)
    // Cursor
    [Export]
    public int CursorBaseWorker { get; set; } = 0;
    [Export]
    public float CursorBaseRate { get; set; } = 1;
    [Export]
    public float CursorBaseMutiplier { get; set; } = 1;
    [Export]
    public float CursorWorkerCost { get; set; } = 10;
    // Chef
    [Export]
    public int ChefBaseWorker { get; set; } = 0;
    [Export]
    public float ChefBaseRate { get; set; } = 10;
    [Export]
    public float ChefBaseMutiplier { get; set; } = 1;
    [Export]
    public float ChefWorkerCost { get; set; } = 2000;
    // Farm
    [Export]
    public int FarmBaseWorker { get; set; } = 0;
    [Export]
    public float FarmBaseRate { get; set; } = 100;
    [Export]
    public float FarmBaseMutiplier { get; set; } = 1;
    [Export]
    public float FarmWorkerCost { get; set; } = 4000;
    // Factory
    [Export]
    public int FactoryBaseWorker { get; set; } = 0;
    [Export]
    public float FactoryBaseRate { get; set; } = 1000;
    [Export]
    public float FactoryBaseMutiplier { get; set; } = 1;
    [Export]
    public float FactoryWorkerCost { get; set; } = 80000;

    public float GetTotalClickPower()
    {
        return ClickPower * ClickPowerInc * ClickPowerMore * AllMultiplier;
    }
    public float GetTotalProducePerSec()
    {
        return ProducePerSec * ProduceInc * ProduceMore * AllMultiplier;
    }
    public void UpdateProducePerSec()
    {
        ProducePerSec = 0 + (CursorBaseWorker * CursorBaseRate * CursorBaseMutiplier);
    }
}