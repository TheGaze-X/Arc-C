using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068C3 RID: 26819
	[Token(Token = "0x20068C3")]
	public class StageCampaignRuleStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x060266C5 RID: 157381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266C5")]
		[Address(RVA = "0x2184790", Offset = "0x2183390", VA = "0x182184790")]
		public StageCampaignRuleStateBean()
		{
		}

		// Token: 0x040361FB RID: 221691
		[Token(Token = "0x40361FB")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string stageId;

		// Token: 0x040361FC RID: 221692
		[Token(Token = "0x40361FC")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CampaignStageType stageType;

		// Token: 0x040361FD RID: 221693
		[Token(Token = "0x40361FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
