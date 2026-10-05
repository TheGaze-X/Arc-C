using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056F5 RID: 22261
	[Token(Token = "0x20056F5")]
	public class RL04NodeUpgradeMuralView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020A6D RID: 133741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A6D")]
		[Address(RVA = "0x1ACBA90", Offset = "0x1ACA690", VA = "0x181ACBA90")]
		public void Render(RL04NodeUpgradeConfig config, RL04NodeUpgradeMuralView.Input input)
		{
		}

		// Token: 0x06020A6E RID: 133742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A6E")]
		[Address(RVA = "0x1ACC0A0", Offset = "0x1ACACA0", VA = "0x181ACC0A0")]
		private void _PlayCompleteAnimIfNeed(RL04NodeUpgradeMuralView.Input input)
		{
		}

		// Token: 0x06020A6F RID: 133743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A6F")]
		[Address(RVA = "0x1ACC1D0", Offset = "0x1ACADD0", VA = "0x181ACC1D0")]
		private void _PlayShowAnimIfNeed(RL04NodeUpgradeMuralView.Input input)
		{
		}

		// Token: 0x06020A70 RID: 133744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A70")]
		[Address(RVA = "0x1ACC480", Offset = "0x1ACB080", VA = "0x181ACC480")]
		private void _RenderView(RL04NodeUpgradeConfig config, RL04NodeUpgradeMuralView.Input input)
		{
		}

		// Token: 0x06020A71 RID: 133745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A71")]
		[Address(RVA = "0x1ACBC90", Offset = "0x1ACA890", VA = "0x181ACBC90")]
		private void _InitIfNot(RL04NodeUpgradeMuralView.Input input)
		{
		}

		// Token: 0x06020A72 RID: 133746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A72")]
		[Address(RVA = "0x1ACC820", Offset = "0x1ACB420", VA = "0x181ACC820")]
		public RL04NodeUpgradeMuralView()
		{
		}

		// Token: 0x0402C4BC RID: 181436
		[Token(Token = "0x402C4BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBgThemeColor;

		// Token: 0x0402C4BD RID: 181437
		[Token(Token = "0x402C4BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBgMural;

		// Token: 0x0402C4BE RID: 181438
		[Token(Token = "0x402C4BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconCenterEye;

		// Token: 0x0402C4BF RID: 181439
		[Token(Token = "0x402C4BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image[] _imgMuralList;

		// Token: 0x0402C4C0 RID: 181440
		[Token(Token = "0x402C4C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup[] _selectGlowList;

		// Token: 0x0402C4C1 RID: 181441
		[Token(Token = "0x402C4C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _glowFadeDuration;

		// Token: 0x0402C4C2 RID: 181442
		[Token(Token = "0x402C4C2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _permCompleteGroup;

		// Token: 0x0402C4C3 RID: 181443
		[Token(Token = "0x402C4C3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _allCompleteIconGo;

		// Token: 0x0402C4C4 RID: 181444
		[Token(Token = "0x402C4C4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _completeEnterAnim;

		// Token: 0x0402C4C5 RID: 181445
		[Token(Token = "0x402C4C5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation[] _muralShowAnimList;

		// Token: 0x0402C4C6 RID: 181446
		[Token(Token = "0x402C4C6")]
		[FieldOffset(Offset = "0x70")]
		private int m_muralTweenCount;

		// Token: 0x0402C4C7 RID: 181447
		[Token(Token = "0x402C4C7")]
		[FieldOffset(Offset = "0x78")]
		private Tween[] m_muralTweenArray;

		// Token: 0x0402C4C8 RID: 181448
		[Token(Token = "0x402C4C8")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_completeEnterTween;

		// Token: 0x0402C4C9 RID: 181449
		[Token(Token = "0x402C4C9")]
		[FieldOffset(Offset = "0x88")]
		private List<FadeSwitchTween> m_glowTweenList;

		// Token: 0x0402C4CA RID: 181450
		[Token(Token = "0x402C4CA")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_permCompleteTween;

		// Token: 0x0402C4CB RID: 181451
		[Token(Token = "0x402C4CB")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402C4CC RID: 181452
		[Token(Token = "0x402C4CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C4CD RID: 181453
		[Token(Token = "0x402C4CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayCompleteAnimIfNeed;

		// Token: 0x0402C4CE RID: 181454
		[Token(Token = "0x402C4CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayShowAnimIfNeed;

		// Token: 0x0402C4CF RID: 181455
		[Token(Token = "0x402C4CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0402C4D0 RID: 181456
		[Token(Token = "0x402C4D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C4D1 RID: 181457
		[Token(Token = "0x402C4D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056F6 RID: 22262
		[Token(Token = "0x20056F6")]
		public class Input
		{
			// Token: 0x06020A73 RID: 133747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020A73")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402C4D2 RID: 181458
			[Token(Token = "0x402C4D2")]
			[FieldOffset(Offset = "0x10")]
			public int permLevel;

			// Token: 0x0402C4D3 RID: 181459
			[Token(Token = "0x402C4D3")]
			[FieldOffset(Offset = "0x14")]
			public bool isPermComplete;

			// Token: 0x0402C4D4 RID: 181460
			[Token(Token = "0x402C4D4")]
			[FieldOffset(Offset = "0x15")]
			public bool isTempComplete;

			// Token: 0x0402C4D5 RID: 181461
			[Token(Token = "0x402C4D5")]
			[FieldOffset(Offset = "0x16")]
			public bool isCompleteAnimPlay;

			// Token: 0x0402C4D6 RID: 181462
			[Token(Token = "0x402C4D6")]
			[FieldOffset(Offset = "0x17")]
			public bool showToDoGlow;

			// Token: 0x0402C4D7 RID: 181463
			[Token(Token = "0x402C4D7")]
			[FieldOffset(Offset = "0x18")]
			public List<int> showAnimIdxList;

			// Token: 0x0402C4D8 RID: 181464
			[Token(Token = "0x402C4D8")]
			[FieldOffset(Offset = "0x20")]
			public float permFadeDuration;
		}
	}
}
