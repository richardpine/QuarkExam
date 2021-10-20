using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class SetInitialValues : MonoBehaviour
{
    #region Declaracion Datos Iniciales
    [SerializeField] string shopName = "QuarkClothing";
    [SerializeField] string shopAddress = "Spinelli Oeste 20";
    [SerializeField] string sellerName = "Ricardo";
    [SerializeField] string sellerLastName = "Pino";
    [SerializeField] int sellerCode = 475869;
    #endregion

    public Vendedor seller;
    public Tienda miTienda;

    private ArrayList InitialList = new ArrayList();

    void Awake()
    {
        
        #region Instanciador de Prendas

            #region Instanciador Inicial de Camisas
            InitialList.Add(new Camisa(100, Quality.STANDARD, Sleev.SHORT, Neck.MAO));
            InitialList.Add(new Camisa(100, Quality.PREMIUM, Sleev.SHORT, Neck.MAO));
            InitialList.Add(new Camisa(150, Quality.STANDARD, Sleev.SHORT, Neck.REGULAR));
            InitialList.Add(new Camisa(150, Quality.PREMIUM, Sleev.SHORT, Neck.REGULAR));
            InitialList.Add(new Camisa(75, Quality.STANDARD, Sleev.LONG, Neck.MAO));
            InitialList.Add(new Camisa(75, Quality.PREMIUM, Sleev.LONG, Neck.MAO));
            InitialList.Add(new Camisa(175, Quality.STANDARD, Sleev.LONG, Neck.REGULAR));
            InitialList.Add(new Camisa(175, Quality.PREMIUM, Sleev.LONG, Neck.REGULAR));
            #endregion
        
            #region Instanciador Inicial de Pantalones
            InitialList.Add(new Pantalon(750, Quality.STANDARD, Pant.CHUPIN));
            InitialList.Add(new Pantalon(750, Quality.PREMIUM, Pant.CHUPIN));
            InitialList.Add(new Pantalon(250, Quality.STANDARD, Pant.REGULAR));
            InitialList.Add(new Pantalon(250, Quality.PREMIUM, Pant.REGULAR));
            #endregion
    
        #endregion
        
        
        seller = new Vendedor(sellerName, sellerLastName, sellerCode);

        miTienda = new Tienda(shopName, shopAddress, InitialList, seller);
        

    }
}
