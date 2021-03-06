﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pEngine.Framework.FrameDependency
{
    public interface IDependencyDescriptor
    {
		/// <summary>
		/// Identifier for this instance of descriptor.
		/// </summary>
		long DescriptorID { get; set; }

		/// <summary>
		/// Actual dependency load state.
		/// </summary>
		DependencyState State { get; set; }
	}
}
