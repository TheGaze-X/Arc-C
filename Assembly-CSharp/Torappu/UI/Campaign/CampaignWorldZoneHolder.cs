using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006113 RID: 24851
	[Token(Token = "0x2006113")]
	public class CampaignWorldZoneHolder : CampaignWorldObjectHolder<CampaignWorldZoneView, CampaignWorldZoneHolder.Config>
	{
		// Token: 0x06023E6F RID: 147055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E6F")]
		[Address(RVA = "0x1E92120", Offset = "0x1E90D20", VA = "0x181E92120")]
		public CampaignWorldZoneHolder()
		{
		}

		// Token: 0x04031D1B RID: 204059
		[Token(Token = "0x4031D1B")]
		[HideInInspector]
		public const float PANEL_INFO_ALIGNMENT_X = 50f;

		// Token: 0x04031D1C RID: 204060
		[Token(Token = "0x4031D1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006114 RID: 24852
		[Token(Token = "0x2006114")]
		[Serializable]
		public class Config
		{
			// Token: 0x06023E70 RID: 147056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023E70")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Config()
			{
			}

			// Token: 0x04031D1D RID: 204061
			[Token(Token = "0x4031D1D")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public Vector2 circleScale;

			// Token: 0x04031D1E RID: 204062
			[Token(Token = "0x4031D1E")]
			[FieldOffset(Offset = "0x18")]
			[ReadOnly]
			public Vector2 panelInfoPosition;

			// Token: 0x04031D1F RID: 204063
			[Token(Token = "0x4031D1F")]
			[FieldOffset(Offset = "0x20")]
			public CampaignWorldZoneHolder.PanelInfoAlignment panelInfoAlignment;
		}

		// Token: 0x02006115 RID: 24853
		[Token(Token = "0x2006115")]
		public enum PanelInfoAlignment
		{
			// Token: 0x04031D21 RID: 204065
			[Token(Token = "0x4031D21")]
			LEFT,
			// Token: 0x04031D22 RID: 204066
			[Token(Token = "0x4031D22")]
			CENTER,
			// Token: 0x04031D23 RID: 204067
			[Token(Token = "0x4031D23")]
			RIGHT
		}
	}
}
