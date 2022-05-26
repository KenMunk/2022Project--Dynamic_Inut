using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallColorTest : MonoBehaviour
{
    public Material active;
    public Material inactive;

    private UnityAction invokableAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activate()
    {
        gameObject.GetComponent<MeshRenderer>().material = active;
        invokableAction?.Invoke();
    }

    public UnityAction getActivate()
    {
        return (new UnityAction(activate));
    }

    public void deactivate()
    {
        gameObject.GetComponent<MeshRenderer>().material = inactive;
    }

    public UnityAction getDeactivate()
    {
        return (new UnityAction(deactivate));
    }
    
    public void addInvokable(UnityAction action)
    {
        if(invokableAction == null)
        {
            invokableAction = action;
        }
        else
        {
            invokableAction += action;
        }
    }
}
