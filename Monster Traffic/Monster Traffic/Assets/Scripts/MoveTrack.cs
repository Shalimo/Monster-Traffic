using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrack : MonoBehaviour
{

    public float speed;

    private Vector2 offset;

    private void Update()
    {
        offset = new Vector2(0, Time.time * speed); //params OsX, OsY

        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}