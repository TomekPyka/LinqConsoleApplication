using System;
using System.Collections.Generic;
using System.Text;

namespace LinqConsoleApplication
{
    class LinqSamples
    {
        public static IEnumerable<Emp> Emps { get; set; }
        public static IEnumerable<Dept> Depts { get; set; }

        public LinqSamples()
        {
            LoadData();
        }

        public void LoadData()
        {
            Dept empsCol = new List<Emp>();
            Dept deptsCol = new List<Dept>();

            #region Load depts
            Dept d1 = new Dept
            {
                Deptno = 1,
                Dname = "R@D",
                Loc = "Cracow"
            };

            Dept d2 = new Dept
            {
                Deptno = 2,
                Dname = "Tenders",
                Loc = "Brussels"
            };

            Dept d3 = new Dept
            {
                Deptno = 3,
                Dname = "CS",
                Loc = "Waszyngton"
            };

            deptsCol.Add(d1);
            deptsCol.Add(d2);
            deptsCol.Add(d3);
            Depts = deptsCol;
            #endregion

            #region Load emps
            Emp e1 = new Emp
            {
                Deptno = 1,
                Empno = 1,
                Ename = "Jerzy Nowak",
                HireDate = DateTime.Now.AddMonths(-10),
                Job = "Konserwator",
                Mgr = null,
                Salary = 4000
            };

            Emp e2 = new Emp
            {
                Deptno = 1,
                Empno = 2,
                Ename = "Jerzy Kozdron",
                HireDate = DateTime.Now.AddMonths(-3),
                Job = "Leniuch",
                Mgr = e1,
                Salary = 666
            };

            Emp e3 = new Emp
            {
                Deptno = 1,
                Empno = 2,
                Ename = "Albert Nosowski",
                HireDate = DateTime.Now.AddMonths(-12),
                Job = "Leniuch do potegi",
                Mgr = null,
                Salary = 44444
            };

            Emp e4 = new Emp
            {
                Deptno = 2,
                Empno = 14,
                Ename = "Paweł Latowski",
                HireDate = DateTime.Now.AddMonths(-2),
                Job = "Konserwator plaszczyzn",
                Mgr = e2,
                Salary = 7787
            };

            Emp e5 = new Emp
            {
                Deptno = 2,
                Empno = 99,
                Ename = "Michał Kowalski",
                HireDate = DateTime.Now.AddMonths(-6),
                Job = "Filozof",
                Mgr = e2,
                Salary = 2222
            };