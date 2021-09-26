﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    public class History
    {
        public string Cap { get; set; }
        public string Truonghoc { get; set; }
        public float DiemTB { get; set; }
        public string Hanhkiem { get; set; }

        public static List<History> GetList()
        {
            var ds = new List<History>();
            ds.Add(new History
            {
                Cap = "Cấp 1",
                Truonghoc = "Trường Tiểu học số 1 Hương Chữ",
                DiemTB = 8f,
                Hanhkiem = "Tốt"
            });
            ds.Add(new History
            {
                Cap = "Cấp 2",
                Truonghoc = "Trường Trung học cơ sở Lê Quang Tiến",
                DiemTB = 8.2f,
                Hanhkiem = "Tốt"
            });
            ds.Add(new History
            {
                Cap = "Cấp 3",
                Truonghoc = "Trường Trung học phổ thông Đăng Huy Trứ",
                DiemTB = 7.8f,
                Hanhkiem = "Tốt"
            });
            return ds;
        }

        public static History Get(string cap)
        {
            var dbHistory = GetList();
            var history = dbHistory.Where(p => p.Cap == cap).FirstOrDefault();
            return history;
        }
    }
}
