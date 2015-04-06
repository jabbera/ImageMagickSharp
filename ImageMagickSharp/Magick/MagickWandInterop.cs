﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageMagickSharp
{
    /// <summary> A magick wand interop. </summary>
    internal static class MagickWandInterop
    { 

        #region [Magick Wand Properties]

        /// <summary> Magick get antialias. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> true if it succeeds, false if it fails. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern bool MagickGetAntialias(IntPtr wand);

        /// <summary> Magick set antialias. </summary>
        /// <param name="wand"> The wand. </param>
        /// <param name="antialias"> true to antialias. </param>
        /// <returns> true if it succeeds, false if it fails. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern bool MagickSetAntialias(IntPtr wand, bool antialias);

        /// <summary> Magick get background color. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr MagickGetBackgroundColor(IntPtr wand);

        /// <summary> Magick set background color. </summary>
        /// <param name="wand"> The wand. </param>
        /// <param name="background"> The background. </param>
        /// <returns> true if it succeeds, false if it fails. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern bool MagickSetBackgroundColor(IntPtr wand, IntPtr background);

        #endregion

        #region [Magick Wand - Fonts]
        /// <summary> Magick set font. </summary>
        /// <param name="wand"> The wand. </param>
        /// <param name="font"> The font. </param>
        /// <returns> true if it succeeds, false if it fails. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern bool MagickSetFont(IntPtr wand, string font);

        /// <summary> Magick get font. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr MagickGetFont(IntPtr wand);

		/// <summary> Magick query font metrics. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="drawing_wand"> The drawing wand. </param>
		/// <param name="text"> The text. </param>
		/// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickQueryFontMetrics(IntPtr wand, IntPtr drawing_wand, IntPtr text);

		/// <summary> Magick query multiline font metrics. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="drawing_wand"> The drawing wand. </param>
		/// <param name="text"> The text. </param>
		/// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickQueryMultilineFontMetrics(IntPtr wand, IntPtr drawing_wand, IntPtr text);

        #endregion

        #region [Magick Wand Methods]

        /// <summary> Creates a new magick wand. </summary>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr NewMagickWand();


        /// <summary> Destroys the magick wand described by wand. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr DestroyMagickWand(IntPtr wand);

        /// <summary> Clone magick wand. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr CloneMagickWand(IntPtr wand);

        /// <summary> Magick relinquish memory. </summary>
        /// <param name="resource"> The resource. </param>
        /// <returns> An int. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern int MagickRelinquishMemory(IntPtr resource);

        /// <summary> Clears the magick wand described by wand. </summary>
        /// <param name="wand"> The wand. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void ClearMagickWand(IntPtr wand);

        #endregion

        #region [Magick Wand Methods - Exception]
        /// <summary> Magick clear exception. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> An int. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern int MagickClearException(IntPtr wand);

        /// <summary> Magick get exception. </summary>
        /// <param name="wand"> The wand. </param>
        /// <param name="exceptionType"> Type of the exception. </param>
        /// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickGetException(IntPtr wand, out int exceptionType);

        /// <summary> Magick get exception type. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> An int. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern int MagickGetExceptionType(IntPtr wand);

        #endregion

        #region [Magick Wand Methods - Iterator]
        /// <summary> Magick set image. </summary>
        /// <param name="wand"> The wand. </param>
        /// <param name="setwand"> The setwand. </param>
        /// <returns> true if it succeeds, false if it fails. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern bool MagickSetImage(IntPtr wand, IntPtr setwand);

		/// <summary> Gets the image at the current image index. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickGetImage(IntPtr wand);

        /// <summary> Magick set iterator index. </summary>
        /// <param name="wand"> The wand. </param>
        /// <param name="index"> Zero-based index of the. </param>
        /// <returns> true if it succeeds, false if it fails. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern bool MagickSetIteratorIndex(IntPtr wand, int index);

        /// <summary> Magick get iterator index. </summary>
        /// <param name="wand"> The wand. </param>
        /// <returns> An int. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern int MagickGetIteratorIndex(IntPtr wand);

        /// <summary> Magick set first iterator. </summary>
        /// <param name="wand"> The wand. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void MagickSetFirstIterator(IntPtr wand);

        /// <summary> Magick set last iterator. </summary>
        /// <param name="wand"> The wand. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void MagickSetLastIterator(IntPtr wand);

        /// <summary> Magick reset iterator. </summary>
        /// <param name="wand"> The wand. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void MagickResetIterator(IntPtr wand);

		/// <summary> Magick get number images. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> An int. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern int MagickGetNumberImages(IntPtr wand);

		/// <summary> Magick next image. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickNextImage(IntPtr wand);

		/// <summary> Magick has next image. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickHasNextImage(IntPtr wand);

		/// <summary> Magick previous image. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickPreviousImage(IntPtr wand);

		/// <summary> Magick has previous image. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickHasPreviousImage(IntPtr wand);

        #endregion

		#region [Magick Wand Methods - Image]
		
		/// <summary> Magick new image. </summary>
		/// <param name="wand"> Handle of the wand. </param>
		/// <param name="columns"> The columns. </param>
		/// <param name="rows"> The rows. </param>
		/// <param name="background"> The background. </param>
		/// <returns> An int. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern int MagickNewImage(IntPtr wand, int columns, int rows, IntPtr background);

		/// <summary> Magick new image. </summary>
		/// <param name="wand"> Handle of the wand. </param>
		/// <param name="columns"> The columns. </param>
		/// <param name="rows"> The rows. </param>
		/// <param name="background"> The background. </param>
		/// <returns> An int. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern int MagickNewImage(IntPtr wand, ulong columns, ulong rows, IntPtr background);

		/// <summary> Magick read image. </summary>
		/// <param name="wand"> Handle of the wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <returns> An int. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern int MagickReadImage(IntPtr wand, string file_name);

		/// <summary> Magick read image. </summary>
		/// <param name="wand"> Handle of the wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <returns> An int. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern int MagickReadImage(IntPtr wand, IntPtr file_name);

		/// <summary>
		/// MagickPingImage() is like MagickReadImage() except the only valid information returned is the
		/// image width, height, size, and format. It is designed to efficiently obtain this information
		/// from a file without reading the entire image sequence into memory. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickPingImage(IntPtr wand, string file_name);

		/// <summary>
		/// MagickPingImage() is like MagickReadImage() except the only valid information returned is the
		/// image width, height, size, and format. It is designed to efficiently obtain this information
		/// from a file without reading the entire image sequence into memory. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickPingImage(IntPtr wand, IntPtr file_name);

		/// <summary> Magick write image. </summary>
		/// <param name="magick_wand"> The magick wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickWriteImage(IntPtr wand, string file_name);

		/// <summary> Magick write image. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickWriteImage(IntPtr wand, IntPtr file_name);

		/// <summary> Magick write images. </summary>
		/// <param name="magick_wand"> The magick wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <param name="adjoin"> true to adjoin. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickWriteImages(IntPtr wand, string file_name, bool adjoin);

		/// <summary> Magick write images. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="file_name"> Filename of the file. </param>
		/// <param name="adjoin"> true to adjoin. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickWriteImages(IntPtr wand, IntPtr file_name, bool adjoin);

		/// <summary> Magick add image. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="add_wand"> The add wand. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickAddImage(IntPtr wand, IntPtr add_wand);

		/// <summary> Magick remove image. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickRemoveImage(IntPtr wand);

		/// <summary> Magick combine images. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="channel"> The channel. </param>
		/// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickCombineImages(IntPtr wand, int channel);

		/// <summary> Magick merge image layers. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="method"> The method. </param>
		/// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickMergeImageLayers(IntPtr wand, ImageLayerType method);

		/// <summary> Magick append images. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="stack"> true to stack. </param>
		/// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickAppendImages(IntPtr wand, bool stack);

		#endregion

		#region [Magick Wand Methods - General]
		
		/// <summary> Magick get page. </summary>
		/// <param name="magick_wand"> The magick wand. </param>
		/// <param name="width"> The width. </param>
		/// <param name="height"> The height. </param>
		/// <param name="x"> The x coordinate. </param>
		/// <param name="y"> The y coordinate. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickGetPage(IntPtr wand, out int width, out int height, out int x, out int y);

		/// <summary> Magick set page. </summary>
		/// <param name="magick_wand"> The magick wand. </param>
		/// <param name="width"> The width. </param>
		/// <param name="height"> The height. </param>
		/// <param name="x"> The x coordinate. </param>
		/// <param name="y"> The y coordinate. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickSetPage(IntPtr wand, int width, int height, int x, int y);

		/// <summary> Magick set size. </summary>
		/// <param name="magick_wand"> The magick wand. </param>
		/// <param name="columns"> The columns. </param>
		/// <param name="rows"> The rows. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickSetSize(IntPtr wand, int columns, int rows);

		/// <summary> Magick get size. </summary>
		/// <param name="magick_wand"> The magick wand. </param>
		/// <param name="columns"> The columns. </param>
		/// <param name="rows"> The rows. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickGetSize(IntPtr wand, out int columns, out int rows);


		/// <summary> Magick get quantum depth. </summary>
		/// <param name="depth"> The depth. </param>
		/// <returns> An IntPtr. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern IntPtr MagickGetQuantumDepth(out int depth);

		/// <summary> Magick get pointsize. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> A double. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern double MagickGetPointsize(IntPtr wand);

		/// <summary> Magick set pointsize. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="pointsize"> The pointsize. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickSetPointsize(IntPtr wand, double pointsize);

		/// <summary> Magick get gravity. </summary>
		/// <param name="wand"> The wand. </param>
		/// <returns> A GravityType. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern GravityType MagickGetGravity(IntPtr wand);

		/// <summary> Magick set gravity. </summary>
		/// <param name="wand"> The wand. </param>
		/// <param name="gravity"> The gravity. </param>
		/// <returns> true if it succeeds, false if it fails. </returns>
		[DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
		internal static extern bool MagickSetGravity(IntPtr wand, GravityType gravity);

		#endregion
	
	}
}
