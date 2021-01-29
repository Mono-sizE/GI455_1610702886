using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextMatching : MonoBehaviour
{
    public Text WordText, ResultText;
    public Button button;
    public InputField SearchText;
    // Start is called before the first frame update
    void Start()
    {
        WordText.text = "Unity\n Unreal\n Resident Evil\n Google\n MongoDB";
    }
    public void SearchingWord()
    {
        if (SearchText.text == "Unity" || SearchText.text == "Unreal" || SearchText.text == "Resident Evil" || SearchText.text == "Google" || SearchText.text == "MongoDB")
        {
            ResultText.text = SearchText.text + "is found!";
        }
        else
        {
            ResultText.text = "Try Again";
        }
    }

}
