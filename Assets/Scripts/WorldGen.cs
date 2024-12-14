using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldGen : MonoBehaviour
{
    //world grid
    [SerializeField] private Tilemap BackgroundTilemap;
    public int worldSizeX = 100;
    public int worldSizeY = 100;
    [SerializeField] private Tile[] bgTile;
    
    public static WorldGen Instance;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else 
        {
            Destroy(gameObject);
        }
    }

    void Start() 
    {
        GenerateBackground();
    }


    private void GenerateBackground() 
    {
        for (int x = -(worldSizeX/2); x < worldSizeX/2; x++)
        {
            for(int y = -(worldSizeY/2); y < worldSizeY/2; y++){
                BackgroundTilemap.SetTile(new Vector3Int(x, y), bgTile[Random.Range(0, bgTile.Length)]);
            }
        }
    }
}
