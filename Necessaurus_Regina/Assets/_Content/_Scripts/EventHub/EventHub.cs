using System;
using UnityEngine;

public static class EventHub 
{
    #region Player Events
    public static event Action<float> Event_MoveSpeed;
    public static void MoveSpeed(float speed)
    {
        Event_MoveSpeed?.Invoke(speed);
    }

    public static event Action Event_PlayerStep;
    public static void PlayerStep()
    {
        Event_PlayerStep?.Invoke();
    }

    public static event Action Event_PlayerJump;
    public static void PlayerJump()
    {
        Event_PlayerJump?.Invoke();
    }

    #endregion

    #region Ball Events

    public static event Action Event_BallWallHit;
    public static void BallWallHit()
    {
        Event_BallWallHit?.Invoke();
    }

    public static event Action Event_BallBirdHit;
    public static void BallBirdHit()
    {
        Event_BallBirdHit?.Invoke();
    }

    #endregion
}
