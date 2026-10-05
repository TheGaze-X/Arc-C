using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C02 RID: 15362
	[Token(Token = "0x2003C02")]
	public class UniEquipArchiveCollectionEquipInfoData : IHotfixable
	{
		// Token: 0x06018063 RID: 98403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018063")]
		[Address(RVA = "0x1079720", Offset = "0x1078320", VA = "0x181079720")]
		public UniEquipArchiveCollectionEquipInfoData()
		{
		}

		// Token: 0x0401D202 RID: 119298
		[Token(Token = "0x401D202")]
		[FieldOffset(Offset = "0x10")]
		public EntryCollectionEquipItemShowState showState;

		// Token: 0x0401D203 RID: 119299
		[Token(Token = "0x401D203")]
		[FieldOffset(Offset = "0x14")]
		public EntryCollectionEquipItemUnlockState unlockState;

		// Token: 0x0401D204 RID: 119300
		[Token(Token = "0x401D204")]
		[FieldOffset(Offset = "0x18")]
		public int playerInstId;

		// Token: 0x0401D205 RID: 119301
		[Token(Token = "0x401D205")]
		[FieldOffset(Offset = "0x20")]
		public string currentTmplId;

		// Token: 0x0401D206 RID: 119302
		[Token(Token = "0x401D206")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
