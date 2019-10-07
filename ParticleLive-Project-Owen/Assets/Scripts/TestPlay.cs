using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlay : MonoBehaviour
{
    public GameObject[] eff;
    private int count=0;
    public AudioSource music;

    // Start is called before the first frame update
    void Start(){
        //music.Play();
        foreach (var item in eff) {
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            eff[count].SetActive(true);
            if (count < eff.Length) {
                count++;
            } else {
                count = 0;
            }
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
