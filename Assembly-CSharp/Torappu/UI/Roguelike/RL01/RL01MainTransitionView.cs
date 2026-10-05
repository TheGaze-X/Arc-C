using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057C1 RID: 22465
	[Token(Token = "0x20057C1")]
	public class RL01MainTransitionView : RoguelikeMainTransController
	{
		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x06020DB8 RID: 134584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D0B")]
		protected FadeSwitchTween mainTransSwitch
		{
			[Token(Token = "0x6020DB8")]
			[Address(RVA = "0x1B2F410", Offset = "0x1B2E010", VA = "0x181B2F410")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020DB9 RID: 134585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DB9")]
		[Address(RVA = "0x1B2E770", Offset = "0x1B2D370", VA = "0x181B2E770")]
		private void OnEnable()
		{
		}

		// Token: 0x06020DBA RID: 134586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DBA")]
		[Address(RVA = "0x1B2E810", Offset = "0x1B2D410", VA = "0x181B2E810", Slot = "4")]
		public override void Render(RoguelikeDungeonZoneViewProperty property)
		{
		}

		// Token: 0x06020DBB RID: 134587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DBB")]
		[Address(RVA = "0x1B2E950", Offset = "0x1B2D550", VA = "0x181B2E950", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06020DBC RID: 134588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DBC")]
		[Address(RVA = "0x1B2EA10", Offset = "0x1B2D610", VA = "0x181B2EA10", Slot = "6")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x06020DBD RID: 134589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DBD")]
		[Address(RVA = "0x1B2EB20", Offset = "0x1B2D720", VA = "0x181B2EB20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020DBE RID: 134590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DBE")]
		[Address(RVA = "0x1B2E710", Offset = "0x1B2D310", VA = "0x181B2E710")]
		public void EventOnMainPanelClicked()
		{
		}

		// Token: 0x06020DBF RID: 134591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DBF")]
		[Address(RVA = "0x1B2EBB0", Offset = "0x1B2D7B0", VA = "0x181B2EBB0")]
		private void _RenderMainTrans(RoguelikeMainTransController.MainTransParam zoneParam)
		{
		}

		// Token: 0x06020DC0 RID: 134592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DC0")]
		[Address(RVA = "0x1B2F220", Offset = "0x1B2DE20", VA = "0x181B2F220")]
		private IEnumerator _WaitForNextClick()
		{
			return null;
		}

		// Token: 0x06020DC1 RID: 134593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DC1")]
		[Address(RVA = "0x1B2F2D0", Offset = "0x1B2DED0", VA = "0x181B2F2D0")]
		public RL01MainTransitionView()
		{
		}

		// Token: 0x0402CA53 RID: 182867
		[Token(Token = "0x402CA53")]
		private const float SHOW_TWEEN_DURATION = 1.5f;

		// Token: 0x0402CA54 RID: 182868
		[Token(Token = "0x402CA54")]
		private const float HIDE_TWEEN_DURATION = 0.5f;

		// Token: 0x0402CA55 RID: 182869
		[Token(Token = "0x402CA55")]
		private const float AUTO_MAIN_TRANS_DUR = 1.5f;

		// Token: 0x0402CA56 RID: 182870
		[Token(Token = "0x402CA56")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelMainTrans;

		// Token: 0x0402CA57 RID: 182871
		[Token(Token = "0x402CA57")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClickPlayer _clickAudio;

		// Token: 0x0402CA58 RID: 182872
		[Token(Token = "0x402CA58")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402CA59 RID: 182873
		[Token(Token = "0x402CA59")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402CA5A RID: 182874
		[Token(Token = "0x402CA5A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _labelAutoTransition;

		// Token: 0x0402CA5B RID: 182875
		[Token(Token = "0x402CA5B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _labelManualTransition;

		// Token: 0x0402CA5C RID: 182876
		[Token(Token = "0x402CA5C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RL01TransitionClockView _clockView;

		// Token: 0x0402CA5D RID: 182877
		[Token(Token = "0x402CA5D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Variation")]
		private SimpleLayoutContent _tagLayoutContent;

		// Token: 0x0402CA5E RID: 182878
		[Token(Token = "0x402CA5E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0402CA5F RID: 182879
		[Token(Token = "0x402CA5F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _fusionNameText;

		// Token: 0x0402CA60 RID: 182880
		[Token(Token = "0x402CA60")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _variationAnim;

		// Token: 0x0402CA61 RID: 182881
		[Token(Token = "0x402CA61")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _fusionAnim;

		// Token: 0x0402CA62 RID: 182882
		[Token(Token = "0x402CA62")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_animTween;

		// Token: 0x0402CA63 RID: 182883
		[Token(Token = "0x402CA63")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_clockTween;

		// Token: 0x0402CA64 RID: 182884
		[Token(Token = "0x402CA64")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_fusionTween;

		// Token: 0x0402CA65 RID: 182885
		[Token(Token = "0x402CA65")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0402CA66 RID: 182886
		[Token(Token = "0x402CA66")]
		[FieldOffset(Offset = "0xB0")]
		private RL01MainTransitionView.TagAdapter m_tagAdapter;

		// Token: 0x0402CA67 RID: 182887
		[Token(Token = "0x402CA67")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeMainTransController.MainTransParam m_cachedMainTransParam;

		// Token: 0x0402CA68 RID: 182888
		[Token(Token = "0x402CA68")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_waitForNextClick;

		// Token: 0x0402CA69 RID: 182889
		[Token(Token = "0x402CA69")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_waitForAnimEnd;

		// Token: 0x0402CA6A RID: 182890
		[Token(Token = "0x402CA6A")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cacheTopicId;

		// Token: 0x0402CA6B RID: 182891
		[Token(Token = "0x402CA6B")]
		[FieldOffset(Offset = "0xE8")]
		private List<string> m_cacheVariationIdList;

		// Token: 0x0402CA6C RID: 182892
		[Token(Token = "0x402CA6C")]
		[FieldOffset(Offset = "0xF0")]
		private string m_cacheFusionId;

		// Token: 0x0402CA6D RID: 182893
		[Token(Token = "0x402CA6D")]
		[FieldOffset(Offset = "0xF8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402CA6E RID: 182894
		[Token(Token = "0x402CA6E")]
		[FieldOffset(Offset = "0x108")]
		private FadeSwitchTween m_mainTransSwitch;

		// Token: 0x0402CA6F RID: 182895
		[Token(Token = "0x402CA6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainTransSwitch;

		// Token: 0x0402CA70 RID: 182896
		[Token(Token = "0x402CA70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402CA71 RID: 182897
		[Token(Token = "0x402CA71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CA72 RID: 182898
		[Token(Token = "0x402CA72")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402CA73 RID: 182899
		[Token(Token = "0x402CA73")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402CA74 RID: 182900
		[Token(Token = "0x402CA74")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CA75 RID: 182901
		[Token(Token = "0x402CA75")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnMainPanelClicked;

		// Token: 0x0402CA76 RID: 182902
		[Token(Token = "0x402CA76")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderMainTrans;

		// Token: 0x0402CA77 RID: 182903
		[Token(Token = "0x402CA77")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__WaitForNextClick;

		// Token: 0x0402CA78 RID: 182904
		[Token(Token = "0x402CA78")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057C2 RID: 22466
		[Token(Token = "0x20057C2")]
		private class TagAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004D0C RID: 19724
			// (get) Token: 0x06020DC5 RID: 134597 RVA: 0x000B7960 File Offset: 0x000B5B60
			[Token(Token = "0x17004D0C")]
			public override int count
			{
				[Token(Token = "0x6020DC5")]
				[Address(RVA = "0x1B43830", Offset = "0x1B42430", VA = "0x181B43830", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020DC6 RID: 134598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020DC6")]
			[Address(RVA = "0x1B43580", Offset = "0x1B42180", VA = "0x181B43580", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020DC7 RID: 134599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DC7")]
			[Address(RVA = "0x1B43730", Offset = "0x1B42330", VA = "0x181B43730")]
			public void SetVariationParam(string topicId, List<string> variationIdList)
			{
			}

			// Token: 0x06020DC8 RID: 134600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DC8")]
			[Address(RVA = "0x1B437D0", Offset = "0x1B423D0", VA = "0x181B437D0")]
			public TagAdapter()
			{
			}

			// Token: 0x0402CA79 RID: 182905
			[Token(Token = "0x402CA79")]
			[FieldOffset(Offset = "0x20")]
			private string m_topicId;

			// Token: 0x0402CA7A RID: 182906
			[Token(Token = "0x402CA7A")]
			[FieldOffset(Offset = "0x28")]
			private List<string> m_variationIdList;

			// Token: 0x0402CA7B RID: 182907
			[Token(Token = "0x402CA7B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402CA7C RID: 182908
			[Token(Token = "0x402CA7C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402CA7D RID: 182909
			[Token(Token = "0x402CA7D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetVariationParam;

			// Token: 0x0402CA7E RID: 182910
			[Token(Token = "0x402CA7E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
