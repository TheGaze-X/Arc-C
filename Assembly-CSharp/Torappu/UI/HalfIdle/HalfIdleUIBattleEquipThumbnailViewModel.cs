using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x0200675F RID: 26463
	[Token(Token = "0x200675F")]
	public class HalfIdleUIBattleEquipThumbnailViewModel : IHotfixable
	{
		// Token: 0x06025F82 RID: 155522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F82")]
		[Address(RVA = "0x20F48B0", Offset = "0x20F34B0", VA = "0x1820F48B0")]
		public HalfIdleUIBattleEquipThumbnailViewModel()
		{
		}

		// Token: 0x040356A7 RID: 218791
		[Token(Token = "0x40356A7")]
		[FieldOffset(Offset = "0x10")]
		public bool isSelected;

		// Token: 0x040356A8 RID: 218792
		[Token(Token = "0x40356A8")]
		[FieldOffset(Offset = "0x11")]
		public bool ableToEquip;

		// Token: 0x040356A9 RID: 218793
		[Token(Token = "0x40356A9")]
		[FieldOffset(Offset = "0x14")]
		public Act1VHalfIdleEquipType type;

		// Token: 0x040356AA RID: 218794
		[Token(Token = "0x40356AA")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleEquipData currentEquip;

		// Token: 0x040356AB RID: 218795
		[Token(Token = "0x40356AB")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x040356AC RID: 218796
		[Token(Token = "0x40356AC")]
		[FieldOffset(Offset = "0x28")]
		public uint lastEquipUid;

		// Token: 0x040356AD RID: 218797
		[Token(Token = "0x40356AD")]
		[FieldOffset(Offset = "0x30")]
		public Act1VHalfIdleEquipData lastEquipData;

		// Token: 0x040356AE RID: 218798
		[Token(Token = "0x40356AE")]
		[FieldOffset(Offset = "0x38")]
		public int autoUpgradeSeqNum;

		// Token: 0x040356AF RID: 218799
		[Token(Token = "0x40356AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
