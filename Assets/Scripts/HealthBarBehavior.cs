using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    public Image background;
    public Image fill;
    public Color lowHealth, highHealth;
    public Vector3 offset;

    public void SetHealth(float currentHealth, float maxHealth)
    {

        gameObject.SetActive(currentHealth < maxHealth);
        //background.gameObject.SetActive(currentHealth < maxHealth);
        //fill.gameObject.SetActive(currentHealth < maxHealth);
        fill.fillAmount = currentHealth / maxHealth;
        
        fill.color = Color.Lerp(lowHealth, highHealth, fill.fillAmount); 

    }

    
    void Update()
    {
        //background.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
        //fill.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
        gameObject.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
    }
}
