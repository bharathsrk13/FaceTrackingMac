using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class FaceController : MonoBehaviour
{
    public Vector2 pos;
    public Vector3 rot;
    public float scaleFactor = 1;

    Vector2 prevPosition;
    Vector3 prevRotation;
    float prevScale;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        rot = transform.rotation.eulerAngles;
    }
    public void RotateMask(float x, float y, float z)
    {
        transform.rotation = Quaternion.Euler(new Vector3(x,y,z));
    }
    public void ScaleMask(float scaleFactorNum)
    {
        var tempScale = new Vector3(scaleFactorNum, scaleFactorNum, scaleFactorNum);
        transform.localScale = tempScale;
    }
    public void TranslateMask (float x, float y)
    {
        var tempPos = new Vector3(x, y, 0.863f);
        transform.position = tempPos;
    }
    // Update is called once per frame
    void Update()
    {
        if(prevPosition!=pos ||  prevRotation!=rot || prevScale != scaleFactor)
        {
            prevPosition = pos;
            prevRotation = rot;

            //updating position
            TranslateMask(pos.x, pos.y);
            // to scale mask
            ScaleMask(scaleFactor);
            //to rotate mask
            RotateMask(rot.x,rot.y,rot.z);
        }
    }
}
