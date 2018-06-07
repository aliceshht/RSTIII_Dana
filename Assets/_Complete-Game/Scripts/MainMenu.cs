using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Completed
{

    public class MainMenu : MonoBehaviour {
    public Image fadeInOutImage;
        
    void Awake()
    {
        fadeInOutImage.GetComponent<Animation>().Play("FadeIn");
    }
	public void PlayGame ()
    {
        if(GameManager.instance!= null)
        {
            GameManager.instance.level = 1;
        }
        fadeInOutImage.GetComponent<Animation>().Play("FadeOut");        
        Invoke("Load",1);
   
    }

    void Load()
    {
        SceneManager.LoadScene(1);
        
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}

}
