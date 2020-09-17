using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] int width = 14;
    [SerializeField] int height1 = 15;
    [SerializeField] int height2 = 14;

    public GameObject[] Emptile; //empty tile
    public GameObject[] DCtile; //double corner tile
    public GameObject[] DWtile; //double wall tile

    public GameObject[] Ctile; //corner tile
    public GameObject[] Wtile; //wall tile

    public GameObject[] Peltile; //pellet tile

    public GameObject[] Powtile; //power up tile

    public GameObject[] Junctile; //Junction tile

    public int[,] levelMap1 = {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };

    public int[,] levelMap2 = {
        {7,2,2,2,2,2,2,2,2,2,2,2,2,1},
        {4,5,5,5,5,5,5,5,5,5,5,5,5,2},
        {4,5,3,4,4,4,3,5,3,4,4,3,5,2},
        {4,5,4,0,0,0,4,5,4,0,0,4,6,2},
        {3,5,3,4,4,4,3,5,3,4,4,3,5,2},
        {5,5,5,5,5,5,5,5,5,5,5,5,5,2},
        {4,4,4,3,5,3,3,5,3,4,4,3,5,2},
        {3,4,4,3,5,4,4,5,3,4,4,3,5,2},
        {4,5,5,5,5,4,4,5,5,5,5,5,5,2},
        {4,0,3,4,4,3,4,5,1,2,2,2,2,1},
        {3,0,3,4,4,3,4,5,2,0,0,0,0,0},
        {0,0,0,0,0,4,4,5,2,0,0,0,0,0},
        {0,4,4,3,0,4,4,5,2,0,0,0,0,0},
        {0,0,0,4,0,3,3,5,1,2,2,2,2,2},
        {0,0,0,4,0,0,0,5,0,0,0,0,0,0},
    };

    public int[,] levelMap3 = {
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
    };

    public int[,] levelMap4 = {
        {0,0,0,4,0,3,3,5,1,2,2,2,2,2},
        {0,4,4,3,0,4,4,5,2,0,0,0,0,0},
        {0,0,0,0,0,4,4,5,2,0,0,0,0,0},
        {3,0,3,4,4,3,4,5,2,0,0,0,0,0},
        {4,0,3,4,4,3,4,5,1,2,2,2,2,1},
        {4,5,5,5,5,4,4,5,5,5,5,5,5,2},
        {3,4,4,3,5,4,4,5,3,4,4,3,5,2},
        {4,4,4,3,5,3,3,5,3,4,4,3,5,2},
        {5,5,5,5,5,5,5,5,5,5,5,5,5,2},
        {3,5,3,4,4,4,3,5,3,4,4,3,5,2},
        {4,5,4,0,0,0,4,5,4,0,0,4,6,2},
        {4,5,3,4,4,4,3,5,3,4,4,3,5,2},
        {4,5,5,5,5,5,5,5,5,5,5,5,5,2},
        {7,2,2,2,2,2,2,2,2,2,2,2,2,1},
    };

    // Start is called before the first frame update
    void Start()
    {
        levelMap1 = new int[width, height1];
        levelMap2 = new int[width, height1];
        levelMap3 = new int[width, height2];
        levelMap4 = new int[width, height2];
        GenerateQuadrant1();
        GenerateQuadrant2();
        GenerateQuadrant3();
        GenerateQuadrant4();
    }

    private void GenerateQuadrant1() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height1; y++) {

                //1.2709 - across
                //1.28 - down
                
                if (y == 0) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, 0.35f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, 0.35f, 0.0f));
                        Instantiate(Junctile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 1) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -0.93f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -0.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }
                
                if (y == 2) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -2.21f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -2.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -2.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -2.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }
                    
                if (y == 3) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -3.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -3.49f, 0.0f));
                        Instantiate(Powtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -3.49f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -3.49f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 4) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -4.77f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -4.77f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -4.77f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -4.77f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 5) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -6.05f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 6) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -7.33f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -7.33f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -7.33f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -7.33f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 7) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -8.61f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -8.61f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -8.61f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -8.61f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 8) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -9.89f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -9.89f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -9.89f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -9.89f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 9) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -11.17f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -11.17f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -11.17f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -11.17f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -11.17f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -11.17f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 10) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -12.45f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -12.45f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -12.45f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -12.45f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -12.45f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -12.45f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -12.45f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -12.45f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 11) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -13.73f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -13.73f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -13.73f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -13.73f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 12) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -15.01f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -15.01f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -15.01f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 13) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -16.29f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -16.29f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -16.29f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -16.29f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -16.29f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 14) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -17.57f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -17.57f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }
            }
        }
    }





























    void GenerateQuadrant2() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height1; y++) {

                //1.2709 - across
                //1.28 - down

                if (y == 0) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, 0.35f, 0.0f));
                        Instantiate(Junctile[0], transform.position, Quaternion.Euler(0.0f, 180.0f, 0.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, 0.35f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, 0.35f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 1) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -0.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -0.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -0.93f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 2) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -2.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -2.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -2.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -2.21f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -2.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -2.21f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 3) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -3.49f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -3.49f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -3.49f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -3.49f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -3.49f, 0.0f));
                        Instantiate(Powtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -3.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 4) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -4.77f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -4.77f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -4.77f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -4.77f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -4.77f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -4.77f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 5) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -6.05f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -6.05f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 6) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -7.33f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -7.33f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -7.33f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -7.33f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -7.33f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -7.33f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 7) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -8.61f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -8.61f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -8.61f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -8.61f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -8.61f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -8.61f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 8) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -9.89f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -9.89f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -9.89f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -9.89f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -9.89f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 9) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -11.17f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -11.17f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -11.17f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -11.17f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -11.17f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -11.17f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -11.17f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -11.17f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }
                }

                if (y == 10) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -12.45f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -12.45f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -12.45f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -12.45f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -12.45f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -12.45f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -12.45f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -12.45f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -12.45f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 11) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -13.73f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -13.73f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -13.73f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -13.73f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -13.73f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 12) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -15.01f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -15.01f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -15.01f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -15.01f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -15.01f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 13) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -16.29f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -16.29f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -16.29f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -16.29f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -16.29f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -16.29f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -16.29f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 14) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -17.57f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -17.57f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -17.57f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }
            }
        }
    }




















    void GenerateQuadrant3() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height2; y++) {

                //1.2709 - across
                //1.28 - down

                if (y == 0) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -18.85f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -18.85f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -18.85f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -18.85f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -18.85f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 1) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -20.13f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -20.13f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -20.13f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }
                
                if (y == 2) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -21.41f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -21.41f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -21.41f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -21.41f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }
                    
                if (y == 3) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -22.69f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -22.69f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -22.69f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -22.69f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -22.69f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -22.69f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -22.69f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -22.69f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 4) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -23.97f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -23.97f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -23.97f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -23.97f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -23.97f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -23.97f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 5) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -25.25f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -25.25f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -25.25f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -25.25f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 6) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -26.53f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -26.53f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -26.53f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -26.53f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }
                }

                if (y == 7) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -27.81f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -27.81f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -27.81f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -27.81f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 8) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -29.09f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 9) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -30.37f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -30.37f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -30.37f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -30.37f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 10) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -31.65f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -31.65f, 0.0f));
                        Instantiate(Powtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -31.65f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -31.65f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 11) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -32.93f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -32.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -32.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -32.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 12) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -34.21f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -34.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 13) {
                    if (x == 0) {
                        transform.position = (new Vector3(0.641f, -35.49f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(1.92f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(3.190902f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(4.461803f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(5.732705f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(7.003607f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(8.274508f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(9.54541f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(10.81631f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(12.08721f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(13.35812f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(14.62902f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(15.89992f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(17.17082f, -35.49f, 0.0f));
                        Instantiate(Junctile[0], transform.position, Quaternion.Euler(0.0f, 180.0f, 180.0f));
                    }
                }
            }
        }
    }























    void GenerateQuadrant4() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height2; y++) {

                //1.2709 - across
                //1.28 - down

                if (y == 0) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -18.85f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -18.85f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -18.85f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -18.85f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -18.85f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -18.85f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -18.85f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 1) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -20.13f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -20.13f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -20.13f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -20.13f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -20.13f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 2) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -21.41f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -21.41f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -21.41f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -21.41f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -21.41f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 3) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -22.69f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -22.69f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -22.69f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -22.69f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -22.69f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -22.69f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -22.69f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -22.69f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -22.69f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }
                }

                if (y == 4) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -23.97f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -23.97f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -23.97f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -23.97f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -23.97f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -23.97f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -23.97f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -23.97f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 5) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -25.25f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -25.25f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -25.25f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -25.25f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -25.25f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 6) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -26.53f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -26.53f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -26.53f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -26.53f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -26.53f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -26.53f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 7) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -27.81f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -27.81f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -27.81f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -27.81f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -27.81f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -27.81f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }
                }

                if (y == 8) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -29.09f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -29.09f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 9) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -30.37f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -30.37f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -30.37f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -30.37f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -30.37f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -30.37f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 10) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -31.65f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -31.65f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -31.65f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -31.65f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -31.65f, 0.0f));
                        Instantiate(Powtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -31.65f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 11) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -32.93f, 0.0f));
                        Instantiate(Emptile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -32.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -32.93f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -32.93f, 0.0f));
                        Instantiate(Ctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -32.93f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -32.93f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 12) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -34.21f, 0.0f));
                        Instantiate(Wtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -34.21f, 0.0f));
                        Instantiate(Peltile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -34.21f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    }
                }

                if (y == 13) {
                    if (x == 0) {
                        transform.position = (new Vector3(18.44172f, -35.49f, 0.0f));
                        Instantiate(Junctile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }

                    if (x == 1) {
                        transform.position = (new Vector3(19.71262f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 2) {
                        transform.position = (new Vector3(20.98352f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 3) {
                        transform.position = (new Vector3(22.25442f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 4) {
                        transform.position = (new Vector3(23.52532f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 5) {
                        transform.position = (new Vector3(24.79622f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 6) {
                        transform.position = (new Vector3(26.06712f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 7) {
                        transform.position = (new Vector3(27.33802f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 8) {
                        transform.position = (new Vector3(28.60892f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 9) {
                        transform.position = (new Vector3(29.87982f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 10) {
                        transform.position = (new Vector3(31.15072f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 11) {
                        transform.position = (new Vector3(32.42162f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 12) {
                        transform.position = (new Vector3(33.69252f, -35.49f, 0.0f));
                        Instantiate(DWtile[0], transform.position, Quaternion.identity);
                    }

                    if (x == 13) {
                        transform.position = (new Vector3(34.96342f, -35.49f, 0.0f));
                        Instantiate(DCtile[0], transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    }
                }
            }
        }

    }
}
