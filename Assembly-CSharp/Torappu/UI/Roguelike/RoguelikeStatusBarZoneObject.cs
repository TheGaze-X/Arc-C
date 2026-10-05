using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005319 RID: 21273
	[Token(Token = "0x2005319")]
	public class RoguelikeStatusBarZoneObject : RoguelikeMenuObject<RoguelikeMenuZoneViewModel>
	{
		// Token: 0x0601F635 RID: 128565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F635")]
		[Address(RVA = "0x191D6F0", Offset = "0x191C2F0", VA = "0x18191D6F0", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x0601F636 RID: 128566 RVA: 0x000B1BE8 File Offset: 0x000AFDE8
		[Token(Token = "0x17004996")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F636")]
			[Address(RVA = "0x191E400", Offset = "0x191D000", VA = "0x18191E400", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F637 RID: 128567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F637")]
		[Address(RVA = "0x191D820", Offset = "0x191C420", VA = "0x18191D820", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F638 RID: 128568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F638")]
		[Address(RVA = "0x191D930", Offset = "0x191C530", VA = "0x18191D930", Slot = "16")]
		public override void Render(RoguelikeMenuZoneViewModel viewModel)
		{
		}

		// Token: 0x0601F639 RID: 128569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F639")]
		[Address(RVA = "0x191DD70", Offset = "0x191C970", VA = "0x18191DD70")]
		private void _Render()
		{
		}

		// Token: 0x0601F63A RID: 128570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F63A")]
		[Address(RVA = "0x191DA30", Offset = "0x191C630", VA = "0x18191DA30")]
		private void _EventOnShowVariationEffect(object arg)
		{
		}

		// Token: 0x0601F63B RID: 128571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F63B")]
		[Address(RVA = "0x191E370", Offset = "0x191CF70", VA = "0x18191E370")]
		public RoguelikeStatusBarZoneObject()
		{
		}

		// Token: 0x0601F63D RID: 128573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F63D")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0601F63E RID: 128574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F63E")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0402A30C RID: 172812
		[Token(Token = "0x402A30C")]
		private const float LOOP_DURATION = 1f;

		// Token: 0x0402A30D RID: 172813
		[Token(Token = "0x402A30D")]
		private const float LOOP_ALPHA_MIN = 0.5f;

		// Token: 0x0402A30E RID: 172814
		[Token(Token = "0x402A30E")]
		private const float LOOP_ALPHA_MAX = 1f;

		// Token: 0x0402A30F RID: 172815
		[Token(Token = "0x402A30F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402A310 RID: 172816
		[Token(Token = "0x402A310")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlContent;

		// Token: 0x0402A311 RID: 172817
		[Token(Token = "0x402A311")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _btnDetail;

		// Token: 0x0402A312 RID: 172818
		[Token(Token = "0x402A312")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textZoneName;

		// Token: 0x0402A313 RID: 172819
		[Token(Token = "0x402A313")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textZoneDesc;

		// Token: 0x0402A314 RID: 172820
		[Token(Token = "0x402A314")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeStatusBarZoneObject.VariationPanel _variationPanel1;

		// Token: 0x0402A315 RID: 172821
		[Token(Token = "0x402A315")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeStatusBarZoneObject.VariationPanel _variationPanel2;

		// Token: 0x0402A316 RID: 172822
		[Token(Token = "0x402A316")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeStatusBarZoneObject.FusionPanel _fusionPanel;

		// Token: 0x0402A317 RID: 172823
		[Token(Token = "0x402A317")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _validFusionToggle;

		// Token: 0x0402A318 RID: 172824
		[Token(Token = "0x402A318")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _animVariation;

		// Token: 0x0402A319 RID: 172825
		[Token(Token = "0x402A319")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _lightVariation;

		// Token: 0x0402A31A RID: 172826
		[Token(Token = "0x402A31A")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeMenuZoneViewModel m_cachedModel;

		// Token: 0x0402A31B RID: 172827
		[Token(Token = "0x402A31B")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_lightTween;

		// Token: 0x0402A31C RID: 172828
		[Token(Token = "0x402A31C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A31D RID: 172829
		[Token(Token = "0x402A31D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A31E RID: 172830
		[Token(Token = "0x402A31E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A31F RID: 172831
		[Token(Token = "0x402A31F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A320 RID: 172832
		[Token(Token = "0x402A320")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402A321 RID: 172833
		[Token(Token = "0x402A321")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnShowVariationEffect;

		// Token: 0x0402A322 RID: 172834
		[Token(Token = "0x402A322")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200531A RID: 21274
		[Token(Token = "0x200531A")]
		[Serializable]
		private class VariationPanel
		{
			// Token: 0x0601F63F RID: 128575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F63F")]
			[Address(RVA = "0x1920C30", Offset = "0x191F830", VA = "0x181920C30")]
			public void Render(RoguelikeVariationModel model)
			{
			}

			// Token: 0x0601F640 RID: 128576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F640")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VariationPanel()
			{
			}

			// Token: 0x0402A323 RID: 172835
			[Token(Token = "0x402A323")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panelVariationName;

			// Token: 0x0402A324 RID: 172836
			[Token(Token = "0x402A324")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textVariationName;
		}

		// Token: 0x0200531B RID: 21275
		[Token(Token = "0x200531B")]
		[Serializable]
		private class FusionPanel
		{
			// Token: 0x0601F641 RID: 128577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F641")]
			[Address(RVA = "0x190C260", Offset = "0x190AE60", VA = "0x18190C260")]
			public void Render(RoguelikeFusionModel model)
			{
			}

			// Token: 0x0601F642 RID: 128578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F642")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FusionPanel()
			{
			}

			// Token: 0x0402A325 RID: 172837
			[Token(Token = "0x402A325")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panelFusionName;

			// Token: 0x0402A326 RID: 172838
			[Token(Token = "0x402A326")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textFusionName;
		}
	}
}
