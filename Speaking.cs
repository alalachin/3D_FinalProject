using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speaking : MonoBehaviour {

    public Text talk;
    public Text talk1;
    public float time;
    // Use this for initialization
    void Start()
    {
        /*float time = 0f;

        string[] say = { "兒子啊，其實你是", "而且你還有個未婚妻", "你必續冒險去找出家傳的戒指" };
        string[] say1 = { "!!", "真的假的", "為了我的未婚，我一定會找出來的" };

       // time += Time.deltaTime;
        
        for (int i = 0; i < 3; i++)
        {
            time += Time.deltaTime;
            if (time < 5f)
            {
                talk.text = say[i];
            }
            time = 0f;
        }

        for (int i = 0; i < 3; i++)
        {
            talk1.text = say1[i];
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > 3.0f && time < 5.0f){
            talk.text = "兒子啊!\n告訴你一個家族的大秘密\n其實你是埃及法老第87代傳人！";
        }
        if(time > 5.0f && time < 7.0f){
            talk.text = " ";
            talk1.text = "媽媽你在逗我";
        }
        if(time > 7.0f && time < 9.0f){
            talk1.text = " ";
            talk.text = "想不到吧！而且家族還要找\n一個美若天仙的女生給你當未婚妻";
        }
        if(time > 9.0f && time < 11.0f){
            talk.text = " ";
            talk1.text = "媽！你可真是我親媽";
        }
        if(time > 11.0f && time < 13.0f){
            talk1.text = " ";
            talk.text = "不過，你要到埃及金字塔裡\n取我們家族特有的戒指，\n那是非常有價值的";
        }
        if (time > 13.0f && time < 15.0f)
        {
            talk.text = " ";
            talk1.text = "媽！我去去就回";
        }
        if (time > 15.0f && time < 17.0f)
        {
            talk1.text = " ";
            talk.text = "別急！可惜戒指不是那麼好拿的！\n為了保住法老的寶物，\n埃及金字塔中有很多怪異的事，\n你一定要小心小心再小心！";
        }
        /* string[] say = { "兒子啊，其實你是", "而且你還有個未婚妻", "你必須冒險去找出家傳的戒指" };
         string[] say1 = { "!!", "真的假的", "為了我的未婚，我一定會找出來的" };

          time += Time.deltaTime;

         for (int i = 0; i < 3; i++)
         {
             //time += Time.deltaTime;
             if (time < 5f)
             {
                 talk.text = say[i];
             }
             time = 0f;
         }

         for (int i = 0; i < 3; i++)
         {
             talk1.text = say1[i];
         }
         /*string[] say = { "兒子啊，其實你是", "而且你還有個未婚妻", "你必續冒險去找出家傳的戒指" };
         string[] say1 = { "!!", "真的假的", "為了我的未婚，我一定會找出來的" };

         for (int i = 0; i < 3;i++){
             talk.text = say[i];
         }

         for (int i = 0; i < 3; i++)
         {
             talk1.text = say1[i];*/
        // }*/
    }

}
