using UnityEngine;
using System.Collections;

public class MainTopBarController : ControllerBase
{
    public MainTopBarController( ViewBase view )
    {
        _viewBase = view;

        this.OnCreate();
    }

    public override void OnCreate()
    {
        base.OnCreate();

        // prepare datas
    }

    public override void OnResume()
    {
        base.OnResume();

        // add event listeners

    }

    public override void OnPause()
    {
        base.OnPause();

        // remover event listeners
    }
}
