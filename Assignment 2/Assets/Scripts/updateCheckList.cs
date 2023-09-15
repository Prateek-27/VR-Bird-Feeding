using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateCheckList : MonoBehaviour
{
    public string text;
    public GameObject buttonObj;
    public Button button;

    public string fruit1;
    public float totalfruit1val = 3;
    public float fruit1val;
    public float fruit1fed;
    public GameObject button1Obj;
    public Button button1;

    public string fruit2;
    public float totalfruit2val =2;
    public float fruit2val;
    public float fruit2fed;
    public GameObject button2Obj;
    public Button button2;

    public string fruit3;
    public float totalfruit3val = 1;
    public float fruit3val;
    public float fruit3fed;
    public GameObject button3Obj;
    public Button button3;

    public string fruit4;
    public float totalfruit4val = 2;
    public float fruit4val;
    public float fruit4fed;
    public GameObject button4Obj;
    public Button button4;

    public string fruit5;
    public float totalfruit5val = 1;
    public float fruit5val;
    public float fruit5fed;
    public GameObject button5Obj;
    public Button button5;

    public GameObject fruitbasket;

    
    // Start is called before the first frame update
    

    

    void Start()
    {
        fruitbasket = GameObject.Find("/MainPlayer/Basket");

        text = "CHECKLIST";
        buttonObj = GameObject.Find("/Canvas/Panel/Scroll View/Viewport/Content/button");
        button = buttonObj.GetComponent<Button>();

        fruit1 = "Apple";
        button1Obj = GameObject.Find("/Canvas/Panel/Scroll View/Viewport/Content/button1");
        button1 = button1Obj.GetComponent<Button>();

        fruit2 = "Strawberry";
        button2Obj = GameObject.Find("/Canvas/Panel/Scroll View/Viewport/Content/button2");
        button2 = button2Obj.GetComponent<Button>();

        fruit3 = "Pear";
        button3Obj = GameObject.Find("/Canvas/Panel/Scroll View/Viewport/Content/button3");
        button3 = button3Obj.GetComponent<Button>();

        fruit4 = "Peach";
        button4Obj = GameObject.Find("/Canvas/Panel/Scroll View/Viewport/Content/button4");
        button4 = button4Obj.GetComponent<Button>();

        fruit5 = "Peanut";
        button5Obj = GameObject.Find("/Canvas/Panel/Scroll View/Viewport/Content/button5");
        button5 = button5Obj.GetComponent<Button>();
        //UpdateText();
        //button1 = GameObject.Find("/Panel/Scroll View/Viewport/Content/button1");
    }

    // Update is called once per frame
    void Update()
    {

        // Check List Updation
        button.GetComponentInChildren<Text>().text = $"{text}";

        fruit1val = fruitbasket.GetComponent<FruitCounter>().appleCount;
        fruit1fed = fruitbasket.GetComponent<FruitCounter>().appleFed;
        button1.GetComponentInChildren<Text>().text = $"{fruit1} x {totalfruit1val - fruit1fed}  (RED) [{fruit1fed}]";

        fruit2val = fruitbasket.GetComponent<FruitCounter>().strawberryCount;
        fruit2fed = fruitbasket.GetComponent<FruitCounter>().strawberryFed;
        button2.GetComponentInChildren<Text>().text = $"{fruit2} x {totalfruit2val - fruit2fed}  (PINK) [{fruit2fed}]";

        fruit3val = fruitbasket.GetComponent<FruitCounter>().pearCount;
        fruit3fed = fruitbasket.GetComponent<FruitCounter>().pearFed;
        button3.GetComponentInChildren<Text>().text = $"{fruit3} x {totalfruit3val - fruit3fed}  (YELLOW) [{fruit3fed}]";

        fruit4val = fruitbasket.GetComponent<FruitCounter>().peachCount;
        fruit4fed = fruitbasket.GetComponent<FruitCounter>().peachFed;
        button4.GetComponentInChildren<Text>().text = $"{fruit4} x {totalfruit4val - fruit4fed}  (ORANGE) [{fruit4fed}]";

        fruit5val = fruitbasket.GetComponent<FruitCounter>().peanutCount;
        fruit5fed = fruitbasket.GetComponent<FruitCounter>().peanutFed;
        button5.GetComponentInChildren<Text>().text = $"{fruit5} x {totalfruit5val - fruit5fed}  (BROWN) [{fruit5fed}]";
    }
}
