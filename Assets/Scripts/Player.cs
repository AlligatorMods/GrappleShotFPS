using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum GSTeam : byte
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Yellow = 3
    }

    public int playerIndex = 0;
    public GSTeam team = 0;
}
