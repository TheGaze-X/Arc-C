using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004507 RID: 17671
	[Token(Token = "0x2004507")]
	public class RoguelikeCommonOuterBuffNormalNodeView : RoguelikeCommonOuterBuffNodeBase
	{
		// Token: 0x0601AF69 RID: 110441 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
		[Token(Token = "0x601AF69")]
		[Address(RVA = "0x141FC80", Offset = "0x141E880", VA = "0x18141FC80", Slot = "4")]
		public override RoguelikeCommonOuterBuffViewType GetType()
		{
			return RoguelikeCommonOuterBuffViewType.NORMAL;
		}

		// Token: 0x0601AF6A RID: 110442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF6A")]
		[Address(RVA = "0x141FD60", Offset = "0x141E960", VA = "0x18141FD60", Slot = "5")]
		protected override void OnInit(RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF6B RID: 110443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF6B")]
		[Address(RVA = "0x1420310", Offset = "0x141EF10", VA = "0x181420310", Slot = "6")]
		protected override void OnRender(string selectedBuffId, RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF6C RID: 110444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF6C")]
		[Address(RVA = "0x14204F0", Offset = "0x141F0F0", VA = "0x1814204F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF6D RID: 110445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF6D")]
		[Address(RVA = "0x1420760", Offset = "0x141F360", VA = "0x181420760")]
		private void _InitNodeStatus(RoguelikeCommonOuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601AF6E RID: 110446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF6E")]
		[Address(RVA = "0x14205F0", Offset = "0x141F1F0", VA = "0x1814205F0")]
		private void _InitLightStatus(RoguelikeCommonOuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601AF6F RID: 110447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF6F")]
		[Address(RVA = "0x14208B0", Offset = "0x141F4B0", VA = "0x1814208B0")]
		private void _PlayActiveAnim(RoguelikeCommonOuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601AF70 RID: 110448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF70")]
		[Address(RVA = "0x1420B30", Offset = "0x141F730", VA = "0x181420B30")]
		private void _PlayUnlockAnim(RoguelikeCommonOuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601AF71 RID: 110449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF71")]
		[Address(RVA = "0x141FCE0", Offset = "0x141E8E0", VA = "0x18141FCE0")]
		public void OnClick()
		{
		}

		// Token: 0x0601AF72 RID: 110450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF72")]
		[Address(RVA = "0x1420CF0", Offset = "0x141F8F0", VA = "0x181420CF0")]
		public RoguelikeCommonOuterBuffNormalNodeView()
		{
		}

		// Token: 0x040229A7 RID: 141735
		[Token(Token = "0x40229A7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x040229A8 RID: 141736
		[Token(Token = "0x40229A8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _unlockLightAnim;

		// Token: 0x040229A9 RID: 141737
		[Token(Token = "0x40229A9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x040229AA RID: 141738
		[Token(Token = "0x40229AA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _activeLightAnim;

		// Token: 0x040229AB RID: 141739
		[Token(Token = "0x40229AB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _activeAnimDelay;

		// Token: 0x040229AC RID: 141740
		[Token(Token = "0x40229AC")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _unlockAnimDelay;

		// Token: 0x040229AD RID: 141741
		[Token(Token = "0x40229AD")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x040229AE RID: 141742
		[Token(Token = "0x40229AE")]
		[FieldOffset(Offset = "0xB0")]
		private string m_buffId;

		// Token: 0x040229AF RID: 141743
		[Token(Token = "0x40229AF")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isUnlock;

		// Token: 0x040229B0 RID: 141744
		[Token(Token = "0x40229B0")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_isActive;

		// Token: 0x040229B1 RID: 141745
		[Token(Token = "0x40229B1")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_nodeTween;

		// Token: 0x040229B2 RID: 141746
		[Token(Token = "0x40229B2")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_lightTween;

		// Token: 0x040229B3 RID: 141747
		[Token(Token = "0x40229B3")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x040229B4 RID: 141748
		[Token(Token = "0x40229B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetType;

		// Token: 0x040229B5 RID: 141749
		[Token(Token = "0x40229B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040229B6 RID: 141750
		[Token(Token = "0x40229B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040229B7 RID: 141751
		[Token(Token = "0x40229B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040229B8 RID: 141752
		[Token(Token = "0x40229B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitNodeStatus;

		// Token: 0x040229B9 RID: 141753
		[Token(Token = "0x40229B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitLightStatus;

		// Token: 0x040229BA RID: 141754
		[Token(Token = "0x40229BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayActiveAnim;

		// Token: 0x040229BB RID: 141755
		[Token(Token = "0x40229BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayUnlockAnim;

		// Token: 0x040229BC RID: 141756
		[Token(Token = "0x40229BC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040229BD RID: 141757
		[Token(Token = "0x40229BD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
