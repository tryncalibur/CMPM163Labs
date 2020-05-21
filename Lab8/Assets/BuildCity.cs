using UnityEngine;
using System.Collections;

public class BuildCity : MonoBehaviour {
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    int buildingFootprint = 3;

    void Start(){
        for (int h = 0; h < mapHeight; ++h)
        {
        	float seed = Random.Range(0, 100);
            for (int w = 0; w < mapWidth; ++w)
            {
                int result = (int) (Mathf.PerlinNoise(w/10.0f + seed, h/10.0f + seed) * 10);
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                //int n = Random.Range(0, buildings.Length);

                if (w == 2 || w == 3 || h == 5 || h == 6) result = 20;

                if (result < 1)
                	Instantiate(buildings[0], pos, Quaternion.identity);
            	else if (result < 2)
            		Instantiate(buildings[1], pos, Quaternion.identity);
        		else if (result < 3)
            		Instantiate(buildings[2], pos, Quaternion.identity);
        		else if (result < 5)
            		Instantiate(buildings[3], pos, Quaternion.identity);
        		else if (result < 6)
            		Instantiate(buildings[4], pos, Quaternion.identity);

            	else if (result < 10)
            		Instantiate(buildings[6], pos, Quaternion.identity);

        		else //Streeet
            		Instantiate(buildings[5], pos, Quaternion.identity);
            }
        }
    }
}
