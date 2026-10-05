using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E34 RID: 24116
	[Token(Token = "0x2005E34")]
	public class CharacterRepoCardView : MonoBehaviour, IAsyncObjectListener, IHotfixable
	{
		// Token: 0x06022F26 RID: 143142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F26")]
		[Address(RVA = "0x1D78160", Offset = "0x1D76D60", VA = "0x181D78160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170052D7 RID: 21207
		// (get) Token: 0x06022F27 RID: 143143 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022F28 RID: 143144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052D7")]
		public Action<int> onClick
		{
			[Token(Token = "0x6022F27")]
			[Address(RVA = "0x1D78C10", Offset = "0x1D77810", VA = "0x181D78C10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022F28")]
			[Address(RVA = "0x1D78DD0", Offset = "0x1D779D0", VA = "0x181D78DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170052D8 RID: 21208
		// (get) Token: 0x06022F29 RID: 143145 RVA: 0x000BF940 File Offset: 0x000BDB40
		// (set) Token: 0x06022F2A RID: 143146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052D8")]
		public bool isGrey
		{
			[Token(Token = "0x6022F29")]
			[Address(RVA = "0x1D78B50", Offset = "0x1D77750", VA = "0x181D78B50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022F2A")]
			[Address(RVA = "0x1D78C70", Offset = "0x1D77870", VA = "0x181D78C70")]
			set
			{
			}
		}

		// Token: 0x170052D9 RID: 21209
		// (get) Token: 0x06022F2B RID: 143147 RVA: 0x000BF958 File Offset: 0x000BDB58
		// (set) Token: 0x06022F2C RID: 143148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052D9")]
		public bool isStarMarkSelected
		{
			[Token(Token = "0x6022F2B")]
			[Address(RVA = "0x1D78BB0", Offset = "0x1D777B0", VA = "0x181D78BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022F2C")]
			[Address(RVA = "0x1D78D40", Offset = "0x1D77940", VA = "0x181D78D40")]
			set
			{
			}
		}

		// Token: 0x06022F2D RID: 143149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F2D")]
		[Address(RVA = "0x1D77D90", Offset = "0x1D76990", VA = "0x181D77D90")]
		public void RenderCard(int index, CharacterCardViewModel viewModel, CharacterTrackPointData trackPointData, CharacterSortType sortType, CharacterRepoCardView.Params customParam)
		{
		}

		// Token: 0x06022F2E RID: 143150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F2E")]
		[Address(RVA = "0x1D78790", Offset = "0x1D77390", VA = "0x181D78790")]
		private void _UpdateCharCard(int index, CharacterCardViewModel cardModel, CharacterRepoCardView.Params customParam)
		{
		}

		// Token: 0x06022F2F RID: 143151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F2F")]
		[Address(RVA = "0x1D785A0", Offset = "0x1D771A0", VA = "0x181D785A0")]
		[Obsolete]
		private void _UpdateCharCardSync(int index, CharacterCardViewModel cardModel, CharacterRepoCardView.Params customParam)
		{
		}

		// Token: 0x06022F30 RID: 143152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F30")]
		[Address(RVA = "0x1D784E0", Offset = "0x1D770E0", VA = "0x181D784E0")]
		private static void _TraceForAVGIfPermitted(AVGSignalActions.Trigger avgBindCard, GameObject cardObject)
		{
		}

		// Token: 0x06022F31 RID: 143153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F31")]
		[Address(RVA = "0x1D77A00", Offset = "0x1D76600", VA = "0x181D77A00")]
		public void EventOnClick()
		{
		}

		// Token: 0x06022F32 RID: 143154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F32")]
		[Address(RVA = "0x1D782C0", Offset = "0x1D76EC0", VA = "0x181D782C0")]
		private void _OnClick(int chrInstId)
		{
		}

		// Token: 0x06022F33 RID: 143155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F33")]
		[Address(RVA = "0x1D783E0", Offset = "0x1D76FE0", VA = "0x181D783E0")]
		private void _SetStarMarkSelectStatus(bool select)
		{
		}

		// Token: 0x06022F34 RID: 143156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F34")]
		[Address(RVA = "0x1D77B70", Offset = "0x1D76770", VA = "0x181D77B70", Slot = "4")]
		public void OnGameObjectLoaded(GameObject cardObject)
		{
		}

		// Token: 0x06022F35 RID: 143157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F35")]
		[Address(RVA = "0x1D78A30", Offset = "0x1D77630", VA = "0x181D78A30")]
		public CharacterRepoCardView()
		{
		}

		// Token: 0x04030237 RID: 197175
		[Token(Token = "0x4030237")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _characterContainer;

		// Token: 0x04030238 RID: 197176
		[Token(Token = "0x4030238")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Scale factor used to scale the character card")]
		private float _cardScaleFactor;

		// Token: 0x04030239 RID: 197177
		[Token(Token = "0x4030239")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGroupSetter _greySetter;

		// Token: 0x0403023A RID: 197178
		[Token(Token = "0x403023A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _greyColor;

		// Token: 0x0403023B RID: 197179
		[Token(Token = "0x403023B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403023C RID: 197180
		[Token(Token = "0x403023C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _newPoint;

		// Token: 0x0403023D RID: 197181
		[Token(Token = "0x403023D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _newVoicePoint;

		// Token: 0x0403023E RID: 197182
		[Token(Token = "0x403023E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _starMarkSelectBg;

		// Token: 0x0403023F RID: 197183
		[Token(Token = "0x403023F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _starMarkSelectTag;

		// Token: 0x04030240 RID: 197184
		[Token(Token = "0x4030240")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _sortInfoContainer;

		// Token: 0x04030241 RID: 197185
		[Token(Token = "0x4030241")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICharacterSortInfoPanel _sortInfoPrefab;

		// Token: 0x04030242 RID: 197186
		[Token(Token = "0x4030242")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04030243 RID: 197187
		[Token(Token = "0x4030243")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isGrey;

		// Token: 0x04030244 RID: 197188
		[Token(Token = "0x4030244")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isInited;

		// Token: 0x04030245 RID: 197189
		[Token(Token = "0x4030245")]
		[FieldOffset(Offset = "0x84")]
		private int m_chrInstIdCache;

		// Token: 0x04030246 RID: 197190
		[Token(Token = "0x4030246")]
		[FieldOffset(Offset = "0x88")]
		private TrackPointViewProperty m_charRepoTrackProp;

		// Token: 0x04030247 RID: 197191
		[Token(Token = "0x4030247")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_charRepoNewTrackProp;

		// Token: 0x04030248 RID: 197192
		[Token(Token = "0x4030248")]
		[FieldOffset(Offset = "0x98")]
		private TrackPointViewProperty m_charRepoNewVoiceTrackProp;

		// Token: 0x04030249 RID: 197193
		[Token(Token = "0x4030249")]
		[FieldOffset(Offset = "0xA0")]
		private UICharacterSortInfoPanel m_sortInfoInst;

		// Token: 0x0403024A RID: 197194
		[Token(Token = "0x403024A")]
		[FieldOffset(Offset = "0xA8")]
		private AsyncDataViewHandler<UICharacterCardPanel, UICharacterCardPanel.AsyncParams> m_asyncHandler;

		// Token: 0x0403024B RID: 197195
		[Token(Token = "0x403024B")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject m_cardObject;

		// Token: 0x0403024C RID: 197196
		[Token(Token = "0x403024C")]
		[FieldOffset(Offset = "0xB8")]
		private AVGSignalActions.Trigger m_avgBindCard;

		// Token: 0x0403024D RID: 197197
		[Token(Token = "0x403024D")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_showSwitch;

		// Token: 0x0403024E RID: 197198
		[Token(Token = "0x403024E")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isStarMarkSelected;

		// Token: 0x04030250 RID: 197200
		[Token(Token = "0x4030250")]
		[FieldOffset(Offset = "0xD8")]
		private UICharacterCardPanel m_cardInst;

		// Token: 0x04030251 RID: 197201
		[Token(Token = "0x4030251")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030252 RID: 197202
		[Token(Token = "0x4030252")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04030253 RID: 197203
		[Token(Token = "0x4030253")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04030254 RID: 197204
		[Token(Token = "0x4030254")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isGrey;

		// Token: 0x04030255 RID: 197205
		[Token(Token = "0x4030255")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isGrey;

		// Token: 0x04030256 RID: 197206
		[Token(Token = "0x4030256")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isStarMarkSelected;

		// Token: 0x04030257 RID: 197207
		[Token(Token = "0x4030257")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isStarMarkSelected;

		// Token: 0x04030258 RID: 197208
		[Token(Token = "0x4030258")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x04030259 RID: 197209
		[Token(Token = "0x4030259")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateCharCard;

		// Token: 0x0403025A RID: 197210
		[Token(Token = "0x403025A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateCharCardSync;

		// Token: 0x0403025B RID: 197211
		[Token(Token = "0x403025B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TraceForAVGIfPermitted;

		// Token: 0x0403025C RID: 197212
		[Token(Token = "0x403025C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403025D RID: 197213
		[Token(Token = "0x403025D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x0403025E RID: 197214
		[Token(Token = "0x403025E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetStarMarkSelectStatus;

		// Token: 0x0403025F RID: 197215
		[Token(Token = "0x403025F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnGameObjectLoaded;

		// Token: 0x04030260 RID: 197216
		[Token(Token = "0x4030260")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E35 RID: 24117
		[Token(Token = "0x2005E35")]
		public struct Params
		{
			// Token: 0x04030261 RID: 197217
			[Token(Token = "0x4030261")]
			[FieldOffset(Offset = "0x0")]
			public AVGSignalActions.Trigger avgBindCard;

			// Token: 0x04030262 RID: 197218
			[Token(Token = "0x4030262")]
			[FieldOffset(Offset = "0x8")]
			public AsyncGameObjectLoader cardLoader;
		}

		// Token: 0x02005E36 RID: 24118
		[Token(Token = "0x2005E36")]
		[Obsolete("Use FadeSwitchTween.Builder.dontDisableGameObject instead.")]
		private class CardSwitchTween : FadeSwitchTween
		{
			// Token: 0x06022F36 RID: 143158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022F36")]
			[Address(RVA = "0x1D76BE0", Offset = "0x1D757E0", VA = "0x181D76BE0")]
			public CardSwitchTween(CanvasGroup alphaHandler)
			{
			}

			// Token: 0x06022F37 RID: 143159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022F37")]
			[Address(RVA = "0x1D76BA0", Offset = "0x1D757A0", VA = "0x181D76BA0", Slot = "20")]
			protected override void SetObjectActive(CanvasGroup alphaHandler, bool isActive)
			{
			}
		}
	}
}
