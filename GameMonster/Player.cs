using System;
namespace GameMonster
{
    public class Player
    {
        public int Hp;
        public int Mana;
        public string Job;


        public int Attack;
        public int Defense;


        public int Dodge;


        public void SetJob(string pJob)
        {
            Job = pJob;
        }
        public void SetHp(int pHp)
        {
            Hp = pHp;
        }
        public void SetMana(int pMana)
        {
            Mana = pMana;
        }
        public void SetAttack(int pAttack)
        {
            Attack = pAttack;
        }
        public void SetDefense(int pDefensee)
        {
            Defense = pDefensee;
        }



        public void SetDodge(int pDodge)
        {
            Dodge = pDodge;
        }
        public int GetHP()
        {
            return (Hp);
        }
    }

}