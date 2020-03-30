using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public int numberOfObjects; // number of objects to place
    private int currentObjects; // number of placed objects
    public bool didLoadObjects = false;

    public GameObject small_bush;
    public GameObject large_bush;
    public GameObject small_thorn_tree;
    public GameObject medium_thorn_tree;
    public GameObject large_thorn_tree;
    public GameObject small_birch_tree;
    public GameObject medium_birch_tree;
    public GameObject large_birch_tree;
    public GameObject small_tree;
    public GameObject large_tree;
    public GameObject extra_large_tree;

    public GameObject chicken;
    public GameObject cow;
    public GameObject biang;
    public GameObject feet;
    public GameObject balls;
    public GameObject shark;
    public GameObject clocks;
    public GameObject butterfly;

    private int terrainWidth; // terrain size (x)
    private int terrainLength; // terrain size (z)
    private int terrainPosX; // terrain position x
    private int terrainPosZ; // terrain position z

    public Texture2D[] textures;
    public Texture2D[] textures1;
    public Texture2D[] textures2;
    public Texture2D[] textures3;
    public Texture2D[] textures4;



    void Start()
    {
        // terrain size x
        terrainWidth = (int)Terrain.activeTerrain.terrainData.size.x - 10;
        // terrain size z
        terrainLength = (int)Terrain.activeTerrain.terrainData.size.z - 10;
        // terrain x position
        terrainPosX = (int)Terrain.activeTerrain.transform.position.x + 5;
        // terrain z position
        terrainPosZ = (int)Terrain.activeTerrain.transform.position.z + 5;
        // textures = Resources.LoadAll<Texture2DArray>("Textures A");
        int ran = Random.Range(0, 5);
        switch (ran)
        {
            case (0):

                Texture2D texture = textures[Random.Range(0, textures.Length)];
                large_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture;
                Texture2D texture1 = textures[Random.Range(0, textures.Length)];
                small_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture1;
                Texture2D texture2 = textures[Random.Range(0, textures.Length)];
                medium_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture2;
                Texture2D texture3 = textures[Random.Range(0, textures.Length)];
                small_bush.GetComponent<Renderer>().material.mainTexture = texture3;
                Texture2D texture4 = textures[Random.Range(0, textures.Length)];
                large_bush.GetComponent<Renderer>().material.mainTexture = texture4;
                Texture2D texture5 = textures[Random.Range(0, textures.Length)];
                small_birch_tree.GetComponent<Renderer>().material.mainTexture = texture5;
                Texture2D texture6 = textures[Random.Range(0, textures.Length)];
                large_birch_tree.GetComponent<Renderer>().material.mainTexture = texture6;
                Texture2D texture7 = textures[Random.Range(0, textures.Length)];
                medium_birch_tree.GetComponent<Renderer>().material.mainTexture = texture7;
                Texture2D texture8 = textures[Random.Range(0, textures.Length)];
                small_tree.GetComponent<Renderer>().material.mainTexture = texture8;
                Texture2D texture9 = textures[Random.Range(0, textures.Length)];
                large_tree.GetComponent<Renderer>().material.mainTexture = texture9;
                Texture2D texture10 = textures[Random.Range(0, textures.Length)];
                extra_large_tree.GetComponent<Renderer>().material.mainTexture = texture10;
                break;
            case (1):
                Texture2D textureA = textures1[Random.Range(0, textures.Length)];
                large_thorn_tree.GetComponent<Renderer>().material.mainTexture = textureA;
                Texture2D texture1A = textures1[Random.Range(0, textures.Length)];
                small_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture1A;
                Texture2D texture2A = textures1[Random.Range(0, textures.Length)];
                medium_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture2A;
                Texture2D texture3A = textures1[Random.Range(0, textures.Length)];
                small_bush.GetComponent<Renderer>().material.mainTexture = texture3A;
                Texture2D texture4A = textures1[Random.Range(0, textures.Length)];
                large_bush.GetComponent<Renderer>().material.mainTexture = texture4A;
                Texture2D texture5A = textures1[Random.Range(0, textures.Length)];
                small_birch_tree.GetComponent<Renderer>().material.mainTexture = texture5A;
                Texture2D texture6A = textures1[Random.Range(0, textures.Length)];
                large_birch_tree.GetComponent<Renderer>().material.mainTexture = texture6A;
                Texture2D texture7A = textures1[Random.Range(0, textures.Length)];
                medium_birch_tree.GetComponent<Renderer>().material.mainTexture = texture7A;
                Texture2D texture8A = textures1[Random.Range(0, textures.Length)];
                small_tree.GetComponent<Renderer>().material.mainTexture = texture8A;
                Texture2D texture9A = textures1[Random.Range(0, textures.Length)];
                large_tree.GetComponent<Renderer>().material.mainTexture = texture9A;
                Texture2D texture10A = textures1[Random.Range(0, textures.Length)];
                extra_large_tree.GetComponent<Renderer>().material.mainTexture = texture10A;
                break;
            case (2):
                Texture2D textureB = textures2[Random.Range(0, textures.Length)];
                large_thorn_tree.GetComponent<Renderer>().material.mainTexture = textureB;
                Texture2D texture1B = textures2[Random.Range(0, textures.Length)];
                small_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture1B;
                Texture2D texture2B = textures2[Random.Range(0, textures.Length)];
                medium_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture2B;
                Texture2D texture3B = textures2[Random.Range(0, textures.Length)];
                small_bush.GetComponent<Renderer>().material.mainTexture = texture3B;
                Texture2D texture4B = textures2[Random.Range(0, textures.Length)];
                large_bush.GetComponent<Renderer>().material.mainTexture = texture4B;
                Texture2D texture5B = textures2[Random.Range(0, textures.Length)];
                small_birch_tree.GetComponent<Renderer>().material.mainTexture = texture5B;
                Texture2D texture6B = textures2[Random.Range(0, textures.Length)];
                large_birch_tree.GetComponent<Renderer>().material.mainTexture = texture6B;
                Texture2D texture7B = textures2[Random.Range(0, textures.Length)];
                medium_birch_tree.GetComponent<Renderer>().material.mainTexture = texture7B;
                Texture2D texture8B = textures2[Random.Range(0, textures.Length)];
                small_tree.GetComponent<Renderer>().material.mainTexture = texture8B;
                Texture2D texture9B = textures2[Random.Range(0, textures.Length)];
                large_tree.GetComponent<Renderer>().material.mainTexture = texture9B;
                Texture2D texture10B = textures2[Random.Range(0, textures.Length)];
                extra_large_tree.GetComponent<Renderer>().material.mainTexture = texture10B;
                break;
            case (3):
                Texture2D textureC = textures3[Random.Range(0, textures.Length)];
                large_thorn_tree.GetComponent<Renderer>().material.mainTexture = textureC;
                Texture2D texture1C = textures3[Random.Range(0, textures.Length)];
                small_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture1C;
                Texture2D texture2C = textures3[Random.Range(0, textures.Length)];
                medium_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture2C;
                Texture2D texture3C = textures3[Random.Range(0, textures.Length)];
                small_bush.GetComponent<Renderer>().material.mainTexture = texture3C;
                Texture2D texture4C = textures3[Random.Range(0, textures.Length)];
                large_bush.GetComponent<Renderer>().material.mainTexture = texture4C;
                Texture2D texture5C = textures3[Random.Range(0, textures.Length)];
                small_birch_tree.GetComponent<Renderer>().material.mainTexture = texture5C;
                Texture2D texture6C = textures3[Random.Range(0, textures.Length)];
                large_birch_tree.GetComponent<Renderer>().material.mainTexture = texture6C;
                Texture2D texture7C = textures3[Random.Range(0, textures.Length)];
                medium_birch_tree.GetComponent<Renderer>().material.mainTexture = texture7C;
                Texture2D texture8C = textures3[Random.Range(0, textures.Length)];
                small_tree.GetComponent<Renderer>().material.mainTexture = texture8C;
                Texture2D texture9C = textures3[Random.Range(0, textures.Length)];
                large_tree.GetComponent<Renderer>().material.mainTexture = texture9C;
                Texture2D texture10C = textures3[Random.Range(0, textures.Length)];
                extra_large_tree.GetComponent<Renderer>().material.mainTexture = texture10C;
                break;
            case (4):
                Texture2D textureD = textures4[Random.Range(0, textures.Length)];
                large_thorn_tree.GetComponent<Renderer>().material.mainTexture = textureD;
                Texture2D texture1D = textures4[Random.Range(0, textures.Length)];
                small_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture1D;
                Texture2D texture2D = textures4[Random.Range(0, textures.Length)];
                medium_thorn_tree.GetComponent<Renderer>().material.mainTexture = texture2D;
                Texture2D texture3D = textures4[Random.Range(0, textures.Length)];
                small_bush.GetComponent<Renderer>().material.mainTexture = texture3D;
                Texture2D texture4D = textures4[Random.Range(0, textures.Length)];
                large_bush.GetComponent<Renderer>().material.mainTexture = texture4D;
                Texture2D texture5D = textures4[Random.Range(0, textures.Length)];
                small_birch_tree.GetComponent<Renderer>().material.mainTexture = texture5D;
                Texture2D texture6D = textures4[Random.Range(0, textures.Length)];
                large_birch_tree.GetComponent<Renderer>().material.mainTexture = texture6D;
                Texture2D texture7D = textures4[Random.Range(0, textures.Length)];
                medium_birch_tree.GetComponent<Renderer>().material.mainTexture = texture7D;
                Texture2D texture8D = textures4[Random.Range(0, textures.Length)];
                small_tree.GetComponent<Renderer>().material.mainTexture = texture8D;
                Texture2D texture9D = textures4[Random.Range(0, textures.Length)];
                large_tree.GetComponent<Renderer>().material.mainTexture = texture9D;
                Texture2D texture10D = textures4[Random.Range(0, textures.Length)];
                extra_large_tree.GetComponent<Renderer>().material.mainTexture = texture10D;
                break;
        }

    }
    // Update is called once per frame
    void Update()
    {
        //generate objects
        if (didLoadObjects == false)
        {
            //generate chickens
            for (int m = 0; m < 50; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(chicken, new Vector3(ax, ay, az), Quaternion.identity);
            }

            //generate cows
            for (int m = 0; m < 25; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(cow, new Vector3(ax, ay, az), Quaternion.identity);
            }

            //generate biang
            for (int m = 0; m < 1; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(biang, new Vector3(ax, ay, az), Quaternion.identity);
            }

            //generate feet
            for (int m = 0; m < 10; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(feet, new Vector3(ax, ay, az), Quaternion.identity);
            }

            //generate balls
            for (int m = 0; m < 10; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(balls, new Vector3(ax, ay, az), Quaternion.identity);
            }

            //generate shark
            for (int m = 0; m < 50; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(shark, new Vector3(ax, ay, az), Quaternion.identity);
            }
            //generate clocks
            for (int m = 0; m < 10; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(clocks, new Vector3(ax, ay, az), Quaternion.identity);
            }

            //generate butterfly
            for (int m = 0; m < 50; m++)
            {
                int ax = Random.Range(terrainPosX, terrainPosX + terrainWidth);
                int az = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
                float ay = Terrain.activeTerrain.SampleHeight(new Vector3(ax, 0, az));

                Instantiate(butterfly, new Vector3(ax, ay, az), Quaternion.identity);
            }

            //so we don't create any more
            didLoadObjects = true;
        }

        // generate trees
        while (currentObjects < numberOfObjects)
        {
            // generate random x position
            int posx = Random.Range(terrainPosX, terrainPosX + terrainWidth);
            // generate random z position
            int posz = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
            // get the terrain height at the random position
            float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
            // create new gameObject on random position
            if (currentObjects >= 0 && currentObjects < (numberOfObjects * 0.10))
            {
                Instantiate(small_birch_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.10) && currentObjects < (numberOfObjects * 0.30))
            {
                Instantiate(large_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.30) && currentObjects < (numberOfObjects * 0.40))
            {
                Instantiate(small_bush, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.40) && currentObjects < (numberOfObjects * 0.50))
            {
                Instantiate(small_thorn_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.50) && currentObjects < (numberOfObjects * 0.505))
            {
                Instantiate(extra_large_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.505) && currentObjects < (numberOfObjects * 0.605))
            {
                Instantiate(small_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.605) && currentObjects < (numberOfObjects * 0.705))
            {
                Instantiate(large_birch_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.705) && currentObjects < (numberOfObjects * 0.805))
            {
                Instantiate(medium_birch_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.805) && currentObjects < (numberOfObjects * 0.890))
            {
                Instantiate(large_bush, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.890) && currentObjects < (numberOfObjects * 0.975))
            {
                Instantiate(large_thorn_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            else if (currentObjects >= (numberOfObjects * 0.975) && currentObjects < numberOfObjects)
            {
                Instantiate(medium_thorn_tree, new Vector3(posx, posy, posz), Quaternion.identity);

            }
            currentObjects += 1;
        }
        if (currentObjects == numberOfObjects)
        {
            Debug.Log("Generate objects complete!");
        }
    }
}