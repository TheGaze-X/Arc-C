using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020069FA RID: 27130
	[Token(Token = "0x20069FA")]
	public class CampaignZoneViewModel : ZoneViewModel
	{
		// Token: 0x06026CB7 RID: 158903 RVA: 0x000CC660 File Offset: 0x000CA860
		[Token(Token = "0x6026CB7")]
		[Address(RVA = "0x21D1FB0", Offset = "0x21D0BB0", VA = "0x1821D1FB0", Slot = "10")]
		public override int CompareTo(ZoneViewModel otherModel)
		{
			return 0;
		}

		// Token: 0x06026CB8 RID: 158904 RVA: 0x000CC678 File Offset: 0x000CA878
		[Token(Token = "0x6026CB8")]
		[Address(RVA = "0x21D2110", Offset = "0x21D0D10", VA = "0x1821D2110")]
		public bool ContainsCampaignStage(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06026CB9 RID: 158905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CB9")]
		[Address(RVA = "0x21D2180", Offset = "0x21D0D80", VA = "0x1821D2180", Slot = "11")]
		public override void LoadExtraData(string zoneId)
		{
		}

		// Token: 0x06026CBA RID: 158906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CBA")]
		[Address(RVA = "0x21D2170", Offset = "0x21D0D70", VA = "0x1821D2170", Slot = "12")]
		public override void LateInitAfterStageLoaded()
		{
		}

		// Token: 0x06026CBB RID: 158907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CBB")]
		[Address(RVA = "0x21D2190", Offset = "0x21D0D90", VA = "0x1821D2190")]
		public void RefreshData()
		{
		}

		// Token: 0x06026CBC RID: 158908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CBC")]
		[Address(RVA = "0x21D21B0", Offset = "0x21D0DB0", VA = "0x1821D21B0")]
		private void _LoadCampaignCommonData()
		{
		}

		// Token: 0x06026CBD RID: 158909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CBD")]
		[Address(RVA = "0x21D22E0", Offset = "0x21D0EE0", VA = "0x1821D22E0")]
		private void _LoadCampaignInstanceData()
		{
		}

		// Token: 0x06026CBE RID: 158910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CBE")]
		[Address(RVA = "0x21D2530", Offset = "0x21D1130", VA = "0x1821D2530")]
		public CampaignZoneViewModel()
		{
		}

		// Token: 0x04036CEB RID: 224491
		[Token(Token = "0x4036CEB")]
		[FieldOffset(Offset = "0x90")]
		public ListDict<string, CampaignViewModel> campaigns;

		// Token: 0x04036CEC RID: 224492
		[Token(Token = "0x4036CEC")]
		[FieldOffset(Offset = "0x98")]
		public int campaignTotalFee;

		// Token: 0x04036CED RID: 224493
		[Token(Token = "0x4036CED")]
		[FieldOffset(Offset = "0x9C")]
		public int campaignCurrentFee;

		// Token: 0x04036CEE RID: 224494
		[Token(Token = "0x4036CEE")]
		[FieldOffset(Offset = "0xA0")]
		public CampaignZoneViewModel.CampaignGroupViewModel currentActiveGroup;

		// Token: 0x020069FB RID: 27131
		[Token(Token = "0x20069FB")]
		public class CampaignGroupViewModel
		{
			// Token: 0x06026CBF RID: 158911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026CBF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CampaignGroupViewModel()
			{
			}

			// Token: 0x04036CEF RID: 224495
			[Token(Token = "0x4036CEF")]
			[FieldOffset(Offset = "0x10")]
			public DateTime nextRefreshDateTime;
		}
	}
}
