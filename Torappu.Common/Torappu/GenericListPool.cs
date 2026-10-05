using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	public class GenericListPool<T> : IHotfixable
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003F3")]
		private static void _ResetList(List<T> inst)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000051D4 File Offset: 0x000033D4
		[Token(Token = "0x60003F4")]
		public static GenericPool<List<T>>.Ref Get()
		{
			return default(GenericPool<List<T>>.Ref);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x60003F5")]
		public static GenericPool<List<T>>.Ref Get(out List<T> result)
		{
			return default(GenericPool<List<T>>.Ref);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003F6")]
		public GenericListPool()
		{
		}

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x0")]
		private static Action<List<T>> s_resetDelegate;
	}
}
