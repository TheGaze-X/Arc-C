using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006983 RID: 27011
	[Token(Token = "0x2006983")]
	public class StageZoneGroupPanelHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B35 RID: 23349
		// (get) Token: 0x06026A5E RID: 158302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B35")]
		public StageZoneWeeklyGroupPanel weeklyGroupPrefab
		{
			[Token(Token = "0x6026A5E")]
			[Address(RVA = "0x21BECC0", Offset = "0x21BD8C0", VA = "0x1821BECC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B36 RID: 23350
		// (get) Token: 0x06026A5F RID: 158303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B36")]
		public StageZoneHomeMainGroupPanel homeGroupPrefab
		{
			[Token(Token = "0x6026A5F")]
			[Address(RVA = "0x21BEB40", Offset = "0x21BD740", VA = "0x1821BEB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B37 RID: 23351
		// (get) Token: 0x06026A60 RID: 158304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B37")]
		public StageZoneCampaignGroupPanel campaignGroupPrefab
		{
			[Token(Token = "0x6026A60")]
			[Address(RVA = "0x21BEAE0", Offset = "0x21BD6E0", VA = "0x1821BEAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B38 RID: 23352
		// (get) Token: 0x06026A61 RID: 158305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B38")]
		public StageZoneMixStoryGroupPanel mixStoryGroupPrefab
		{
			[Token(Token = "0x6026A61")]
			[Address(RVA = "0x21BEBA0", Offset = "0x21BD7A0", VA = "0x1821BEBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B39 RID: 23353
		// (get) Token: 0x06026A62 RID: 158306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B39")]
		public StageZonePermModeGroupPanel permModeGroupPrefab
		{
			[Token(Token = "0x6026A62")]
			[Address(RVA = "0x21BEC00", Offset = "0x21BD800", VA = "0x1821BEC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B3A RID: 23354
		// (get) Token: 0x06026A63 RID: 158307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B3A")]
		public StageZoneSeasonGroupPanel seasonGroupPanel
		{
			[Token(Token = "0x6026A63")]
			[Address(RVA = "0x21BEC60", Offset = "0x21BD860", VA = "0x1821BEC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026A64 RID: 158308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A64")]
		[Address(RVA = "0x21BEA80", Offset = "0x21BD680", VA = "0x1821BEA80")]
		public StageZoneGroupPanelHolder()
		{
		}

		// Token: 0x04036907 RID: 223495
		[Token(Token = "0x4036907")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageZoneMixStoryGroupPanel _mixStoryGroup;

		// Token: 0x04036908 RID: 223496
		[Token(Token = "0x4036908")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageZoneWeeklyGroupPanel _weeklyGroup;

		// Token: 0x04036909 RID: 223497
		[Token(Token = "0x4036909")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StageZoneHomeMainGroupPanel _homeGroup;

		// Token: 0x0403690A RID: 223498
		[Token(Token = "0x403690A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StageZoneCampaignGroupPanel _campaignGroup;

		// Token: 0x0403690B RID: 223499
		[Token(Token = "0x403690B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StageZonePermModeGroupPanel _permModeGroup;

		// Token: 0x0403690C RID: 223500
		[Token(Token = "0x403690C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StageZoneSeasonGroupPanel _seasonGroup;

		// Token: 0x0403690D RID: 223501
		[Token(Token = "0x403690D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_weeklyGroupPrefab;

		// Token: 0x0403690E RID: 223502
		[Token(Token = "0x403690E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeGroupPrefab;

		// Token: 0x0403690F RID: 223503
		[Token(Token = "0x403690F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_campaignGroupPrefab;

		// Token: 0x04036910 RID: 223504
		[Token(Token = "0x4036910")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_mixStoryGroupPrefab;

		// Token: 0x04036911 RID: 223505
		[Token(Token = "0x4036911")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_permModeGroupPrefab;

		// Token: 0x04036912 RID: 223506
		[Token(Token = "0x4036912")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_seasonGroupPanel;

		// Token: 0x04036913 RID: 223507
		[Token(Token = "0x4036913")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
