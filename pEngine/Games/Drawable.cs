﻿using System;
using System.Collections.Generic;

using pEngine.Physics;
using pEngine.Graphics;
using pEngine.Framework.Caching;

namespace pEngine.Games
{
	public abstract partial class Drawable : PhysicalObject
	{

		/// <summary>
		/// Makes a new instance of <see cref="Drawable"/> class.
		/// </summary>
		/// <param name="parent">Parent object.</param>
		public Drawable()
		{

		}

		/// <summary>
		/// Dispose all resources used from this class.
		/// </summary>
		/// <param name="disposing">Dispose managed resources.</param>
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		#region Visibility
		
		/// <summary>
		/// Gets or sets if this object is visible.
		/// </summary>
		public bool Visible { get; set; }

		/// <summary>
		/// Gets or sets the object opacity.
		/// </summary>
		public double Opacity { get; set; }

		/// <summary>
		/// Gets or sets the depth order relative 
		/// to parent's children
		/// </summary>
		public int zIndex { get; set; }

		#endregion

		#region Assets

		/// <summary>
		/// Calculate the assets which can be rendered.
		/// </summary>
		[Cached(Channel = "Graphics")]
		public virtual IEnumerable<Asset> GetAssets()
		{
			if (State == Resources.ResourceState.NotLoaded)
				return new List<Asset>();
			
			return CalculateAssets();
		}

		/// <summary>
		/// Overridable function that compute the assets for this <see cref="Drawable"/>.
		/// </summary>
		protected virtual List<Asset> CalculateAssets()
		{
			return new List<Asset>();
		}

		#endregion
	}
}
