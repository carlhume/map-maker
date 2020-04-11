using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkHexTileGenerator : MonoBehaviour
{
     public GameObject WaterHexTilePrefab;
    public GameObject ForestHexTilePrefab;
    public GameObject PlainsHexTilePrefab;
    public GameObject DesertHexTilePrefab;
    public GameObject MountainHexTilePrefab;

    private GameObject [] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        loadPrefabs();
        createHexTilemap();
    }

    private void loadPrefabs() {
        prefabs = new GameObject[5];
        prefabs[0] = WaterHexTilePrefab;
        prefabs[1] = ForestHexTilePrefab;
        prefabs[2] = PlainsHexTilePrefab;
        prefabs[3] = DesertHexTilePrefab;
        prefabs[4] = MountainHexTilePrefab;
    }

    private void createHexTilemap() {
    
    }

}
