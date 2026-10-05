using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005722 RID: 22306
	[Token(Token = "0x2005722")]
	public class RL04MainTransitionView : RoguelikeMainTransController
	{
		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x06020B14 RID: 133908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CA7")]
		protected FadeSwitchTween mainTransSwitch
		{
			[Token(Token = "0x6020B14")]
			[Address(RVA = "0x1B13B20", Offset = "0x1B12720", VA = "0x181B13B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020B15 RID: 133909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B15")]
		[Address(RVA = "0x1B13480", Offset = "0x1B12080", VA = "0x181B13480")]
		private void OnEnable()
		{
		}

		// Token: 0x06020B16 RID: 133910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B16")]
		[Address(RVA = "0x1B13520", Offset = "0x1B12120", VA = "0x181B13520", Slot = "4")]
		public override void Render(RoguelikeDungeonZoneViewProperty property)
		{
		}

		// Token: 0x06020B17 RID: 133911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B17")]
		[Address(RVA = "0x1B13680", Offset = "0x1B12280", VA = "0x181B13680", Slot = "6")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x06020B18 RID: 133912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B18")]
		[Address(RVA = "0x1B135E0", Offset = "0x1B121E0", VA = "0x181B135E0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06020B19 RID: 133913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B19")]
		[Address(RVA = "0x1B13420", Offset = "0x1B12020", VA = "0x181B13420")]
		public void EventOnMainPanelClicked()
		{
		}

		// Token: 0x06020B1A RID: 133914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B1A")]
		[Address(RVA = "0x1B13750", Offset = "0x1B12350", VA = "0x181B13750")]
		private void _RenderMainTrans(RoguelikeMainTransController.MainTransParam zoneParam)
		{
		}

		// Token: 0x06020B1B RID: 133915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B1B")]
		[Address(RVA = "0x1B13A10", Offset = "0x1B12610", VA = "0x181B13A10")]
		private IEnumerator _WaitForNextClick()
		{
			return null;
		}

		// Token: 0x06020B1C RID: 133916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B1C")]
		[Address(RVA = "0x1B13AC0", Offset = "0x1B126C0", VA = "0x181B13AC0")]
		public RL04MainTransitionView()
		{
		}

		// Token: 0x0402C5E6 RID: 181734
		[Token(Token = "0x402C5E6")]
		private const float SHOW_TWEEN_DURATION = 1.5f;

		// Token: 0x0402C5E7 RID: 181735
		[Token(Token = "0x402C5E7")]
		private const float HIDE_TWEEN_DURATION = 0.5f;

		// Token: 0x0402C5E8 RID: 181736
		[Token(Token = "0x402C5E8")]
		private const float AUTO_MAIN_TRANS_DUR = 1.5f;

		// Token: 0x0402C5E9 RID: 181737
		[Token(Token = "0x402C5E9")]
		private const string ANIM_ENTER = "anim_main_trans_enter";

		// Token: 0x0402C5EA RID: 181738
		[Token(Token = "0x402C5EA")]
		private const string SECRET_ID = "zone_secret";

		// Token: 0x0402C5EB RID: 181739
		[Token(Token = "0x402C5EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelMainTrans;

		// Token: 0x0402C5EC RID: 181740
		[Token(Token = "0x402C5EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClickPlayer _clickAudio;

		// Token: 0x0402C5ED RID: 181741
		[Token(Token = "0x402C5ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402C5EE RID: 181742
		[Token(Token = "0x402C5EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402C5EF RID: 181743
		[Token(Token = "0x402C5EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0402C5F0 RID: 181744
		[Token(Token = "0x402C5F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0402C5F1 RID: 181745
		[Token(Token = "0x402C5F1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgLevelLabel;

		// Token: 0x0402C5F2 RID: 181746
		[Token(Token = "0x402C5F2")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_enterTween;

		// Token: 0x0402C5F3 RID: 181747
		[Token(Token = "0x402C5F3")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeMainTransController.MainTransParam m_cachedMainTransParam;

		// Token: 0x0402C5F4 RID: 181748
		[Token(Token = "0x402C5F4")]
		[FieldOffset(Offset = "0x80")]
		private bool m_waitForNextClick;

		// Token: 0x0402C5F5 RID: 181749
		[Token(Token = "0x402C5F5")]
		[FieldOffset(Offset = "0x81")]
		private bool m_waitForAnimEnd;

		// Token: 0x0402C5F6 RID: 181750
		[Token(Token = "0x402C5F6")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C5F7 RID: 181751
		[Token(Token = "0x402C5F7")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_mainTransSwitch;

		// Token: 0x0402C5F8 RID: 181752
		[Token(Token = "0x402C5F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainTransSwitch;

		// Token: 0x0402C5F9 RID: 181753
		[Token(Token = "0x402C5F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402C5FA RID: 181754
		[Token(Token = "0x402C5FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C5FB RID: 181755
		[Token(Token = "0x402C5FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402C5FC RID: 181756
		[Token(Token = "0x402C5FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402C5FD RID: 181757
		[Token(Token = "0x402C5FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnMainPanelClicked;

		// Token: 0x0402C5FE RID: 181758
		[Token(Token = "0x402C5FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderMainTrans;

		// Token: 0x0402C5FF RID: 181759
		[Token(Token = "0x402C5FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__WaitForNextClick;

		// Token: 0x0402C600 RID: 181760
		[Token(Token = "0x402C600")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
