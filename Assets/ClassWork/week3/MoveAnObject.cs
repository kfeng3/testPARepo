using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnObject : MonoBehaviour
{
    public Vector3 position;
    public Vector3 rotation;
    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jiggle = new Vector3(
            position.x + Mathf.Sin(60f),
            position.y + Random.value,
            position.z);
        this.transform.position = jiggle*5f;
        this.transform.localEulerAngles = rotation;
        this.transform.localScale = scale;

        if (Input.GetButtonDown("Jump"))
            Time.fixedDeltaTime = 0.0003f * Time.timeScale;

        else if (Input.GetButtonDown("Fire1"))
            Time.fixedDeltaTime = 1.0f;
                           
       
    }
}
