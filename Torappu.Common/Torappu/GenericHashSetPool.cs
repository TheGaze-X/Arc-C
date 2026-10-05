using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public class GenericHashSetPool<T> : IHotfixable
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003FB")]
		private static void _ResetHashSet(HashSet<T> inst)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x60003FC")]
		public static GenericPool<HashSet<T>>.Ref Get()
		{
			return default(GenericPool<HashSet<T>>.Ref);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x60003FD")]
		public static GenericPool<HashSet<T>>.Ref Get(out HashSet<T> result)
		{
			return default(GenericPool<HashSet<T>>.Ref);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003FE")]
		public GenericHashSetPool()
		{
		}

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x0")]
		private static Action<HashSet<T>> s_resetDelegate;
	}
}
