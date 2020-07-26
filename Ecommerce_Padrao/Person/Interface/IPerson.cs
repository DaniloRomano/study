using Enum.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Interface
{
    public interface IPerson
    {
        #region Getters
        int GetId();
        string GetName();
        EnumPersonType GetPersonType();
        #endregion

        #region Setters
        void SetId(int id);
        void SetName(string name);
        void SetPersonType(EnumPersonType type);
        #endregion
    }
}
