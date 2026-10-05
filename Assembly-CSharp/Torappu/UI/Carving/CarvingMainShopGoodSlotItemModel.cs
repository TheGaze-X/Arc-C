using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006096 RID: 24726
	[Token(Token = "0x2006096")]
	public class CarvingMainShopGoodSlotItemModel : IHotfixable
	{
		// Token: 0x1700548C RID: 21644
		// (get) Token: 0x06023C68 RID: 146536 RVA: 0x000C1F98 File Offset: 0x000C0198
		// (set) Token: 0x06023C69 RID: 146537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700548C")]
		public int curSlotCnt
		{
			[Token(Token = "0x6023C68")]
			[Address(RVA = "0x1E79CD0", Offset = "0x1E788D0", VA = "0x181E79CD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023C69")]
			[Address(RVA = "0x1E79EB0", Offset = "0x1E78AB0", VA = "0x181E79EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700548D RID: 21645
		// (get) Token: 0x06023C6A RID: 146538 RVA: 0x000C1FB0 File Offset: 0x000C01B0
		// (set) Token: 0x06023C6B RID: 146539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700548D")]
		public int maxSlotCnt
		{
			[Token(Token = "0x6023C6A")]
			[Address(RVA = "0x1E79DF0", Offset = "0x1E789F0", VA = "0x181E79DF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023C6B")]
			[Address(RVA = "0x1E7A000", Offset = "0x1E78C00", VA = "0x181E7A000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700548E RID: 21646
		// (get) Token: 0x06023C6C RID: 146540 RVA: 0x000C1FC8 File Offset: 0x000C01C8
		// (set) Token: 0x06023C6D RID: 146541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700548E")]
		public int price
		{
			[Token(Token = "0x6023C6C")]
			[Address(RVA = "0x1E79E50", Offset = "0x1E78A50", VA = "0x181E79E50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023C6D")]
			[Address(RVA = "0x1E7A070", Offset = "0x1E78C70", VA = "0x181E7A070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700548F RID: 21647
		// (get) Token: 0x06023C6E RID: 146542 RVA: 0x000C1FE0 File Offset: 0x000C01E0
		// (set) Token: 0x06023C6F RID: 146543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700548F")]
		public bool isEmpty
		{
			[Token(Token = "0x6023C6E")]
			[Address(RVA = "0x1E79D30", Offset = "0x1E78930", VA = "0x181E79D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6023C6F")]
			[Address(RVA = "0x1E79F20", Offset = "0x1E78B20", VA = "0x181E79F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005490 RID: 21648
		// (get) Token: 0x06023C70 RID: 146544 RVA: 0x000C1FF8 File Offset: 0x000C01F8
		// (set) Token: 0x06023C71 RID: 146545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005490")]
		public bool isSelect
		{
			[Token(Token = "0x6023C70")]
			[Address(RVA = "0x1E79D90", Offset = "0x1E78990", VA = "0x181E79D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6023C71")]
			[Address(RVA = "0x1E79F90", Offset = "0x1E78B90", VA = "0x181E79F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06023C72 RID: 146546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C72")]
		[Address(RVA = "0x1E799A0", Offset = "0x1E785A0", VA = "0x181E799A0")]
		public void SetData(int iCurSlotCnt, int iMaxSlotCnt, int iCoin)
		{
		}

		// Token: 0x06023C73 RID: 146547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C73")]
		[Address(RVA = "0x1E79BF0", Offset = "0x1E787F0", VA = "0x181E79BF0")]
		public void SetSelect(bool isSelect)
		{
		}

		// Token: 0x06023C74 RID: 146548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C74")]
		[Address(RVA = "0x1E79C70", Offset = "0x1E78870", VA = "0x181E79C70")]
		public CarvingMainShopGoodSlotItemModel()
		{
		}

		// Token: 0x04031998 RID: 203160
		[Token(Token = "0x4031998")]
		private const int EMPTY_COIN_PRICE = -1;

		// Token: 0x0403199E RID: 203166
		[Token(Token = "0x403199E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curSlotCnt;

		// Token: 0x0403199F RID: 203167
		[Token(Token = "0x403199F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curSlotCnt;

		// Token: 0x040319A0 RID: 203168
		[Token(Token = "0x40319A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxSlotCnt;

		// Token: 0x040319A1 RID: 203169
		[Token(Token = "0x40319A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_maxSlotCnt;

		// Token: 0x040319A2 RID: 203170
		[Token(Token = "0x40319A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_price;

		// Token: 0x040319A3 RID: 203171
		[Token(Token = "0x40319A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_price;

		// Token: 0x040319A4 RID: 203172
		[Token(Token = "0x40319A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x040319A5 RID: 203173
		[Token(Token = "0x40319A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isEmpty;

		// Token: 0x040319A6 RID: 203174
		[Token(Token = "0x40319A6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isSelect;

		// Token: 0x040319A7 RID: 203175
		[Token(Token = "0x40319A7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isSelect;

		// Token: 0x040319A8 RID: 203176
		[Token(Token = "0x40319A8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040319A9 RID: 203177
		[Token(Token = "0x40319A9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x040319AA RID: 203178
		[Token(Token = "0x40319AA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
