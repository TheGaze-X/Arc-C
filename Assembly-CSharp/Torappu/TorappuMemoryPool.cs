using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200058F RID: 1423
	[Token(Token = "0x200058F")]
	public class TorappuMemoryPool : Singleton<TorappuMemoryPool>
	{
		// Token: 0x06005C15 RID: 23573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C15")]
		[Address(RVA = "0x1CFC520", Offset = "0x1CFB120", VA = "0x181CFC520")]
		private TorappuMemoryPool()
		{
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C16")]
		[Address(RVA = "0x1CFC3B0", Offset = "0x1CFAFB0", VA = "0x181CFC3B0")]
		public LRUCache<string, TorappuMemoryPool.Value> RequestGroup(string group, int capacity = 3)
		{
			return null;
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C17")]
		[Address(RVA = "0x1CFC290", Offset = "0x1CFAE90", VA = "0x181CFC290")]
		public void DeleteGroup(string group)
		{
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C18")]
		[Address(RVA = "0x1CFC320", Offset = "0x1CFAF20", VA = "0x181CFC320")]
		public void MarkGlobalFlag(int flag)
		{
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x0002F160 File Offset: 0x0002D360
		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x1CFC200", Offset = "0x1CFAE00", VA = "0x181CFC200")]
		public bool ConsumeGlobalFlag(int flag)
		{
			return default(bool);
		}

		// Token: 0x040021C4 RID: 8644
		[Token(Token = "0x40021C4")]
		private const int DEFAULT_CAPACITY = 3;

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x10")]
		private ListSet<int> m_globalFlags;

		// Token: 0x040021C6 RID: 8646
		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, LRUCache<string, TorappuMemoryPool.Value>> m_cacheGroup;

		// Token: 0x040021C7 RID: 8647
		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040021C8 RID: 8648
		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RequestGroup;

		// Token: 0x040021C9 RID: 8649
		[Token(Token = "0x40021C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DeleteGroup;

		// Token: 0x040021CA RID: 8650
		[Token(Token = "0x40021CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_MarkGlobalFlag;

		// Token: 0x040021CB RID: 8651
		[Token(Token = "0x40021CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeGlobalFlag;

		// Token: 0x02000590 RID: 1424
		[Token(Token = "0x2000590")]
		public class Value
		{
			// Token: 0x06005C1A RID: 23578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C1A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Value()
			{
			}

			// Token: 0x040021CC RID: 8652
			[Token(Token = "0x40021CC")]
			[FieldOffset(Offset = "0x10")]
			public string value;
		}
	}
}
