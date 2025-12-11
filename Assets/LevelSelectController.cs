using UnityEngine;

public class LevelSelectController : MonoBehaviour
{
    public void Level1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 3");
    }
    public void Level4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 4");
    }
    public void Level5()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 5");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
