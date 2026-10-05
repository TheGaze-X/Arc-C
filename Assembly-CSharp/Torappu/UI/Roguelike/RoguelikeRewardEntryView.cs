using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053DD RID: 21469
	[Token(Token = "0x20053DD")]
	public class RoguelikeRewardEntryView : DataBinder<RoguelikeRewardViewProperty>
	{
		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x0601F973 RID: 129395 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F974 RID: 129396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049FA")]
		public RoguelikeRewardStyle uiStyle
		{
			[Token(Token = "0x601F973")]
			[Address(RVA = "0x193CCE0", Offset = "0x193B8E0", VA = "0x18193CCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F974")]
			[Address(RVA = "0x193CDC0", Offset = "0x193B9C0", VA = "0x18193CDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x0601F975 RID: 129397 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F976 RID: 129398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049FB")]
		public RoguelikeRewardState bindRewardState
		{
			[Token(Token = "0x601F975")]
			[Address(RVA = "0x193CC80", Offset = "0x193B880", VA = "0x18193CC80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F976")]
			[Address(RVA = "0x193CD40", Offset = "0x193B940", VA = "0x18193CD40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F977 RID: 129399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F977")]
		[Address(RVA = "0x193B240", Offset = "0x1939E40", VA = "0x18193B240")]
		private void _InitIfNot(string topicId)
		{
		}

		// Token: 0x0601F978 RID: 129400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F978")]
		[Address(RVA = "0x193BB20", Offset = "0x193A720", VA = "0x18193BB20")]
		private void _RenderInitPart(RoguelikeRewardEntryView.RenderParam renderParam)
		{
		}

		// Token: 0x0601F979 RID: 129401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F979")]
		[Address(RVA = "0x193B850", Offset = "0x193A450", VA = "0x18193B850")]
		private void _RenderDelta(RoguelikeRewardEntryView.RenderParam renderParam)
		{
		}

		// Token: 0x0601F97A RID: 129402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F97A")]
		[Address(RVA = "0x193ADF0", Offset = "0x19399F0", VA = "0x18193ADF0")]
		private IEnumerator EffectPart(RoguelikeRewardEntryView.RenderParam renderParam)
		{
			return null;
		}

		// Token: 0x0601F97B RID: 129403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F97B")]
		[Address(RVA = "0x193B690", Offset = "0x193A290", VA = "0x18193B690")]
		private RoguelikeRewardEntryView.HpBarDecorationView _LoadHpDeco(string topicId, UIStateFinder finder)
		{
			return null;
		}

		// Token: 0x0601F97C RID: 129404 RVA: 0x000B25D8 File Offset: 0x000B07D8
		[Token(Token = "0x601F97C")]
		[Address(RVA = "0x193CB10", Offset = "0x193B710", VA = "0x18193CB10")]
		private CharWordShowType _ShowWhichCharWord(RoguelikeGameStageData stageData, RoguelikeRewardEarnViewModel earnViewModel, bool isPefectAndSuccessBattle)
		{
			return CharWordShowType.HOME_SHOW;
		}

		// Token: 0x0601F97D RID: 129405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F97D")]
		[Address(RVA = "0x193AF60", Offset = "0x1939B60", VA = "0x18193AF60", Slot = "7")]
		public override void OnValueChanged(RoguelikeRewardViewProperty property)
		{
		}

		// Token: 0x0601F97E RID: 129406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F97E")]
		[Address(RVA = "0x193CBE0", Offset = "0x193B7E0", VA = "0x18193CBE0")]
		public RoguelikeRewardEntryView()
		{
		}

		// Token: 0x0402A88C RID: 174220
		[Token(Token = "0x402A88C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageBackground;

		// Token: 0x0402A88D RID: 174221
		[Token(Token = "0x402A88D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0402A88E RID: 174222
		[Token(Token = "0x402A88E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rect;

		// Token: 0x0402A88F RID: 174223
		[Token(Token = "0x402A88F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _illustCont;

		// Token: 0x0402A890 RID: 174224
		[Token(Token = "0x402A890")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AVGTypeWriterText _illustText;

		// Token: 0x0402A891 RID: 174225
		[Token(Token = "0x402A891")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _illustTextPanel;

		// Token: 0x0402A892 RID: 174226
		[Token(Token = "0x402A892")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelTextSuccess;

		// Token: 0x0402A893 RID: 174227
		[Token(Token = "0x402A893")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelTextFail;

		// Token: 0x0402A894 RID: 174228
		[Token(Token = "0x402A894")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animationLocationEntry;

		// Token: 0x0402A895 RID: 174229
		[Token(Token = "0x402A895")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _hpPart;

		// Token: 0x0402A896 RID: 174230
		[Token(Token = "0x402A896")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _hpNormPart;

		// Token: 0x0402A897 RID: 174231
		[Token(Token = "0x402A897")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _currentHP;

		// Token: 0x0402A898 RID: 174232
		[Token(Token = "0x402A898")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _hpLoseImg;

		// Token: 0x0402A899 RID: 174233
		[Token(Token = "0x402A899")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _hpWithMaxPart;

		// Token: 0x0402A89A RID: 174234
		[Token(Token = "0x402A89A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _currentHpWithMax;

		// Token: 0x0402A89B RID: 174235
		[Token(Token = "0x402A89B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _currentMaxHp;

		// Token: 0x0402A89C RID: 174236
		[Token(Token = "0x402A89C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _hpWithMaxLoseImg;

		// Token: 0x0402A89D RID: 174237
		[Token(Token = "0x402A89D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _minusHP;

		// Token: 0x0402A89E RID: 174238
		[Token(Token = "0x402A89E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _noHpLosePart;

		// Token: 0x0402A89F RID: 174239
		[Token(Token = "0x402A89F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _perfectItemHolder;

		// Token: 0x0402A8A0 RID: 174240
		[Token(Token = "0x402A8A0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup _hpLosePart;

		// Token: 0x0402A8A1 RID: 174241
		[Token(Token = "0x402A8A1")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _shieldPart;

		// Token: 0x0402A8A2 RID: 174242
		[Token(Token = "0x402A8A2")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _shieldLoseBg;

		// Token: 0x0402A8A3 RID: 174243
		[Token(Token = "0x402A8A3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _currentShield;

		// Token: 0x0402A8A4 RID: 174244
		[Token(Token = "0x402A8A4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _textHpLoseTitle;

		// Token: 0x0402A8A5 RID: 174245
		[Token(Token = "0x402A8A5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AnimationWrapper _hpAnimationWrapper;

		// Token: 0x0402A8A6 RID: 174246
		[Token(Token = "0x402A8A6")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Level Part")]
		private RLRewardEntryLevelPartView _normalLevelPartView;

		// Token: 0x0402A8A7 RID: 174247
		[Token(Token = "0x402A8A7")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Level Part")]
		private RectTransform _spLevelPartContainer;

		// Token: 0x0402A8A8 RID: 174248
		[Token(Token = "0x402A8A8")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private AnimationWrapper _popAddAnimationWrapper;

		// Token: 0x0402A8A9 RID: 174249
		[Token(Token = "0x402A8A9")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _popAddObj;

		// Token: 0x0402A8AA RID: 174250
		[Token(Token = "0x402A8AA")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private RoguelikePopBarView _barView;

		// Token: 0x0402A8AC RID: 174252
		[Token(Token = "0x402A8AC")]
		[FieldOffset(Offset = "0x128")]
		private RoguelikeRewardPerfectItemView m_perfectItemView;

		// Token: 0x0402A8AD RID: 174253
		[Token(Token = "0x402A8AD")]
		[FieldOffset(Offset = "0x130")]
		private bool m_isRendered;

		// Token: 0x0402A8AE RID: 174254
		[Token(Token = "0x402A8AE")]
		[FieldOffset(Offset = "0x138")]
		private GameObject m_cacheView;

		// Token: 0x0402A8AF RID: 174255
		[Token(Token = "0x402A8AF")]
		[FieldOffset(Offset = "0x140")]
		private string m_illustWord;

		// Token: 0x0402A8B0 RID: 174256
		[Token(Token = "0x402A8B0")]
		[FieldOffset(Offset = "0x148")]
		private RLRewardEntryLevelPartView m_spLevelPartPrefab;

		// Token: 0x0402A8B1 RID: 174257
		[Token(Token = "0x402A8B1")]
		[FieldOffset(Offset = "0x150")]
		private RLRewardEntryLevelPartView m_levelPartView;

		// Token: 0x0402A8B2 RID: 174258
		[Token(Token = "0x402A8B2")]
		[FieldOffset(Offset = "0x158")]
		[NonSerialized]
		public bool isEffectFinishFlag;

		// Token: 0x0402A8B3 RID: 174259
		[Token(Token = "0x402A8B3")]
		[FieldOffset(Offset = "0x159")]
		private bool m_inited;

		// Token: 0x0402A8B4 RID: 174260
		[Token(Token = "0x402A8B4")]
		[FieldOffset(Offset = "0x160")]
		private Tween m_effectTween;

		// Token: 0x0402A8B5 RID: 174261
		[Token(Token = "0x402A8B5")]
		[FieldOffset(Offset = "0x168")]
		private bool isHpNoLoseShowFar;

		// Token: 0x0402A8B6 RID: 174262
		[Token(Token = "0x402A8B6")]
		private const float CONST_ALPHA = 0.4f;

		// Token: 0x0402A8B7 RID: 174263
		[Token(Token = "0x402A8B7")]
		private const float INIT_HEIGHT = -58f;

		// Token: 0x0402A8B8 RID: 174264
		[Token(Token = "0x402A8B8")]
		private const float TARGET_HEIGHT = 40f;

		// Token: 0x0402A8B9 RID: 174265
		[Token(Token = "0x402A8B9")]
		private const float HP_NO_LOSE_POS_1 = 187f;

		// Token: 0x0402A8BA RID: 174266
		[Token(Token = "0x402A8BA")]
		private const float HP_NO_LOSE_POS_2 = 104f;

		// Token: 0x0402A8BB RID: 174267
		[Token(Token = "0x402A8BB")]
		private const int OBJ_BEFORE_HP_NO_LOSE = 2;

		// Token: 0x0402A8BC RID: 174268
		[Token(Token = "0x402A8BC")]
		[FieldOffset(Offset = "0x170")]
		private UIStateFinder m_finder;

		// Token: 0x0402A8BE RID: 174270
		[Token(Token = "0x402A8BE")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private RectTransform _hpDecoHolder;

		// Token: 0x0402A8BF RID: 174271
		[Token(Token = "0x402A8BF")]
		[FieldOffset(Offset = "0x190")]
		private RoguelikeRewardEntryView.HpBarDecorationView m_hpDecorationView;

		// Token: 0x0402A8C0 RID: 174272
		[Token(Token = "0x402A8C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiStyle;

		// Token: 0x0402A8C1 RID: 174273
		[Token(Token = "0x402A8C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_uiStyle;

		// Token: 0x0402A8C2 RID: 174274
		[Token(Token = "0x402A8C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bindRewardState;

		// Token: 0x0402A8C3 RID: 174275
		[Token(Token = "0x402A8C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_bindRewardState;

		// Token: 0x0402A8C4 RID: 174276
		[Token(Token = "0x402A8C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A8C5 RID: 174277
		[Token(Token = "0x402A8C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderInitPart;

		// Token: 0x0402A8C6 RID: 174278
		[Token(Token = "0x402A8C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderDelta;

		// Token: 0x0402A8C7 RID: 174279
		[Token(Token = "0x402A8C7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EffectPart;

		// Token: 0x0402A8C8 RID: 174280
		[Token(Token = "0x402A8C8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadHpDeco;

		// Token: 0x0402A8C9 RID: 174281
		[Token(Token = "0x402A8C9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowWhichCharWord;

		// Token: 0x0402A8CA RID: 174282
		[Token(Token = "0x402A8CA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402A8CB RID: 174283
		[Token(Token = "0x402A8CB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053DE RID: 21470
		[Token(Token = "0x20053DE")]
		private struct RenderParam
		{
			// Token: 0x0402A8CC RID: 174284
			[Token(Token = "0x402A8CC")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402A8CD RID: 174285
			[Token(Token = "0x402A8CD")]
			[FieldOffset(Offset = "0x8")]
			public RoguelikeRewardEarnViewModel earnViewModel;

			// Token: 0x0402A8CE RID: 174286
			[Token(Token = "0x402A8CE")]
			[FieldOffset(Offset = "0x10")]
			public string charInst;

			// Token: 0x0402A8CF RID: 174287
			[Token(Token = "0x402A8CF")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x0402A8D0 RID: 174288
			[Token(Token = "0x402A8D0")]
			[FieldOffset(Offset = "0x20")]
			public bool isUseSpExpStyle;

			// Token: 0x0402A8D1 RID: 174289
			[Token(Token = "0x402A8D1")]
			[FieldOffset(Offset = "0x24")]
			public int battleResultState;

			// Token: 0x0402A8D2 RID: 174290
			[Token(Token = "0x402A8D2")]
			[FieldOffset(Offset = "0x28")]
			public bool battleIsPerfect;
		}

		// Token: 0x020053DF RID: 21471
		[Token(Token = "0x20053DF")]
		public class HpBarDecorationView : MonoBehaviour, IHotfixable
		{
			// Token: 0x0601F97F RID: 129407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F97F")]
			[Address(RVA = "0x1937C50", Offset = "0x1936850", VA = "0x181937C50", Slot = "4")]
			public virtual void Render(string topicId)
			{
			}

			// Token: 0x0601F980 RID: 129408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F980")]
			[Address(RVA = "0x1937CB0", Offset = "0x19368B0", VA = "0x181937CB0")]
			public HpBarDecorationView()
			{
			}

			// Token: 0x0402A8D3 RID: 174291
			[Token(Token = "0x402A8D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402A8D4 RID: 174292
			[Token(Token = "0x402A8D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
