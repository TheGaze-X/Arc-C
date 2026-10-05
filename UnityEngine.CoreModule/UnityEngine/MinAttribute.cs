using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x28616F0", Offset = "0x28602F0", VA = "0x1828616F0")]
		public MinAttribute(float min)
		{
		}

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;
	}
}
