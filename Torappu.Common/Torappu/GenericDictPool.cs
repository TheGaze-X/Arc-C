using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public class GenericDictPool<K, V> : IHotfixable
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003F7")]
		private static void _ResetDict(Dictionary<K, V> inst)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00005204 File Offset: 0x00003404
		[Token(Token = "0x60003F8")]
		public static GenericPool<Dictionary<K, V>>.Ref Get()
		{
			return default(GenericPool<Dictionary<K, V>>.Ref);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x60003F9")]
		public static GenericPool<Dictionary<K, V>>.Ref Get(out Dictionary<K, V> result)
		{
			return default(GenericPool<Dictionary<K, V>>.Ref);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003FA")]
		public GenericDictPool()
		{
		}

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x0")]
		private static Action<Dictionary<K, V>> s_resetDelegate;
	}
}
