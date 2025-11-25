using UnityEngine;

public abstract class OffensiveSpell : Spell
{
    public float damage;
    public float range;
    public GameObject projectilePrefab;

    public override void Cast()
    {
        if (projectilePrefab != null)
        {
            GameObject proj = Instantiate(projectilePrefab,
                                          caster.transform.position + caster.transform.forward * 0.5f,
                                          caster.transform.rotation);

           // proj.GetComponent<Projectile>().Initialize(damage, range);
        }
    }
}
