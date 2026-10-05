using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CampaignDB")]
	[Serializable]
	public class CampaignDB : ConstTable<CampaignTable, CampaignDB>
	{
		// Token: 0x060060B9 RID: 24761 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
		[Token(Token = "0x60060B9")]
		[Address(RVA = "0x1CE6EE0", Offset = "0x1CE5AE0", VA = "0x181CE6EE0")]
		public bool BattleOnly_TryGetCampaign(string stageId, out CampaignData campaignData)
		{
			return default(bool);
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x0002F6E8 File Offset: 0x0002D8E8
		[Token(Token = "0x60060BA")]
		[Address(RVA = "0x1CE78A0", Offset = "0x1CE64A0", VA = "0x181CE78A0")]
		public bool SDCOnly_TryGetCampaign(string stageId, out CampaignData campaignData)
		{
			return default(bool);
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x0002F700 File Offset: 0x0002D900
		[Token(Token = "0x60060BB")]
		[Address(RVA = "0x1CE77D0", Offset = "0x1CE63D0", VA = "0x181CE77D0")]
		public bool SDCOnly_TryGetCampaignGroup(string campGroupId, out CampaignGroupData campGroupData)
		{
			return default(bool);
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BC")]
		[Address(RVA = "0x1CE7070", Offset = "0x1CE5C70", VA = "0x181CE7070")]
		public CampaignData GetCampaignData(string stageId)
		{
			return null;
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BD")]
		[Address(RVA = "0x1CE76F0", Offset = "0x1CE62F0", VA = "0x181CE76F0")]
		public CampaignZoneData GetZoneData(string zoneId)
		{
			return null;
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BE")]
		[Address(RVA = "0x1CE7280", Offset = "0x1CE5E80", VA = "0x181CE7280")]
		public CampaignRegionData GetRegionData(string regionId)
		{
			return null;
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BF")]
		[Address(RVA = "0x1CE7360", Offset = "0x1CE5F60", VA = "0x181CE7360")]
		public CampaignRotateOpenTimeData GetRotateGroup(string groupId)
		{
			return null;
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C0")]
		[Address(RVA = "0x1CE7150", Offset = "0x1CE5D50", VA = "0x181CE7150")]
		public CampaignRotateOpenTimeData GetPreviousRotateGroup(string curGroupId)
		{
			return null;
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C1")]
		[Address(RVA = "0x1CE75C0", Offset = "0x1CE61C0", VA = "0x181CE75C0")]
		public CampaignTrainingOpenTimeData GetTrainingGroup(string groupId)
		{
			return null;
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C2")]
		[Address(RVA = "0x1CE7490", Offset = "0x1CE6090", VA = "0x181CE7490")]
		public CampaignTrainingAllOpenTimeData GetTrainingAllOpenGroup(string groupId)
		{
			return null;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x0002F718 File Offset: 0x0002D918
		[Token(Token = "0x60060C3")]
		[Address(RVA = "0x1CE7970", Offset = "0x1CE6570", VA = "0x181CE7970")]
		public bool TryGetNextTrainingGroupOrAllOpenGroup(long endTs, out CampaignTrainingOpenTimeData nextTrainingGroup, out CampaignTrainingAllOpenTimeData nextAllOpenGroup)
		{
			return default(bool);
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x0002F730 File Offset: 0x0002D930
		[Token(Token = "0x60060C4")]
		[Address(RVA = "0x1CE6FB0", Offset = "0x1CE5BB0", VA = "0x181CE6FB0")]
		public long CalcTrainingGroupEndTs(CampaignTrainingOpenTimeData curTrainingGroup)
		{
			return 0L;
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C5")]
		[Address(RVA = "0x1CE7B90", Offset = "0x1CE6790", VA = "0x181CE7B90")]
		public CampaignDB()
		{
		}

		// Token: 0x04002A38 RID: 10808
		[Token(Token = "0x4002A38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BattleOnly_TryGetCampaign;

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SDCOnly_TryGetCampaign;

		// Token: 0x04002A3A RID: 10810
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SDCOnly_TryGetCampaignGroup;

		// Token: 0x04002A3B RID: 10811
		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCampaignData;

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetZoneData;

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRegionData;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetRotateGroup;

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPreviousRotateGroup;

		// Token: 0x04002A40 RID: 10816
		[Token(Token = "0x4002A40")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetTrainingGroup;

		// Token: 0x04002A41 RID: 10817
		[Token(Token = "0x4002A41")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetTrainingAllOpenGroup;

		// Token: 0x04002A42 RID: 10818
		[Token(Token = "0x4002A42")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryGetNextTrainingGroupOrAllOpenGroup;

		// Token: 0x04002A43 RID: 10819
		[Token(Token = "0x4002A43")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CalcTrainingGroupEndTs;

		// Token: 0x04002A44 RID: 10820
		[Token(Token = "0x4002A44")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
