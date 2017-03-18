﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    class TaxiPark
    {
        private List<Element> _taxies = new List<Element>();

        public void Attach(Element taxi)
        {
            _taxies.Add(taxi);
        }

        public void Detach(Element taxi)
        {
            _taxies.Remove(taxi);
        }

        public void Accept(Visitor visitor)
        {
            foreach(Element taxi in _taxies)
            {
                taxi.Accept(visitor);
            }
        }
    }
}
