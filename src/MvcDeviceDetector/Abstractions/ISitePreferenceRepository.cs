﻿namespace MvcDeviceDetector.Abstractions
{
	using Microsoft.AspNetCore.Http;

	public interface ISitePreferenceRepository
    {
        IDevice LoadPreference(HttpContext context);
        void SavePreference(HttpContext context, IDevice device);
        void ResetPreference(HttpContext context);
    }
}