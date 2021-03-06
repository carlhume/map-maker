﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkHexTileGenerator : MonoBehaviour
{
    public GameObject WaterHexTilePrefab;
    public GameObject ForestHexTilePrefab;
    public GameObject PlainsHexTilePrefab;
    public GameObject DesertHexTilePrefab;
    public GameObject MountainHexTilePrefab;
    public float tileXOffset;
    public float tileYoffset;

    private GameObject [] prefabs;
    private GameObject [,] mapData;

    // Start is called before the first frame update
    void Start() {
        loadMapData();
        createHexTilemap();
    }

    private void createHexTilemap() {
        //Game object which is the parent of all the hex tiles
        GameObject hexGridGO = new GameObject( "HexGrid" );

        for( int x = 0; x < 26; x++ ) {
            for( int y = 0; y < 26; y++ ) {
                GameObject hexToPlaceGO = Instantiate( mapData[x,y] );

                if( isEvenRow( y ) ) {
                    hexToPlaceGO.transform.position = new Vector3( x * tileXOffset + tileXOffset / 2, y * tileYoffset, 0.01f );
                } else {
                    hexToPlaceGO.transform.position = new Vector3( x * tileXOffset, y * tileYoffset, 0.01f );
                }
            }
        }
    }

    private void loadMapData() {
        // TODO:  This will be replaced by reaching out over the network - stubbing data for now
        mapData = new GameObject[26,26];

        mapData[0,0] = PlainsHexTilePrefab;
        mapData[0,1] = WaterHexTilePrefab;
        mapData[0,2] = DesertHexTilePrefab;
        mapData[0,3] = MountainHexTilePrefab;
        mapData[0,4] = ForestHexTilePrefab;
        mapData[0,5] = PlainsHexTilePrefab;
        mapData[0,6] = PlainsHexTilePrefab;
        mapData[0,7] = PlainsHexTilePrefab;
        mapData[0,8] = PlainsHexTilePrefab;
        mapData[0,9] = PlainsHexTilePrefab;
        mapData[0,10] = PlainsHexTilePrefab;
        mapData[0,11] = PlainsHexTilePrefab;
        mapData[0,12] = PlainsHexTilePrefab;
        mapData[0,13] = PlainsHexTilePrefab;
        mapData[0,14] = PlainsHexTilePrefab;
        mapData[0,15] = PlainsHexTilePrefab;
        mapData[0,16] = PlainsHexTilePrefab;
        mapData[0,17] = PlainsHexTilePrefab;
        mapData[0,18] = PlainsHexTilePrefab;
        mapData[0,19] = PlainsHexTilePrefab;
        mapData[0,20] = PlainsHexTilePrefab;
        mapData[0,21] = PlainsHexTilePrefab;
        mapData[0,22] = PlainsHexTilePrefab;
        mapData[0,23] = PlainsHexTilePrefab;
        mapData[0,24] = PlainsHexTilePrefab;
        mapData[0,25] = PlainsHexTilePrefab;

        mapData[1,0] = PlainsHexTilePrefab;
        mapData[1,1] = PlainsHexTilePrefab;
        mapData[1,2] = PlainsHexTilePrefab;
        mapData[1,3] = PlainsHexTilePrefab;
        mapData[1,4] = PlainsHexTilePrefab;
        mapData[1,5] = PlainsHexTilePrefab;
        mapData[1,6] = PlainsHexTilePrefab;
        mapData[1,7] = PlainsHexTilePrefab;
        mapData[1,8] = PlainsHexTilePrefab;
        mapData[1,9] = PlainsHexTilePrefab;
        mapData[1,10] = PlainsHexTilePrefab;
        mapData[1,11] = PlainsHexTilePrefab;
        mapData[1,12] = PlainsHexTilePrefab;
        mapData[1,13] = PlainsHexTilePrefab;
        mapData[1,14] = PlainsHexTilePrefab;
        mapData[1,15] = PlainsHexTilePrefab;
        mapData[1,16] = PlainsHexTilePrefab;
        mapData[1,17] = PlainsHexTilePrefab;
        mapData[1,18] = PlainsHexTilePrefab;
        mapData[1,19] = PlainsHexTilePrefab;
        mapData[1,20] = PlainsHexTilePrefab;
        mapData[1,21] = PlainsHexTilePrefab;
        mapData[1,22] = PlainsHexTilePrefab;
        mapData[1,23] = PlainsHexTilePrefab;
        mapData[1,24] = PlainsHexTilePrefab;
        mapData[1,25] = PlainsHexTilePrefab;

        mapData[2,0] = PlainsHexTilePrefab;
        mapData[2,1] = PlainsHexTilePrefab;
        mapData[2,2] = PlainsHexTilePrefab;
        mapData[2,3] = PlainsHexTilePrefab;
        mapData[2,4] = PlainsHexTilePrefab;
        mapData[2,5] = PlainsHexTilePrefab;
        mapData[2,6] = PlainsHexTilePrefab;
        mapData[2,7] = PlainsHexTilePrefab;
        mapData[2,8] = PlainsHexTilePrefab;
        mapData[2,9] = PlainsHexTilePrefab;
        mapData[2,10] = PlainsHexTilePrefab;
        mapData[2,11] = PlainsHexTilePrefab;
        mapData[2,12] = PlainsHexTilePrefab;
        mapData[2,13] = PlainsHexTilePrefab;
        mapData[2,14] = PlainsHexTilePrefab;
        mapData[2,15] = PlainsHexTilePrefab;
        mapData[2,16] = PlainsHexTilePrefab;
        mapData[2,17] = PlainsHexTilePrefab;
        mapData[2,18] = PlainsHexTilePrefab;
        mapData[2,19] = PlainsHexTilePrefab;
        mapData[2,20] = PlainsHexTilePrefab;
        mapData[2,21] = PlainsHexTilePrefab;
        mapData[2,22] = PlainsHexTilePrefab;
        mapData[2,23] = PlainsHexTilePrefab;
        mapData[2,24] = PlainsHexTilePrefab;
        mapData[2,25] = PlainsHexTilePrefab;

        mapData[3,0] = PlainsHexTilePrefab;
        mapData[3,1] = PlainsHexTilePrefab;
        mapData[3,2] = PlainsHexTilePrefab;
        mapData[3,3] = PlainsHexTilePrefab;
        mapData[3,4] = PlainsHexTilePrefab;
        mapData[3,5] = PlainsHexTilePrefab;
        mapData[3,6] = PlainsHexTilePrefab;
        mapData[3,7] = PlainsHexTilePrefab;
        mapData[3,8] = PlainsHexTilePrefab;
        mapData[3,9] = PlainsHexTilePrefab;
        mapData[3,10] = PlainsHexTilePrefab;
        mapData[3,11] = PlainsHexTilePrefab;
        mapData[3,12] = PlainsHexTilePrefab;
        mapData[3,13] = PlainsHexTilePrefab;
        mapData[3,14] = PlainsHexTilePrefab;
        mapData[3,15] = PlainsHexTilePrefab;
        mapData[3,16] = PlainsHexTilePrefab;
        mapData[3,17] = PlainsHexTilePrefab;
        mapData[3,18] = PlainsHexTilePrefab;
        mapData[3,19] = PlainsHexTilePrefab;
        mapData[3,20] = PlainsHexTilePrefab;
        mapData[3,21] = PlainsHexTilePrefab;
        mapData[3,22] = PlainsHexTilePrefab;
        mapData[3,23] = PlainsHexTilePrefab;
        mapData[3,24] = PlainsHexTilePrefab;
        mapData[3,25] = PlainsHexTilePrefab;

        mapData[4,0] = PlainsHexTilePrefab;
        mapData[4,1] = PlainsHexTilePrefab;
        mapData[4,2] = PlainsHexTilePrefab;
        mapData[4,3] = PlainsHexTilePrefab;
        mapData[4,4] = PlainsHexTilePrefab;
        mapData[4,5] = PlainsHexTilePrefab;
        mapData[4,6] = PlainsHexTilePrefab;
        mapData[4,7] = PlainsHexTilePrefab;
        mapData[4,8] = PlainsHexTilePrefab;
        mapData[4,9] = PlainsHexTilePrefab;
        mapData[4,10] = PlainsHexTilePrefab;
        mapData[4,11] = PlainsHexTilePrefab;
        mapData[4,12] = PlainsHexTilePrefab;
        mapData[4,13] = PlainsHexTilePrefab;
        mapData[4,14] = PlainsHexTilePrefab;
        mapData[4,15] = PlainsHexTilePrefab;
        mapData[4,16] = PlainsHexTilePrefab;
        mapData[4,17] = PlainsHexTilePrefab;
        mapData[4,18] = PlainsHexTilePrefab;
        mapData[4,19] = PlainsHexTilePrefab;
        mapData[4,20] = PlainsHexTilePrefab;
        mapData[4,21] = PlainsHexTilePrefab;
        mapData[4,22] = PlainsHexTilePrefab;
        mapData[4,23] = PlainsHexTilePrefab;
        mapData[4,24] = PlainsHexTilePrefab;
        mapData[4,25] = PlainsHexTilePrefab;

        mapData[5,0] = PlainsHexTilePrefab;
        mapData[5,1] = PlainsHexTilePrefab;
        mapData[5,2] = PlainsHexTilePrefab;
        mapData[5,3] = PlainsHexTilePrefab;
        mapData[5,4] = PlainsHexTilePrefab;
        mapData[5,5] = PlainsHexTilePrefab;
        mapData[5,6] = PlainsHexTilePrefab;
        mapData[5,7] = PlainsHexTilePrefab;
        mapData[5,8] = PlainsHexTilePrefab;
        mapData[5,9] = PlainsHexTilePrefab;
        mapData[5,10] = PlainsHexTilePrefab;
        mapData[5,11] = PlainsHexTilePrefab;
        mapData[5,12] = PlainsHexTilePrefab;
        mapData[5,13] = PlainsHexTilePrefab;
        mapData[5,14] = PlainsHexTilePrefab;
        mapData[5,15] = PlainsHexTilePrefab;
        mapData[5,16] = PlainsHexTilePrefab;
        mapData[5,17] = PlainsHexTilePrefab;
        mapData[5,18] = PlainsHexTilePrefab;
        mapData[5,19] = PlainsHexTilePrefab;
        mapData[5,20] = PlainsHexTilePrefab;
        mapData[5,21] = PlainsHexTilePrefab;
        mapData[5,22] = PlainsHexTilePrefab;
        mapData[5,23] = PlainsHexTilePrefab;
        mapData[5,24] = PlainsHexTilePrefab;
        mapData[5,25] = PlainsHexTilePrefab;

        mapData[6,0] = PlainsHexTilePrefab;
        mapData[6,1] = PlainsHexTilePrefab;
        mapData[6,2] = PlainsHexTilePrefab;
        mapData[6,3] = PlainsHexTilePrefab;
        mapData[6,4] = PlainsHexTilePrefab;
        mapData[6,5] = PlainsHexTilePrefab;
        mapData[6,6] = PlainsHexTilePrefab;
        mapData[6,7] = PlainsHexTilePrefab;
        mapData[6,8] = PlainsHexTilePrefab;
        mapData[6,9] = PlainsHexTilePrefab;
        mapData[6,10] = PlainsHexTilePrefab;
        mapData[6,11] = PlainsHexTilePrefab;
        mapData[6,12] = PlainsHexTilePrefab;
        mapData[6,13] = PlainsHexTilePrefab;
        mapData[6,14] = PlainsHexTilePrefab;
        mapData[6,15] = PlainsHexTilePrefab;
        mapData[6,16] = PlainsHexTilePrefab;
        mapData[6,17] = PlainsHexTilePrefab;
        mapData[6,18] = PlainsHexTilePrefab;
        mapData[6,19] = PlainsHexTilePrefab;
        mapData[6,20] = PlainsHexTilePrefab;
        mapData[6,21] = PlainsHexTilePrefab;
        mapData[6,22] = PlainsHexTilePrefab;
        mapData[6,23] = PlainsHexTilePrefab;
        mapData[6,24] = PlainsHexTilePrefab;
        mapData[6,25] = PlainsHexTilePrefab;

        mapData[7,0] = PlainsHexTilePrefab;
        mapData[7,1] = PlainsHexTilePrefab;
        mapData[7,2] = PlainsHexTilePrefab;
        mapData[7,3] = PlainsHexTilePrefab;
        mapData[7,4] = PlainsHexTilePrefab;
        mapData[7,5] = PlainsHexTilePrefab;
        mapData[7,6] = PlainsHexTilePrefab;
        mapData[7,7] = PlainsHexTilePrefab;
        mapData[7,8] = PlainsHexTilePrefab;
        mapData[7,9] = PlainsHexTilePrefab;
        mapData[7,10] = PlainsHexTilePrefab;
        mapData[7,11] = PlainsHexTilePrefab;
        mapData[7,12] = PlainsHexTilePrefab;
        mapData[7,13] = PlainsHexTilePrefab;
        mapData[7,14] = PlainsHexTilePrefab;
        mapData[7,15] = PlainsHexTilePrefab;
        mapData[7,16] = PlainsHexTilePrefab;
        mapData[7,17] = PlainsHexTilePrefab;
        mapData[7,18] = PlainsHexTilePrefab;
        mapData[7,19] = PlainsHexTilePrefab;
        mapData[7,20] = PlainsHexTilePrefab;
        mapData[7,21] = PlainsHexTilePrefab;
        mapData[7,22] = PlainsHexTilePrefab;
        mapData[7,23] = PlainsHexTilePrefab;
        mapData[7,24] = PlainsHexTilePrefab;
        mapData[7,25] = PlainsHexTilePrefab;

        mapData[8,0] = PlainsHexTilePrefab;
        mapData[8,1] = PlainsHexTilePrefab;
        mapData[8,2] = PlainsHexTilePrefab;
        mapData[8,3] = PlainsHexTilePrefab;
        mapData[8,4] = PlainsHexTilePrefab;
        mapData[8,5] = PlainsHexTilePrefab;
        mapData[8,6] = PlainsHexTilePrefab;
        mapData[8,7] = PlainsHexTilePrefab;
        mapData[8,8] = PlainsHexTilePrefab;
        mapData[8,9] = PlainsHexTilePrefab;
        mapData[8,10] = PlainsHexTilePrefab;
        mapData[8,11] = PlainsHexTilePrefab;
        mapData[8,12] = PlainsHexTilePrefab;
        mapData[8,13] = PlainsHexTilePrefab;
        mapData[8,14] = PlainsHexTilePrefab;
        mapData[8,15] = PlainsHexTilePrefab;
        mapData[8,16] = PlainsHexTilePrefab;
        mapData[8,17] = PlainsHexTilePrefab;
        mapData[8,18] = PlainsHexTilePrefab;
        mapData[8,19] = PlainsHexTilePrefab;
        mapData[8,20] = PlainsHexTilePrefab;
        mapData[8,21] = PlainsHexTilePrefab;
        mapData[8,22] = PlainsHexTilePrefab;
        mapData[8,23] = PlainsHexTilePrefab;
        mapData[8,24] = PlainsHexTilePrefab;
        mapData[8,25] = PlainsHexTilePrefab;

        mapData[9,0] = PlainsHexTilePrefab;
        mapData[9,1] = PlainsHexTilePrefab;
        mapData[9,2] = PlainsHexTilePrefab;
        mapData[9,3] = PlainsHexTilePrefab;
        mapData[9,4] = PlainsHexTilePrefab;
        mapData[9,5] = PlainsHexTilePrefab;
        mapData[9,6] = PlainsHexTilePrefab;
        mapData[9,7] = PlainsHexTilePrefab;
        mapData[9,8] = PlainsHexTilePrefab;
        mapData[9,9] = PlainsHexTilePrefab;
        mapData[9,10] = PlainsHexTilePrefab;
        mapData[9,11] = PlainsHexTilePrefab;
        mapData[9,12] = PlainsHexTilePrefab;
        mapData[9,13] = PlainsHexTilePrefab;
        mapData[9,14] = PlainsHexTilePrefab;
        mapData[9,15] = PlainsHexTilePrefab;
        mapData[9,16] = PlainsHexTilePrefab;
        mapData[9,17] = PlainsHexTilePrefab;
        mapData[9,18] = PlainsHexTilePrefab;
        mapData[9,19] = PlainsHexTilePrefab;
        mapData[9,20] = PlainsHexTilePrefab;
        mapData[9,21] = PlainsHexTilePrefab;
        mapData[9,22] = PlainsHexTilePrefab;
        mapData[9,23] = PlainsHexTilePrefab;
        mapData[9,24] = PlainsHexTilePrefab;
        mapData[9,25] = PlainsHexTilePrefab;

        mapData[10,0] = PlainsHexTilePrefab;
        mapData[10,1] = PlainsHexTilePrefab;
        mapData[10,2] = PlainsHexTilePrefab;
        mapData[10,3] = PlainsHexTilePrefab;
        mapData[10,4] = PlainsHexTilePrefab;
        mapData[10,5] = PlainsHexTilePrefab;
        mapData[10,6] = PlainsHexTilePrefab;
        mapData[10,7] = PlainsHexTilePrefab;
        mapData[10,8] = PlainsHexTilePrefab;
        mapData[10,9] = PlainsHexTilePrefab;
        mapData[10,10] = PlainsHexTilePrefab;
        mapData[10,11] = PlainsHexTilePrefab;
        mapData[10,12] = PlainsHexTilePrefab;
        mapData[10,13] = PlainsHexTilePrefab;
        mapData[10,14] = PlainsHexTilePrefab;
        mapData[10,15] = PlainsHexTilePrefab;
        mapData[10,16] = PlainsHexTilePrefab;
        mapData[10,17] = PlainsHexTilePrefab;
        mapData[10,18] = PlainsHexTilePrefab;
        mapData[10,19] = PlainsHexTilePrefab;
        mapData[10,20] = PlainsHexTilePrefab;
        mapData[10,21] = PlainsHexTilePrefab;
        mapData[10,22] = PlainsHexTilePrefab;
        mapData[10,23] = PlainsHexTilePrefab;
        mapData[10,24] = PlainsHexTilePrefab;
        mapData[10,25] = PlainsHexTilePrefab;

        mapData[11,0] = PlainsHexTilePrefab;
        mapData[11,1] = PlainsHexTilePrefab;
        mapData[11,2] = PlainsHexTilePrefab;
        mapData[11,3] = PlainsHexTilePrefab;
        mapData[11,4] = PlainsHexTilePrefab;
        mapData[11,5] = PlainsHexTilePrefab;
        mapData[11,6] = PlainsHexTilePrefab;
        mapData[11,7] = PlainsHexTilePrefab;
        mapData[11,8] = PlainsHexTilePrefab;
        mapData[11,9] = PlainsHexTilePrefab;
        mapData[11,10] = PlainsHexTilePrefab;
        mapData[11,11] = PlainsHexTilePrefab;
        mapData[11,12] = PlainsHexTilePrefab;
        mapData[11,13] = PlainsHexTilePrefab;
        mapData[11,14] = PlainsHexTilePrefab;
        mapData[11,15] = PlainsHexTilePrefab;
        mapData[11,16] = PlainsHexTilePrefab;
        mapData[11,17] = PlainsHexTilePrefab;
        mapData[11,18] = PlainsHexTilePrefab;
        mapData[11,19] = PlainsHexTilePrefab;
        mapData[11,20] = PlainsHexTilePrefab;
        mapData[11,21] = PlainsHexTilePrefab;
        mapData[11,22] = PlainsHexTilePrefab;
        mapData[11,23] = PlainsHexTilePrefab;
        mapData[11,24] = PlainsHexTilePrefab;
        mapData[11,25] = PlainsHexTilePrefab;

        mapData[12,0] = PlainsHexTilePrefab;
        mapData[12,1] = PlainsHexTilePrefab;
        mapData[12,2] = PlainsHexTilePrefab;
        mapData[12,3] = PlainsHexTilePrefab;
        mapData[12,4] = PlainsHexTilePrefab;
        mapData[12,5] = PlainsHexTilePrefab;
        mapData[12,6] = PlainsHexTilePrefab;
        mapData[12,7] = PlainsHexTilePrefab;
        mapData[12,8] = PlainsHexTilePrefab;
        mapData[12,9] = PlainsHexTilePrefab;
        mapData[12,10] = PlainsHexTilePrefab;
        mapData[12,11] = PlainsHexTilePrefab;
        mapData[12,12] = PlainsHexTilePrefab;
        mapData[12,13] = PlainsHexTilePrefab;
        mapData[12,14] = PlainsHexTilePrefab;
        mapData[12,15] = PlainsHexTilePrefab;
        mapData[12,16] = PlainsHexTilePrefab;
        mapData[12,17] = PlainsHexTilePrefab;
        mapData[12,18] = PlainsHexTilePrefab;
        mapData[12,19] = PlainsHexTilePrefab;
        mapData[12,20] = PlainsHexTilePrefab;
        mapData[12,21] = PlainsHexTilePrefab;
        mapData[12,22] = PlainsHexTilePrefab;
        mapData[12,23] = PlainsHexTilePrefab;
        mapData[12,24] = PlainsHexTilePrefab;
        mapData[12,25] = PlainsHexTilePrefab;

        mapData[13,0] = PlainsHexTilePrefab;
        mapData[13,1] = PlainsHexTilePrefab;
        mapData[13,2] = PlainsHexTilePrefab;
        mapData[13,3] = PlainsHexTilePrefab;
        mapData[13,4] = PlainsHexTilePrefab;
        mapData[13,5] = PlainsHexTilePrefab;
        mapData[13,6] = PlainsHexTilePrefab;
        mapData[13,7] = PlainsHexTilePrefab;
        mapData[13,8] = PlainsHexTilePrefab;
        mapData[13,9] = PlainsHexTilePrefab;
        mapData[13,10] = PlainsHexTilePrefab;
        mapData[13,11] = PlainsHexTilePrefab;
        mapData[13,12] = PlainsHexTilePrefab;
        mapData[13,13] = PlainsHexTilePrefab;
        mapData[13,14] = PlainsHexTilePrefab;
        mapData[13,15] = PlainsHexTilePrefab;
        mapData[13,16] = PlainsHexTilePrefab;
        mapData[13,17] = PlainsHexTilePrefab;
        mapData[13,18] = PlainsHexTilePrefab;
        mapData[13,19] = PlainsHexTilePrefab;
        mapData[13,20] = PlainsHexTilePrefab;
        mapData[13,21] = PlainsHexTilePrefab;
        mapData[13,22] = PlainsHexTilePrefab;
        mapData[13,23] = PlainsHexTilePrefab;
        mapData[13,24] = PlainsHexTilePrefab;
        mapData[13,25] = PlainsHexTilePrefab;

        mapData[14,0] = PlainsHexTilePrefab;
        mapData[14,1] = PlainsHexTilePrefab;
        mapData[14,2] = PlainsHexTilePrefab;
        mapData[14,3] = PlainsHexTilePrefab;
        mapData[14,4] = PlainsHexTilePrefab;
        mapData[14,5] = PlainsHexTilePrefab;
        mapData[14,6] = PlainsHexTilePrefab;
        mapData[14,7] = PlainsHexTilePrefab;
        mapData[14,8] = PlainsHexTilePrefab;
        mapData[14,9] = PlainsHexTilePrefab;
        mapData[14,10] = PlainsHexTilePrefab;
        mapData[14,11] = PlainsHexTilePrefab;
        mapData[14,12] = PlainsHexTilePrefab;
        mapData[14,13] = PlainsHexTilePrefab;
        mapData[14,14] = PlainsHexTilePrefab;
        mapData[14,15] = PlainsHexTilePrefab;
        mapData[14,16] = PlainsHexTilePrefab;
        mapData[14,17] = PlainsHexTilePrefab;
        mapData[14,18] = PlainsHexTilePrefab;
        mapData[14,19] = PlainsHexTilePrefab;
        mapData[14,20] = PlainsHexTilePrefab;
        mapData[14,21] = PlainsHexTilePrefab;
        mapData[14,22] = PlainsHexTilePrefab;
        mapData[14,23] = PlainsHexTilePrefab;
        mapData[14,24] = PlainsHexTilePrefab;
        mapData[14,25] = PlainsHexTilePrefab;

        mapData[15,0] = PlainsHexTilePrefab;
        mapData[15,1] = PlainsHexTilePrefab;
        mapData[15,2] = PlainsHexTilePrefab;
        mapData[15,3] = PlainsHexTilePrefab;
        mapData[15,4] = PlainsHexTilePrefab;
        mapData[15,5] = PlainsHexTilePrefab;
        mapData[15,6] = PlainsHexTilePrefab;
        mapData[15,7] = PlainsHexTilePrefab;
        mapData[15,8] = PlainsHexTilePrefab;
        mapData[15,9] = PlainsHexTilePrefab;
        mapData[15,10] = PlainsHexTilePrefab;
        mapData[15,11] = PlainsHexTilePrefab;
        mapData[15,12] = PlainsHexTilePrefab;
        mapData[15,13] = PlainsHexTilePrefab;
        mapData[15,14] = PlainsHexTilePrefab;
        mapData[15,15] = PlainsHexTilePrefab;
        mapData[15,16] = PlainsHexTilePrefab;
        mapData[15,17] = PlainsHexTilePrefab;
        mapData[15,18] = PlainsHexTilePrefab;
        mapData[15,19] = PlainsHexTilePrefab;
        mapData[15,20] = PlainsHexTilePrefab;
        mapData[15,21] = PlainsHexTilePrefab;
        mapData[15,22] = PlainsHexTilePrefab;
        mapData[15,23] = PlainsHexTilePrefab;
        mapData[15,24] = PlainsHexTilePrefab;
        mapData[15,25] = PlainsHexTilePrefab;

        mapData[16,0] = PlainsHexTilePrefab;
        mapData[16,1] = PlainsHexTilePrefab;
        mapData[16,2] = PlainsHexTilePrefab;
        mapData[16,3] = PlainsHexTilePrefab;
        mapData[16,4] = PlainsHexTilePrefab;
        mapData[16,5] = PlainsHexTilePrefab;
        mapData[16,6] = PlainsHexTilePrefab;
        mapData[16,7] = PlainsHexTilePrefab;
        mapData[16,8] = PlainsHexTilePrefab;
        mapData[16,9] = PlainsHexTilePrefab;
        mapData[16,10] = PlainsHexTilePrefab;
        mapData[16,11] = PlainsHexTilePrefab;
        mapData[16,12] = PlainsHexTilePrefab;
        mapData[16,13] = PlainsHexTilePrefab;
        mapData[16,14] = PlainsHexTilePrefab;
        mapData[16,15] = PlainsHexTilePrefab;
        mapData[16,16] = PlainsHexTilePrefab;
        mapData[16,17] = PlainsHexTilePrefab;
        mapData[16,18] = PlainsHexTilePrefab;
        mapData[16,19] = PlainsHexTilePrefab;
        mapData[16,20] = PlainsHexTilePrefab;
        mapData[16,21] = PlainsHexTilePrefab;
        mapData[16,22] = PlainsHexTilePrefab;
        mapData[16,23] = PlainsHexTilePrefab;
        mapData[16,24] = PlainsHexTilePrefab;
        mapData[16,25] = PlainsHexTilePrefab;

        mapData[17,0] = PlainsHexTilePrefab;
        mapData[17,1] = PlainsHexTilePrefab;
        mapData[17,2] = PlainsHexTilePrefab;
        mapData[17,3] = PlainsHexTilePrefab;
        mapData[17,4] = PlainsHexTilePrefab;
        mapData[17,5] = PlainsHexTilePrefab;
        mapData[17,6] = PlainsHexTilePrefab;
        mapData[17,7] = PlainsHexTilePrefab;
        mapData[17,8] = PlainsHexTilePrefab;
        mapData[17,9] = PlainsHexTilePrefab;
        mapData[17,10] = PlainsHexTilePrefab;
        mapData[17,11] = PlainsHexTilePrefab;
        mapData[17,12] = PlainsHexTilePrefab;
        mapData[17,13] = PlainsHexTilePrefab;
        mapData[17,14] = PlainsHexTilePrefab;
        mapData[17,15] = PlainsHexTilePrefab;
        mapData[17,16] = PlainsHexTilePrefab;
        mapData[17,17] = PlainsHexTilePrefab;
        mapData[17,18] = PlainsHexTilePrefab;
        mapData[17,19] = PlainsHexTilePrefab;
        mapData[17,20] = PlainsHexTilePrefab;
        mapData[17,21] = PlainsHexTilePrefab;
        mapData[17,22] = PlainsHexTilePrefab;
        mapData[17,23] = PlainsHexTilePrefab;
        mapData[17,24] = PlainsHexTilePrefab;
        mapData[17,25] = PlainsHexTilePrefab;

        mapData[18,0] = PlainsHexTilePrefab;
        mapData[18,1] = PlainsHexTilePrefab;
        mapData[18,2] = PlainsHexTilePrefab;
        mapData[18,3] = PlainsHexTilePrefab;
        mapData[18,4] = PlainsHexTilePrefab;
        mapData[18,5] = PlainsHexTilePrefab;
        mapData[18,6] = PlainsHexTilePrefab;
        mapData[18,7] = PlainsHexTilePrefab;
        mapData[18,8] = PlainsHexTilePrefab;
        mapData[18,9] = PlainsHexTilePrefab;
        mapData[18,10] = PlainsHexTilePrefab;
        mapData[18,11] = PlainsHexTilePrefab;
        mapData[18,12] = PlainsHexTilePrefab;
        mapData[18,13] = PlainsHexTilePrefab;
        mapData[18,14] = PlainsHexTilePrefab;
        mapData[18,15] = PlainsHexTilePrefab;
        mapData[18,16] = PlainsHexTilePrefab;
        mapData[18,17] = PlainsHexTilePrefab;
        mapData[18,18] = PlainsHexTilePrefab;
        mapData[18,19] = PlainsHexTilePrefab;
        mapData[18,20] = PlainsHexTilePrefab;
        mapData[18,21] = PlainsHexTilePrefab;
        mapData[18,22] = PlainsHexTilePrefab;
        mapData[18,23] = PlainsHexTilePrefab;
        mapData[18,24] = PlainsHexTilePrefab;
        mapData[18,25] = PlainsHexTilePrefab;

        mapData[19,0] = PlainsHexTilePrefab;
        mapData[19,1] = PlainsHexTilePrefab;
        mapData[19,2] = PlainsHexTilePrefab;
        mapData[19,3] = PlainsHexTilePrefab;
        mapData[19,4] = PlainsHexTilePrefab;
        mapData[19,5] = PlainsHexTilePrefab;
        mapData[19,6] = PlainsHexTilePrefab;
        mapData[19,7] = PlainsHexTilePrefab;
        mapData[19,8] = PlainsHexTilePrefab;
        mapData[19,9] = PlainsHexTilePrefab;
        mapData[19,10] = PlainsHexTilePrefab;
        mapData[19,11] = PlainsHexTilePrefab;
        mapData[19,12] = PlainsHexTilePrefab;
        mapData[19,13] = PlainsHexTilePrefab;
        mapData[19,14] = PlainsHexTilePrefab;
        mapData[19,15] = PlainsHexTilePrefab;
        mapData[19,16] = PlainsHexTilePrefab;
        mapData[19,17] = PlainsHexTilePrefab;
        mapData[19,18] = PlainsHexTilePrefab;
        mapData[19,19] = PlainsHexTilePrefab;
        mapData[19,20] = PlainsHexTilePrefab;
        mapData[19,21] = PlainsHexTilePrefab;
        mapData[19,22] = PlainsHexTilePrefab;
        mapData[19,23] = PlainsHexTilePrefab;
        mapData[19,24] = PlainsHexTilePrefab;
        mapData[19,25] = PlainsHexTilePrefab;
        
        mapData[20,0] = PlainsHexTilePrefab;
        mapData[20,1] = PlainsHexTilePrefab;
        mapData[20,2] = PlainsHexTilePrefab;
        mapData[20,3] = PlainsHexTilePrefab;
        mapData[20,4] = PlainsHexTilePrefab;
        mapData[20,5] = PlainsHexTilePrefab;
        mapData[20,6] = PlainsHexTilePrefab;
        mapData[20,7] = PlainsHexTilePrefab;
        mapData[20,8] = PlainsHexTilePrefab;
        mapData[20,9] = PlainsHexTilePrefab;
        mapData[20,10] = PlainsHexTilePrefab;
        mapData[20,11] = PlainsHexTilePrefab;
        mapData[20,12] = PlainsHexTilePrefab;
        mapData[20,13] = PlainsHexTilePrefab;
        mapData[20,14] = PlainsHexTilePrefab;
        mapData[20,15] = PlainsHexTilePrefab;
        mapData[20,16] = PlainsHexTilePrefab;
        mapData[20,17] = PlainsHexTilePrefab;
        mapData[20,18] = PlainsHexTilePrefab;
        mapData[20,19] = PlainsHexTilePrefab;
        mapData[20,20] = PlainsHexTilePrefab;
        mapData[20,21] = PlainsHexTilePrefab;
        mapData[20,22] = PlainsHexTilePrefab;
        mapData[20,23] = PlainsHexTilePrefab;
        mapData[20,24] = PlainsHexTilePrefab;
        mapData[20,25] = PlainsHexTilePrefab;

        mapData[21,0] = PlainsHexTilePrefab;
        mapData[21,1] = PlainsHexTilePrefab;
        mapData[21,2] = PlainsHexTilePrefab;
        mapData[21,3] = PlainsHexTilePrefab;
        mapData[21,4] = PlainsHexTilePrefab;
        mapData[21,5] = PlainsHexTilePrefab;
        mapData[21,6] = PlainsHexTilePrefab;
        mapData[21,7] = PlainsHexTilePrefab;
        mapData[21,8] = PlainsHexTilePrefab;
        mapData[21,9] = PlainsHexTilePrefab;
        mapData[21,10] = PlainsHexTilePrefab;
        mapData[21,11] = PlainsHexTilePrefab;
        mapData[21,12] = PlainsHexTilePrefab;
        mapData[21,13] = PlainsHexTilePrefab;
        mapData[21,14] = PlainsHexTilePrefab;
        mapData[21,15] = PlainsHexTilePrefab;
        mapData[21,16] = PlainsHexTilePrefab;
        mapData[21,17] = PlainsHexTilePrefab;
        mapData[21,18] = PlainsHexTilePrefab;
        mapData[21,19] = PlainsHexTilePrefab;
        mapData[21,20] = PlainsHexTilePrefab;
        mapData[21,21] = PlainsHexTilePrefab;
        mapData[21,22] = PlainsHexTilePrefab;
        mapData[21,23] = PlainsHexTilePrefab;
        mapData[21,24] = PlainsHexTilePrefab;
        mapData[21,25] = PlainsHexTilePrefab;

        mapData[22,0] = PlainsHexTilePrefab;
        mapData[22,1] = PlainsHexTilePrefab;
        mapData[22,2] = PlainsHexTilePrefab;
        mapData[22,3] = PlainsHexTilePrefab;
        mapData[22,4] = PlainsHexTilePrefab;
        mapData[22,5] = PlainsHexTilePrefab;
        mapData[22,6] = PlainsHexTilePrefab;
        mapData[22,7] = PlainsHexTilePrefab;
        mapData[22,8] = PlainsHexTilePrefab;
        mapData[22,9] = PlainsHexTilePrefab;
        mapData[22,10] = PlainsHexTilePrefab;
        mapData[22,11] = PlainsHexTilePrefab;
        mapData[22,12] = PlainsHexTilePrefab;
        mapData[22,13] = PlainsHexTilePrefab;
        mapData[22,14] = PlainsHexTilePrefab;
        mapData[22,15] = PlainsHexTilePrefab;
        mapData[22,16] = PlainsHexTilePrefab;
        mapData[22,17] = PlainsHexTilePrefab;
        mapData[22,18] = PlainsHexTilePrefab;
        mapData[22,19] = PlainsHexTilePrefab;
        mapData[22,20] = PlainsHexTilePrefab;
        mapData[22,21] = PlainsHexTilePrefab;
        mapData[22,22] = PlainsHexTilePrefab;
        mapData[22,23] = PlainsHexTilePrefab;
        mapData[22,24] = PlainsHexTilePrefab;
        mapData[22,25] = PlainsHexTilePrefab;

        mapData[23,0] = PlainsHexTilePrefab;
        mapData[23,1] = PlainsHexTilePrefab;
        mapData[23,2] = PlainsHexTilePrefab;
        mapData[23,3] = PlainsHexTilePrefab;
        mapData[23,4] = PlainsHexTilePrefab;
        mapData[23,5] = PlainsHexTilePrefab;
        mapData[23,6] = PlainsHexTilePrefab;
        mapData[23,7] = PlainsHexTilePrefab;
        mapData[23,8] = PlainsHexTilePrefab;
        mapData[23,9] = PlainsHexTilePrefab;
        mapData[23,10] = PlainsHexTilePrefab;
        mapData[23,11] = PlainsHexTilePrefab;
        mapData[23,12] = PlainsHexTilePrefab;
        mapData[23,13] = PlainsHexTilePrefab;
        mapData[23,14] = PlainsHexTilePrefab;
        mapData[23,15] = PlainsHexTilePrefab;
        mapData[23,16] = PlainsHexTilePrefab;
        mapData[23,17] = PlainsHexTilePrefab;
        mapData[23,18] = PlainsHexTilePrefab;
        mapData[23,19] = PlainsHexTilePrefab;
        mapData[23,20] = PlainsHexTilePrefab;
        mapData[23,21] = PlainsHexTilePrefab;
        mapData[23,22] = PlainsHexTilePrefab;
        mapData[23,23] = PlainsHexTilePrefab;
        mapData[23,24] = PlainsHexTilePrefab;
        mapData[23,25] = PlainsHexTilePrefab;

        mapData[24,0] = PlainsHexTilePrefab;
        mapData[24,1] = PlainsHexTilePrefab;
        mapData[24,2] = PlainsHexTilePrefab;
        mapData[24,3] = PlainsHexTilePrefab;
        mapData[24,4] = PlainsHexTilePrefab;
        mapData[24,5] = PlainsHexTilePrefab;
        mapData[24,6] = PlainsHexTilePrefab;
        mapData[24,7] = PlainsHexTilePrefab;
        mapData[24,8] = PlainsHexTilePrefab;
        mapData[24,9] = PlainsHexTilePrefab;
        mapData[24,10] = PlainsHexTilePrefab;
        mapData[24,11] = PlainsHexTilePrefab;
        mapData[24,12] = PlainsHexTilePrefab;
        mapData[24,13] = PlainsHexTilePrefab;
        mapData[24,14] = PlainsHexTilePrefab;
        mapData[24,15] = PlainsHexTilePrefab;
        mapData[24,16] = PlainsHexTilePrefab;
        mapData[24,17] = PlainsHexTilePrefab;
        mapData[24,18] = PlainsHexTilePrefab;
        mapData[24,19] = PlainsHexTilePrefab;
        mapData[24,20] = PlainsHexTilePrefab;
        mapData[24,21] = PlainsHexTilePrefab;
        mapData[24,22] = PlainsHexTilePrefab;
        mapData[24,23] = PlainsHexTilePrefab;
        mapData[24,24] = PlainsHexTilePrefab;
        mapData[24,25] = PlainsHexTilePrefab;

        mapData[25,0] = PlainsHexTilePrefab;
        mapData[25,1] = PlainsHexTilePrefab;
        mapData[25,2] = PlainsHexTilePrefab;
        mapData[25,3] = PlainsHexTilePrefab;
        mapData[25,4] = PlainsHexTilePrefab;
        mapData[25,5] = PlainsHexTilePrefab;
        mapData[25,6] = PlainsHexTilePrefab;
        mapData[25,7] = PlainsHexTilePrefab;
        mapData[25,8] = PlainsHexTilePrefab;
        mapData[25,9] = PlainsHexTilePrefab;
        mapData[25,10] = PlainsHexTilePrefab;
        mapData[25,11] = PlainsHexTilePrefab;
        mapData[25,12] = PlainsHexTilePrefab;
        mapData[25,13] = PlainsHexTilePrefab;
        mapData[25,14] = PlainsHexTilePrefab;
        mapData[25,15] = PlainsHexTilePrefab;
        mapData[25,16] = PlainsHexTilePrefab;
        mapData[25,17] = PlainsHexTilePrefab;
        mapData[25,18] = PlainsHexTilePrefab;
        mapData[25,19] = PlainsHexTilePrefab;
        mapData[25,20] = PlainsHexTilePrefab;
        mapData[25,21] = PlainsHexTilePrefab;
        mapData[25,22] = PlainsHexTilePrefab;
        mapData[25,23] = PlainsHexTilePrefab;
        mapData[25,24] = PlainsHexTilePrefab;
        mapData[25,25] = PlainsHexTilePrefab;
    }

    private bool isEvenRow( int row ) {
        return row % 2 == 0;
    }

}
