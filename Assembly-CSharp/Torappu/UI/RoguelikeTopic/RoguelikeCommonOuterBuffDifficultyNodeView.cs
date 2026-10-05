using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044FE RID: 17662
	[Token(Token = "0x20044FE")]
	public class RoguelikeCommonOuterBuffDifficultyNodeView : RoguelikeCommonOuterBuffNodeBase
	{
		// Token: 0x0601AF42 RID: 110402 RVA: 0x000A3B90 File Offset: 0x000A1D90
		[Token(Token = "0x601AF42")]
		[Address(RVA = "0x141CA10", Offset = "0x141B610", VA = "0x18141CA10", Slot = "4")]
		public override RoguelikeCommonOuterBuffViewType GetType()
		{
			return RoguelikeCommonOuterBuffViewType.NORMAL;
		}

		// Token: 0x0601AF43 RID: 110403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF43")]
		[Address(RVA = "0x141CAF0", Offset = "0x141B6F0", VA = "0x18141CAF0", Slot = "5")]
		protected override void OnInit(RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF44 RID: 110404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF44")]
		[Address(RVA = "0x141CF70", Offset = "0x141BB70", VA = "0x18141CF70", Slot = "6")]
		protected override void OnRender(string selectedBuffId, RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF45 RID: 110405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF45")]
		[Address(RVA = "0x141D390", Offset = "0x141BF90", VA = "0x18141D390")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF46 RID: 110406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF46")]
		[Address(RVA = "0x141D490", Offset = "0x141C090", VA = "0x18141D490")]
		private void _PlayActiveAnim(RoguelikeCommonOuterBuffDifficultyNodeViewModel model)
		{
		}

		// Token: 0x0601AF47 RID: 110407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF47")]
		[Address(RVA = "0x141CA70", Offset = "0x141B670", VA = "0x18141CA70")]
		public void OnClick()
		{
		}

		// Token: 0x0601AF48 RID: 110408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF48")]
		[Address(RVA = "0x141D650", Offset = "0x141C250", VA = "0x18141D650")]
		public RoguelikeCommonOuterBuffDifficultyNodeView()
		{
		}

		// Token: 0x0402295E RID: 141662
		[Token(Token = "0x402295E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0402295F RID: 141663
		[Token(Token = "0x402295F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x04022960 RID: 141664
		[Token(Token = "0x4022960")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _animDelay;

		// Token: 0x04022961 RID: 141665
		[Token(Token = "0x4022961")]
		[FieldOffset(Offset = "0x84")]
		private bool m_isInited;

		// Token: 0x04022962 RID: 141666
		[Token(Token = "0x4022962")]
		[FieldOffset(Offset = "0x88")]
		private string m_buffId;

		// Token: 0x04022963 RID: 141667
		[Token(Token = "0x4022963")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isActive;

		// Token: 0x04022964 RID: 141668
		[Token(Token = "0x4022964")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_tween;

		// Token: 0x04022965 RID: 141669
		[Token(Token = "0x4022965")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x04022966 RID: 141670
		[Token(Token = "0x4022966")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetType;

		// Token: 0x04022967 RID: 141671
		[Token(Token = "0x4022967")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04022968 RID: 141672
		[Token(Token = "0x4022968")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04022969 RID: 141673
		[Token(Token = "0x4022969")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402296A RID: 141674
		[Token(Token = "0x402296A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayActiveAnim;

		// Token: 0x0402296B RID: 141675
		[Token(Token = "0x402296B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402296C RID: 141676
		[Token(Token = "0x402296C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
