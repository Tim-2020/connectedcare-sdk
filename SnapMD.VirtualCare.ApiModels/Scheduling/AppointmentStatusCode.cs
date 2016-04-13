﻿namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public enum AppointmentStatusCode
    {
        NotSpecified,

        /// <summary>
        /// A future appointment.
        /// </summary>
        Scheduled,

        /// <summary>
        /// The patient for this appointment arrived to the clinic.
        /// </summary>
        Waiting,

        /// <summary>
        /// The patient cancelled the appointment.
        /// </summary>
        CancelledByPatient,

        /// <summary>
        /// The appointment was cancelled by the Provider.
        /// </summary>
        CancelledByProvider,

        /// <summary>
        /// The appointment has taken place.
        /// </summary>
        Fulfilled,

        /// <summary>
        /// The patient was transferred to a different doctor.
        /// </summary>
        Transferred
    }
}
