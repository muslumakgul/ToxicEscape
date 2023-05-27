using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyObjects; // Düşman objelerinin listesi
    public PlayAgain playagain;
    private bool allEnemiesDestroyed = false; // Tüm düşmanlar yok edildi mi?
    public GameObject LevelDoor;
    private void Start()
    {
        // Düşman objelerini tespit et
        enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void Update()
    {
        // Tüm düşmanlar yok edildiyse
        if (!allEnemiesDestroyed)
        {
            CheckEnemiesDestroyed();
        }
    }

    public void CheckEnemiesDestroyed()
    {
        // Tüm düşmanlar yok edildi mi kontrol et
        foreach (GameObject enemyObject in enemyObjects)
        {
            if (enemyObject == null || enemyObject.Equals(null) || enemyObject.Equals(System.DBNull.Value))
            {
                // enemyObject null veya yoksa, listeden kaldır
                enemyObjects = RemoveDestroyedEnemies(enemyObject);
            }
        }

        // Tüm düşmanlar yok edildi
        if (enemyObjects.Length == 0)
        {
            allEnemiesDestroyed = true;
            LevelDoor.GetComponent<LevelDoor>().LevelUpOpenDoor(); // Kapıyı açabilir veya diğer işlemleri yapabilirsiniz
            //playagain.LevelUp(); // Level geçiş işlemlerini yapabilirsiniz
            Debug.Log("KAPI ACILDI!");
        }
    }

    private GameObject[] RemoveDestroyedEnemies(GameObject destroyedEnemy)
    {
        List<GameObject> updatedList = new List<GameObject>(enemyObjects);

        if (updatedList.Contains(destroyedEnemy))
        {
            updatedList.Remove(destroyedEnemy);
        }

        return updatedList.ToArray();
    }
}
