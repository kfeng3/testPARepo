using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Art
{
    public class SquarePacking : ArtMakerTemplate
    {
        public float largeSize = 2;
        public float smallSize = .5f;
        public int num = 10;
        public float worldSize = 10;
        public GameObject[] objects;

        public override void MakeArt()
        {
            
            List<Vector3> Cubes = CirclePacker.PackCircles(smallSize, largeSize, num, worldSize);
            for (int i = 0; i < Cubes.Count; i++)
            {
                GameObject g = Instantiate(objects[Random.Range(0, objects.Length)]);
                g.transform.parent = root.transform;
                float s = Random.value * .25f;
                g.transform.localPosition = new Vector3(Cubes[i].x, Cubes[i].y, s);
                g.transform.localScale = new Vector3(Cubes[i].z, Cubes[i].z, Cubes[i].z);

                
            }

            
            
        }
    }
}