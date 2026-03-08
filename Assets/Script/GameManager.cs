using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject victoryScreen;
    public static GameManager Instance;
    public int score;
    public int key;
    public int level;
    public int next;
    public Text textScore;
    public Text keyText;
        // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
        victoryScreen.SetActive(false);
        score = 0;
        key = 0;
        textScore.text = "Point : " + score;
        level = 1;
        next = level + 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f; 
    }
    public void victory()
    {
        victoryScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void nextLevel()
    {
        SceneManager.LoadScene("Level" + next);
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void quit()
    {
        // SceneManager.LoadScene("MainMenu");
        Application.Quit();
    }
    public void addScore()
    {
        score += 1;
        textScore.text = "Coin: " + score;
    }
    public void addKey()
    {
        key += 1;
        keyText.text = "Key: " + key;

    }
}
