using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /// <summary>
    /// ���
    /// </summary>
    /// <param name="conversation">��ܪ����e</param>
    private void Talk(string conversation) 
    {

    }
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns>�O�_�}�Ұө�</returns>
    public bool OpenShop() 
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="ItemMoney">�D�����</param>
    /// <returns></returns>
    public int BuyItem(int ItemMoney=100) 
    {
        return 0;
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="MissonNumber">���Ƚs��</param>
    public void GetMisson(int MissonNumber)
    {

    }
    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="MissonItem">��o�����ȹD��</param>
    /// <returns></returns>
    private int MissonUpdate(int MissonItem = 1)
    {
        return 0;
    }
    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="MissonNumber">���Ƚs��</param>
    /// <returns></returns>
    private bool MissonComplte(int MissonNumber)
    {
        return false;
    }
}
