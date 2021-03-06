﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pEngine.Platform.Input;

namespace pEngine.Input.Bindings
{
	public struct JoypadKeyCombination : IKeyCombination<int>, IEquatable<JoypadKeyCombination>
	{
		/// <summary>
		/// Empty key combination.
		/// </summary>
		public static JoypadKeyCombination Empty => new JoypadKeyCombination();

		/// <summary>
		/// Makes a new instance of <see cref="JoypadKeyCombination"/> class.
		/// </summary>
		/// <param name="id">Target joypad.</param>
		/// <param name="keys">Key combination.</param>
		public JoypadKeyCombination(int joypadNum, params int[] keys)
		{
			JoypadID = joypadNum;
			Keys = keys;
			KeysHash = keys.Sum(x => Convert.ToInt32(x)) % int.MaxValue;
		}

		/// <summary>
		/// Key list.
		/// </summary>
		public IEnumerable<int> Keys { get; }

		/// <summary>
		/// Joypad identifier.
		/// </summary>
		public int JoypadID { get; }

		/// <summary>
		/// Hash reappresenting the binding keys.
		/// </summary>
		public int KeysHash { get; }

		#region .NET implementations

		public bool Equals(JoypadKeyCombination other)
		{
			return Keys.Equals(other.Keys);
		}

		public override int GetHashCode()
		{
			return KeysHash;
		}

		#endregion
	}
}
