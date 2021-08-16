using System;
using System.Collections.Generic;
namespace GameMonster
{

    public class Monster
    {
        public int mHp;
        public int mMana;
        public string mName;

        public int mAttack;
        public int mDefense;

        public int mAccuracy;

        public int mDodge;

        public string[] Drop = new string[4];


        public void SetName(string Name)
        {
            mName = Name;
        }

        public void SetHp(int Hp)
        {
            mHp = Hp;
        }
        public void SetMana(int Mana)
        {
            mMana = Mana;
        }
        public void SetAttack(int Attack)
        {
            mAttack = Attack;
        }
        public void SetDefense(int Defensee)
        {
            mDefense = Defensee;
        }

        public void SetAccuracy(int Accuracy)
        {
            mAccuracy = Accuracy;
        }

        public void SetDodge(int Dodge)
        {
            mDodge = Dodge;

        }

        public int GetHp()
        {
            return (mHp);
        }
        public string GetDrop(int LuckDrop)
        {
            return Drop[LuckDrop];
        }







    }

}
