using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002170 RID: 8560
	[Token(Token = "0x2002170")]
	public class BakeMuzzleDataHolder : SingletonWithMonoHost<BakeMuzzleDataHolder, BattleController>, IDisposable
	{
		// Token: 0x0600D2D6 RID: 53974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2D6")]
		[Address(RVA = "0x3532010", Offset = "0x3530C10", VA = "0x183532010")]
		private BakeMuzzleDataHolder()
		{
		}

		// Token: 0x0600D2D7 RID: 53975 RVA: 0x0004BF78 File Offset: 0x0004A178
		[Token(Token = "0x600D2D7")]
		[Address(RVA = "0x3531DD0", Offset = "0x35309D0", VA = "0x183531DD0")]
		public bool Touch(string dataPath)
		{
			return default(bool);
		}

		// Token: 0x0600D2D8 RID: 53976 RVA: 0x0004BF90 File Offset: 0x0004A190
		[Token(Token = "0x600D2D8")]
		[Address(RVA = "0x3531F30", Offset = "0x3530B30", VA = "0x183531F30")]
		public bool TryGetCached(string dataPath, out BakedSpineData data)
		{
			return default(bool);
		}

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2D9")]
		[Address(RVA = "0x3531D30", Offset = "0x3530930", VA = "0x183531D30", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400E1D7 RID: 57815
		[Token(Token = "0x400E1D7")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, BakedSpineData> m_cache;

		// Token: 0x0400E1D8 RID: 57816
		[Token(Token = "0x400E1D8")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<string> m_failedPaths;

		// Token: 0x0400E1D9 RID: 57817
		[Token(Token = "0x400E1D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400E1DA RID: 57818
		[Token(Token = "0x400E1DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Touch;

		// Token: 0x0400E1DB RID: 57819
		[Token(Token = "0x400E1DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetCached;

		// Token: 0x0400E1DC RID: 57820
		[Token(Token = "0x400E1DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
