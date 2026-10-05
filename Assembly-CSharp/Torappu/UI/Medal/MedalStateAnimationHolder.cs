using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004973 RID: 18803
	[Token(Token = "0x2004973")]
	public class MedalStateAnimationHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C56B RID: 116075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C56B")]
		[Address(RVA = "0x15DA6F0", Offset = "0x15D92F0", VA = "0x1815DA6F0")]
		private void _SetAlphaActiveFlag(bool activeFlag)
		{
		}

		// Token: 0x0601C56C RID: 116076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C56C")]
		[Address(RVA = "0x15DA4F0", Offset = "0x15D90F0", VA = "0x1815DA4F0")]
		public void SetAvail(bool activeFlag)
		{
		}

		// Token: 0x0601C56D RID: 116077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C56D")]
		[Address(RVA = "0x15DA2A0", Offset = "0x15D8EA0", VA = "0x1815DA2A0")]
		public void Render(bool state)
		{
		}

		// Token: 0x0601C56E RID: 116078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C56E")]
		[Address(RVA = "0x15DA820", Offset = "0x15D9420", VA = "0x1815DA820")]
		public MedalStateAnimationHolder()
		{
		}

		// Token: 0x0402514F RID: 151887
		[Token(Token = "0x402514F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04025150 RID: 151888
		[Token(Token = "0x4025150")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04025151 RID: 151889
		[Token(Token = "0x4025151")]
		[FieldOffset(Offset = "0x28")]
		private float m_cacheState;

		// Token: 0x04025152 RID: 151890
		[Token(Token = "0x4025152")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_cacheTween;

		// Token: 0x04025153 RID: 151891
		[Token(Token = "0x4025153")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_alphaSwitch;

		// Token: 0x04025154 RID: 151892
		[Token(Token = "0x4025154")]
		[FieldOffset(Offset = "0x40")]
		private bool m_renderFlag;

		// Token: 0x04025155 RID: 151893
		[Token(Token = "0x4025155")]
		private const string DEFAULT_ANIM = "left_right_move_bar";

		// Token: 0x04025156 RID: 151894
		[Token(Token = "0x4025156")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetAlphaActiveFlag;

		// Token: 0x04025157 RID: 151895
		[Token(Token = "0x4025157")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetAvail;

		// Token: 0x04025158 RID: 151896
		[Token(Token = "0x4025158")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025159 RID: 151897
		[Token(Token = "0x4025159")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
