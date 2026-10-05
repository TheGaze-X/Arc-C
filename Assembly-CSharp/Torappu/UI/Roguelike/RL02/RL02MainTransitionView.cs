using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x020057A3 RID: 22435
	[Token(Token = "0x20057A3")]
	public class RL02MainTransitionView : RoguelikeMainTransController
	{
		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x06020D10 RID: 134416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CEC")]
		protected FadeSwitchTween mainTransSwitch
		{
			[Token(Token = "0x6020D10")]
			[Address(RVA = "0x1B23200", Offset = "0x1B21E00", VA = "0x181B23200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020D11 RID: 134417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D11")]
		[Address(RVA = "0x1B22770", Offset = "0x1B21370", VA = "0x181B22770")]
		private void OnEnable()
		{
		}

		// Token: 0x06020D12 RID: 134418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D12")]
		[Address(RVA = "0x1B22810", Offset = "0x1B21410", VA = "0x181B22810", Slot = "4")]
		public override void Render(RoguelikeDungeonZoneViewProperty property)
		{
		}

		// Token: 0x06020D13 RID: 134419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D13")]
		[Address(RVA = "0x1B22A10", Offset = "0x1B21610", VA = "0x181B22A10", Slot = "6")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x06020D14 RID: 134420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D14")]
		[Address(RVA = "0x1B22950", Offset = "0x1B21550", VA = "0x181B22950", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06020D15 RID: 134421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D15")]
		[Address(RVA = "0x1B22B00", Offset = "0x1B21700", VA = "0x181B22B00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020D16 RID: 134422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D16")]
		[Address(RVA = "0x1B22710", Offset = "0x1B21310", VA = "0x181B22710")]
		public void EventOnMainPanelClicked()
		{
		}

		// Token: 0x06020D17 RID: 134423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D17")]
		[Address(RVA = "0x1B22B90", Offset = "0x1B21790", VA = "0x181B22B90")]
		private void _RenderMainTrans(RoguelikeMainTransController.MainTransParam zoneParam)
		{
		}

		// Token: 0x06020D18 RID: 134424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D18")]
		[Address(RVA = "0x1B23060", Offset = "0x1B21C60", VA = "0x181B23060")]
		private IEnumerator _WaitForNextClick()
		{
			return null;
		}

		// Token: 0x06020D19 RID: 134425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D19")]
		[Address(RVA = "0x1B22FB0", Offset = "0x1B21BB0", VA = "0x181B22FB0")]
		private IEnumerator _ShowVariationTrans()
		{
			return null;
		}

		// Token: 0x06020D1A RID: 134426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D1A")]
		[Address(RVA = "0x1B23110", Offset = "0x1B21D10", VA = "0x181B23110")]
		public RL02MainTransitionView()
		{
		}

		// Token: 0x0402C96C RID: 182636
		[Token(Token = "0x402C96C")]
		private const float SHOW_TWEEN_DURATION = 1.5f;

		// Token: 0x0402C96D RID: 182637
		[Token(Token = "0x402C96D")]
		private const float HIDE_TWEEN_DURATION = 0.5f;

		// Token: 0x0402C96E RID: 182638
		[Token(Token = "0x402C96E")]
		private const float AUTO_MAIN_TRANS_DUR = 1.5f;

		// Token: 0x0402C96F RID: 182639
		[Token(Token = "0x402C96F")]
		private const string ANIM_ENTER = "anim_main_trans_enter";

		// Token: 0x0402C970 RID: 182640
		[Token(Token = "0x402C970")]
		private const string ANIM_VARIATION = "anim_main_trans_vari";

		// Token: 0x0402C971 RID: 182641
		[Token(Token = "0x402C971")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelMainTrans;

		// Token: 0x0402C972 RID: 182642
		[Token(Token = "0x402C972")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClickPlayer _clickAudio;

		// Token: 0x0402C973 RID: 182643
		[Token(Token = "0x402C973")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _iconAtlasImage;

		// Token: 0x0402C974 RID: 182644
		[Token(Token = "0x402C974")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402C975 RID: 182645
		[Token(Token = "0x402C975")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402C976 RID: 182646
		[Token(Token = "0x402C976")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgLevelLabel;

		// Token: 0x0402C977 RID: 182647
		[Token(Token = "0x402C977")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _tagLayoutContent;

		// Token: 0x0402C978 RID: 182648
		[Token(Token = "0x402C978")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<RL02MainTransitionView.ZoneIconStruct> _zoneIconStructs;

		// Token: 0x0402C979 RID: 182649
		[Token(Token = "0x402C979")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasObject _uiAtlasObject;

		// Token: 0x0402C97A RID: 182650
		[Token(Token = "0x402C97A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _effectPrefab;

		// Token: 0x0402C97B RID: 182651
		[Token(Token = "0x402C97B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _effectTransform;

		// Token: 0x0402C97C RID: 182652
		[Token(Token = "0x402C97C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0402C97D RID: 182653
		[Token(Token = "0x402C97D")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_enterTween;

		// Token: 0x0402C97E RID: 182654
		[Token(Token = "0x402C97E")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_variationTween;

		// Token: 0x0402C97F RID: 182655
		[Token(Token = "0x402C97F")]
		[FieldOffset(Offset = "0x90")]
		private GameObject m_variationEffect;

		// Token: 0x0402C980 RID: 182656
		[Token(Token = "0x402C980")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0402C981 RID: 182657
		[Token(Token = "0x402C981")]
		[FieldOffset(Offset = "0xA0")]
		private RL02MainTransitionView.TagAdapter m_tagAdapter;

		// Token: 0x0402C982 RID: 182658
		[Token(Token = "0x402C982")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeMainTransController.MainTransParam m_cachedMainTransParam;

		// Token: 0x0402C983 RID: 182659
		[Token(Token = "0x402C983")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_waitForNextClick;

		// Token: 0x0402C984 RID: 182660
		[Token(Token = "0x402C984")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_waitForAnimEnd;

		// Token: 0x0402C985 RID: 182661
		[Token(Token = "0x402C985")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C986 RID: 182662
		[Token(Token = "0x402C986")]
		[FieldOffset(Offset = "0xE0")]
		private FadeSwitchTween m_mainTransSwitch;

		// Token: 0x0402C987 RID: 182663
		[Token(Token = "0x402C987")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainTransSwitch;

		// Token: 0x0402C988 RID: 182664
		[Token(Token = "0x402C988")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402C989 RID: 182665
		[Token(Token = "0x402C989")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C98A RID: 182666
		[Token(Token = "0x402C98A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402C98B RID: 182667
		[Token(Token = "0x402C98B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402C98C RID: 182668
		[Token(Token = "0x402C98C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C98D RID: 182669
		[Token(Token = "0x402C98D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnMainPanelClicked;

		// Token: 0x0402C98E RID: 182670
		[Token(Token = "0x402C98E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderMainTrans;

		// Token: 0x0402C98F RID: 182671
		[Token(Token = "0x402C98F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__WaitForNextClick;

		// Token: 0x0402C990 RID: 182672
		[Token(Token = "0x402C990")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowVariationTrans;

		// Token: 0x0402C991 RID: 182673
		[Token(Token = "0x402C991")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057A4 RID: 22436
		[Token(Token = "0x20057A4")]
		[Serializable]
		private struct ZoneIconStruct
		{
			// Token: 0x0402C992 RID: 182674
			[Token(Token = "0x402C992")]
			[FieldOffset(Offset = "0x0")]
			public string zoneId;

			// Token: 0x0402C993 RID: 182675
			[Token(Token = "0x402C993")]
			[FieldOffset(Offset = "0x8")]
			public string iconId;
		}

		// Token: 0x020057A5 RID: 22437
		[Token(Token = "0x20057A5")]
		private class TagAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004CED RID: 19693
			// (get) Token: 0x06020D1D RID: 134429 RVA: 0x000B7738 File Offset: 0x000B5938
			[Token(Token = "0x17004CED")]
			public override int count
			{
				[Token(Token = "0x6020D1D")]
				[Address(RVA = "0x1B2B690", Offset = "0x1B2A290", VA = "0x181B2B690", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020D1E RID: 134430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020D1E")]
			[Address(RVA = "0x1B2B320", Offset = "0x1B29F20", VA = "0x181B2B320", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020D1F RID: 134431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D1F")]
			[Address(RVA = "0x1B2B630", Offset = "0x1B2A230", VA = "0x181B2B630")]
			public TagAdapter()
			{
			}

			// Token: 0x0402C994 RID: 182676
			[Token(Token = "0x402C994")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeMainTransController.MainTransParam viewParam;

			// Token: 0x0402C995 RID: 182677
			[Token(Token = "0x402C995")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C996 RID: 182678
			[Token(Token = "0x402C996")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402C997 RID: 182679
			[Token(Token = "0x402C997")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
