using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006766 RID: 26470
	[Token(Token = "0x2006766")]
	public class HalfIdleUIImportantTipView : DataBinder<HalfIdleBattleTipListProperty>
	{
		// Token: 0x06025F9D RID: 155549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F9D")]
		[Address(RVA = "0x20F8A50", Offset = "0x20F7650", VA = "0x1820F8A50", Slot = "7")]
		public override void OnValueChanged(HalfIdleBattleTipListProperty property)
		{
		}

		// Token: 0x06025F9E RID: 155550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F9E")]
		[Address(RVA = "0x20F8AE0", Offset = "0x20F76E0", VA = "0x1820F8AE0")]
		public void Render(HalfIdleTipListViewModel viewModel)
		{
		}

		// Token: 0x06025F9F RID: 155551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F9F")]
		[Address(RVA = "0x20F8E50", Offset = "0x20F7A50", VA = "0x1820F8E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025FA0 RID: 155552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FA0")]
		[Address(RVA = "0x20F8FA0", Offset = "0x20F7BA0", VA = "0x1820F8FA0")]
		public HalfIdleUIImportantTipView()
		{
		}

		// Token: 0x04035706 RID: 218886
		[Token(Token = "0x4035706")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x04035707 RID: 218887
		[Token(Token = "0x4035707")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _loseHpAnim;

		// Token: 0x04035708 RID: 218888
		[Token(Token = "0x4035708")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _warnAnim;

		// Token: 0x04035709 RID: 218889
		[Token(Token = "0x4035709")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0403570A RID: 218890
		[Token(Token = "0x403570A")]
		[FieldOffset(Offset = "0x54")]
		private HalfIdleBattleTipItemType m_cachedType;

		// Token: 0x0403570B RID: 218891
		[Token(Token = "0x403570B")]
		[FieldOffset(Offset = "0x58")]
		private AnimationSwitchTween m_showTween;

		// Token: 0x0403570C RID: 218892
		[Token(Token = "0x403570C")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_switchTween;

		// Token: 0x0403570D RID: 218893
		[Token(Token = "0x403570D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403570E RID: 218894
		[Token(Token = "0x403570E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403570F RID: 218895
		[Token(Token = "0x403570F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035710 RID: 218896
		[Token(Token = "0x4035710")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
