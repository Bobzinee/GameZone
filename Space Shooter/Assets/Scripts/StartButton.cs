using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartButton : MonoBehaviour
{
    private AudioSource selectSound;
    private Animator anim;
    private Button btn;

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.enabled = false;
        selectSound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        Invoke("setActive", 30f);
    }
    private void setActive()
    {
        btn.enabled = true;
        anim.SetBool("Active", true);
    }
    public void StartGame()
    {
        selectSound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
