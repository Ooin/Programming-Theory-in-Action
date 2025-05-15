using TMPro;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    [SerializeField] private int score = 1;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    public void ScorePoint()
    {
        GameObject obj = GameObject.Find("UI");
        if (obj != null)
        {
            GUIController script = obj.GetComponent<GUIController>();
            if (script != null)
            {
                script.Score(score);
            }
            else
            {
                Debug.Log("Script Not Found");
            }
        }
        else
        {
            Debug.Log("No GUIController");
        }
    }
}