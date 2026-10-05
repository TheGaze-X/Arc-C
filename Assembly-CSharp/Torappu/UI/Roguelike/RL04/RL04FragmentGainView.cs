using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056CB RID: 22219
	[Token(Token = "0x20056CB")]
	public class RL04FragmentGainView : DataBinder<RL04FragmentGainProperty>, IHotfixable
	{
		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x06020962 RID: 133474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020963 RID: 133475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C59")]
		public ILoadAsset loader
		{
			[Token(Token = "0x6020962")]
			[Address(RVA = "0x1AB06A0", Offset = "0x1AAF2A0", VA = "0x181AB06A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020963")]
			[Address(RVA = "0x1AB07C0", Offset = "0x1AAF3C0", VA = "0x181AB07C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x06020965 RID: 133477 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020964 RID: 133476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C5A")]
		public Action onNextBtnClick
		{
			[Token(Token = "0x6020965")]
			[Address(RVA = "0x1AB0760", Offset = "0x1AAF360", VA = "0x181AB0760")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020964")]
			[Address(RVA = "0x1AB08C0", Offset = "0x1AAF4C0", VA = "0x181AB08C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x06020967 RID: 133479 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020966 RID: 133478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C5B")]
		public Action onCloseBtnClick
		{
			[Token(Token = "0x6020967")]
			[Address(RVA = "0x1AB0700", Offset = "0x1AAF300", VA = "0x181AB0700")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020966")]
			[Address(RVA = "0x1AB0840", Offset = "0x1AAF440", VA = "0x181AB0840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020968 RID: 133480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020968")]
		[Address(RVA = "0x1AB0200", Offset = "0x1AAEE00", VA = "0x181AB0200", Slot = "7")]
		public override void OnValueChanged(RL04FragmentGainProperty property)
		{
		}

		// Token: 0x06020969 RID: 133481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020969")]
		[Address(RVA = "0x1AB00F0", Offset = "0x1AAECF0", VA = "0x181AB00F0")]
		public void EventOnNextBtnClick()
		{
		}

		// Token: 0x0602096A RID: 133482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602096A")]
		[Address(RVA = "0x1AAFFE0", Offset = "0x1AAEBE0", VA = "0x181AAFFE0")]
		public void EventOnCloseBtnClick()
		{
		}

		// Token: 0x0602096B RID: 133483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602096B")]
		[Address(RVA = "0x1AB04F0", Offset = "0x1AAF0F0", VA = "0x181AB04F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602096C RID: 133484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602096C")]
		[Address(RVA = "0x1AB0630", Offset = "0x1AAF230", VA = "0x181AB0630")]
		public RL04FragmentGainView()
		{
		}

		// Token: 0x0402C2AA RID: 180906
		[Token(Token = "0x402C2AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL04FragmentDetailCard _detailCardPrefab;

		// Token: 0x0402C2AB RID: 180907
		[Token(Token = "0x402C2AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x0402C2AC RID: 180908
		[Token(Token = "0x402C2AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _nextBtnObj;

		// Token: 0x0402C2AD RID: 180909
		[Token(Token = "0x402C2AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _closeBtnObj;

		// Token: 0x0402C2AE RID: 180910
		[Token(Token = "0x402C2AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0402C2B2 RID: 180914
		[Token(Token = "0x402C2B2")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0402C2B3 RID: 180915
		[Token(Token = "0x402C2B3")]
		[FieldOffset(Offset = "0x6C")]
		private int m_cachedShowIndex;

		// Token: 0x0402C2B4 RID: 180916
		[Token(Token = "0x402C2B4")]
		[FieldOffset(Offset = "0x70")]
		private RL04FragmentDetailCard m_detailCard;

		// Token: 0x0402C2B5 RID: 180917
		[Token(Token = "0x402C2B5")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_animTween;

		// Token: 0x0402C2B6 RID: 180918
		[Token(Token = "0x402C2B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402C2B7 RID: 180919
		[Token(Token = "0x402C2B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402C2B8 RID: 180920
		[Token(Token = "0x402C2B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onNextBtnClick;

		// Token: 0x0402C2B9 RID: 180921
		[Token(Token = "0x402C2B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onNextBtnClick;

		// Token: 0x0402C2BA RID: 180922
		[Token(Token = "0x402C2BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onCloseBtnClick;

		// Token: 0x0402C2BB RID: 180923
		[Token(Token = "0x402C2BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onCloseBtnClick;

		// Token: 0x0402C2BC RID: 180924
		[Token(Token = "0x402C2BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402C2BD RID: 180925
		[Token(Token = "0x402C2BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClick;

		// Token: 0x0402C2BE RID: 180926
		[Token(Token = "0x402C2BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClick;

		// Token: 0x0402C2BF RID: 180927
		[Token(Token = "0x402C2BF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C2C0 RID: 180928
		[Token(Token = "0x402C2C0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
