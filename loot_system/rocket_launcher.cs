using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using OVRInput = Oculus.XR.OVRInput;

public class RocketLauncher : XRGrabInteractable
{
    public float Damage { get; private set; }
    public int MagazineSize { get; private set; }
    public float FireRate { get; private set; }
    public GameObject RocketPrefab { get; private set; }
    public Transform FirePoint { get; private set; }

    public RocketLauncher(string name, string rarity, string description, float damage, int magazineSize, float fireRate, GameObject rocketPrefab, Transform firePoint) : base()
    {
        Damage = damage;
        MagazineSize = magazineSize;
        FireRate = fireRate;
        RocketPrefab = rocketPrefab;
        FirePoint = firePoint;
    }

    public void FireRocket()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            GameObject rocket = GameObject.Instantiate(RocketPrefab, FirePoint.position, FirePoint.rotation);
            Rigidbody rb = rocket.GetComponent<Rigidbody>();
            rb.AddForce(FirePoint.forward * FireRate, ForceMode.Impulse);

            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        }

        // TODO: Handle ammo logic
    }

    // Additional VR-specific methods and interactions can be added here
}