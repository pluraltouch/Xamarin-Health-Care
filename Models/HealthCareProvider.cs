﻿using Core;

namespace SampleApplication.Models
{
    public class HealthCareProvider : ModelBase
    {
        private string _address;
        private string _description;

        private double _distanceFromCurrentLocation;
        private string _email;
        private string _facebookUrl;
        private string _imageName;
        private bool _isPinned;
        private string _location;
        private string _name;

        private string _phoneNumber;

        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public double DistanceFromCurrentLocation
        {
            get { return _distanceFromCurrentLocation; }
            set { SetProperty(ref _distanceFromCurrentLocation, value); }
        }

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public string FacebookUrl
        {
            get { return _facebookUrl; }
            set { SetProperty(ref _facebookUrl, value); }
        }

        public string ImageName
        {
            get { return _imageName; }
            set { SetProperty(ref _imageName, value); }
        }

        public bool IsPinned
        {
            get { return _isPinned; }
            set { SetProperty(ref _isPinned, value); }
        }

        public string Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }
    }
}