using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[DefaultMember("Item")]
	[UsedByNativeCode]
	[StructLayout(2)]
	public struct Color32 : IFormattable
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x575F5A0", Offset = "0x575E1A0", VA = "0x18575F5A0")]
		[MethodImpl(256)]
		public Color32(byte r, byte g, byte b, byte a)
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xD676F0", Offset = "0xD662F0", VA = "0x180D676F0")]
		[MethodImpl(256)]
		public static implicit operator Color32(Color c)
		{
			return default(Color32);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x5948320", Offset = "0x5946F20", VA = "0x185948320")]
		[MethodImpl(256)]
		public static implicit operator Color(Color32 c)
		{
			return default(Color);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xD675E0", Offset = "0xD661E0", VA = "0x180D675E0")]
		[MethodImpl(256)]
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			return default(Color32);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x5948310", Offset = "0x5946F10", VA = "0x185948310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x59480A0", Offset = "0x5946CA0", VA = "0x1859480A0", Slot = "4")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Ignore(DoesNotContributeToSize = true)]
		private int rgba;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte r;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte g;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte b;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte a;
	}
}
