using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cursor is updated based on last known cursor state. If the state is unchanged from the last frame, the image is not updated.
/// This should stop the cursor from being changed if it isn't neccessary, reducing the number of calls to SetCursor(). 
/// If the cursor is not updated in the last frame it will reset to default. 
/// This means you don't need to worry about changing the cursor back to default after using it.
/// </summary>
public class MouseCursor : MonoBehaviour
{
    // Cursor state, defines which cursor to draw.
    public enum State
    {
        POINTER, CLICKABLE, TARGET
    }
    
    private bool b_isUpdated = false;

    private State g_defaultState = State.POINTER;
    private State g_currentState = State.POINTER;
    private State g_prevState = State.POINTER;

    [Tooltip("Default cursor image.")]
    public Texture2D m_pointerCursor;

    [Tooltip("Cursor image when hovering over a clickable object.")]
    public Texture2D m_clickableCursor;

    [Tooltip("Cursor image when using the extinguisher.")]
    public Texture2D m_targetCursor;
    
    // Called at fixed intervals. Synchronised with physics updates.
    void FixedUpdate ()
    {
        // Check if cursor has been updated this frame.
        if (b_isUpdated)
        {
            // Check if new state is different to previous state.
            if (g_currentState != g_prevState)
            {
                // Update cursor based on last known cursor state.
                UpdateCursor(g_currentState);
            }

            // Update complete, reset boolean.
            b_isUpdated = false;
        }
        else
        {
            // Cursor is not updated, check if state is already default.
            if (g_currentState != g_defaultState)
            {
                // Set state to default, update cursor.
                g_currentState = g_defaultState;
                UpdateCursor(g_defaultState);
            }
        }

        // Update previous state.
        g_prevState = g_currentState;
    }

    /// <summary>
    /// Update cursor state, changing the state will change the cursor being rendered.
    /// </summary>
    /// <param name="state">The new cursor state.</param>
    public void SetState (State state)
    {
        // State has been updated, change cursor state.
        b_isUpdated = true;
        g_currentState = state;
    }

    /// <summary>
    /// Set default cursor state, changes the default state the cursor will revert to if not updated during a frame.
    /// </summary>
    /// <param name="state">The new default cursor state.</param>
    public void SetDefaultState(State state)
    {
        g_defaultState = state;
    }

    private void UpdateCursor(State state)
    {
        // Update cursor image based on current state.
        switch (state)
        {
            case State.POINTER:
                {
                    Cursor.SetCursor(m_pointerCursor, Vector2.zero, CursorMode.Auto); break;
                }
            case State.CLICKABLE:
                {
                    Cursor.SetCursor(m_clickableCursor, Vector2.zero, CursorMode.Auto); break;
                }
            case State.TARGET:
                {
                    Cursor.SetCursor(m_targetCursor, new Vector2(m_targetCursor.width * 0.5f, m_targetCursor.height * 0.5f), CursorMode.Auto); break;
                }
            default:
                {
                    // Safety measure, set to default if state isn't already covered.
                    Cursor.SetCursor(m_pointerCursor, Vector2.zero, CursorMode.Auto); break;
                }
        }
    }
}
