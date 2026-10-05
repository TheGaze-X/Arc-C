using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047EA RID: 18410
	[Token(Token = "0x20047EA")]
	public class MonopolyEntryModel : IHotfixable
	{
		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x0601BD98 RID: 114072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004238")]
		public MonopolyEntryStageModel curStageModel
		{
			[Token(Token = "0x601BD98")]
			[Address(RVA = "0x1524800", Offset = "0x1523400", VA = "0x181524800")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BD99 RID: 114073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD99")]
		[Address(RVA = "0x1523DD0", Offset = "0x15229D0", VA = "0x181523DD0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601BD9A RID: 114074 RVA: 0x000A66E0 File Offset: 0x000A48E0
		[Token(Token = "0x601BD9A")]
		[Address(RVA = "0x1524400", Offset = "0x1523000", VA = "0x181524400")]
		public bool TryLeft()
		{
			return default(bool);
		}

		// Token: 0x0601BD9B RID: 114075 RVA: 0x000A66F8 File Offset: 0x000A48F8
		[Token(Token = "0x601BD9B")]
		[Address(RVA = "0x1524480", Offset = "0x1523080", VA = "0x181524480")]
		public bool TryRight()
		{
			return default(bool);
		}

		// Token: 0x0601BD9C RID: 114076 RVA: 0x000A6710 File Offset: 0x000A4910
		[Token(Token = "0x601BD9C")]
		[Address(RVA = "0x1524530", Offset = "0x1523130", VA = "0x181524530")]
		private bool _CheckCurHasNewInRight()
		{
			return default(bool);
		}

		// Token: 0x0601BD9D RID: 114077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD9D")]
		[Address(RVA = "0x1524630", Offset = "0x1523230", VA = "0x181524630")]
		private void _ConsumeCurStageNew()
		{
		}

		// Token: 0x0601BD9E RID: 114078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD9E")]
		[Address(RVA = "0x1524750", Offset = "0x1523350", VA = "0x181524750")]
		public MonopolyEntryModel()
		{
		}

		// Token: 0x040243E5 RID: 148453
		[Token(Token = "0x40243E5")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, MonopolyEntryStageModel> stageModelList;

		// Token: 0x040243E6 RID: 148454
		[Token(Token = "0x40243E6")]
		[FieldOffset(Offset = "0x18")]
		public int curIndex;

		// Token: 0x040243E7 RID: 148455
		[Token(Token = "0x40243E7")]
		[FieldOffset(Offset = "0x1C")]
		public int maxIndex;

		// Token: 0x040243E8 RID: 148456
		[Token(Token = "0x40243E8")]
		[FieldOffset(Offset = "0x20")]
		public int playingMissionCnt;

		// Token: 0x040243E9 RID: 148457
		[Token(Token = "0x40243E9")]
		[FieldOffset(Offset = "0x28")]
		public string playingStageId;

		// Token: 0x040243EA RID: 148458
		[Token(Token = "0x40243EA")]
		[FieldOffset(Offset = "0x30")]
		public bool hasNewCurInRight;

		// Token: 0x040243EB RID: 148459
		[Token(Token = "0x40243EB")]
		[FieldOffset(Offset = "0x38")]
		public string actId;

		// Token: 0x040243EC RID: 148460
		[Token(Token = "0x40243EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curStageModel;

		// Token: 0x040243ED RID: 148461
		[Token(Token = "0x40243ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040243EE RID: 148462
		[Token(Token = "0x40243EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryLeft;

		// Token: 0x040243EF RID: 148463
		[Token(Token = "0x40243EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryRight;

		// Token: 0x040243F0 RID: 148464
		[Token(Token = "0x40243F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckCurHasNewInRight;

		// Token: 0x040243F1 RID: 148465
		[Token(Token = "0x40243F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ConsumeCurStageNew;

		// Token: 0x040243F2 RID: 148466
		[Token(Token = "0x40243F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
