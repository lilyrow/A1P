using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTag : MonoBehaviour
{
    public enum Type
    {
        NONE,
        SCORE_UP,
        HEALTH_DOWN,
    }

    public Type type = Type.NONE;
}
