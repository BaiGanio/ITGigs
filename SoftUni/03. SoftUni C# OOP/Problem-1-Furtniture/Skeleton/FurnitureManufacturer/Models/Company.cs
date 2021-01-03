using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private readonly string _name;
        private string _registrationNUmber;
       private List<IFurniture> furnituresList = new List<IFurniture>();

        public Company(string name, string registrationNumber)
        {
            this._name = name;
            this._registrationNUmber = registrationNumber;
        }

        #region Properties
        public string Name
        {
            get { return this._name; }
        }

        public string RegistrationNumber
        {
            get { return this._registrationNUmber; }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnituresList; }
        }
        #endregion




        public void Add(IFurniture furniture)
        {
            this.furnituresList.Add(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnituresList
                .FirstOrDefault(f => f.Model.ToLowerInvariant() == model.ToLowerInvariant());
        }

        public void Remove(IFurniture furniture)
        {
            this.furnituresList.Remove(furniture);
        }

        public string Catalog()
        {
            string catalogHeader = String.Format("{0} - {1} - {2} {3}",
                this.Name, this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture");
            return catalogHeader;

        }
    }
}