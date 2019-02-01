using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

    public GameObject block;
    public int worldSizeX = 2;
    public int worldSizeY = 4;
    public int worldSizeZ = 1;


    public IEnumerator BuildWorld()
    {
        for(int z = 0; z < worldSizeX; z++)
        {
            for(int y = 0; y < worldSizeY; y++)
            {
                for(int x = 0; x < worldSizeZ; x++)
                {
                    Vector3 pos = new Vector3(x, y, z);
                    GameObject cube = GameObject.Instantiate(block, pos, Quaternion.identity);
                    cube.name = x + "_" + y + "_" + z;
                    cube.GetComponent<Renderer>().material = new Material(Shader.Find("Standard"));
                }
                yield return null;
            }
        }
    }
	// Use this for initialization
	void Start () {
        StartCoroutine(BuildWorld());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
