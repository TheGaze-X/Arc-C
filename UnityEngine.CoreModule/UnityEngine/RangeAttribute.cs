using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4F1E70", Offset = "0x4F0A70", VA = "0x1804F1E70")]
		public RangeAttribute(float min, float max)
		{
		}

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x14")]
		public readonly float max;
	}
}
