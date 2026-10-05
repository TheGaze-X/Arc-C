using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CB0 RID: 31920
	[Token(Token = "0x2007CB0")]
	public static class fiAssemblyExtensions
	{
		// Token: 0x0602C960 RID: 182624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C960")]
		[Address(RVA = "0x2883F20", Offset = "0x2882B20", VA = "0x182883F20")]
		public static Type[] GetTypesWithoutException(this Assembly assembly)
		{
			return null;
		}

		// Token: 0x040403DB RID: 263131
		[Token(Token = "0x40403DB")]
		[FieldOffset(Offset = "0x0")]
		private static Type[] s_EmptyArray;
	}
}
