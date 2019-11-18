using UnityEngine;

public class MoveTrack : MonoBehaviour
{
    public float speedTrack;
    private Vector2 offset;

    private void Update()
    {
        offset = new Vector2(0, Time.time * speedTrack); 
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}