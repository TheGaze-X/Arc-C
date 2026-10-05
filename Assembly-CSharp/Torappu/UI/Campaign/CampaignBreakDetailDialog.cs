using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006123 RID: 24867
	[Token(Token = "0x2006123")]
	public class CampaignBreakDetailDialog : UICompDialog<CampaignBreakDetailDialog.Input>, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x06023EA7 RID: 147111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EA7")]
		[Address(RVA = "0x1E83EC0", Offset = "0x1E82AC0", VA = "0x181E83EC0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06023EA8 RID: 147112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EA8")]
		[Address(RVA = "0x1E841B0", Offset = "0x1E82DB0", VA = "0x181E841B0", Slot = "18")]
		protected override void OnRender(CampaignBreakDetailDialog.Input input)
		{
		}

		// Token: 0x06023EA9 RID: 147113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023EA9")]
		[Address(RVA = "0x1E83DA0", Offset = "0x1E829A0", VA = "0x181E83DA0", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06023EAA RID: 147114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EAA")]
		[Address(RVA = "0x1E83CE0", Offset = "0x1E828E0", VA = "0x181E83CE0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06023EAB RID: 147115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EAB")]
		[Address(RVA = "0x1E83F50", Offset = "0x1E82B50", VA = "0x181E83F50", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06023EAC RID: 147116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EAC")]
		[Address(RVA = "0x1E84650", Offset = "0x1E83250", VA = "0x181E84650")]
		private void _EventOnItemClicked(int index)
		{
		}

		// Token: 0x06023EAD RID: 147117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EAD")]
		[Address(RVA = "0x1E84410", Offset = "0x1E83010", VA = "0x181E84410")]
		private void _EventOnConfirmAllClicked()
		{
		}

		// Token: 0x06023EAE RID: 147118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EAE")]
		[Address(RVA = "0x1E84940", Offset = "0x1E83540", VA = "0x181E84940")]
		private void _SendConfirmRewardRequest(string stageId, List<int> indexList)
		{
		}

		// Token: 0x06023EAF RID: 147119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EAF")]
		[Address(RVA = "0x1E84810", Offset = "0x1E83410", VA = "0x181E84810")]
		private void _HandleConfirmRewardResponse(CampaignConfirmBreakRewardResponse response)
		{
		}

		// Token: 0x06023EB0 RID: 147120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EB0")]
		[Address(RVA = "0x1E84BC0", Offset = "0x1E837C0", VA = "0x181E84BC0")]
		public CampaignBreakDetailDialog()
		{
		}

		// Token: 0x06023EB1 RID: 147121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EB1")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06023EB2 RID: 147122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023EB2")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x04031D91 RID: 204177
		[Token(Token = "0x4031D91")]
		[NonSerialized]
		public const int ON_ITEM_CLICKED = 0;

		// Token: 0x04031D92 RID: 204178
		[Token(Token = "0x4031D92")]
		[NonSerialized]
		public const int ON_CONFIRM_ALL_CLICKED = 1;

		// Token: 0x04031D93 RID: 204179
		[Token(Token = "0x4031D93")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04031D94 RID: 204180
		[Token(Token = "0x4031D94")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CampaignBreakDetailView _detailView;

		// Token: 0x04031D95 RID: 204181
		[Token(Token = "0x4031D95")]
		[FieldOffset(Offset = "0x80")]
		private CampaignBreakDetailProperty m_property;

		// Token: 0x04031D96 RID: 204182
		[Token(Token = "0x4031D96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04031D97 RID: 204183
		[Token(Token = "0x4031D97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04031D98 RID: 204184
		[Token(Token = "0x4031D98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04031D99 RID: 204185
		[Token(Token = "0x4031D99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04031D9A RID: 204186
		[Token(Token = "0x4031D9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04031D9B RID: 204187
		[Token(Token = "0x4031D9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x04031D9C RID: 204188
		[Token(Token = "0x4031D9C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnConfirmAllClicked;

		// Token: 0x04031D9D RID: 204189
		[Token(Token = "0x4031D9D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendConfirmRewardRequest;

		// Token: 0x04031D9E RID: 204190
		[Token(Token = "0x4031D9E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleConfirmRewardResponse;

		// Token: 0x04031D9F RID: 204191
		[Token(Token = "0x4031D9F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006124 RID: 24868
		[Token(Token = "0x2006124")]
		public class Input
		{
			// Token: 0x06023EB3 RID: 147123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EB3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04031DA0 RID: 204192
			[Token(Token = "0x4031DA0")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;
		}

		// Token: 0x02006125 RID: 24869
		[Token(Token = "0x2006125")]
		private class CampaignBreakDetailSwitchTween : DefaultDialogSwitchTween, IHotfixable
		{
			// Token: 0x06023EB4 RID: 147124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EB4")]
			[Address(RVA = "0x1E859B0", Offset = "0x1E845B0", VA = "0x181E859B0")]
			public CampaignBreakDetailSwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale = false)
			{
			}

			// Token: 0x06023EB5 RID: 147125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EB5")]
			[Address(RVA = "0x1E85940", Offset = "0x1E84540", VA = "0x181E85940", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x06023EB6 RID: 147126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EB6")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x04031DA1 RID: 204193
			[Token(Token = "0x4031DA1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031DA2 RID: 204194
			[Token(Token = "0x4031DA2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;
		}
	}
}
