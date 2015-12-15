using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider healthSlider;                                 // Reference to the UI's health bar.
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    public Canvas canvas;
    public Button Y;
    public bool isDead;
                                            
    bool damaged;                                               // True when the player gets damaged.


    void Start()
    {
        canvas = canvas.GetComponent<Canvas>();
        Y = Y.GetComponent<Button>();
        currentHealth = startingHealth;

        canvas.enabled = false;
        Y.enabled = false;
    }


    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }

        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        damaged = false;
    }


    public void TakeDamage()
    {
            damaged = true;

            currentHealth -= 5;

            healthSlider.value = currentHealth;

            if (currentHealth <= 0 && !isDead)
            {
                StartCoroutine(death());
            }
    }


    IEnumerator death()
    {
        isDead = true;
        //stop particle system.

        yield return new WaitForSeconds(1);

        canvas.enabled = true;
        Y.enabled = true;
    }

}

