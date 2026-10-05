using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004389 RID: 17289
	[Token(Token = "0x2004389")]
	public class SandboxV2RiftTeamSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601A8BF RID: 108735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A8BF")]
		[Address(RVA = "0x13B8370", Offset = "0x13B6F70", VA = "0x1813B8370", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A8C0 RID: 108736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C0")]
		[Address(RVA = "0x13B83D0", Offset = "0x13B6FD0", VA = "0x1813B83D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A8C1 RID: 108737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C1")]
		[Address(RVA = "0x13B8960", Offset = "0x13B7560", VA = "0x1813B8960", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A8C2 RID: 108738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C2")]
		[Address(RVA = "0x13B8B70", Offset = "0x13B7770", VA = "0x1813B8B70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A8C3 RID: 108739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C3")]
		[Address(RVA = "0x13B9270", Offset = "0x13B7E70", VA = "0x1813B9270")]
		private void _ResetEnterAnim()
		{
		}

		// Token: 0x0601A8C4 RID: 108740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C4")]
		[Address(RVA = "0x13B9150", Offset = "0x13B7D50", VA = "0x1813B9150")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601A8C5 RID: 108741 RVA: 0x000A2558 File Offset: 0x000A0758
		[Token(Token = "0x601A8C5")]
		[Address(RVA = "0x13B8AE0", Offset = "0x13B76E0", VA = "0x1813B8AE0")]
		private bool _EnsureStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601A8C6 RID: 108742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C6")]
		[Address(RVA = "0x13B86F0", Offset = "0x13B72F0", VA = "0x1813B86F0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A8C7 RID: 108743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C7")]
		[Address(RVA = "0x13B8C10", Offset = "0x13B7810", VA = "0x1813B8C10")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0601A8C8 RID: 108744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C8")]
		[Address(RVA = "0x13B8CF0", Offset = "0x13B78F0", VA = "0x1813B8CF0")]
		private void _OnConfirmClicked()
		{
		}

		// Token: 0x0601A8C9 RID: 108745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8C9")]
		[Address(RVA = "0x13B8FC0", Offset = "0x13B7BC0", VA = "0x1813B8FC0")]
		private void _OnTeamButtonClicked(string teamId)
		{
		}

		// Token: 0x0601A8CA RID: 108746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8CA")]
		[Address(RVA = "0x13B9350", Offset = "0x13B7F50", VA = "0x1813B9350")]
		public SandboxV2RiftTeamSelectState()
		{
		}

		// Token: 0x0601A8CC RID: 108748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8CC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A8CD RID: 108749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8CD")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04021C99 RID: 138393
		[Token(Token = "0x4021C99")]
		[NonSerialized]
		public const int ON_BACK_CLICKED = 0;

		// Token: 0x04021C9A RID: 138394
		[Token(Token = "0x4021C9A")]
		[NonSerialized]
		public const int ON_CONFIRM_CLICKED = 1;

		// Token: 0x04021C9B RID: 138395
		[Token(Token = "0x4021C9B")]
		[NonSerialized]
		public const int ON_TEAM_BUTTON_CLICKED = 2;

		// Token: 0x04021C9C RID: 138396
		[Token(Token = "0x4021C9C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2RiftTeamSelectView _view;

		// Token: 0x04021C9D RID: 138397
		[Token(Token = "0x4021C9D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04021C9E RID: 138398
		[Token(Token = "0x4021C9E")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2RiftTeamSelectStateBean m_stateBean;

		// Token: 0x04021C9F RID: 138399
		[Token(Token = "0x4021C9F")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04021CA0 RID: 138400
		[Token(Token = "0x4021CA0")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedTopicId;

		// Token: 0x04021CA1 RID: 138401
		[Token(Token = "0x4021CA1")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedEnterTeamId;

		// Token: 0x04021CA2 RID: 138402
		[Token(Token = "0x4021CA2")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_enterTween;

		// Token: 0x04021CA3 RID: 138403
		[Token(Token = "0x4021CA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04021CA4 RID: 138404
		[Token(Token = "0x4021CA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04021CA5 RID: 138405
		[Token(Token = "0x4021CA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04021CA6 RID: 138406
		[Token(Token = "0x4021CA6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021CA7 RID: 138407
		[Token(Token = "0x4021CA7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetEnterAnim;

		// Token: 0x04021CA8 RID: 138408
		[Token(Token = "0x4021CA8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04021CA9 RID: 138409
		[Token(Token = "0x4021CA9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EnsureStateStable;

		// Token: 0x04021CAA RID: 138410
		[Token(Token = "0x4021CAA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04021CAB RID: 138411
		[Token(Token = "0x4021CAB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x04021CAC RID: 138412
		[Token(Token = "0x4021CAC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnConfirmClicked;

		// Token: 0x04021CAD RID: 138413
		[Token(Token = "0x4021CAD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTeamButtonClicked;

		// Token: 0x04021CAE RID: 138414
		[Token(Token = "0x4021CAE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
