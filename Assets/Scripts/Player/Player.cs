class Player
{
    private int health;
    private int damage;

    private int experience;

    public Player(int health, int damage)
    {
        this.health = health;
        this.damage = damage;
        this.experience = 0;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0) health = 0;
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetExperience()
    {
        return experience;
    }

    public void GainExperience(int amount)
    {
        experience += amount;
    }

    public int GetDamage()
    {
        return damage;
    }
}