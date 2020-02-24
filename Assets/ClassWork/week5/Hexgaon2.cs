using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexgaon2 : MonoBehaviour
    {

        void Start()
        {
        float r = Random.value;
        float x = Random.value;
        float y = Random.value;
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = new Material(Shader.Find("Roystan/Toon"));
        GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue);
        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[12]
        {
            new Vector3(x, y+r*2.25f, 0),
            new Vector3(x+r*2.125f*Mathf.Sqrt(3), y+r*1.125f, 0),
            new Vector3(x+r*2.125f*Mathf.Sqrt(3), y-r*1.125f, 0),
            new Vector3(x, y-r*2.25f, 0),
            new Vector3(x-r*2.125f, y-r*1.125f, 0),
            new Vector3(x-r*2.125f, y+r*1.125f, 0),
            new Vector3(x, y+r*2, 0),
            new Vector3(x+r*Mathf.Sqrt(3), y+r, 0),
            new Vector3(x+r*Mathf.Sqrt(3), y-r, 0),
            new Vector3(x, y-r*2, 0),
            new Vector3(x-r*Mathf.Sqrt(3), y-r, 0),
            new Vector3(x-r*Mathf.Sqrt(3), y+r, 0),
            };
            mesh.vertices = vertices;
            int[] tris = new int[36]
            {
             0,6,1,
             1,6,7,
             1,7,2,
             2,7,8,
             2,8,3,
             3,9,8,
             3,4,9,
             4,9,10,
             4,5,10,
             5,10,11,
             5,11,0,
             0,6,11

            };
            mesh.triangles = tris;
            Vector3[] normals = new Vector3[12]
            {
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward
            };
            mesh.normals = normals;
            Vector2[] uv = new Vector2[12]
            {
            new Vector2(x, y+r*2.25f),
            new Vector2(x+r*2.125f*Mathf.Sqrt(3), y+r*1.125f),
            new Vector2(x+r*2.125f*Mathf.Sqrt(3), y-r*1.125f),
            new Vector2(x, y-r*2.25f),
            new Vector2(x-r*2.125f, y-r*1.125f),
            new Vector2(x-r*2.125f, y+r*1.125f),
            new Vector2(x, y+r*2),
            new Vector2(x+r*Mathf.Sqrt(3), y+r),
            new Vector2(x+r*Mathf.Sqrt(3), y-r),
            new Vector2(x, y-r*2),
            new Vector2(x-r*Mathf.Sqrt(3), y-r),
            new Vector2(x-r*Mathf.Sqrt(3), y+r),
            };
            mesh.uv = uv;
            meshFilter.mesh = mesh;

            



        }
    }


