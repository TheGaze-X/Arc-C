using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200610D RID: 24845
	[Token(Token = "0x200610D")]
	public class CampaignWorldRegionHolder : CampaignWorldObjectHolder<CampaignWorldRegionView, CampaignWorldRegionHolder.Config>
	{
		// Token: 0x06023E64 RID: 147044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E64")]
		[Address(RVA = "0x1E8D780", Offset = "0x1E8C380", VA = "0x181E8D780")]
		public CampaignWorldRegionHolder()
		{
		}

		// Token: 0x04031D09 RID: 204041
		[Token(Token = "0x4031D09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200610E RID: 24846
		[Token(Token = "0x200610E")]
		[Serializable]
		public class Config
		{
			// Token: 0x06023E65 RID: 147045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023E65")]
			[Address(RVA = "0x1E9AB00", Offset = "0x1E99700", VA = "0x181E9AB00")]
			public Config()
			{
			}

			// Token: 0x04031D0A RID: 204042
			[Token(Token = "0x4031D0A")]
			[FieldOffset(Offset = "0x10")]
			public bool useFog;

			// Token: 0x04031D0B RID: 204043
			[Token(Token = "0x4031D0B")]
			[FieldOffset(Offset = "0x14")]
			[ReadOnly]
			public float constantFogRate;

			// Token: 0x04031D0C RID: 204044
			[Token(Token = "0x4031D0C")]
			[FieldOffset(Offset = "0x18")]
			[ReadOnly]
			public List<Vector3> vertices;
		}
	}
}
