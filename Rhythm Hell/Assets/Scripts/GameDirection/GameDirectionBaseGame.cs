using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameDirectionBaseGame : MonoBehaviour
{

    public AudioSource bgmRhythmSong;
    public BeatScrollController bsController;

    public TextMeshProUGUI rhythmRatingText;

    public bool isPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPressed)
        {
            if (Input.anyKeyDown)
            {
                bsController.isMusicStarted = true;
                isPressed = true;
                bgmRhythmSong.Play();
            }
        }

    }
    


   public void RhythmRatingState(string state)
    {
        if (state == "1")
        {
            rhythmRatingText.gameObject.SetActive(true);
            rhythmRatingText.text = "GOOD";
            GameManager.instance.scoreManager.incrementGameScore(true);
        }
        else
        {
            rhythmRatingText.gameObject.SetActive(true);
            rhythmRatingText.text = "BAD";
        }

        // StartCoroutine(RatingTextDeactivate());
    }

    IEnumerator RatingTextDeactivate()
    {
        yield return new WaitForSeconds(1f);
        rhythmRatingText.gameObject.SetActive(false);
    }


}
