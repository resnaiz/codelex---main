﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    public class Dog
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }

        public Dog(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public void SetMother(string mother)
        {
            Mother = mother;
        }

        public void SetFather(string father)
        {
            Father = father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (otherDog.Mother == Mother)
            {
                return true;
            }

            return false;
        }

        public string FathersName()
        {
            if (Father == null)
            {
                return "Unknown";
            }

            return Father;
        }
    }
}