using Godot;
using System;

public partial class Toast : RichTextLabel
{
    // --- Exported Properties ---

    [Export]
    public float VisibleDuration = 5.0f;
    [Export]
    public float FadeSpeed = 2.0f;

    // --- Internal State Variables ---

    private float _timeVisible = 0.0f;   // Tracks how long the toast has been fully visible.
    private bool _isFading = false;      // State flag: Is the toast currently fading out?

    public override void _Ready()
    {
        Visible = false;

        Modulate = new Color(Modulate.R, Modulate.G, Modulate.B, 1.0f);
    }

    public override void _Process(double delta)
    {
        float d = (float)delta;

        if (Visible)
        {
            if (!_isFading)
            {
                // 1. Fully Visible Phase
                _timeVisible += d;

                if (_timeVisible >= VisibleDuration)
                {
                    // Time to start fading
                    _isFading = true;
                }
            }
            else
            {
                // 2. Fading Phase
                // Decrease the alpha (A) component of the Modulate color
                float currentAlpha = Modulate.A;

                // Calculate the new alpha value
                float newAlpha = currentAlpha - FadeSpeed * d;

                // Clamp the new alpha to be at least 0.0
                newAlpha = Mathf.Max(0.0f, newAlpha);

                // Apply the new color with reduced transparency
                Modulate = new Color(Modulate.R, Modulate.G, Modulate.B, newAlpha);

                if (newAlpha <= 0.0f)
                {
                    // Fading is complete, hide the control
                    Visible = false;
                    _isFading = false;

                    // Reset alpha for the next time it's shown
                    Modulate = new Color(Modulate.R, Modulate.G, Modulate.B, 1.0f);
                }
            }
        }
    }
    public void ShowToast(string message)
    {
        // 1. Set the content
        Text = message;

        // 2. Reset state variables
        _timeVisible = 0.0f;
        _isFading = false;

        // 3. Reset transparency and visibility
        Modulate = new Color(Modulate.R, Modulate.G, Modulate.B, 1.0f);
        Visible = true;
    }
}