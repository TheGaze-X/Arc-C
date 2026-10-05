using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066C7 RID: 26311
	[Token(Token = "0x20066C7")]
	public class HandBookStageViewModel : IHotfixable
	{
		// Token: 0x06025C7B RID: 154747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C7B")]
		[Address(RVA = "0x20BDF40", Offset = "0x20BCB40", VA = "0x1820BDF40")]
		public void InitData(HandbookStoryStageData inputData, int chrinstID)
		{
		}

		// Token: 0x06025C7C RID: 154748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C7C")]
		[Address(RVA = "0x20BE320", Offset = "0x20BCF20", VA = "0x1820BE320")]
		public HandBookStageViewModel()
		{
		}

		// Token: 0x040351C1 RID: 217537
		[Token(Token = "0x40351C1")]
		[FieldOffset(Offset = "0x10")]
		public HandbookStoryStageData data;

		// Token: 0x040351C2 RID: 217538
		[Token(Token = "0x40351C2")]
		[FieldOffset(Offset = "0x18")]
		public List<HandBookUnlockInfo> unlockInfo;

		// Token: 0x040351C3 RID: 217539
		[Token(Token = "0x40351C3")]
		[FieldOffset(Offset = "0x20")]
		public bool isUnlock;

		// Token: 0x040351C4 RID: 217540
		[Token(Token = "0x40351C4")]
		[FieldOffset(Offset = "0x28")]
		public PlayerHandBookAddon.GetInfo addon;

		// Token: 0x040351C5 RID: 217541
		[Token(Token = "0x40351C5")]
		[FieldOffset(Offset = "0x30")]
		public CharUISkinStruct skin;

		// Token: 0x040351C6 RID: 217542
		[Token(Token = "0x40351C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040351C7 RID: 217543
		[Token(Token = "0x40351C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
