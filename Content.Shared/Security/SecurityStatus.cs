﻿namespace Content.Shared.Security;

/// <summary>
/// Status used in Criminal Records.
///
/// None - the default value
/// Suspected - the person is suspected of doing something illegal
/// Wanted - the person is being wanted by security
/// Detained - the person is detained by security
/// Paroled - the person is on parole
/// Discharged - the person has been released from prison
/// </summary>
public enum SecurityStatus : byte
{
    None,
    // Harmony additional status
    Monitor,
    // Harmony additional status
    Search,
    Suspected,
    Wanted,
    // Harmony additional status
    KillOnSight,
    Detained,
    Paroled,
    Discharged
}
