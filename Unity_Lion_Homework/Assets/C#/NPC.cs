using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="conversation">對話的內容</param>
    private void Talk(string conversation) 
    {

    }
    /// <summary>
    /// 開啟商店
    /// </summary>
    public bool OpenShop() 
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="ItemMoney">道具價錢</param>
    /// <returns></returns>
    public int BuyItem(int Price=100) 
    {
        return 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="MissonNumber">任務編號</param>
    public void GetMisson(int MissonNumber)
    {

    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="MissonItem">任務道具數量</param>
    /// <returns></returns>
    private int MissonUpdate(int MissonItem = 1)
    {
        return 0;
    }
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="MissonNumber">任務編號</param>
    /// <returns></returns>
    private bool MissonComplete(int MissonNumber)
    {
        return false;
    }
}
