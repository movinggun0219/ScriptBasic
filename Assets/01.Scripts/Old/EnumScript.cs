using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; //이렇게위에서 지정가능ㄴ
public class EnumScript : MonoBehaviour
{

    enum Direction
    {
        North,
        East,
        South,
        West
    }

    void Start()
    {
        Direction myDirection = Direction.North;
        
        int dir = (int)myDirection;
        int len = System.Enum.GetValues(typeof(Direction)).Length;

        // System Random
        //var rand1 = new System.Random();
        //myDirection = (Direction)(rand1.Next() % len);
        //Debug.Log(myDirection);

        //Unity Random
        var rand2 = UnityEngine.Random.Range(0, len - 1);
        myDirection = (Direction)rand2;
        Debug.Log(myDirection);

        var returnDirection = ReversDirection(myDirection);
        Debug.Log(returnDirection);
    }

    int Redirection(int dir)
    {
        switch ((Direction)dir)
        {
            case Direction.North:
                dir = (int)Direction.South;
                break;
            case Direction.South:
                dir = (int)Direction.North;
                break;
            case Direction.East:
                dir = (int)Direction.West;
                break;
            case Direction.West:
                dir = (int)Direction.East;
                break;
            default:
                break;
        }

        return dir;
    }
    Direction ReversDirection(Direction dir)
    {
        /*
        if (dir == Direction.North)
        {
            dir = Direction.South;
        }
        else if (dir == Direction.South)
        {
            dir = Direction.North;
        }
        else if (dir == Direction.East)
        {
            dir = Direction.West;
        }
        else if (dir == Direction.West)
        {
            dir = Direction.East;
        }
        */

        switch (dir)
        {
            case Direction.North:
                dir = Direction.South;
                break;
            case Direction.East:
                dir = Direction.West;
                break;
            case Direction.South:
                dir = Direction.North;
                break;
            case Direction.West:
                dir = Direction.East;
                break;

            default:
                Debug.Log("dir의 잘못된값이들어옴");
                break;

        }
        return dir;
    }
}
