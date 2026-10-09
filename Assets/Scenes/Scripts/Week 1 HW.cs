using UnityEngine;

public class Week1HW : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(LetterGrade(100f)); // A

        Debug.Log(LetterGrade(85f)); // B

        Debug.Log(LetterGrade(72f)); // C

        Debug.Log(LetterGrade(68f)); // D

        Debug.Log(LetterGrade(2f)); // F
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string LetterGrade(float percentage)
    {
        if (percentage >= 90f)
        {
            return "A";
        }
        else if (percentage >= 80f)
        {
            return "B";
        }
        else if (percentage >= 70f)
        {
            return "C";
        }
        else if (percentage >= 60f)
        {
            return "D";
        }
        return "F";
    }
}
