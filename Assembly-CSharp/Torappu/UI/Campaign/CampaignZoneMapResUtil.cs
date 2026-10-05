using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006130 RID: 24880
	[Token(Token = "0x2006130")]
	public class CampaignZoneMapResUtil : IHotfixable
	{
		// Token: 0x06023ED1 RID: 147153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023ED1")]
		[Address(RVA = "0x1E94D20", Offset = "0x1E93920", VA = "0x181E94D20")]
		public static Sprite LoadCampaignStageRes(ILoadAsset loader, string stageId)
		{
			return null;
		}

		// Token: 0x06023ED2 RID: 147154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023ED2")]
		[Address(RVA = "0x1E94DF0", Offset = "0x1E939F0", VA = "0x181E94DF0")]
		public static Sprite LoadCampaignZoneMapBkg(ILoadAsset loader, string zoneId)
		{
			return null;
		}

		// Token: 0x06023ED3 RID: 147155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ED3")]
		[Address(RVA = "0x1E94EC0", Offset = "0x1E93AC0", VA = "0x181E94EC0")]
		public CampaignZoneMapResUtil()
		{
		}

		// Token: 0x04031DE5 RID: 204261
		[Token(Token = "0x4031DE5")]
		private const string ZONE_MAP_BKG_FORMAT = "bkg_{0}";

		// Token: 0x04031DE6 RID: 204262
		[Token(Token = "0x4031DE6")]
		private const string ZONE_MAP_STAGE_ICON_FORMAT = "icon_{0}";

		// Token: 0x04031DE7 RID: 204263
		[Token(Token = "0x4031DE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCampaignStageRes;

		// Token: 0x04031DE8 RID: 204264
		[Token(Token = "0x4031DE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadCampaignZoneMapBkg;

		// Token: 0x04031DE9 RID: 204265
		[Token(Token = "0x4031DE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
