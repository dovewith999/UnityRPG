using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define
{
    public enum EScene
    {
        Unknown,
        TitleScene,
        GameScene,
    }

    public enum EUIEvent
    {
        Click,           //클릭했을 때
        PointerDown,     //마우스를 누르는 순간
        PointerUp,       //마우스를 떼는 순간
        Drag,            //마우스를 누르고 드래그 하는 순간
    }

    public enum EJoystickState
    {
        PointerDown,
        PointerUp,
        Drag,
    }

    public enum EObjectType
    {
        None,
        Creature,
        Projectile,
        Env,
    }

    public enum ECreatureType
    {
        None,
        Hero,
        Monster,
        Npc,
    }

    public enum ECreatureState
    {
        None,
        Idle,
        Move,
        Skill,
        Dead
    }

    public enum ESound
    {
        Bgm,
        Effect,
        Max,
    }
}

public static class AnimName
{
    public const string IDLE = "idle";
    public const string ATTACK_A = "attack_a";
    public const string ATTACK_B = "attack_b";
    public const string MOVE = "move";
    public const string DEAD = "dead";
}
