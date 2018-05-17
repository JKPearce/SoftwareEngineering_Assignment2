///////////////////////////////////////////////////////////
//  Item.cs
//  Implementation of the Class Item
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////


using System;

namespace Mazegame.Entity
{
    public class Item
    {
        private int value;
        private double weight;
        private string description;
        private string label;

        public Item(string label, int value, double weight, string description)
        {
            this.label = label;
            this.description = description;
            this.weight = weight;
            this.value = value;
        }

        public int GetValue()
        {
            return value;
        }

        public double GetWeight()
        {
            return weight;
        }

        public string GetLabel()
        {
            return label;
        }

        public string GetDescription()
        {
            return description;
        }
    } //end Item
} //end namespace Entity