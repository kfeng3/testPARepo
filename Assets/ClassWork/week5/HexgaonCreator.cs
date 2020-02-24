using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexgaonCreator : MonoBehaviour
    {

        void Start()
        {
            float r = Random.value;
            float x = Random.value;
            float y = Random.value;
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
            meshRenderer.sharedMaterial = new Material(Shader.Find("Roystan/Toon"));
            GetComponent<MeshRenderer>().material.SetColor("_Color",Color.blue);
            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            Mesh mesh = new Mesh();
            Vector3[] vertices = new Vector3[7]
            {
            new Vector3(x, y, 0),
            new Vector3(x,y+r*2f,0),
            new Vector3(x+r*Mathf.Sqrt(3) , y+r , 0),
            new Vector3(x+r*Mathf.Sqrt(3), y-r, 0),
            new Vector3(x, y-r*2f, 0),
            new Vector3(x-r*Mathf.Sqrt(3), y-r, 0),
            new Vector3(x-r*Mathf.Sqrt(3), y+r, 0),
            };
            mesh.vertices = vertices;
            int[] tris = new int[18]
            {
             0, 1, 2,
             0, 2, 3,
             0, 3, 4,
             0, 4, 5,
             0, 5, 6,
             0, 6, 1
            };
            mesh.triangles = tris;
            Vector3[] normals = new Vector3[7]
            {
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward
            };
            mesh.normals = normals;
            Vector2[] uv = new Vector2[7]
            {
            new Vector2(x, y),
            new Vector2(x,y+r*2f),
            new Vector2(x+r*Mathf.Sqrt(3) , y+r),
            new Vector2(x+r*Mathf.Sqrt(3), y-r),
            new Vector2(x, y-r*2f),
            new Vector2(x-r*Mathf.Sqrt(3), y-r),
            new Vector2(x-r*Mathf.Sqrt(3), y+r),
            };
            mesh.uv = uv;
            meshFilter.mesh = mesh;

            



        }
    }


