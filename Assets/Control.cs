using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public int MaxScore = 5;
    // Start is called before the first frame update

    public void GameOver()
    {
        GameOverScreen.Setup(MaxScore);
    }

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            ResetTheGame();
        }
    }

    public void ResetTheGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
