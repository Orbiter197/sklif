﻿using PropertyChanged;using System;using System.Collections.Generic;using System.ComponentModel;using System.Text;namespace EverydayPatientInfo{    /// <summary>    /// A base view model that fires Property Changed events    /// </summary>    [AddINotifyPropertyChangedInterface]    public class BaseViewModel : INotifyPropertyChanged    {        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };                /// <summary>
        /// Call sthis to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }    }}