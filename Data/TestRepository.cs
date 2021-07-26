﻿using System;
using System.Collections.Generic;
using Data.Interfaces;
using Entities;

namespace Data
{
    public class TestRepository : ITestRepository
    {
        /// <summary>
        ///     Instantiate our
        /// </summary>
        public TestRepository()
        {
            IrishCompanies = new List<IrishCompany>();
            IrishCompanies.AddRange(populateIrishCompanies());
            ForeignCompanies = new List<ForeignCompany>();
            ForeignCompanies.AddRange(populateForeignCompanies());
            SoleTraders = new List<SoleTrader>();
            SoleTraders.AddRange(populateSoleTraders());
        }

        public List<IrishCompany> IrishCompanies { get; set; }
        public List<ForeignCompany> ForeignCompanies { get; set; }
        public List<SoleTrader> SoleTraders { get; set; }

        /* 
         * Implement a method to return all companies in one list
         */

        public List<Company> FindAllCompanies()
        {
            List<Company> objCompany = new List<Company>();
            objCompany.AddRange(this.SoleTraders);
            objCompany.AddRange(this.IrishCompanies);
            objCompany.AddRange(this.ForeignCompanies);
            return objCompany;
        }
       


        #region dummy data

        private IEnumerable<IrishCompany> populateIrishCompanies()
        {
            var comp1 = new IrishCompany
            {
                Name = "Irish1",
                AddressLine1 = "addr1",
                AddressLine2 = "addr2",
                AddressLine3 = "addr3",
                Employments = new List<Employment>
                {
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee15",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2010"),
                        EmploymentEndDate = Convert.ToDateTime("10/10/2012"),
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee16",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2012"),
                        EmploymentEndDate = Convert.ToDateTime("10/10/2014"),
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee17",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2000"),
                        EmploymentEndDate = null,
                    }
                }
            };

            var comp2 = new IrishCompany
            {
                Name = "Irish2",
                AddressLine1 = "addr1",
                AddressLine2 = "addr2",
                AddressLine3 = "addr3"
            };

            var comp3 = new IrishCompany
            {
                Name = "Irish3",
                AddressLine1 = "addr1",
                AddressLine2 = "addr2",
                AddressLine3 = "addr3"
            };

            var comp4 = new IrishCompany
            {
                Name = "Irish4",
                AddressLine1 = "addr1",
                AddressLine2 = "addr2",
                AddressLine3 = "addr3"
            };

            return new List<IrishCompany> { comp1, comp2, comp3, comp4 };
        }

        private IEnumerable<ForeignCompany> populateForeignCompanies()
        {
            var comp1 = new ForeignCompany
            {
                Name = "Foreign1",
                AddressLine1 = "addr1",
                AddressLine2 = "addr2",
                AddressLine3 = "addr3"
                ,
                Employments = new List<Employment>
                {
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee9",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2010"),
                        EmploymentEndDate = Convert.ToDateTime("10/10/2012"),
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee10",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2012"),
                        EmploymentEndDate = Convert.ToDateTime("10/10/2014"),
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee11",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2000"),
                        EmploymentEndDate = null,
                    }
                }
            };

            var comp2 = new ForeignCompany
            {
                Name = "Foreign2",
                AddressLine1 = "addr1",
                AddressLine2 = "addr2",
                AddressLine3 = "addr3"
                ,
                Employments = new List<Employment>
                {
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee4",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2012"),
                        EmploymentEndDate = null,
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee5",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2004"),
                        EmploymentEndDate = null,
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee6",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2000"),
                        EmploymentEndDate = Convert.ToDateTime("10/10/2003"),
                    }
                }
            };

            return new List<ForeignCompany> { comp1, comp2 };
        }

        private IEnumerable<SoleTrader> populateSoleTraders()
        {
            var comp1 = new SoleTrader
            {
                Name = "SoleTrader1",
                AddressLine1 = "addr1",
                AddressLine2 = "addr2",
                AddressLine3 = "addr3"
                ,
                Employments = new List<Employment>
                {
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee1",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2000"),
                        EmploymentEndDate = Convert.ToDateTime("10/10/2013"),
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee2",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/1988"),
                        EmploymentEndDate = Convert.ToDateTime("10/10/2003"),
                    },
                    new Employment
                    {
                        Employee = new Person
                        {
                            Name = "Employee3",
                        },
                        EmployementStartDate = Convert.ToDateTime("10/10/2005"),
                        EmploymentEndDate = null,
                    }
                }
            };


            return new List<SoleTrader> { comp1 };
        }

        #endregion
    }
}