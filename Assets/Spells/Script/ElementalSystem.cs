using UnityEngine;
public enum ElementType { Fire, Ice, Lightning, Earth, Wind }

public abstract class ElementalMagic : Spell
{
    public ElementType type;

    public virtual void ApplyElementalEffect(GameObject target)
    {
        switch(type)
        {
            case ElementType.Fire:
                // burn damage-over-time
                break;

            case ElementType.Ice:
                // slow enemy
                break;

            case ElementType.Lightning:
                // chain to nearby enemies
                break;

            case ElementType.Earth:
                // stun enemy
                break;

            case ElementType.Wind:
                // knockback
                break;
        }
    }
}
