using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicNote : MonoBehaviour
{
    public bool isPressed;

    public KeyCode pressedKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pressedKey))
        {
            if(isPressed)
            {
                gameObject.SetActive(false);
                GameManager.instance.gameDirectionBaseGame.RhythmRatingState("1");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D colider)
    {
        if (colider.tag == "CollidedKey")
        {
            isPressed = true;
        }
    }

    void OnTriggerExit2D(Collider2D colider)
    {
        if (colider.tag == "CollidedKey")
        {
            isPressed = false;
            GameManager.instance.gameDirectionBaseGame.RhythmRatingState("0");
        }
    }


}
