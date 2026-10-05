using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class MultiLinePropertyAttribute : Attribute
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4E18F90", Offset = "0x4E17B90", VA = "0x184E18F90")]
		public MultiLinePropertyAttribute(int lines = 3)
		{
		}

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x10")]
		public int Lines;
	}
}
