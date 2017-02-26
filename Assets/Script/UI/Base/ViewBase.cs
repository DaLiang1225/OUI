using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ViewBase : MonoBehaviour
{
    protected ControllerBase _controller;
    protected Animation _falledInAnimation;
    protected Animation _falledOutAnimation;


    private bool _inited = false;
    private static Stack<ViewBase> _viewStack = new Stack<ViewBase>();

    public virtual void OnInit()
    {
        _inited = true;
    }

    public virtual void OnEnter()
    {
        if ( _inited == false )
        {
            OnInit();
        }

        if ( !_viewStack.Contains( this ) )
        {
            _viewStack.Push( this );
        }

        if ( _falledInAnimation != null)
        {
            _falledInAnimation.Play();
        }
    }

    public virtual void OnExit()
    {
        if ( _viewStack != null && _viewStack.Peek().Equals( this ) )
        {
            _viewStack.Pop();

            if ( this._controller != null )
            {
                this._controller.OnPause();
            }
        }

        if ( _falledOutAnimation != null )
        {
            _falledOutAnimation.Play();
        }
    }

    public virtual void OnDestory()
    {
        if ( _viewStack != null && _viewStack.Peek().Equals( this ) )
        {
            _viewStack.Pop();

            if ( this._controller != null )
            {
                this._controller.OnDestory();
            }
        }
    }
}
