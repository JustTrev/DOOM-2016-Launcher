using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace DOOM_Launcher
{
    class x360_Gamepad
    {
    }
}

// Stores states of a single gamepad button
public struct xButton
{
    public ButtonState prev_state;
    public ButtonState state;
}

// Stores state of a single gamepad trigger
public struct TriggerState
{
    public float prev_value;
    public float current_value;
}

// Rumble (vibration) event
class xRumble
{
    public float timer;    // Rumble timer
    public float duration; // Fade-out (in seconds)
    public Vector2 power;  // Intensity of rumble
}

// Above code omitted....

public class x360_Gamepad
{
    private GamePadState prev_state; // Previous gamepad state
    private GamePadState state;      // Current gamepad state

    private int gamepadIndex;        // Numeric index (1,2,3 or 4
    private PlayerIndex playerIndex;    // XInput 'Player' index
    private List<xRumble> rumbleEvents; // Stores rumble events

    // Button input map (explained soon!)
    private Dictionary<string, xButton> inputMap;

    // States for all buttons/inputs supported
    private xButton A, B, X, Y; // Action (face) buttons
    private xButton DPad_Up, DPad_Down, DPad_Left, DPad_Right;

    private xButton Guide;       // Xbox logo button}
    private xButton Back, Start;
    private xButton L3, R3;      // Thumbstick buttons
    private xButton LB, RB;      // 'Bumper' (shoulder) buttons
    private TriggerState LT, RT; // Triggers

    // Constructor
    public x360_Gamepad(int index)
    {
        // Set gamepad index
        gamepadIndex = index - 1;
        playerIndex = (PlayerIndex)gamepadIndex;

        // Create rumble container and input map
        rumbleEvents = new List<xRumble>();
        inputMap = new Dictionary<string, xButton>();
    }

    // Constructor...

    // Update gamepad state
    public void Update()
    {
        //PlayerIndex playerIndex = default(PlayerIndex);
        // Get current state
        state = GamePad.GetState(playerIndex);

        // Check gamepad is connected
        if (state.IsConnected)
        {
            A.state = state.Buttons.A;
            B.state = state.Buttons.B;
            X.state = state.Buttons.X;
            Y.state = state.Buttons.Y;


            DPad_Up.state = state.DPad.Up;
            DPad_Down.state = state.DPad.Down;
            DPad_Left.state = state.DPad.Left;
            DPad_Right.state = state.DPad.Right;

            Guide.state = state.Buttons.Start; //This button is not available to program.
            Back.state = state.Buttons.Back;
            Start.state = state.Buttons.Start;
            L3.state = state.Buttons.LeftStick;
            R3.state = state.Buttons.RightStick;
            LB.state = state.Buttons.LeftShoulder;
            RB.state = state.Buttons.RightShoulder;

            // Read trigger values into trigger states
            LT.current_value = state.Triggers.Left;
            RT.current_value = state.Triggers.Right;
        }
    }

    // Above code omitted...
    // 'Update' function...

    // Refresh previous gamepad state
    public void Refresh()
    {
        // This 'saves' the current state for next update
        prev_state = state;

        // Check gamepad is connected
        if (state.IsConnected)
        {
            A.prev_state = prev_state.Buttons.A;
            B.prev_state = prev_state.Buttons.B;
            X.prev_state = prev_state.Buttons.X;
            Y.prev_state = prev_state.Buttons.Y;

            DPad_Up.prev_state = prev_state.DPad.Up;
            DPad_Down.prev_state = prev_state.DPad.Down;
            DPad_Left.prev_state = prev_state.DPad.Left;
            DPad_Right.prev_state = prev_state.DPad.Right;

            Guide.prev_state = prev_state.Buttons.Start;
            Back.prev_state = prev_state.Buttons.Back;
            Start.prev_state = prev_state.Buttons.Start;
            L3.prev_state = prev_state.Buttons.LeftStick;
            R3.prev_state = prev_state.Buttons.RightStick;
            LB.prev_state = prev_state.Buttons.LeftShoulder;
            RB.prev_state = prev_state.Buttons.RightShoulder;

            // Read previous trigger values into trigger states
            LT.prev_value = prev_state.Triggers.Left;
            RT.prev_value = prev_state.Triggers.Right;
        }
    }

    // Above code omitted...
    // 'Refresh' function...

    // Return numeric gamepad index
    public int Index { get { return gamepadIndex; } }

    // Return gamepad connection state
    public bool IsConnected { get { return state.IsConnected; } }
}

