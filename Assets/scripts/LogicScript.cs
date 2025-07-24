using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase score")]
    public void addscore(int scoreToAdd) 
    {
        playerscore = playerscore + scoreToAdd;
        scoreText.text = playerscore.ToString();
    }

    

    public void restartGame() 
    {
        AudioManager.instance.MusicStart = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void gameOver() 
        {
    gameOverScreen.SetActive(true);
    }

    public void OnApplicationQuit() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();

    }

}
