﻿using QuanLiQuanCafeNew.Business.EntitiesClass;
using QuanLiQuanCafeNew.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.Business.Component
{
    internal class E_tb_HDB
    {
        SQL_tb_HDB hdbsql = new SQL_tb_HDB();
        public void themoihdb(EC_tb_HDB hdb)
        {
            if (!hdbsql.Equals(hdb.MAHDB))
            {
                hdbsql.themmoiHDB(hdb);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahdb(EC_tb_HDB hdb)
        {
            hdbsql.suaHDB(hdb);
        }
        public void xoahdb(EC_tb_HDB hdb)
        {
            hdbsql.xoaHDB(hdb);
        }
        //load nv
        public void loadmanv(ComboBox cbnv)
        {
            hdbsql.loadmanv(cbnv);
        }
        public string loadtennv(string Tennv, string Manv)
        {
            Tennv = hdbsql.Loadtennv(Tennv, Manv);
            return Tennv;
        }
        //load khách
        public void loadmakh(ComboBox cbkh)
        {
            hdbsql.loadmakhach(cbkh);
        }
        public string loadtenkh(string Tenk, string Mak)
        {
            Tenk = hdbsql.Loadtenkhach(Tenk, Mak);
            return Tenk;
        }
    }
}
