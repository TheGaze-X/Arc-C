using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069BA RID: 27066
	[Token(Token = "0x20069BA")]
	public class StageZoneTabGroupViewModel : IHotfixable
	{
		// Token: 0x06026BC1 RID: 158657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BC1")]
		[Address(RVA = "0x21D7F60", Offset = "0x21D6B60", VA = "0x1821D7F60")]
		public void LoadData(StageStateBean stageStateBean)
		{
		}

		// Token: 0x06026BC2 RID: 158658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026BC2")]
		[Address(RVA = "0x21D8A00", Offset = "0x21D7600", VA = "0x1821D8A00")]
		private static StageSeasonTabViewModel _LoadSeasonTab()
		{
			return null;
		}

		// Token: 0x06026BC3 RID: 158659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026BC3")]
		[Address(RVA = "0x21D86B0", Offset = "0x21D72B0", VA = "0x1821D86B0")]
		private static StageCampaignTabViewModel _LoadCampaignTab()
		{
			return null;
		}

		// Token: 0x06026BC4 RID: 158660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026BC4")]
		[Address(RVA = "0x21D8930", Offset = "0x21D7530", VA = "0x1821D8930")]
		private static StagePermModeTabViewModel _LoadPermModeTab()
		{
			return null;
		}

		// Token: 0x06026BC5 RID: 158661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026BC5")]
		[Address(RVA = "0x21D8780", Offset = "0x21D7380", VA = "0x1821D8780")]
		private static StageZoneTabViewModel _LoadMixStoryTab(StageStateBean stageStateBean)
		{
			return null;
		}

		// Token: 0x06026BC6 RID: 158662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BC6")]
		[Address(RVA = "0x21D8540", Offset = "0x21D7140", VA = "0x1821D8540")]
		public void ReloadCrisisTab()
		{
		}

		// Token: 0x06026BC7 RID: 158663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BC7")]
		[Address(RVA = "0x21D84D0", Offset = "0x21D70D0", VA = "0x1821D84D0")]
		public void ReloadCampaignTab()
		{
		}

		// Token: 0x06026BC8 RID: 158664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BC8")]
		[Address(RVA = "0x21D85B0", Offset = "0x21D71B0", VA = "0x1821D85B0")]
		public void UpdateStatus(ZoneViewProperty selectedZoneProp)
		{
		}

		// Token: 0x06026BC9 RID: 158665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BC9")]
		[Address(RVA = "0x21D8C00", Offset = "0x21D7800", VA = "0x1821D8C00")]
		public StageZoneTabGroupViewModel()
		{
		}

		// Token: 0x04036B1B RID: 224027
		[Token(Token = "0x4036B1B")]
		[FieldOffset(Offset = "0x10")]
		public StageZoneTabViewModel homeTab;

		// Token: 0x04036B1C RID: 224028
		[Token(Token = "0x4036B1C")]
		[FieldOffset(Offset = "0x18")]
		public StageZoneTabViewModel weeklyTab;

		// Token: 0x04036B1D RID: 224029
		[Token(Token = "0x4036B1D")]
		[FieldOffset(Offset = "0x20")]
		public StageZoneTabViewModel campaignTab;

		// Token: 0x04036B1E RID: 224030
		[Token(Token = "0x4036B1E")]
		[FieldOffset(Offset = "0x28")]
		public StageZoneTabViewModel mixStoryTab;

		// Token: 0x04036B1F RID: 224031
		[Token(Token = "0x4036B1F")]
		[FieldOffset(Offset = "0x30")]
		public StageSeasonTabViewModel crisisTab;

		// Token: 0x04036B20 RID: 224032
		[Token(Token = "0x4036B20")]
		[FieldOffset(Offset = "0x38")]
		public StagePermModeTabViewModel permModeTab;

		// Token: 0x04036B21 RID: 224033
		[Token(Token = "0x4036B21")]
		[FieldOffset(Offset = "0x40")]
		public bool isBlack;

		// Token: 0x04036B22 RID: 224034
		[Token(Token = "0x4036B22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036B23 RID: 224035
		[Token(Token = "0x4036B23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSeasonTab;

		// Token: 0x04036B24 RID: 224036
		[Token(Token = "0x4036B24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadCampaignTab;

		// Token: 0x04036B25 RID: 224037
		[Token(Token = "0x4036B25")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadPermModeTab;

		// Token: 0x04036B26 RID: 224038
		[Token(Token = "0x4036B26")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadMixStoryTab;

		// Token: 0x04036B27 RID: 224039
		[Token(Token = "0x4036B27")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReloadCrisisTab;

		// Token: 0x04036B28 RID: 224040
		[Token(Token = "0x4036B28")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReloadCampaignTab;

		// Token: 0x04036B29 RID: 224041
		[Token(Token = "0x4036B29")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04036B2A RID: 224042
		[Token(Token = "0x4036B2A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
