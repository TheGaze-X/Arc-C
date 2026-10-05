using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006141 RID: 24897
	[Token(Token = "0x2006141")]
	public class CampaignZoneMapStageListView : DataBinder<CampaignZoneMapProperty>, IHotfixable
	{
		// Token: 0x06023F0B RID: 147211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F0B")]
		[Address(RVA = "0x1E95EB0", Offset = "0x1E94AB0", VA = "0x181E95EB0", Slot = "7")]
		public override void OnValueChanged(CampaignZoneMapProperty property)
		{
		}

		// Token: 0x06023F0C RID: 147212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F0C")]
		[Address(RVA = "0x1E960D0", Offset = "0x1E94CD0", VA = "0x181E960D0")]
		public CampaignZoneMapStageListView()
		{
		}

		// Token: 0x04031E69 RID: 204393
		[Token(Token = "0x4031E69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CampaignZoneMapStageListAdapter _adapter;

		// Token: 0x04031E6A RID: 204394
		[Token(Token = "0x4031E6A")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedZoneId;

		// Token: 0x04031E6B RID: 204395
		[Token(Token = "0x4031E6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031E6C RID: 204396
		[Token(Token = "0x4031E6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
