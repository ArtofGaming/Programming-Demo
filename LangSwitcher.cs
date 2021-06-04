using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Naninovel;


public class LangSwitcher : MonoBehaviour
{
    public Button switcher;
    // Start is called before the first frame update
    void Start()
    {
       switcher.onClick.AddListener(Transition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Transition()
    {
        Engine.GetService<ILocalizationManager>().SelectLocaleAsync("de");
        Debug.Log(Engine.GetService<ILocalizationManager>().SelectedLocale);
    }
}
