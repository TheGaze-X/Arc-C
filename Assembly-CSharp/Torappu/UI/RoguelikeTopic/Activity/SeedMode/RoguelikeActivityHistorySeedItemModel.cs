using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046AD RID: 18093
	[Token(Token = "0x20046AD")]
	public class RoguelikeActivityHistorySeedItemModel : RoguelikeActivitySeedItemModel
	{
		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x0601B71E RID: 112414 RVA: 0x000A5318 File Offset: 0x000A3518
		[Token(Token = "0x17004151")]
		public override SeedItemType seedItemType
		{
			[Token(Token = "0x601B71E")]
			[Address(RVA = "0x14D3650", Offset = "0x14D2250", VA = "0x1814D3650", Slot = "5")]
			get
			{
				return SeedItemType.NONE;
			}
		}

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x0601B71F RID: 112415 RVA: 0x000A5330 File Offset: 0x000A3530
		[Token(Token = "0x17004152")]
		public override long sortId
		{
			[Token(Token = "0x601B71F")]
			[Address(RVA = "0x14D36C0", Offset = "0x14D22C0", VA = "0x1814D36C0", Slot = "4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0601B720 RID: 112416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B720")]
		[Address(RVA = "0x14D2E50", Offset = "0x14D1A50", VA = "0x1814D2E50")]
		public void LoadData(string topicId, PlayerRoguelikeV2.OuterData.Record.History history)
		{
		}

		// Token: 0x0601B721 RID: 112417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B721")]
		[Address(RVA = "0x14D3330", Offset = "0x14D1F30", VA = "0x1814D3330")]
		private void _LoadEndingDataWhenSuccess(RoguelikeTopicDetail detailData, string endingId)
		{
		}

		// Token: 0x0601B722 RID: 112418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B722")]
		[Address(RVA = "0x14D3280", Offset = "0x14D1E80", VA = "0x1814D3280")]
		private void _LoadEndingDataWhenFail(RoguelikeTopicDetail detailData)
		{
		}

		// Token: 0x0601B723 RID: 112419 RVA: 0x000A5348 File Offset: 0x000A3548
		[Token(Token = "0x601B723")]
		[Address(RVA = "0x14D3420", Offset = "0x14D2020", VA = "0x1814D3420")]
		private bool _TryLoadFailEndingData(RoguelikeTopicDetail detailData, string failEndingId)
		{
			return default(bool);
		}

		// Token: 0x0601B724 RID: 112420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B724")]
		[Address(RVA = "0x14D3590", Offset = "0x14D2190", VA = "0x1814D3590")]
		public RoguelikeActivityHistorySeedItemModel()
		{
		}

		// Token: 0x0402384C RID: 145484
		[Token(Token = "0x402384C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RoguelikeActivityHistorySeedItemModel EMPTY_ITEM;

		// Token: 0x0402384D RID: 145485
		[Token(Token = "0x402384D")]
		private const string DATE_TIME_FORMAT = "yyyy/MM/dd HH:mm";

		// Token: 0x0402384E RID: 145486
		[Token(Token = "0x402384E")]
		[FieldOffset(Offset = "0x20")]
		public string bandId;

		// Token: 0x0402384F RID: 145487
		[Token(Token = "0x402384F")]
		[FieldOffset(Offset = "0x28")]
		public string bandName;

		// Token: 0x04023850 RID: 145488
		[Token(Token = "0x4023850")]
		[FieldOffset(Offset = "0x30")]
		public string modeGradeName;

		// Token: 0x04023851 RID: 145489
		[Token(Token = "0x4023851")]
		[FieldOffset(Offset = "0x38")]
		public int modeGrade;

		// Token: 0x04023852 RID: 145490
		[Token(Token = "0x4023852")]
		[FieldOffset(Offset = "0x40")]
		public string endingName;

		// Token: 0x04023853 RID: 145491
		[Token(Token = "0x4023853")]
		[FieldOffset(Offset = "0x48")]
		public string endTime;

		// Token: 0x04023854 RID: 145492
		[Token(Token = "0x4023854")]
		[FieldOffset(Offset = "0x50")]
		public string topicId;

		// Token: 0x04023855 RID: 145493
		[Token(Token = "0x4023855")]
		[FieldOffset(Offset = "0x58")]
		public RoguelikeGameEndingData endingData;

		// Token: 0x04023856 RID: 145494
		[Token(Token = "0x4023856")]
		[FieldOffset(Offset = "0x60")]
		private long m_ts;

		// Token: 0x04023857 RID: 145495
		[Token(Token = "0x4023857")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_seedItemType;

		// Token: 0x04023858 RID: 145496
		[Token(Token = "0x4023858")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04023859 RID: 145497
		[Token(Token = "0x4023859")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402385A RID: 145498
		[Token(Token = "0x402385A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadEndingDataWhenSuccess;

		// Token: 0x0402385B RID: 145499
		[Token(Token = "0x402385B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadEndingDataWhenFail;

		// Token: 0x0402385C RID: 145500
		[Token(Token = "0x402385C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryLoadFailEndingData;

		// Token: 0x0402385D RID: 145501
		[Token(Token = "0x402385D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
