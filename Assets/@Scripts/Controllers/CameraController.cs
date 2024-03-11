using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Rendering;
using UnityEngine;

public class CameraController : InitBase
{

    private BaseObject _target;
    public BaseObject Target
    {
        get { return _target; } 
        set { _target = value; }    
    }

    public override bool Init()
    {
        if(false == base.Init())
        {
            return false;
        }

        Camera.main.orthographicSize = 15.0f;    

        return true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (null == _target)
        {
            return;
        }

        Vector3 targetPosition = new Vector3(Target.CenterPosition.x, Target.CenterPosition.y, -10f);
        transform.position = targetPosition;
    }
}
