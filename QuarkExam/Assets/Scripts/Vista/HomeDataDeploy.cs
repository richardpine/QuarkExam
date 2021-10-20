using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomeDataDeploy : MonoBehaviour
{
    [SerializeField] SetInitialValues initialValues;

    [SerializeField] TextMeshProUGUI shopName;
    [SerializeField] TextMeshProUGUI shopAddress;

    [SerializeField] TextMeshProUGUI sellerName;
    [SerializeField] TextMeshProUGUI sellerCode;

    // Start is called before the first frame update
    void Start()
    {
        DeployInitialData();
    }

    private void DeployInitialData()
    {
        shopName.text = initialValues.miTienda.Name;
        shopAddress.text = initialValues.miTienda.Address;

        sellerName.text = $"{initialValues.seller.Name} {initialValues.seller.LastName}";
        sellerCode.text = initialValues.seller.SellerCode.ToString();
    }

   
}
