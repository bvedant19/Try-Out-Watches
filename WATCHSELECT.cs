using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WATCHSELECT : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;

    // Start is called before the first frame update
    
    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();
    }

    public void WatchOneButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        w1WindowAnimation["W11ANIMATION"].speed = 1;
        w1WindowAnimation.Play();
    }
    public void WatchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2WindowAnimation["W12ANIMATION"].speed = 1;
        w2WindowAnimation.Play();

    }
    public void WatchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        w3WindowAnimation["W13ANIMATION"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked(){
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "w1close")
        {
            w1WindowAnimation["W11ANIMATION"].speed = -1;
            w1WindowAnimation["W11ANIMATION"].time = w1WindowAnimation["W11ANIMATION"].length;
            w1WindowAnimation.Play();
        }
        else if (buttonName == "w2close")
        {
            w2WindowAnimation["W12ANIMATION"].speed = -1;
            w2WindowAnimation["W12ANIMATION"].time = w2WindowAnimation["W12ANIMATION"].length;
            w2WindowAnimation.Play();
        }
        else if (buttonName == "w3close")
        {
            w3WindowAnimation["W13ANIMATION"].speed = -1;
            w3WindowAnimation["W13ANIMATION"].time = w3WindowAnimation["W13ANIMATION"].length;
            w3WindowAnimation.Play();
        }
    }
}
