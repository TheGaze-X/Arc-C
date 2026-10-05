using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CA8 RID: 31912
	[Token(Token = "0x2007CA8")]
	public static class fiSingletons
	{
		// Token: 0x0602C932 RID: 182578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C932")]
		public static T Get<T>()
		{
			return null;
		}

		// Token: 0x0602C933 RID: 182579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C933")]
		[Address(RVA = "0x2873DC0", Offset = "0x28729C0", VA = "0x182873DC0")]
		public static object Get(Type type)
		{
			return null;
		}

		// Token: 0x040403CF RID: 263119
		[Token(Token = "0x40403CF")]
		[ThreadStatic]
		private static Dictionary<Type, object> _instances;
	}
}
