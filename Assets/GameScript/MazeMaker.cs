using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMaker : MonoBehaviour
{
    public GameObject Bridge;
    public GameObject Plate;
    public GameObject Ground;
    public GameObject Ground2;
    public GameObject Wall;
    public List<GameObject> Walls;
    const float MazeWH = 200;
    const float WALLWIDTH=10;
    const float WALLHEIGHT = 10;
    float NORTH;
    float SOUTH;
    float WEST;
    float EAST;
    // Start is called before the first frame update
    void Start()
    {
        //미로는 Z축이 위쪽방향 X축이 오른쪽방향일때 위쪽이 북쪽이다.
        Vector3 gp = Ground.transform.position;
        NORTH = gp.z + MazeWH / 2;
        SOUTH = gp.z - MazeWH / 2;
        WEST = gp.x - MazeWH / 2;
        EAST = gp.x + MazeWH / 2;
        for (float i = WALLWIDTH / 2; i < MazeWH; i += WALLWIDTH) {
            Walls.Add(Instantiate(Wall, new Vector3(WEST + i, WALLHEIGHT / 2, NORTH), Quaternion.Euler(0, 90f, 0)));//북쪽
            Walls.Add(Instantiate(Wall, new Vector3(WEST + i, WALLHEIGHT / 2, SOUTH), Quaternion.Euler(0, 90f, 0)));//남쪽
            Walls.Add(Instantiate(Wall, new Vector3(EAST, WALLHEIGHT / 2, SOUTH + i), Quaternion.identity));//동쪽
            Walls.Add(Instantiate(Wall, new Vector3(WEST, WALLHEIGHT / 2, SOUTH + i), Quaternion.identity));//서쪽   
        }
        for (float x = 1; x < 20; x += 1f)
        {
            for(float z=1; z < 20; z += 1f)
            {
                bool randBool = (Random.value > 0.5f);
                MakeWall(randBool, x, z);
            }
       }
        //MakeWall(true, 1, 1);
        //MakeWall(false, 1, 1);
        //       Vector3 gp1 = Ground.transform.GetChild(0).position;
        //       Vector3 gp2 = Ground2.transform.GetChild(0).position;
        //      Vector3 ConnectPos = gp1;
        //       if (ConnectPos.x > gp2.x) { GameObject temp=Instantiate(Plate, new Vector3(ConnectPos.x - 10, 0, ConnectPos.z+5), Quaternion.identity);ConnectPos = temp.transform.position; }
        //      else if (ConnectPos.x < gp2.x) { GameObject temp = Instantiate(Plate, new Vector3(ConnectPos.x + 10, 0, ConnectPos.z+5), Quaternion.identity); ConnectPos = temp.transform.position; }
        //       else if (ConnectPos.x == gp2.x) { }

    }
    void MakeWall(bool isHorizon, float x ,float z)
    {
        if(isHorizon) Walls.Add(Instantiate(Wall, new Vector3(WEST- WALLWIDTH / 2 + (WALLWIDTH * x), WALLHEIGHT/2, SOUTH  + (WALLWIDTH*z)), Quaternion.Euler(0, 90f, 0))); // 가로벽 (위쪽)
        else Walls.Add(Instantiate(Wall, new Vector3(WEST  + (WALLWIDTH * x), WALLHEIGHT/2, SOUTH- WALLWIDTH / 2 + (WALLWIDTH * z)), Quaternion.identity)); //세로벽(오른쪽)
    }
   // void GroundConnect()
   // {
   //     Vector3 gp1 = Ground.transform.GetChild(0).position;
   //     Vector3 gp2 = Ground2.transform.GetChild(0).position;
   //     Vector3 ConnectPos = gp1;
    //    if (ConnectPos.x> gp2.x) { Instantiate(Plate, new Vector3(ConnectPos.x-10,0, ConnectPos.z), Quaternion.identity); }
    //    else if (ConnectPos.x < gp2.x) { Instantiate(Plate, new Vector3(ConnectPos.x+10, 0, ConnectPos.z), Quaternion.identity); }
   //     else if (ConnectPos.x == gp2.x) {  }
   // }
        
        

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
