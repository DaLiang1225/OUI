using UnityEngine;
using System.Collections;

public class MainTopBarView : ViewBase
{
    void Awake()
    {
        _controller = new MainTopBarController( this );
        _controller.OnCreate();
    }

    public override void OnEnter()
    {
        base.OnEnter();

    }

    public override void OnInit()
    {
        base.OnInit();
    }

    public override void OnExit()
    {
        base.OnExit();
    }

    public override void OnDestory()
    {

    }
}
