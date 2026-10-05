using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D91 RID: 19857
	[Token(Token = "0x2004D91")]
	public class NameCardV2MainlineModuleModel : NameCardV2RemovableModuleBaseModel
	{
		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x0601DB54 RID: 121684 RVA: 0x000AC530 File Offset: 0x000AA730
		[Token(Token = "0x170045A4")]
		public override NameCardV2ModuleSubType moduleSubType
		{
			[Token(Token = "0x601DB54")]
			[Address(RVA = "0x1749460", Offset = "0x1748060", VA = "0x181749460", Slot = "10")]
			get
			{
				return NameCardV2ModuleSubType.NONE;
			}
		}

		// Token: 0x0601DB55 RID: 121685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB55")]
		[Address(RVA = "0x1748CD0", Offset = "0x17478D0", VA = "0x181748CD0", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB56 RID: 121686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB56")]
		[Address(RVA = "0x1748D60", Offset = "0x1747960", VA = "0x181748D60", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB57 RID: 121687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB57")]
		[Address(RVA = "0x1748DD0", Offset = "0x17479D0", VA = "0x181748DD0", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB58 RID: 121688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB58")]
		[Address(RVA = "0x17490C0", Offset = "0x1747CC0", VA = "0x1817490C0")]
		private void _LoadDataByStageData(StageData stageData)
		{
		}

		// Token: 0x0601DB59 RID: 121689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DB59")]
		[Address(RVA = "0x1749300", Offset = "0x1747F00", VA = "0x181749300")]
		private MainlineZoneData _TryFindMainlineZoneData(string mainlineZoneId)
		{
			return null;
		}

		// Token: 0x0601DB5A RID: 121690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DB5A")]
		[Address(RVA = "0x1748E30", Offset = "0x1747A30", VA = "0x181748E30")]
		private ChapterData _GetLatestChapterData()
		{
			return null;
		}

		// Token: 0x0601DB5B RID: 121691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB5B")]
		[Address(RVA = "0x1749400", Offset = "0x1748000", VA = "0x181749400")]
		public NameCardV2MainlineModuleModel()
		{
		}

		// Token: 0x04027433 RID: 160819
		[Token(Token = "0x4027433")]
		private const string CHAPTER_BG_FORMAT = "{0}";

		// Token: 0x04027434 RID: 160820
		[Token(Token = "0x4027434")]
		[FieldOffset(Offset = "0x50")]
		public string chapterEnName;

		// Token: 0x04027435 RID: 160821
		[Token(Token = "0x4027435")]
		[FieldOffset(Offset = "0x58")]
		public string stageCode;

		// Token: 0x04027436 RID: 160822
		[Token(Token = "0x4027436")]
		[FieldOffset(Offset = "0x60")]
		public string chapterTitleBgId;

		// Token: 0x04027437 RID: 160823
		[Token(Token = "0x4027437")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moduleSubType;

		// Token: 0x04027438 RID: 160824
		[Token(Token = "0x4027438")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x04027439 RID: 160825
		[Token(Token = "0x4027439")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x0402743A RID: 160826
		[Token(Token = "0x402743A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x0402743B RID: 160827
		[Token(Token = "0x402743B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadDataByStageData;

		// Token: 0x0402743C RID: 160828
		[Token(Token = "0x402743C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryFindMainlineZoneData;

		// Token: 0x0402743D RID: 160829
		[Token(Token = "0x402743D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetLatestChapterData;

		// Token: 0x0402743E RID: 160830
		[Token(Token = "0x402743E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
