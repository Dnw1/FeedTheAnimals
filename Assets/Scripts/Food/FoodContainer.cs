using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;

//[XmlRoot("AnimalCollection")]
public class FoodContainer : MonoBehaviour
{

    private static Dictionary<string, List<string>> AnimalsByFood;

    void Start()
    {
        LoadFoodData();
    }

    private void LoadFoodData()
    {
        AnimalsByFood = new Dictionary<string, List<string>>();

        TextAsset foodData = (TextAsset) Resources.Load("animals");
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(foodData.text);

        foreach (XmlNode Animal in xmlDocument["Animals"].ChildNodes)
        {
            string animalName = Animal.Attributes["name"].Value;
            foreach (XmlNode Food in xmlDocument["Animal"].ChildNodes)
            {
                
            }
        }
    }
}
