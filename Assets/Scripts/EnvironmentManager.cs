using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    ///what does this need to do?
    ///spawn ponds
    ///spawn trees
    ///add more over time?
    ///before spawning anything, check to see if anything else is there already
    ///need pond and tree prefabs
    /// how do this..
    /// generate randomly slowly? initial spawning, then periodically afterwards? sure
    ///
             
    [SerializeField] private GameObject pondPrefab;
    [SerializeField] private GameObject treePrefab;
    [SerializeField] private int numPonds;
    [SerializeField] private int numTrees;


    void Start()
    {
        InitializeEnvironment();
    }
    public void InitializeEnvironment()
    {
        //spawn trees
        for(int i = 0; i < numTrees; i++)
        {
            Vector3Int pos = GetPosition();
            if(isValidPosition(pos))
            {
                Instantiate(treePrefab, pos, Quaternion.identity);
            }
        }

        //spawn ponds
        for(int i = 0; i < numPonds; i++)
        {
            Vector3Int pos = GetPosition();
            if(isValidPosition(pos))
            {
                Instantiate(pondPrefab, pos, Quaternion.identity);
            }
        }
    }

    //generate random position on world grid   
    private Vector3Int GetPosition()
    {
        return new Vector3Int(Random.Range(-WorldGen.Instance.worldSizeX/2+5, WorldGen.Instance.worldSizeX/2-5),
                                        Random.Range(-WorldGen.Instance.worldSizeY/2+5, WorldGen.Instance.worldSizeY/2-5), 
                                        0);
    }

    //Check whether a given position is valid (is there already a gameobject there?)
    private bool isValidPosition(Vector3Int pos)
    {
        return Physics2D.OverlapPoint(new Vector3(pos.x, pos.y)) == null;
    }

}
