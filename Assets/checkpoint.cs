using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public Transform m_NewTransform;
    Collider m_Collider;
    Vector3 m_Point;

    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
       
        m_Point = m_NewTransform.position;
    }

 

    // Update is called once per frame
    void Update()
    {
        if (m_Collider.bounds.Contains(m_Point))
        {
            Debug.Log("Bounds contain the point : " + m_Point);
            
        }
    }
}
