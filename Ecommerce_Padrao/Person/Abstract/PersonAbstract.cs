using Enum.Person;
using Person.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Abstract
{
    public abstract class PersonAbstract : IPerson
    {
        #region Attributes
        int id;
        string name;
        EnumPersonType type;
        #endregion
        #region Getters
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public EnumPersonType GetPersonType()
        {
            return type;
        }
        #endregion
        #region Setters
        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPersonType(EnumPersonType type)
        {
            this.type = type;
        }
        #endregion
    }
}
