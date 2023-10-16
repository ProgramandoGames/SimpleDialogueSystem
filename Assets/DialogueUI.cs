using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueUI : MonoBehaviour {

    Image background;
    TextMeshProUGUI nameText;
    TextMeshProUGUI talkText;

    public float speed = 10f;
    bool open = false;

    void Awake() {
        background = transform.GetChild(0).GetComponent<Image>();
        nameText   = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        talkText   = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
    }

    void Start() {

    }

    void Update() {
        if(open) {
            background.fillAmount = Mathf.Lerp(background.fillAmount, 1, speed * Time.deltaTime);
        } else {
            background.fillAmount = Mathf.Lerp(background.fillAmount, 0, speed * Time.deltaTime);
        }
    }

    public void SetName(string name) {
        nameText.text = name;
    }

    public void Enable() {
        background.fillAmount = 0;
        open = true;
    }

    public void Disable() {
        open = false;
        nameText.text = "";
        talkText.text = "";
    }

}












































































































































































































































