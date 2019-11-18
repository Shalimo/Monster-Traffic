using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedPlayer = 15f;    
    public AudioManager am;
    public UIManager ui;
    private Vector2 position;

    void Start()
    {
        am.carSound.Play();
        position = transform.position;
    }
 
    void Update()
    {
        float temp = Input.acceleration.x;
        position.x += temp * speedPlayer * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;
        if (Time.timeScale == 0)
        {
            am.carSound.Pause();
        }
        else
        {
            am.carSound.UnPause();
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            ui.GameOverActivated();
            am.carSound.Stop();
            am.carCrash.Play();
        }
    }
}
