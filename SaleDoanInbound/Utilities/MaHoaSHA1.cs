﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SaleDoanInbound.Utilities
{
    public static class MaHoaSHA1
    {
        public static string EncodeSHA1(string pass)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha1.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x1").ToUpper());
            }
            pass = s.ToString();
            return pass;
        }
    }
}
