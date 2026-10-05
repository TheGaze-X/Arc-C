using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x59531A0", Offset = "0x5951DA0", VA = "0x1859531A0")]
		public SpaceAttribute()
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x28616F0", Offset = "0x28602F0", VA = "0x1828616F0")]
		public SpaceAttribute(float height)
		{
		}

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x10")]
		public readonly float height;
	}
}
