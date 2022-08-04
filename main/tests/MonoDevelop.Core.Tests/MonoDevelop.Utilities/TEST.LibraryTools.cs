//
// TEST.LibraryTools.cs
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
using MonoDevelop.Components;
using NUnit.Framework;

namespace MonoDevelop.Utilities
{
	[TestFixture]
	public class TEST_LibraryTools
	{
		[Test]
		public void LoadLibraryAndMethod_ValidMethods_DoesNotThrow ()
		{
			//Arrange
			var lib = LibraryTools.LoadLibrary (CairoLibraryDefinition.Library);
			//Act
			var pushgroup = LibraryTools.GetProcAddress (lib, CairoLibraryDefinition.API.PushGroup);
			var popgroup = LibraryTools.GetProcAddress (lib, CairoLibraryDefinition.API.PopGroup);
			var popgrouptosource = LibraryTools.GetProcAddress (lib, CairoLibraryDefinition.API.PopGroupToSource);
			var getsource = LibraryTools.GetProcAddress (lib, CairoLibraryDefinition.API.GetSource);
			var patternsetextend = LibraryTools.GetProcAddress (lib, CairoLibraryDefinition.API.PatternSetExtend);
			//Assert
			Assert.AreNotEqual (IntPtr.Zero, lib, "library is not found");
			Assert.AreNotEqual (IntPtr.Zero, pushgroup, "proc address pushgroup is not found");
			Assert.AreNotEqual (IntPtr.Zero, popgroup, "proc address popgroup is not found");
			Assert.AreNotEqual (IntPtr.Zero, popgrouptosource, "proc address popgrouptosource is not found");
			Assert.AreNotEqual (IntPtr.Zero, getsource, "proc address getsource is not found");
			Assert.AreNotEqual (IntPtr.Zero, patternsetextend, "proc address patternsetextend is not found");
		}
	}
}