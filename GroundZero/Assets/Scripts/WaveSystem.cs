using UnityEngine;
using System.Collections;

public class WaveSystem : MonoBehaviour {
    private int waves = 20;
    private int maxUnits = 10;
    private int units = 0;
    private bool clear = true;
    private int currentWave;
    private int nextWave;
    private GameObject[] spawnRegions;
    private Vector3[][] SpawnLocations;

    // Use this for initialization
    void Start () {
        //set default start and next wave
        currentWave = 0;
        nextWave = 1;
        //get all regions setup and then make a 2d array of that size where we will store the list of vectors
        spawnRegions = GameObject.FindGameObjectsWithTag("SpawnRegion");
        SpawnLocations = new Vector3[spawnRegions.Length][];
        int i = 0;
        foreach (GameObject spawnRegion in spawnRegions) {
            Renderer rend = spawnRegion.GetComponent<Renderer>();
            Vector3 center = rend.bounds.center;
            Vector3 extents = rend.bounds.extents;
            //after we get the bounds of each region calculate the 4 corners
            Vector3[] positionArray = new Vector3[2];
            positionArray[0] = center;
            positionArray[1] = extents;
            //add values to our array
            SpawnLocations[i] = positionArray;
            i++;
        }
    }

    // Update is called once per frame
    void Update () {
        if (clear == true) {
            if (units < maxUnits) {
                int region = Random.Range(0, SpawnLocations.Length);
                Vector3 center = SpawnLocations[region][0];
                Vector3 extents = SpawnLocations[region][1];
                GameObject prefab = (GameObject)Resources.Load("EnemyBasic");
                Instantiate(prefab, new Vector3(Random.Range(center.x - extents.x, center.x + extents.x),0,Random.Range(center.z - extents.z, center.z + extents.z)), Quaternion.identity);
                units++;
            } else {
                clear = false;
            }
        }
	}

    public void ClearStage() {
        if (currentWave != waves) {
            //right now we just increment and reset, eventually this is where we will set the enemy type for each wave and the max units for that wave
            currentWave++;
            nextWave++;
            units = 0;
            clear = true;
        }
    }
    public void CheckStage() {
        int Living = GameObject.FindGameObjectsWithTag("Enemy").Length;
        print(Living);
        if (Living <= 1) {
            print("new");
            ClearStage();
        }
    }
}
