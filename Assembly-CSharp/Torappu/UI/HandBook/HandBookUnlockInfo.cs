using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066C8 RID: 26312
	[Token(Token = "0x20066C8")]
	public class HandBookUnlockInfo : IHotfixable
	{
		// Token: 0x17005987 RID: 22919
		// (get) Token: 0x06025C7D RID: 154749 RVA: 0x000C9120 File Offset: 0x000C7320
		[Token(Token = "0x17005987")]
		public bool isUnlock
		{
			[Token(Token = "0x6025C7D")]
			[Address(RVA = "0x20BE720", Offset = "0x20BD320", VA = "0x1820BE720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C7E RID: 154750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C7E")]
		[Address(RVA = "0x20BE6C0", Offset = "0x20BD2C0", VA = "0x1820BE6C0")]
		public HandBookUnlockInfo()
		{
		}

		// Token: 0x040351C8 RID: 217544
		[Token(Token = "0x40351C8")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x040351C9 RID: 217545
		[Token(Token = "0x40351C9")]
		[FieldOffset(Offset = "0x18")]
		public HandbookUnlockParam unlockParam;

		// Token: 0x040351CA RID: 217546
		[Token(Token = "0x40351CA")]
		[FieldOffset(Offset = "0x20")]
		public string overrideString;

		// Token: 0x040351CB RID: 217547
		[Token(Token = "0x40351CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x040351CC RID: 217548
		[Token(Token = "0x40351CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
