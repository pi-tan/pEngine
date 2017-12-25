﻿using System;

namespace pEngine.Resources.Files
{
    public class TrueTypeFont : File
    {

		public TrueTypeFont(string path)
			: base(path)
		{
			switch (Extension.ToLower())
			{
				case "ttf":
				case "ttc":
					break;
				default:
					throw new InvalidOperationException("This file is not a ttf.");
			}
		}

		protected override void OnLoad()
		{
			base.OnLoad();
		}

        protected override void OnComplete()
		{
			base.OnComplete();
		}

        protected override bool OnAbort(IResource res, Exception e)
		{
			return base.OnAbort(res, e);
		}

		public override void Dispose()
		{
			base.Dispose();
		}
	}
}
