﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMagickSharp
{
	/// <summary> A font metrics. </summary>
	internal class FontMetrics
	{
		#region [Constructors]
		/// <summary> Initializes a new instance of the ImageMagickSharp.FontMetrics class. </summary>
		/// <param name="matrix"> The matrix. </param>
		internal FontMetrics(double[] matrix)
		{
			CharacterWidth = matrix[0];
			CharacterHeight = matrix[1];
			Ascender = matrix[2];
			Descender = matrix[3];
			TextWidth = matrix[4];
			TextHeight = matrix[5];
			HorizontalAdvance = matrix[6];
			BoundingBoxX1 = matrix[7];
			BoundingBoxY2 = matrix[8];
			BoundingBoxX1 = matrix[9];
			BoundingBoxY2 = matrix[10];
			OriginX = matrix[11];
			OriginY = matrix[12];
		}

		/// <summary> Initializes a new instance of the ImageMagickSharp.FontMetrics class. </summary>
		internal FontMetrics()
		{
		}

		#endregion

		#region [internal Properties]

		/// <summary> Gets or sets the width of the character. </summary>
		/// <value> The width of the character. </value>
		internal double CharacterWidth { get; set; }

		/// <summary> Gets or sets the height of the character. </summary>
		/// <value> The height of the character. </value>
		internal double CharacterHeight { get; set; }

		/// <summary> Gets or sets the ascender. </summary>
		/// <value> The ascender. </value>
		internal double Ascender { get; set; }

		/// <summary> Gets or sets the descender. </summary>
		/// <value> The descender. </value>
		internal double Descender { get; set; }

		/// <summary> Gets or sets the width of the text. </summary>
		/// <value> The width of the text. </value>
		internal double TextWidth { get; set; }

		/// <summary> Gets or sets the height of the text. </summary>
		/// <value> The height of the text. </value>
		internal double TextHeight { get; set; }

		/// <summary> Gets or sets the horizontal advance. </summary>
		/// <value> The horizontal advance. </value>
		internal double HorizontalAdvance { get; set; }

		/// <summary> Gets or sets the bounding box x coordinate 1. </summary>
		/// <value> The bounding box x coordinate 1. </value>
		internal double BoundingBoxX1 { get; set; }

		/// <summary> Gets or sets the bounding box y coordinate 1. </summary>
		/// <value> The bounding box y coordinate 1. </value>
		internal double BoundingBoxY1 { get; set; }

		/// <summary> Gets or sets the bounding box x coordinate 2. </summary>
		/// <value> The bounding box x coordinate 2. </value>
		internal double BoundingBoxX2 { get; set; }

		/// <summary> Gets or sets the bounding box y coordinate 2. </summary>
		/// <value> The bounding box y coordinate 2. </value>
		internal double BoundingBoxY2 { get; set; }

		/// <summary> Gets or sets the origin x coordinate. </summary>
		/// <value> The origin x coordinate. </value>
		internal double OriginX { get; set; }

		/// <summary> Gets or sets the origin y coordinate. </summary>
		/// <value> The origin y coordinate. </value>
		internal double OriginY { get; set; }

		#endregion

	}
}
