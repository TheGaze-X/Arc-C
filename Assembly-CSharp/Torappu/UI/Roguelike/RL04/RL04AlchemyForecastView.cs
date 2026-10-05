using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200566E RID: 22126
	[Token(Token = "0x200566E")]
	public class RL04AlchemyForecastView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020779 RID: 132985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020779")]
		[Address(RVA = "0x1A906A0", Offset = "0x1A8F2A0", VA = "0x181A906A0")]
		public void Render(RL04AlchemyForecastViewModel forecastViewModel, RL04AlchemyForecastRandomViewModel emptyRandomViewModel, bool isMelded)
		{
		}

		// Token: 0x0602077A RID: 132986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602077A")]
		[Address(RVA = "0x1A908F0", Offset = "0x1A8F4F0", VA = "0x181A908F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602077B RID: 132987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602077B")]
		[Address(RVA = "0x1A91190", Offset = "0x1A8FD90", VA = "0x181A91190")]
		private void _RenderNotReadyPart(RL04AlchemyForecastRandomViewModel emptyRandomViewModel)
		{
		}

		// Token: 0x0602077C RID: 132988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602077C")]
		[Address(RVA = "0x1A914B0", Offset = "0x1A900B0", VA = "0x181A914B0")]
		private void _RenderRandomPart(RL04AlchemyForecastRandomViewModel randomViewModel)
		{
		}

		// Token: 0x0602077D RID: 132989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602077D")]
		[Address(RVA = "0x1A90DA0", Offset = "0x1A8F9A0", VA = "0x181A90DA0")]
		private void _RefreshRewardForecastTxt(AlchemyPoolRarityType rarityType)
		{
		}

		// Token: 0x0602077E RID: 132990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602077E")]
		[Address(RVA = "0x1A90ED0", Offset = "0x1A8FAD0", VA = "0x181A90ED0")]
		private void _RenderDefinitenessPart(RL04AlchemyForecastDefinitenessItemViewModel definitenessItemViewModel)
		{
		}

		// Token: 0x0602077F RID: 132991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602077F")]
		[Address(RVA = "0x1A916E0", Offset = "0x1A902E0", VA = "0x181A916E0")]
		private void _SlidePropToValue(float relicProp, float shieldProp, float populationProp)
		{
		}

		// Token: 0x06020780 RID: 132992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020780")]
		[Address(RVA = "0x1A918D0", Offset = "0x1A904D0", VA = "0x181A918D0")]
		public RL04AlchemyForecastView()
		{
		}

		// Token: 0x0402BF86 RID: 180102
		[Token(Token = "0x402BF86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _ensureAnim;

		// Token: 0x0402BF87 RID: 180103
		[Token(Token = "0x402BF87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _durForWeightGuyShow;

		// Token: 0x0402BF88 RID: 180104
		[Token(Token = "0x402BF88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _weightGuyAnim;

		// Token: 0x0402BF89 RID: 180105
		[Token(Token = "0x402BF89")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasWeightGuy;

		// Token: 0x0402BF8A RID: 180106
		[Token(Token = "0x402BF8A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Not Ready Part")]
		private CanvasGroup _canvasRarityNotReady;

		// Token: 0x0402BF8B RID: 180107
		[Token(Token = "0x402BF8B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Random Part")]
		private Text _txtRewardForecast;

		// Token: 0x0402BF8C RID: 180108
		[Token(Token = "0x402BF8C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Random Part")]
		private CanvasGroup _canvasRarityReady;

		// Token: 0x0402BF8D RID: 180109
		[Token(Token = "0x402BF8D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Random Part")]
		private SimpleLayoutContent _rarityStarList;

		// Token: 0x0402BF8E RID: 180110
		[Token(Token = "0x402BF8E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Random Part")]
		private UIAnimationLocation _rarityNormalAnim;

		// Token: 0x0402BF8F RID: 180111
		[Token(Token = "0x402BF8F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Random Part")]
		private UIAnimationLocation _rarityRareAnim;

		// Token: 0x0402BF90 RID: 180112
		[Token(Token = "0x402BF90")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Random Part")]
		private UIAnimationLocation _raritySuperRareAnim;

		// Token: 0x0402BF91 RID: 180113
		[Token(Token = "0x402BF91")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Random Part")]
		private Slider _sliderRelic;

		// Token: 0x0402BF92 RID: 180114
		[Token(Token = "0x402BF92")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Random Part")]
		private Slider _sliderShield;

		// Token: 0x0402BF93 RID: 180115
		[Token(Token = "0x402BF93")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Random Part")]
		private Slider _sliderPopulation;

		// Token: 0x0402BF94 RID: 180116
		[Token(Token = "0x402BF94")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Random Part")]
		private float _sliderTweenDuration;

		// Token: 0x0402BF95 RID: 180117
		[Token(Token = "0x402BF95")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Definiteness Part")]
		private RL04ItemIconWithFragment _definiteRewardItem;

		// Token: 0x0402BF96 RID: 180118
		[Token(Token = "0x402BF96")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Definiteness Part")]
		private Text _txtDefiniteRewardItemName;

		// Token: 0x0402BF97 RID: 180119
		[Token(Token = "0x402BF97")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Definiteness Part")]
		private Text _txtDefiniteRewardItemDesc;

		// Token: 0x0402BF98 RID: 180120
		[Token(Token = "0x402BF98")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x0402BF99 RID: 180121
		[Token(Token = "0x402BF99")]
		[FieldOffset(Offset = "0xD8")]
		private RL04AlchemyForecastView.PoolRarityStarListAdapter m_poolRarityStarListAdapter;

		// Token: 0x0402BF9A RID: 180122
		[Token(Token = "0x402BF9A")]
		[FieldOffset(Offset = "0xE0")]
		private UISwitchTween.TweenWrapper m_weightSwitchTweenWrapper;

		// Token: 0x0402BF9B RID: 180123
		[Token(Token = "0x402BF9B")]
		[FieldOffset(Offset = "0xE8")]
		private RL04AlchemyForecastView.WeightSwitchTween m_weightSwitchTween;

		// Token: 0x0402BF9C RID: 180124
		[Token(Token = "0x402BF9C")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_ensureAnimTween;

		// Token: 0x0402BF9D RID: 180125
		[Token(Token = "0x402BF9D")]
		[FieldOffset(Offset = "0xF8")]
		private AnimationSwitchTween m_rarityNormalAnimTween;

		// Token: 0x0402BF9E RID: 180126
		[Token(Token = "0x402BF9E")]
		[FieldOffset(Offset = "0x100")]
		private AnimationSwitchTween m_rarityRareAnimTween;

		// Token: 0x0402BF9F RID: 180127
		[Token(Token = "0x402BF9F")]
		[FieldOffset(Offset = "0x108")]
		private AnimationSwitchTween m_raritySuperRareAnimTween;

		// Token: 0x0402BFA0 RID: 180128
		[Token(Token = "0x402BFA0")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_sliderRelicTween;

		// Token: 0x0402BFA1 RID: 180129
		[Token(Token = "0x402BFA1")]
		[FieldOffset(Offset = "0x118")]
		private Tween m_sliderShieldTween;

		// Token: 0x0402BFA2 RID: 180130
		[Token(Token = "0x402BFA2")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_sliderPopulationTween;

		// Token: 0x0402BFA3 RID: 180131
		[Token(Token = "0x402BFA3")]
		[FieldOffset(Offset = "0x128")]
		private FadeSwitchTween m_rarityNotReady;

		// Token: 0x0402BFA4 RID: 180132
		[Token(Token = "0x402BFA4")]
		[FieldOffset(Offset = "0x130")]
		private FadeSwitchTween m_rarityReady;

		// Token: 0x0402BFA5 RID: 180133
		[Token(Token = "0x402BFA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BFA6 RID: 180134
		[Token(Token = "0x402BFA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BFA7 RID: 180135
		[Token(Token = "0x402BFA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderNotReadyPart;

		// Token: 0x0402BFA8 RID: 180136
		[Token(Token = "0x402BFA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderRandomPart;

		// Token: 0x0402BFA9 RID: 180137
		[Token(Token = "0x402BFA9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshRewardForecastTxt;

		// Token: 0x0402BFAA RID: 180138
		[Token(Token = "0x402BFAA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderDefinitenessPart;

		// Token: 0x0402BFAB RID: 180139
		[Token(Token = "0x402BFAB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SlidePropToValue;

		// Token: 0x0402BFAC RID: 180140
		[Token(Token = "0x402BFAC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200566F RID: 22127
		[Token(Token = "0x200566F")]
		private class PoolRarityStarListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004C1A RID: 19482
			// (get) Token: 0x06020781 RID: 132993 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020782 RID: 132994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004C1A")]
			public List<RL04AlchemyForecastRandomViewModel.RandomRewardRarityItemStatus> rarityDataList
			{
				[Token(Token = "0x6020781")]
				[Address(RVA = "0x1A8BDA0", Offset = "0x1A8A9A0", VA = "0x181A8BDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020782")]
				[Address(RVA = "0x1A8BE00", Offset = "0x1A8AA00", VA = "0x181A8BE00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004C1B RID: 19483
			// (get) Token: 0x06020783 RID: 132995 RVA: 0x000B61D8 File Offset: 0x000B43D8
			[Token(Token = "0x17004C1B")]
			public override int count
			{
				[Token(Token = "0x6020783")]
				[Address(RVA = "0x1A8BCE0", Offset = "0x1A8A8E0", VA = "0x181A8BCE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020784 RID: 132996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020784")]
			[Address(RVA = "0x1A8B950", Offset = "0x1A8A550", VA = "0x181A8B950", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020785 RID: 132997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020785")]
			[Address(RVA = "0x1A8BC80", Offset = "0x1A8A880", VA = "0x181A8BC80")]
			public PoolRarityStarListAdapter()
			{
			}

			// Token: 0x0402BFAE RID: 180142
			[Token(Token = "0x402BFAE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_rarityDataList;

			// Token: 0x0402BFAF RID: 180143
			[Token(Token = "0x402BFAF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_rarityDataList;

			// Token: 0x0402BFB0 RID: 180144
			[Token(Token = "0x402BFB0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402BFB1 RID: 180145
			[Token(Token = "0x402BFB1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402BFB2 RID: 180146
			[Token(Token = "0x402BFB2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005670 RID: 22128
		[Token(Token = "0x2005670")]
		private class WeightSwitchTween : UISwitchTween
		{
			// Token: 0x06020786 RID: 132998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020786")]
			[Address(RVA = "0x1AA3690", Offset = "0x1AA2290", VA = "0x181AA3690")]
			public WeightSwitchTween(RL04AlchemyForecastView itemView)
			{
			}

			// Token: 0x06020787 RID: 132999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020787")]
			[Address(RVA = "0x1AA3420", Offset = "0x1AA2020", VA = "0x181AA3420", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06020788 RID: 133000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020788")]
			[Address(RVA = "0x1AA32A0", Offset = "0x1AA1EA0", VA = "0x181AA32A0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0402BFB3 RID: 180147
			[Token(Token = "0x402BFB3")]
			[FieldOffset(Offset = "0x48")]
			private RL04AlchemyForecastView m_closure;

			// Token: 0x0402BFB4 RID: 180148
			[Token(Token = "0x402BFB4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BFB5 RID: 180149
			[Token(Token = "0x402BFB5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402BFB6 RID: 180150
			[Token(Token = "0x402BFB6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}
	}
}
