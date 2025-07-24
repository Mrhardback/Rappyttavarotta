using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
   

    public void OnStartClick() {

        
        SceneManager.LoadScene("SampleScene");
    }

    public void onExitClick() {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
