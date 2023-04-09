using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{
    public int playerscore=0;
    public Text scoretext;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    [ContextMenu("Increase Score")]
   public void addscore()
    {
        playerscore += 1;
        scoretext.text = playerscore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
