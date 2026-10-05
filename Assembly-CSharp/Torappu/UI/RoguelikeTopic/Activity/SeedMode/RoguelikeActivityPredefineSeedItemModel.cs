using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046AE RID: 18094
	[Token(Token = "0x20046AE")]
	public class RoguelikeActivityPredefineSeedItemModel : RoguelikeActivitySeedItemModel
	{
		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x0601B726 RID: 112422 RVA: 0x000A5360 File Offset: 0x000A3560
		[Token(Token = "0x17004153")]
		public override SeedItemType seedItemType
		{
			[Token(Token = "0x601B726")]
			[Address(RVA = "0x14D3920", Offset = "0x14D2520", VA = "0x1814D3920", Slot = "5")]
			get
			{
				return SeedItemType.NONE;
			}
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x0601B727 RID: 112423 RVA: 0x000A5378 File Offset: 0x000A3578
		[Token(Token = "0x17004154")]
		public override long sortId
		{
			[Token(Token = "0x601B727")]
			[Address(RVA = "0x14D3990", Offset = "0x14D2590", VA = "0x1814D3990", Slot = "4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0601B728 RID: 112424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B728")]
		[Address(RVA = "0x14D3730", Offset = "0x14D2330", VA = "0x1814D3730")]
		public void LoadData(RoguelikeActivitySeedModeData.RoguelikeActivityOfficialSeedData predefine)
		{
		}

		// Token: 0x0601B729 RID: 112425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B729")]
		[Address(RVA = "0x14D3860", Offset = "0x14D2460", VA = "0x1814D3860")]
		public RoguelikeActivityPredefineSeedItemModel()
		{
		}

		// Token: 0x0402385E RID: 145502
		[Token(Token = "0x402385E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RoguelikeActivityPredefineSeedItemModel EMPTY_ITEM;

		// Token: 0x0402385F RID: 145503
		[Token(Token = "0x402385F")]
		[FieldOffset(Offset = "0x20")]
		public string predefineDesc;

		// Token: 0x04023860 RID: 145504
		[Token(Token = "0x4023860")]
		[FieldOffset(Offset = "0x28")]
		private long m_sortId;

		// Token: 0x04023861 RID: 145505
		[Token(Token = "0x4023861")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_seedItemType;

		// Token: 0x04023862 RID: 145506
		[Token(Token = "0x4023862")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04023863 RID: 145507
		[Token(Token = "0x4023863")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04023864 RID: 145508
		[Token(Token = "0x4023864")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
