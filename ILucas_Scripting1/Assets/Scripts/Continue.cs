using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour {

    public Button Y;
    public Button N;

    public Canvas canvas;
    public Slider healthSlider;

    private PlayerHealth playerHealth;

    void Start()
    {
        Y = Y.GetComponent<Button>();
        N = N.GetComponent<Button>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            yes();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            no();
        }
    }

    public void yes()
    {   
        //start particle system.

        playerHealth.currentHealth = 100;
        healthSlider.value = playerHealth.currentHealth;

        canvas.enabled = false;
        Y.enabled = false;
        playerHealth.isDead = false;
    }

    public void no()
    {
        //quit
    }

}
