//
// CairoLibraryDefinition.cs
//
// Author:
//       glenn <>
//
// Copyright (c) 2022 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonoDevelop.Components
{
	/// <summary>
	/// A class containing definitions for the cairo library api's.
	/// </summary>
	public static class CairoLibraryDefinition
	{
		static readonly PlatformID currentOS;
		static readonly string linuxCairoLib = "libcairo.so.2";
		static readonly string winCairoLib = "libcairo-2.dll";
		static readonly string macOsCairoLib = "libcairo.2.dylib";

		static readonly Dictionary<PlatformID, string> libraries
			= new Dictionary<PlatformID, string> (){
				{ PlatformID.Unix, linuxCairoLib },
				{ PlatformID.Win32NT, winCairoLib },
				{ PlatformID.Win32S, winCairoLib },
				{ PlatformID.Win32Windows, winCairoLib },
				{ PlatformID.WinCE, winCairoLib },
				{PlatformID.MacOSX, macOsCairoLib}
			};

		static CairoLibraryDefinition ()
		{
			currentOS = Environment.OSVersion.Platform;
			Library = libraries.First (lib => lib.Key == currentOS).Value;
		}

		/// <summary>
		/// Gets the name of the library to be loaded.
		/// </summary>
		public static readonly string Library;

		/// <summary>
		/// Contains the method names defined in the library.
		/// </summary>
		public static class API
		{
			public static readonly string PushGroup = "cairo_push_group";
			public static readonly string PopGroup = "cairo_pop_group";
			public static readonly string PopGroupToSource = "cairo_pop_group_to_source";
			public static readonly string GetSource = "cairo_get_source";
			public static readonly string PatternSetExtend = "cairo_pattern_set_extend";
			public static readonly string QuartzSurfaceCreate = "cairo_quartz_surface_create";
			public static readonly string QuartzSurfaceGetCGContext = "cairo_quartz_surface_get_cg_context";
			public static readonly string GetTarget = "cairo_get_target";
		}
	}
}
