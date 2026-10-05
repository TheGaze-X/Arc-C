using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
	[StructLayout(2)]
	internal struct StyleValue
	{
		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StylePropertyId id;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public StyleKeyword keyword;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float number;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Length length;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Color color;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GCHandle resource;
	}
}
