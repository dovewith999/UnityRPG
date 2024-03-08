using System.Collections;
using System.Collections.Generic;
using Unity.Profiling.Editor;
using UnityEngine;

using static Define;

public class TitleScene : BaseScene
{
    public override bool Init()
    {
        if(false == base.Init())
        {
            return false;
        }
        
        SceneType = EScene.TitleScene;

        //StartLoadAsset();

        return true;
        
    }
    // Start is called before the first frame update
    void StartLoadAsset()
    {
        Managers.Resource.LoadAllAsync<Object>("PreLoad", (key, count, totalCount) =>
        {
            Debug.Log($"{key} {count}/{totalCount}");

            if(count == totalCount)
            {

            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
