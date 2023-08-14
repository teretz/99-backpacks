using UnityEngine;

public class RocketLauncherTemplate : MonoBehaviour
{
    public int damage = 100;
    public int magazineSize = 5;
    public float fireRate = 1f;
    public GameObject rocketPrefab;
    public Transform firePoint;

    private int currentAmmo;
    private float nextFireTime;

    private void Start()
    {
        currentAmmo = magazineSize;
    }

    public void FireRocket()
    {
        if (Time.time >= nextFireTime && currentAmmo > 0)
        {
            Instantiate(rocketPrefab, firePoint.position, firePoint.rotation);
            currentAmmo--;
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
}