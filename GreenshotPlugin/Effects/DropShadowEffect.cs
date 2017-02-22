﻿#region Greenshot GNU General Public License

// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2017 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Usings

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using GreenshotPlugin.Core;
using GreenshotPlugin.Gfx;

#endregion

namespace GreenshotPlugin.Effects
{
	/// <summary>
	///     DropShadowEffect
	/// </summary>
	[TypeConverter(typeof(EffectConverter))]
	public class DropShadowEffect : IEffect
	{
		public DropShadowEffect()
		{
			Reset();
		}

		public float Darkness { get; set; }

		public int ShadowSize { get; set; }

		public Point ShadowOffset { get; set; }

		public virtual void Reset()
		{
			Darkness = 0.6f;
			ShadowSize = 7;
			ShadowOffset = new Point(-1, -1);
		}

		public virtual Image Apply(Image sourceImage, Matrix matrix)
		{
			return sourceImage.CreateShadow(Darkness, ShadowSize, ShadowOffset, matrix, PixelFormat.Format32bppArgb);
		}
	}
}