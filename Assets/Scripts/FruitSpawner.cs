using UnityEngine;

public class FruitSpawner : FruitFactory
{
    [SerializeField] private Fruit _fruit;
    [SerializeField] private Transform spawnPoint;

    public override Fruit SpawnFruit()
    {
        Fruit fruit = Instantiate(_fruit, spawnPoint.position, Quaternion.identity);
        return fruit;
    }
}
