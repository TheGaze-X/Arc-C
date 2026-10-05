using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200611D RID: 24861
	[Token(Token = "0x200611D")]
	public class CampaignFastBattleRuleView : UICustomDialog<string>
	{
		// Token: 0x06023E85 RID: 147077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E85")]
		[Address(RVA = "0x1E86C60", Offset = "0x1E85860", VA = "0x181E86C60", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x06023E86 RID: 147078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E86")]
		[Address(RVA = "0x1E86D90", Offset = "0x1E85990", VA = "0x181E86D90", Slot = "7")]
		protected override void OnRender(string options)
		{
		}

		// Token: 0x06023E87 RID: 147079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E87")]
		[Address(RVA = "0x1E86BF0", Offset = "0x1E857F0", VA = "0x181E86BF0")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x06023E88 RID: 147080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E88")]
		[Address(RVA = "0x1E86E40", Offset = "0x1E85A40", VA = "0x181E86E40")]
		public CampaignFastBattleRuleView()
		{
		}

		// Token: 0x04031D64 RID: 204132
		[Token(Token = "0x4031D64")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04031D65 RID: 204133
		[Token(Token = "0x4031D65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04031D66 RID: 204134
		[Token(Token = "0x4031D66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04031D67 RID: 204135
		[Token(Token = "0x4031D67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBlankClicked;

		// Token: 0x04031D68 RID: 204136
		[Token(Token = "0x4031D68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
