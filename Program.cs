namespace R1_Weapon
{
    class Weapon
    {
        private int _damage;
        private int _bullets;

        public void Fire(Player player)
        {
            if (_bullets > 0)
            {
                player.TakeDamage(_damage);
                _bullets -= 1;
            }
        }
    }

    class Player
    {
        public int Health { get; private set; }

        public void TakeDamage(int damage)
        {
            if (damage > 0)
                Health -= damage;
        }
    }

    class Bot
    {
        private Weapon _weapon;

        public void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }
}
