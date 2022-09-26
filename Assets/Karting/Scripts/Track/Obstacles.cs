using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    static bool placePegs = false;
    public CrashObject CrashObjPrefab;

    public int AddPegs()
    {
        //...
        var obj =(GameObject)GameObject.Find("CrashObject");
        //(CrashObject)Resources.Load("Props/CrashObject");
        GameObject track = GameObject.Find("OvalTrack");
        var pos = new Vector3(0, 0, 0);
        var rot = new Quaternion();
        int res = 0;
        foreach (Transform child in track.transform)
        {
            Instantiate(obj, pos, rot, child.transform);
            res++;
        }
        return res;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (AddPegs() > 1)
            placePegs = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!placePegs)
        {
            if (AddPegs() > 1)
                placePegs = true;
        }
    }
}
