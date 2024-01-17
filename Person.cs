using System;
using System.Collections.Generic;
/*
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;

using Communications;
using Fluidics;
using Data;
using CAD;
using Controls;
using SystemsEngineering;

using Automotive;
*/

namespace MissionsNamespace
{
    public class Person
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _FirstName;
        private String _LastName;
        private String _ID;
        //
        //  Definition
        private Boolean _IsAdversary;
        private String _Description;
        //  Owned & Owning Objects
        //
        //  Role
        private Role _Role;
        private List<Role> _Roles;
        private ViewPoint _MyViewPoint;
        //
        //  Vehicles
        //private Automobile _CurrentVehicle;
       // private List<Automobile> _Vehicles;
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************
        public enum PersonTypeEnum
        {
            Stakeholder = 0,
            Adversary
        }
        //  *****************************************************************************************


            //  *****************************************************************************************
            //  PERSON CONSTRUCTOR
            //
            //  ************************************************************
        public Person()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  First Name
        public String FirstName
        {
            set => _FirstName = value;
            get
            {
                return _FirstName;
            }
        }
        //
        //  Last Name
        public String LastName
        {
            set => _LastName = value;
            get
            {
                return _LastName;
            }
        }
        //
        //  Last Name
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
            }
        }
        //
        //  Definition
        //  
        //  Is an Adversary
        public Boolean IsAdversary
        {
            set => _IsAdversary = value;
            get
            {
                return _IsAdversary;
            }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get
            {
                return _Description;
            }
        }
        //  Owned & Owning Objects
        //
        //  Role
        public Role Role
        {
            set => _Role = value;
            get
            {
                return _Role;
            }
        }
        //
        //  Roles
        public List<Role> Roles
        {
            set => _Roles = value;
            get
            {
                return _Roles;
            }
        }
        public ViewPoint MyViewPoint
        {
            set => _MyViewPoint = value;
            get
            {
                return _MyViewPoint;
            }
        }
        //
        //  Current Vehicle
        /*
        public Automobile CurrentVehicle
        {
            set => _CurrentVehicle = value;
            get
            {
                return _CurrentVehicle;
            }
        }
        //
        //  Vehicles
        public List<Automobile> Vehicles
        {
            set => _Vehicles = value;
            get
            {
                return _Vehicles;
            }
        }
        */
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
