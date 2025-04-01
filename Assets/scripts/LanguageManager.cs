using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    public TranslationData spanish;
    public TranslationData english;
    public TranslationData french;

    public void SetLanguage(TranslationData translation)
    {
        text1.text = translation.text1;
        text2.text = translation.text2;
        text3.text = translation.text3;
        text4.text = translation.text4;
    }
}
