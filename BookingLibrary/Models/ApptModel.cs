﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    /// <summary>
    /// One appointment slot.
    /// </summary>
    public class ApptModel
    {   
        /// <summary>
        /// ID for appointment
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Person who is in the appt slot.
        /// </summary>
        public PersonModel Person { get; set; }
        /// <summary>
        /// Date of Appointment
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Time of appt.
        /// </summary>
        public string TimeSlotName { get; set; }

        /// <summary>
        /// Type of appt.
        /// </summary>
        public string ServiceName { get; set; }

      
    }
}
