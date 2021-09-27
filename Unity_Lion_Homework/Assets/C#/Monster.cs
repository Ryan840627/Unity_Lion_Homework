using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("Monster相關參數"),Range(0,10)]
    public float MonsterSpeed = 3.5f;
    [Range(0, 500)]
    public int MonsterAttack = 100;
    [Range(0,5000)]
    public int MonsterHp = 350;
    [Range(0, 50)]
    public int monsterTrackRange = 30;
    public Vector3 v3MonsterPosition;
    [Header("掉落道具係數")]
    public GameObject ItemDrop;
    [Range(0, 1)]
    public float GameObjectDrop = 1;
    [Header("音效檔案")]
    public AudioClip ObjectDropSound;
    public AudioClip HurtSound;
    public AudioClip AttackSound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    
}
