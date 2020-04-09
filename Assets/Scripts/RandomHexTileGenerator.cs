using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHexTileGenerator : MonoBehaviour
{
    public GameObject WaterHexTilePrefab;
    public GameObject ForestHexTilePrefab;
    public GameObject PlainsHexTilePrefab;
    public GameObject DesertHexTilePrefab;
    public GameObject MountainHexTilePrefab;

    private GameObject [] prefabs;

    public int mapWidthInHexes;
    public int mapHeightInHexes;

    public float tileXOffset;
    public float tileYoffset;

    private System.Random random = new System.Random();

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
        //Game object which is the parent of all the hex tiles
        GameObject hexGridGO = new GameObject( "HexGrid" );

        for( int x = 0; x < mapWidthInHexes; x++ ) {
            for( int y = 0; y < mapHeightInHexes; y++ ) {
                GameObject hexToPlaceGO = chooseHex();

                if( isEvenRow( y ) ) {
                    hexToPlaceGO.transform.position = new Vector3( x * tileXOffset + tileXOffset / 2, y * tileYoffset, 0.01f );
                } else {
                    hexToPlaceGO.transform.position = new Vector3( x * tileXOffset, y * tileYoffset, 0.01f );
                }
            }
        }

    }

    private GameObject chooseHex() {
        GameObject prefab = prefabs[ random.Next( 0, prefabs.Length ) ];
        return Instantiate( prefab );
    }

    private bool isEvenRow( int row ) {
        return row % 2 == 0;
    }

}
