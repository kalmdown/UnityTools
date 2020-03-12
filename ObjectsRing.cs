using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
[ExecuteAlways]
public class ObjectsRing : MonoBehaviour
{
    //public float radius = { get { return m_Radius; } set { m_Radius = value; } }
    [Range(0f, 100f)]
    public float radius = 10;

    [Range(0f,360f)]
    public float beginAngle = 0f;

    [Range(0f,360f)]
    public float endAngle = 360f;

    public bool flip = false;

    public enum orientationList {radial, upright};
    // [SerializeField]
    public orientationList orientation;    

    // Start is called before the first frame update
    void Start()
    {
        UpdateRing();
    }

    // Update is called once per frame
    void OnValidate()
    {
        UpdateRing();       
    }

    private void UpdateRing()
    {
        //Input error handling
        if (endAngle < beginAngle)
        {
            float tempAngle = beginAngle; 
            beginAngle = endAngle;
            endAngle = tempAngle;
        }

        // Attach mesh, rotate object and add material
        float objectAngle = (endAngle - beginAngle) / (transform.childCount);
        float rotation = beginAngle;
        for (int cnt = 0; cnt < transform.childCount; cnt++)
        {
            // Translate and rotate each object
            transform.GetChild(cnt).GetComponent<Transform>().localPosition = new Vector3(radius, 0, 0);
            // transform.GetChild(cnt).GetComponent<Transform>().rotation = Quaternion.Euler(0, rotation, 0);
            rotation = beginAngle + cnt * objectAngle;
            transform.GetChild(cnt).RotateAround(transform.position, new Vector3(0,1,0), rotation);
            transform.GetChild(cnt).LookAt(transform.position);
            if (flip)
            {
                transform.GetChild(cnt).Rotate(new Vector3(0,180,0));
            }
            if (orientation == orientationList.radial)
            {
                transform.GetChild(cnt).Rotate(new Vector3(-90,-90,0));                
            }         
        }
    }
}
