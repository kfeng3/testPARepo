using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruleBasedGeometryPlacer : MonoBehaviour
{

    public Vector3 position;
    public Vector3 scale;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jiggle = new Vector3(position.x, position.y + Random.value, position.z);
        this.transform.position = jiggle;
        this.transform.localScale = scale;
        this.transform.localEulerAngles = rotation;
    }
}
