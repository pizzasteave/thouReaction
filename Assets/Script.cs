
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{
    public GameObject help; 
    public void OnReloadUI()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

    public void OnHelpUI()
    {
       help.SetActive(false);
    }
}
