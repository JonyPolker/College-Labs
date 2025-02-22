using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work9
{
    internal class Unit
    {
        private int _maxHeath;
        private int _currentHealth;
        public Unit(int maxHeath)
        {
            _maxHeath = maxHeath;
            _currentHealth = _maxHeath;
        }

        public void SetHealth(int health)
        {
            _currentHealth = Math.Clamp(health, 0, _maxHeath);
        }


        public int GetHeath()
        {
            return _currentHealth;
        }
        public void Heal(uint heal)
        {
            int GCH = GetHeath();
            SetHealth((int)(GCH + heal));
            Console.WriteLine($"Здоровье увеличено на - {heal}, текущее здоровье - {_currentHealth}");
        }

        public void Damage(uint damage)
        {
            int GCH = GetHeath();
            SetHealth((int)Math.Max(0, _currentHealth - damage));
            Console.WriteLine($"Здоровье уменьшено на - {damage}, текущее здоровье - {_currentHealth}");
        }


        public void IncreaseHealth(uint bonus)
        {
            _maxHeath = (int)Math.Clamp(_maxHeath + bonus, 100, 500);
            Console.WriteLine($"Максимальное здоровье было увеличено на {bonus}, максимальное здоровье - {_maxHeath}");
            SetHealth(_maxHeath);
            Console.WriteLine($"Здоровье после увелечения максимального порога - {_currentHealth}");
        }
    }
}
