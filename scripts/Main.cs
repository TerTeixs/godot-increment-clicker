using Godot;
using System;

public partial class Main : Node
{
    private Steak _steakNode;
    private const string PlayerStatsSingletonPath = "/root/PlayerStats";
    // Time interval is 0.05 seconds (50ms)
    const float ProduceTimer = 0.05f;

    public override void _Ready()
    {

        _steakNode = GetNode<Steak>("Steak");
        _steakNode.SteakButtonPressed += OnSteakButtonPressed;
        GetNode<Timer>("ProduceTimer").Start();
    }
    // public override void _Process(double delta)
    // {

    // }
    private void OnSteakButtonPressed()
    {
        var PlayerStats = GetNode<PlayerStats>(PlayerStatsSingletonPath);
        PlayerStats.UserSteaks += PlayerStats.GetTotalClickPower();
    }
    private void OnProduceTimerTimeout()
    {
        var PlayerStats = GetNode<PlayerStats>(PlayerStatsSingletonPath);
        PlayerStats.UserSteaks += PlayerStats.GetTotalProducePerSec() * ProduceTimer;
    }
}
