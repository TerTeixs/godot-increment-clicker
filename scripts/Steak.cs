using Godot;
using System;

public partial class Steak : Area2D
{
    private AudioStreamPlayer _clickSound;
    private AnimatedSprite2D _animatedSprite;
    private Vector2 _initialScale;

    [Signal]
    public delegate void SteakButtonPressedEventHandler();
    public override void _Ready()
    {
        _clickSound = GetNode<AudioStreamPlayer>("AnimatedSprite2D/SteakButton/ClickSound");
        _animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

        _initialScale = Vector2.One * 1.5f;
        _animatedSprite.Scale = _initialScale;
    }
    public override void _Process(double delta)
    {
        RotationDegrees += (float)delta * 30f;
    }
    private void OnPressedSteakButton()
    {
        _clickSound.Play();
        // 1. Create a new Tween
        Tween tween = CreateTween();

        // 2. Make the sprite bigger (e.g., 30% larger than initial scale)
        Vector2 targetScale = _initialScale * 1.3f;
        // The duration to reach the larger size (e.g., 0.05 seconds)
        tween.TweenProperty(_animatedSprite, "scale", targetScale, 0.05f)
             .SetTrans(Tween.TransitionType.Sine)
             .SetEase(Tween.EaseType.Out);

        // 3. Immediately follow with a tween to bring it back to the initial size
        // The duration to return to normal size (e.g., 0.1 seconds)
        tween.TweenProperty(_animatedSprite, "scale", _initialScale, 0.1f)
             .SetTrans(Tween.TransitionType.Sine)
             .SetEase(Tween.EaseType.Out);

        EmitSignal(SignalName.SteakButtonPressed);
    }
}
