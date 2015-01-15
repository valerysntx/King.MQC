﻿namespace King.MQC
{
    using System;

    /// <summary>
    /// Attribute based routing
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class RouteAttribute : Attribute
    {
        #region Members
        /// <summary>
        /// Route Name
        /// </summary>
        protected readonly string name;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Route Name</param>
        public RouteAttribute(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name");
            }

            this.name = name;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Route Name
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this.name;
            }
        }
        #endregion
    }
}