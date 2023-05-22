// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class EnemyManager : MonoBehaviour
// {
//     public GameObject door; // Açılacak kapı GameObject referansı
//     public GameObject[] enemyObjects; // Düşman objelerinin listesi
//
//     private bool allEnemiesDestroyed = false; // Tüm düşmanlar yok edildi mi?
//
//     private void Start()
//     {
//         // Düşman objelerini tespit et
//         enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
//     }
//
//     private void Update()
//     {
//         // Tüm düşmanlar yok edildiyse ve kapı hala kapalıysa
//         if (allEnemiesDestroyed && door.activeSelf)
//         {
//             // Kapıyı aç
//             door.GetComponent<Door>().OpenDoor();
//         }
//     }
//
//     public void EnemyDestroyed()
//     {
//         // Düşman yok edildiğinde bu fonksiyon çağrılır
//
//         // Tüm düşmanlar yok edildi mi kontrol et
//         foreach (GameObject enemyObject in enemyObjects)
//         {
//             if (enemyObject != null)
//             {
//                 return; // Henüz tüm düşmanlar yok edilmedi, çıkış yap
//             }
//         }
//
//         // Tüm düşmanlar yok edildi
//         allEnemiesDestroyed = true;
//     }
// }
