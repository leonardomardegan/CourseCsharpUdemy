﻿namespace Exercise1.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 1.5;
            }
        }
    }
}
