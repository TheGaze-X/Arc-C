using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066C9 RID: 26313
	[Token(Token = "0x20066C9")]
	public class HandBookAvgGroupViewModel : IHotfixable
	{
		// Token: 0x17005988 RID: 22920
		// (get) Token: 0x06025C7F RID: 154751 RVA: 0x000C9138 File Offset: 0x000C7338
		[Token(Token = "0x17005988")]
		public bool isGet
		{
			[Token(Token = "0x6025C7F")]
			[Address(RVA = "0x20B7A80", Offset = "0x20B6680", VA = "0x1820B7A80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C80 RID: 154752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C80")]
		[Address(RVA = "0x20B77F0", Offset = "0x20B63F0", VA = "0x1820B77F0")]
		public void InitData(HandbookAvgGroupData groupData)
		{
		}

		// Token: 0x06025C81 RID: 154753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C81")]
		[Address(RVA = "0x20B76B0", Offset = "0x20B62B0", VA = "0x1820B76B0")]
		public HandbookAvgData FindAvgData(string storyId)
		{
			return null;
		}

		// Token: 0x06025C82 RID: 154754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C82")]
		[Address(RVA = "0x20B7A20", Offset = "0x20B6620", VA = "0x1820B7A20")]
		public HandBookAvgGroupViewModel()
		{
		}

		// Token: 0x040351CD RID: 217549
		[Token(Token = "0x40351CD")]
		[FieldOffset(Offset = "0x10")]
		public HandbookAvgGroupData data;

		// Token: 0x040351CE RID: 217550
		[Token(Token = "0x40351CE")]
		[FieldOffset(Offset = "0x18")]
		public bool isAvail;

		// Token: 0x040351CF RID: 217551
		[Token(Token = "0x40351CF")]
		[FieldOffset(Offset = "0x20")]
		public List<HandBookUnlockInfo> unlockList;

		// Token: 0x040351D0 RID: 217552
		[Token(Token = "0x40351D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isGet;

		// Token: 0x040351D1 RID: 217553
		[Token(Token = "0x40351D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040351D2 RID: 217554
		[Token(Token = "0x40351D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindAvgData;

		// Token: 0x040351D3 RID: 217555
		[Token(Token = "0x40351D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
