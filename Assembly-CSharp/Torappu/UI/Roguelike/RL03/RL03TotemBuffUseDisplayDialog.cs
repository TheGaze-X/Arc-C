using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005855 RID: 22613
	[Token(Token = "0x2005855")]
	public class RL03TotemBuffUseDisplayDialog : UICustomDialog<RL03TotemBuffUseDisplayDialog.Options>
	{
		// Token: 0x06021085 RID: 135301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021085")]
		[Address(RVA = "0x1B66520", Offset = "0x1B65120", VA = "0x181B66520", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06021086 RID: 135302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021086")]
		[Address(RVA = "0x1B66580", Offset = "0x1B65180", VA = "0x181B66580", Slot = "7")]
		protected override void OnRender(RL03TotemBuffUseDisplayDialog.Options options)
		{
		}

		// Token: 0x06021087 RID: 135303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021087")]
		[Address(RVA = "0x1B66C40", Offset = "0x1B65840", VA = "0x181B66C40")]
		private void _RenderEffect(string combineGroupName, RoguelikeTotemColorType colorType)
		{
		}

		// Token: 0x06021088 RID: 135304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021088")]
		[Address(RVA = "0x1B669E0", Offset = "0x1B655E0", VA = "0x181B669E0")]
		private void _PlayAnim(bool canResonance, Action callback)
		{
		}

		// Token: 0x06021089 RID: 135305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021089")]
		[Address(RVA = "0x1B66D80", Offset = "0x1B65980", VA = "0x181B66D80")]
		public RL03TotemBuffUseDisplayDialog()
		{
		}

		// Token: 0x0402CEDB RID: 184027
		[Token(Token = "0x402CEDB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402CEDC RID: 184028
		[Token(Token = "0x402CEDC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgTotemLocation;

		// Token: 0x0402CEDD RID: 184029
		[Token(Token = "0x402CEDD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgTotemEffect;

		// Token: 0x0402CEDE RID: 184030
		[Token(Token = "0x402CEDE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgTotemBg;

		// Token: 0x0402CEDF RID: 184031
		[Token(Token = "0x402CEDF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _txtLocation;

		// Token: 0x0402CEE0 RID: 184032
		[Token(Token = "0x402CEE0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtEffect;

		// Token: 0x0402CEE1 RID: 184033
		[Token(Token = "0x402CEE1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _txtResonance;

		// Token: 0x0402CEE2 RID: 184034
		[Token(Token = "0x402CEE2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _normalAnim;

		// Token: 0x0402CEE3 RID: 184035
		[Token(Token = "0x402CEE3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _resonanceAnim;

		// Token: 0x0402CEE4 RID: 184036
		[Token(Token = "0x402CEE4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Effect")]
		private RectTransform _effectContainer;

		// Token: 0x0402CEE5 RID: 184037
		[Token(Token = "0x402CEE5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Effect")]
		private GameObject _blueEffect;

		// Token: 0x0402CEE6 RID: 184038
		[Token(Token = "0x402CEE6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Effect")]
		private GameObject _greenEffect;

		// Token: 0x0402CEE7 RID: 184039
		[Token(Token = "0x402CEE7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Effect")]
		private GameObject _redEffect;

		// Token: 0x0402CEE8 RID: 184040
		[Token(Token = "0x402CEE8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Effect")]
		private GameObject _bossEffect;

		// Token: 0x0402CEE9 RID: 184041
		[Token(Token = "0x402CEE9")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_animTween;

		// Token: 0x0402CEEA RID: 184042
		[Token(Token = "0x402CEEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402CEEB RID: 184043
		[Token(Token = "0x402CEEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402CEEC RID: 184044
		[Token(Token = "0x402CEEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderEffect;

		// Token: 0x0402CEED RID: 184045
		[Token(Token = "0x402CEED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0402CEEE RID: 184046
		[Token(Token = "0x402CEEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005856 RID: 22614
		[Token(Token = "0x2005856")]
		public struct Options
		{
			// Token: 0x0402CEEF RID: 184047
			[Token(Token = "0x402CEEF")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402CEF0 RID: 184048
			[Token(Token = "0x402CEF0")]
			[FieldOffset(Offset = "0x8")]
			public RL03TotemViewModel locationViewModel;

			// Token: 0x0402CEF1 RID: 184049
			[Token(Token = "0x402CEF1")]
			[FieldOffset(Offset = "0x10")]
			public RL03TotemViewModel effectViewModel;

			// Token: 0x0402CEF2 RID: 184050
			[Token(Token = "0x402CEF2")]
			[FieldOffset(Offset = "0x18")]
			public Action callback;
		}
	}
}
