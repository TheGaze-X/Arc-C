using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FC6 RID: 28614
	[Token(Token = "0x2006FC6")]
	public class ActMultiV3SquadEffectSelectView : DataBinder<ActMultiV3SquadEffectSelectProp>
	{
		// Token: 0x06028A26 RID: 166438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A26")]
		[Address(RVA = "0x23F3E30", Offset = "0x23F2A30", VA = "0x1823F3E30", Slot = "7")]
		public override void OnValueChanged(ActMultiV3SquadEffectSelectProp property)
		{
		}

		// Token: 0x06028A27 RID: 166439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A27")]
		[Address(RVA = "0x23F4A10", Offset = "0x23F3610", VA = "0x1823F4A10")]
		private void _RenderSelectEffectInfo(ActMultiV3SquadEffectSelectModel viewModel)
		{
		}

		// Token: 0x06028A28 RID: 166440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A28")]
		[Address(RVA = "0x23F4590", Offset = "0x23F3190", VA = "0x1823F4590")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028A29 RID: 166441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A29")]
		[Address(RVA = "0x23F48C0", Offset = "0x23F34C0", VA = "0x1823F48C0")]
		protected void _OnClick(ActMultiV3SquadEffectModel effectModel, ActMultiV3SquadEffectItemView.Param param)
		{
		}

		// Token: 0x06028A2A RID: 166442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A2A")]
		[Address(RVA = "0x23F4AB0", Offset = "0x23F36B0", VA = "0x1823F4AB0")]
		public ActMultiV3SquadEffectSelectView()
		{
		}

		// Token: 0x04039E43 RID: 237123
		[Token(Token = "0x4039E43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textKeyCount;

		// Token: 0x04039E44 RID: 237124
		[Token(Token = "0x4039E44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _effectItemList;

		// Token: 0x04039E45 RID: 237125
		[Token(Token = "0x4039E45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textHint;

		// Token: 0x04039E46 RID: 237126
		[Token(Token = "0x4039E46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCollectStarHint;

		// Token: 0x04039E47 RID: 237127
		[Token(Token = "0x4039E47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCollectProgress;

		// Token: 0x04039E48 RID: 237128
		[Token(Token = "0x4039E48")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ActMultiV3SquadEffectInfoView _effectInfoViewPrefab;

		// Token: 0x04039E49 RID: 237129
		[Token(Token = "0x4039E49")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _effectInfoViewContainer;

		// Token: 0x04039E4A RID: 237130
		[Token(Token = "0x4039E4A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _btnInteractGO;

		// Token: 0x04039E4B RID: 237131
		[Token(Token = "0x4039E4B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnAlreadyEquipGO;

		// Token: 0x04039E4C RID: 237132
		[Token(Token = "0x4039E4C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnKeyLackGO;

		// Token: 0x04039E4D RID: 237133
		[Token(Token = "0x4039E4D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _collectProgressGO;

		// Token: 0x04039E4E RID: 237134
		[Token(Token = "0x4039E4E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animBtnUnlock;

		// Token: 0x04039E4F RID: 237135
		[Token(Token = "0x4039E4F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animCoinFade;

		// Token: 0x04039E50 RID: 237136
		[Token(Token = "0x4039E50")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04039E51 RID: 237137
		[Token(Token = "0x4039E51")]
		[FieldOffset(Offset = "0xA0")]
		private ActMultiV3SquadEffectSelectModel m_viewModel;

		// Token: 0x04039E52 RID: 237138
		[Token(Token = "0x4039E52")]
		[FieldOffset(Offset = "0xA8")]
		private ActMultiV3SquadEffectSelectView.EffectItemAdapter m_effectItemAdapter;

		// Token: 0x04039E53 RID: 237139
		[Token(Token = "0x4039E53")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cacheSelectId;

		// Token: 0x04039E54 RID: 237140
		[Token(Token = "0x4039E54")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationSwitchTween m_btnTween;

		// Token: 0x04039E55 RID: 237141
		[Token(Token = "0x4039E55")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_coinFadeTween;

		// Token: 0x04039E56 RID: 237142
		[Token(Token = "0x4039E56")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039E57 RID: 237143
		[Token(Token = "0x4039E57")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039E58 RID: 237144
		[Token(Token = "0x4039E58")]
		[FieldOffset(Offset = "0xE8")]
		private ActMultiV3SquadEffectInfoView m_effectInfoView;

		// Token: 0x04039E59 RID: 237145
		[Token(Token = "0x4039E59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039E5A RID: 237146
		[Token(Token = "0x4039E5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSelectEffectInfo;

		// Token: 0x04039E5B RID: 237147
		[Token(Token = "0x4039E5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039E5C RID: 237148
		[Token(Token = "0x4039E5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x04039E5D RID: 237149
		[Token(Token = "0x4039E5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FC7 RID: 28615
		[Token(Token = "0x2006FC7")]
		private class EffectItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028A2B RID: 166443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028A2B")]
			[Address(RVA = "0x2402D50", Offset = "0x2401950", VA = "0x182402D50")]
			public EffectItemAdapter(ActMultiV3SquadEffectSelectView closure)
			{
			}

			// Token: 0x17005FEF RID: 24559
			// (get) Token: 0x06028A2C RID: 166444 RVA: 0x000D2798 File Offset: 0x000D0998
			[Token(Token = "0x17005FEF")]
			public override int count
			{
				[Token(Token = "0x6028A2C")]
				[Address(RVA = "0x2402DD0", Offset = "0x24019D0", VA = "0x182402DD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028A2D RID: 166445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028A2D")]
			[Address(RVA = "0x2402A90", Offset = "0x2401690", VA = "0x182402A90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039E5E RID: 237150
			[Token(Token = "0x4039E5E")]
			private const int COL_CNT = 3;

			// Token: 0x04039E5F RID: 237151
			[Token(Token = "0x4039E5F")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3SquadEffectSelectView m_closure;

			// Token: 0x04039E60 RID: 237152
			[Token(Token = "0x4039E60")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039E61 RID: 237153
			[Token(Token = "0x4039E61")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039E62 RID: 237154
			[Token(Token = "0x4039E62")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
