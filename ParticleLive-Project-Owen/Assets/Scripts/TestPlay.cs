using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlay : MonoBehaviour
{
    public GameObject[] eff;
    
    public AudioSource music;

    // Start is called before the first frame update
    void Start(){
        music.Play();
        foreach (var item in eff) {
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            for(int i = 0; i < 3; i++) {
                eff[i].SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            eff[3].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.D)){
            eff[4].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            foreach(var item in eff) {
                if (item.activeSelf) {
                    item.SetActive(false);
                }
            }
        }
        
    }
}
