﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pEngine.Framework.FrameDependency
{
	public interface IDependencyReference
    {

		/// <summary>
		/// Dependency identifier.
		/// </summary>
		long DependencyID { get; }

	}
}
