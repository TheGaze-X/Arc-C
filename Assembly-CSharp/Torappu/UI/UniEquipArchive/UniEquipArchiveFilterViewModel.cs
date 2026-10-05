using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BD1 RID: 15313
	[Token(Token = "0x2003BD1")]
	public class UniEquipArchiveFilterViewModel : IHotfixable
	{
		// Token: 0x06017F7E RID: 98174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F7E")]
		[Address(RVA = "0x1064BA0", Offset = "0x10637A0", VA = "0x181064BA0")]
		public void InitData()
		{
		}

		// Token: 0x06017F7F RID: 98175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F7F")]
		[Address(RVA = "0x1064C00", Offset = "0x1063800", VA = "0x181064C00")]
		public UniEquipArchiveFilterViewModel()
		{
		}

		// Token: 0x0401D038 RID: 118840
		[Token(Token = "0x401D038")]
		[FieldOffset(Offset = "0x10")]
		public bool showTrack;

		// Token: 0x0401D039 RID: 118841
		[Token(Token = "0x401D039")]
		[FieldOffset(Offset = "0x14")]
		public UniEquipArchiveFilterEquipState equipUnlockState;

		// Token: 0x0401D03A RID: 118842
		[Token(Token = "0x401D03A")]
		[FieldOffset(Offset = "0x18")]
		public int fastSeq;

		// Token: 0x0401D03B RID: 118843
		[Token(Token = "0x401D03B")]
		[FieldOffset(Offset = "0x1C")]
		public int trackNum;

		// Token: 0x0401D03C RID: 118844
		[Token(Token = "0x401D03C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401D03D RID: 118845
		[Token(Token = "0x401D03D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
