using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Salad
    {
        private string name;
        private int completeMass = 0;
        private Dictionary<Vegetables, int> setOfVegetables = new Dictionary<Vegetables, int>(); //ключ растительный ингридиент(овощ), значение масса
        private Dictionary<NotVegetables, int> setOfNotVegetables = new Dictionary<NotVegetables, int>(); //ключ не растительный ингридиент(не реализовано), значение масса
        private Dictionary<Dressing, int> setOfDressing = new Dictionary<Dressing, int>();  //ключ заправка(не реалиовано), значение масса

        public Salad(string name)
        {
            this.name = name;
        }
        public int CompleteMass
        {
            get { return completeMass; }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        //методы добавляют ингридиенты ingr разных типов (овощи, не овощи, заправка) с массой mass
        public void AddIngridient(Vegetables ingr, int mass)
        {
            completeMass += mass;
            if (setOfVegetables.ContainsKey(ingr))
            {
                setOfVegetables[ingr] += mass;
            }
            else
            {
                setOfVegetables.Add(ingr, mass);
            }
        }
        public void AddIngridient(NotVegetables ingr, int mass)
        {
            completeMass += mass;
            if (setOfNotVegetables.ContainsKey(ingr))
            {
                setOfNotVegetables[ingr] += mass;
            }
            else
            {
                setOfNotVegetables.Add(ingr, mass);
            }
        }
        public void AddIngridient(Dressing ingr, int mass)
        {
            completeMass += mass;
            if (setOfDressing.ContainsKey(ingr))
            {
                setOfDressing[ingr] += mass;
            }
            else
            {
                setOfDressing.Add(ingr, mass);
            }
        }

        //расчет калорий по массе и энергии
        private double Сalories(double energy, int mass)
        {
            return ((energy * mass) / 100);
        }

        //метод считает калорийность
        public double CalculateCalories()
        {
            double fullCalories = 0;

            foreach (KeyValuePair<Vegetables, int> item in setOfVegetables)
            {
                fullCalories += Сalories(item.Key.energy, item.Value);
            }
            //foreach (KeyValuePair<NotVegetables, int> item in setOfNotVegetables)
            //{
            //    fullCalories += Сalories(item.Key.energy, item.Value);
            //}
            //foreach (KeyValuePair<Dressing, int> item in setOfDressing)
            //{
            //    fullCalories += Сalories(item.Key.energy, item.Value);
            //}
            return fullCalories;
        }

        //метод показывает ингридиенты по диапазону калорийности в салате (реализованы только овощи)
        public List<string> CaloriesRangeIngridients(double minCalories, double maxCalories)
        {
            List<string> ingridients = new List<string>();
            foreach (KeyValuePair<Vegetables, int> item in setOfVegetables)
            {
                Vegetables vg = item.Key;
                int vg_mass = item.Value;
                double cal = Сalories(vg.energy, vg_mass);

                if (cal >= minCalories && cal <= maxCalories)
                {
                    ingridients.Add(vg.Name);
                }
            }
            //foreach (KeyValuePair<NotVegetables, int> item in setOfNotVegetables)
            //{
            //    NotVegetables nvg = item.Key;
            //    int nvg_mass = item.Value;
            //    double cal = Сalories(nvg.energy, nvg_mass);

            //    if (cal >= minCalories && cal <= maxCalories)
            //    {
            //        ingridients.Add(nvg.Name);
            //    }
            //}
            //foreach (KeyValuePair<Dressing, int> item in setOfDressing)
            //{
            //    Dressing drs = item.Key;
            //    int drs_mass = item.Value;
            //    double cal = Сalories(drs.energy, drs_mass);

            //    if (cal >= minCalories && cal <= maxCalories)
            //    {
            //        ingridients.Add(drs.Name);
            //    }
            //}
            return ingridients;
        }
    }
}
