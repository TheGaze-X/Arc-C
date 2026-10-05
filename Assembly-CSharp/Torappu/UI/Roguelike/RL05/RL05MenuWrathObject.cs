using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055E3 RID: 21987
	[Token(Token = "0x20055E3")]
	public class RL05MenuWrathObject : RoguelikeMenuObject<RL05MenuWrathViewModel>
	{
		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x06020463 RID: 132195 RVA: 0x000B52C0 File Offset: 0x000B34C0
		[Token(Token = "0x17004BA2")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020463")]
			[Address(RVA = "0x1A6A520", Offset = "0x1A69120", VA = "0x181A6A520", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020464 RID: 132196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020464")]
		[Address(RVA = "0x1A68420", Offset = "0x1A67020", VA = "0x181A68420", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06020465 RID: 132197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020465")]
		[Address(RVA = "0x1A689C0", Offset = "0x1A675C0", VA = "0x181A689C0", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x06020466 RID: 132198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020466")]
		[Address(RVA = "0x1A68B00", Offset = "0x1A67700", VA = "0x181A68B00", Slot = "16")]
		public override void Render(RL05MenuWrathViewModel viewModel)
		{
		}

		// Token: 0x06020467 RID: 132199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020467")]
		[Address(RVA = "0x1A68890", Offset = "0x1A67490", VA = "0x181A68890", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x06020468 RID: 132200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020468")]
		[Address(RVA = "0x1A69CB0", Offset = "0x1A688B0", VA = "0x181A69CB0")]
		private void _Render(bool fastMode, bool isFromAdapterChange)
		{
		}

		// Token: 0x06020469 RID: 132201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020469")]
		[Address(RVA = "0x1A69E00", Offset = "0x1A68A00", VA = "0x181A69E00")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x0602046A RID: 132202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602046A")]
		[Address(RVA = "0x1A69320", Offset = "0x1A67F20", VA = "0x181A69320")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x0602046B RID: 132203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602046B")]
		[Address(RVA = "0x1A69B10", Offset = "0x1A68710", VA = "0x181A69B10")]
		private void _RenderZone(string zoneId, bool fastMode)
		{
		}

		// Token: 0x0602046C RID: 132204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602046C")]
		[Address(RVA = "0x1A69850", Offset = "0x1A68450", VA = "0x181A69850")]
		private void _RenderWrath(RL05MenuWrathObject.WrathParam wrathParam, bool fastMode)
		{
		}

		// Token: 0x0602046D RID: 132205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602046D")]
		[Address(RVA = "0x1A693D0", Offset = "0x1A67FD0", VA = "0x181A693D0")]
		private void _RenderWrathPart(RL05MenuWrathViewModel viewModel, bool fastMode)
		{
		}

		// Token: 0x0602046E RID: 132206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602046E")]
		[Address(RVA = "0x1A69080", Offset = "0x1A67C80", VA = "0x181A69080")]
		private void _PlayWrathAnimation(RL05MenuWrathViewModel viewModel)
		{
		}

		// Token: 0x0602046F RID: 132207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602046F")]
		[Address(RVA = "0x1A69EE0", Offset = "0x1A68AE0", VA = "0x181A69EE0")]
		private void _UpdateWrathTags(RL05MenuWrathViewModel viewModel, bool fastMode)
		{
		}

		// Token: 0x06020470 RID: 132208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020470")]
		[Address(RVA = "0x1A69550", Offset = "0x1A68150", VA = "0x181A69550")]
		private void _RenderWrathTags(RL05MenuWrathViewModel viewModel)
		{
		}

		// Token: 0x06020471 RID: 132209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020471")]
		[Address(RVA = "0x1A68D80", Offset = "0x1A67980", VA = "0x181A68D80")]
		private void _ClearWrathTags()
		{
		}

		// Token: 0x06020472 RID: 132210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020472")]
		[Address(RVA = "0x1A68FE0", Offset = "0x1A67BE0", VA = "0x181A68FE0")]
		private void _EventOnNewWrathGain(object arg)
		{
		}

		// Token: 0x06020473 RID: 132211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020473")]
		[Address(RVA = "0x1A68F40", Offset = "0x1A67B40", VA = "0x181A68F40")]
		private void _EventOnDungeonShowAnim(object arg)
		{
		}

		// Token: 0x06020474 RID: 132212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020474")]
		[Address(RVA = "0x1A6A440", Offset = "0x1A69040", VA = "0x181A6A440")]
		public RL05MenuWrathObject()
		{
		}

		// Token: 0x0602047B RID: 132219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602047B")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0602047C RID: 132220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602047C")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0602047D RID: 132221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602047D")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402BAA5 RID: 178853
		[Token(Token = "0x402BAA5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402BAA6 RID: 178854
		[Token(Token = "0x402BAA6")]
		private const string WRATH_ANIMATION_NAME_FORMAT = "rogue5_menu_disaster_level_{0}";

		// Token: 0x0402BAA7 RID: 178855
		[Token(Token = "0x402BAA7")]
		private const float WRATH_LAYOUT_SPACING_ANIM_TIME = 0.5f;

		// Token: 0x0402BAA8 RID: 178856
		[Token(Token = "0x402BAA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0402BAA9 RID: 178857
		[Token(Token = "0x402BAA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtZoneName;

		// Token: 0x0402BAAA RID: 178858
		[Token(Token = "0x402BAAA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelWrath;

		// Token: 0x0402BAAB RID: 178859
		[Token(Token = "0x402BAAB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgZoneIcon;

		// Token: 0x0402BAAC RID: 178860
		[Token(Token = "0x402BAAC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _wrathTagContainer;

		// Token: 0x0402BAAD RID: 178861
		[Token(Token = "0x402BAAD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HorizontalLayoutGroup _wrathTagLayout;

		// Token: 0x0402BAAE RID: 178862
		[Token(Token = "0x402BAAE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _wrathTagPrefab;

		// Token: 0x0402BAAF RID: 178863
		[Token(Token = "0x402BAAF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _wrathEffects;

		// Token: 0x0402BAB0 RID: 178864
		[Token(Token = "0x402BAB0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _zoneName;

		// Token: 0x0402BAB1 RID: 178865
		[Token(Token = "0x402BAB1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _zoneIcon;

		// Token: 0x0402BAB2 RID: 178866
		[Token(Token = "0x402BAB2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnWrath;

		// Token: 0x0402BAB3 RID: 178867
		[Token(Token = "0x402BAB3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _wrathLevelAnimationWrapper;

		// Token: 0x0402BAB4 RID: 178868
		[Token(Token = "0x402BAB4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIColorGraphic _hotspotColorGraphic;

		// Token: 0x0402BAB5 RID: 178869
		[Token(Token = "0x402BAB5")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_wrathLevelAnimationTween;

		// Token: 0x0402BAB6 RID: 178870
		[Token(Token = "0x402BAB6")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_spacingTween;

		// Token: 0x0402BAB7 RID: 178871
		[Token(Token = "0x402BAB7")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BAB8 RID: 178872
		[Token(Token = "0x402BAB8")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402BAB9 RID: 178873
		[Token(Token = "0x402BAB9")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeMenuViewRenderer<string> m_zoneRenderer;

		// Token: 0x0402BABA RID: 178874
		[Token(Token = "0x402BABA")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeMenuViewRenderer<RL05MenuWrathObject.WrathParam> m_wrathRenderer;

		// Token: 0x0402BABB RID: 178875
		[Token(Token = "0x402BABB")]
		[FieldOffset(Offset = "0xC8")]
		private RL05MenuWrathViewModel m_cachedModel;

		// Token: 0x0402BABC RID: 178876
		[Token(Token = "0x402BABC")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_cachedStateShow;

		// Token: 0x0402BABD RID: 178877
		[Token(Token = "0x402BABD")]
		[FieldOffset(Offset = "0xD8")]
		private List<RL05MenuWrathTagObject> m_wrathTagObjs;

		// Token: 0x0402BABE RID: 178878
		[Token(Token = "0x402BABE")]
		[FieldOffset(Offset = "0xE0")]
		private List<string> m_cachedNewWrathIds;

		// Token: 0x0402BABF RID: 178879
		[Token(Token = "0x402BABF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402BAC0 RID: 178880
		[Token(Token = "0x402BAC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402BAC1 RID: 178881
		[Token(Token = "0x402BAC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402BAC2 RID: 178882
		[Token(Token = "0x402BAC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BAC3 RID: 178883
		[Token(Token = "0x402BAC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402BAC4 RID: 178884
		[Token(Token = "0x402BAC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402BAC5 RID: 178885
		[Token(Token = "0x402BAC5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402BAC6 RID: 178886
		[Token(Token = "0x402BAC6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402BAC7 RID: 178887
		[Token(Token = "0x402BAC7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderZone;

		// Token: 0x0402BAC8 RID: 178888
		[Token(Token = "0x402BAC8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderWrath;

		// Token: 0x0402BAC9 RID: 178889
		[Token(Token = "0x402BAC9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderWrathPart;

		// Token: 0x0402BACA RID: 178890
		[Token(Token = "0x402BACA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayWrathAnimation;

		// Token: 0x0402BACB RID: 178891
		[Token(Token = "0x402BACB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateWrathTags;

		// Token: 0x0402BACC RID: 178892
		[Token(Token = "0x402BACC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderWrathTags;

		// Token: 0x0402BACD RID: 178893
		[Token(Token = "0x402BACD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ClearWrathTags;

		// Token: 0x0402BACE RID: 178894
		[Token(Token = "0x402BACE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnNewWrathGain;

		// Token: 0x0402BACF RID: 178895
		[Token(Token = "0x402BACF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnDungeonShowAnim;

		// Token: 0x0402BAD0 RID: 178896
		[Token(Token = "0x402BAD0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055E4 RID: 21988
		[Token(Token = "0x20055E4")]
		private struct WrathParam
		{
			// Token: 0x0402BAD1 RID: 178897
			[Token(Token = "0x402BAD1")]
			[FieldOffset(Offset = "0x0")]
			public bool isInit;

			// Token: 0x0402BAD2 RID: 178898
			[Token(Token = "0x402BAD2")]
			[FieldOffset(Offset = "0x1")]
			public bool hasWrath;

			// Token: 0x0402BAD3 RID: 178899
			[Token(Token = "0x402BAD3")]
			[FieldOffset(Offset = "0x8")]
			public ShallowEqualArray<string> wrathIds;
		}
	}
}
