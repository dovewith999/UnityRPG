using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Pipeline;
using UnityEngine;
using static Define;

public class Hero : Creature
{
    public float Speed { get; set; } = 5.0f;
    Vector2 _moveDir = Vector2.zero;

    public override bool Init()
    {
        if(false == base.Init())
        {
            return false;
        }

        CreatureType = ECreatureType.Hero;
        CreatureState = ECreatureState.Idle;
        //Speed = 5.0f;

        Managers.Game.OnMoveDirChanged -= HandleOnMoveDirChanged;
        Managers.Game.OnMoveDirChanged += HandleOnMoveDirChanged;
        Managers.Game.OnJoystickStateChanged -= HandleOnJoystickStateChanged;
        Managers.Game.OnJoystickStateChanged += HandleOnJoystickStateChanged;

        return true;
    }

    void Update()
    {
        transform.TranslateEx(_moveDir * Time.deltaTime * Speed);
    }

    private void HandleOnMoveDirChanged(Vector2 dir)
    {
        _moveDir = dir;
        Debug.Log(dir);
    }

    private void HandleOnJoystickStateChanged(EJoystickState joystickState)
    {
        switch (joystickState)
        {
            case Define.EJoystickState.PointerDown:
                CreatureState = Define.ECreatureState.Move;
                break;
            case Define.EJoystickState.Drag:
                break;
            case Define.EJoystickState.PointerUp:
                CreatureState = Define.ECreatureState.Idle;
                break;
            default:
                break;
        }
    }
}
