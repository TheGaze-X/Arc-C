using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060FB RID: 24827
	[Token(Token = "0x20060FB")]
	public class CampaignWorldHomeBriefView : DataBinder<CampaignWorldHomeBriefViewProperty>
	{
		// Token: 0x06023E20 RID: 146976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E20")]
		[Address(RVA = "0x1E8A810", Offset = "0x1E89410", VA = "0x181E8A810", Slot = "7")]
		public override void OnValueChanged(CampaignWorldHomeBriefViewProperty prop)
		{
		}

		// Token: 0x06023E21 RID: 146977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E21")]
		[Address(RVA = "0x1E8A8E0", Offset = "0x1E894E0", VA = "0x181E8A8E0")]
		public CampaignWorldHomeBriefView()
		{
		}

		// Token: 0x04031C67 RID: 203879
		[Token(Token = "0x4031C67")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x04031C68 RID: 203880
		[Token(Token = "0x4031C68")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageBkgTrainingAllOpen;

		// Token: 0x04031C69 RID: 203881
		[Token(Token = "0x4031C69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031C6A RID: 203882
		[Token(Token = "0x4031C6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
