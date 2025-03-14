using UnityEngine;

public class DisplayText : MonoBehaviour
{
    public int score = 0;
    TMPro.TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        text.text = "Score: " + score;
        
    }

    void Update()
    {
        
    }
    
    public void incrementScore()
    {
        score++;
        text.text = "Score: " + score;
    }
}
