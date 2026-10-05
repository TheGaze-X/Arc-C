using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003ED3 RID: 16083
	[Token(Token = "0x2003ED3")]
	public class SkinGroupCommonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018F45 RID: 102213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F45")]
		[Address(RVA = "0x1199820", Offset = "0x1198420", VA = "0x181199820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018F46 RID: 102214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F46")]
		[Address(RVA = "0x1199050", Offset = "0x1197C50", VA = "0x181199050")]
		public void ApplyState(float state)
		{
		}

		// Token: 0x06018F47 RID: 102215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F47")]
		[Address(RVA = "0x1199790", Offset = "0x1198390", VA = "0x181199790")]
		public void SetIllustVisible(bool isVisible)
		{
		}

		// Token: 0x06018F48 RID: 102216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F48")]
		[Address(RVA = "0x1199610", Offset = "0x1198210", VA = "0x181199610")]
		public void SetIllustObjectType(SkinGroupCommonView.IllustObjectType type)
		{
		}

		// Token: 0x06018F49 RID: 102217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F49")]
		[Address(RVA = "0x1198850", Offset = "0x1197450", VA = "0x181198850")]
		public void ApplyData(int index, SkinSelectViewModel viewModel, UIPage page)
		{
		}

		// Token: 0x06018F4A RID: 102218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F4A")]
		[Address(RVA = "0x1199C80", Offset = "0x1198880", VA = "0x181199C80")]
		private void _LoadIllusts(SkinSelectViewModel viewModel, UICharacterIllustLoader illustLoader)
		{
		}

		// Token: 0x06018F4B RID: 102219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F4B")]
		[Address(RVA = "0x1199FB0", Offset = "0x1198BB0", VA = "0x181199FB0")]
		private void _SetDrawerName(string name)
		{
		}

		// Token: 0x06018F4C RID: 102220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F4C")]
		[Address(RVA = "0x119A140", Offset = "0x1198D40", VA = "0x18119A140")]
		private void _SetModelName(string name)
		{
		}

		// Token: 0x06018F4D RID: 102221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F4D")]
		[Address(RVA = "0x119A2D0", Offset = "0x1198ED0", VA = "0x18119A2D0")]
		private void _TryLoadSpineIfNot()
		{
		}

		// Token: 0x06018F4E RID: 102222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F4E")]
		[Address(RVA = "0x11999E0", Offset = "0x11985E0", VA = "0x1811999E0")]
		private UICharacterIllust _LoadAndConfigIllust(UICharacterIllustLoader illustLoader, CharUISkinStruct skinStruct, bool showDynIllust)
		{
			return null;
		}

		// Token: 0x06018F4F RID: 102223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F4F")]
		[Address(RVA = "0x119A390", Offset = "0x1198F90", VA = "0x18119A390")]
		public SkinGroupCommonView()
		{
		}

		// Token: 0x0401ECDD RID: 126173
		[Token(Token = "0x401ECDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SkinGroupCommonView.ListImage> _toColor;

		// Token: 0x0401ECDE RID: 126174
		[Token(Token = "0x401ECDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _avatarImage;

		// Token: 0x0401ECDF RID: 126175
		[Token(Token = "0x401ECDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Obsolete("This would only be used as a placeholder for UIAtlasImage")]
		private Image _portraitImage;

		// Token: 0x0401ECE0 RID: 126176
		[Token(Token = "0x401ECE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x0401ECE1 RID: 126177
		[Token(Token = "0x401ECE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharSpineHolder _spineHolder;

		// Token: 0x0401ECE2 RID: 126178
		[Token(Token = "0x401ECE2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0401ECE3 RID: 126179
		[Token(Token = "0x401ECE3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("DrawerName")]
		[Tooltip("Legacy")]
		[HideInInspector]
		private Text _drawerName;

		// Token: 0x0401ECE4 RID: 126180
		[Token(Token = "0x401ECE4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("DrawerName")]
		[Tooltip("Nullable")]
		private Text _pureDrawerName;

		// Token: 0x0401ECE5 RID: 126181
		[Token(Token = "0x401ECE5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("ModelName")]
		[Tooltip("Legacy")]
		[HideInInspector]
		private Text _modelName;

		// Token: 0x0401ECE6 RID: 126182
		[Token(Token = "0x401ECE6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("ModelName")]
		[Tooltip("Nullable")]
		private Text _pureModelName;

		// Token: 0x0401ECE7 RID: 126183
		[Token(Token = "0x401ECE7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _content;

		// Token: 0x0401ECE8 RID: 126184
		[Token(Token = "0x401ECE8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAutoSlideRect _autoSlideRect;

		// Token: 0x0401ECE9 RID: 126185
		[Token(Token = "0x401ECE9")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401ECEA RID: 126186
		[Token(Token = "0x401ECEA")]
		[FieldOffset(Offset = "0x80")]
		private SkinGroupCommonView.IllustObjectWrapper m_illustObjectWrapper;

		// Token: 0x0401ECEB RID: 126187
		[Token(Token = "0x401ECEB")]
		[FieldOffset(Offset = "0x88")]
		private UIAtlasImage m_portraitImg;

		// Token: 0x0401ECEC RID: 126188
		[Token(Token = "0x401ECEC")]
		[FieldOffset(Offset = "0x90")]
		public int index;

		// Token: 0x0401ECED RID: 126189
		[Token(Token = "0x401ECED")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedSkinId;

		// Token: 0x0401ECEE RID: 126190
		[Token(Token = "0x401ECEE")]
		[FieldOffset(Offset = "0xA0")]
		private SkinSelectViewModel m_cachedViewModel;

		// Token: 0x0401ECEF RID: 126191
		[Token(Token = "0x401ECEF")]
		[FieldOffset(Offset = "0xA8")]
		private SkinSelectState.IllustClickInfo m_clickInfo;

		// Token: 0x0401ECF0 RID: 126192
		[Token(Token = "0x401ECF0")]
		[FieldOffset(Offset = "0xB0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401ECF1 RID: 126193
		[Token(Token = "0x401ECF1")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedPortraitId;

		// Token: 0x0401ECF2 RID: 126194
		[Token(Token = "0x401ECF2")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedAvatarId;

		// Token: 0x0401ECF3 RID: 126195
		[Token(Token = "0x401ECF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401ECF4 RID: 126196
		[Token(Token = "0x401ECF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0401ECF5 RID: 126197
		[Token(Token = "0x401ECF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetIllustVisible;

		// Token: 0x0401ECF6 RID: 126198
		[Token(Token = "0x401ECF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetIllustObjectType;

		// Token: 0x0401ECF7 RID: 126199
		[Token(Token = "0x401ECF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0401ECF8 RID: 126200
		[Token(Token = "0x401ECF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadIllusts;

		// Token: 0x0401ECF9 RID: 126201
		[Token(Token = "0x401ECF9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetDrawerName;

		// Token: 0x0401ECFA RID: 126202
		[Token(Token = "0x401ECFA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetModelName;

		// Token: 0x0401ECFB RID: 126203
		[Token(Token = "0x401ECFB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryLoadSpineIfNot;

		// Token: 0x0401ECFC RID: 126204
		[Token(Token = "0x401ECFC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadAndConfigIllust;

		// Token: 0x0401ECFD RID: 126205
		[Token(Token = "0x401ECFD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003ED4 RID: 16084
		[Token(Token = "0x2003ED4")]
		public enum IllustObjectType
		{
			// Token: 0x0401ECFF RID: 126207
			[Token(Token = "0x401ECFF")]
			DEFAULT,
			// Token: 0x0401ED00 RID: 126208
			[Token(Token = "0x401ED00")]
			SP_DYN_ILLUST
		}

		// Token: 0x02003ED5 RID: 16085
		[Token(Token = "0x2003ED5")]
		private class IllustObjectWrapper
		{
			// Token: 0x17003B82 RID: 15234
			// (get) Token: 0x06018F50 RID: 102224 RVA: 0x0009C750 File Offset: 0x0009A950
			[Token(Token = "0x17003B82")]
			public bool isActiveIllust
			{
				[Token(Token = "0x6018F50")]
				[Address(RVA = "0x1196410", Offset = "0x1195010", VA = "0x181196410")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003B83 RID: 15235
			// (get) Token: 0x06018F51 RID: 102225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003B83")]
			public UICharacterIllust currentIllust
			{
				[Token(Token = "0x6018F51")]
				[Address(RVA = "0x11963A0", Offset = "0x1194FA0", VA = "0x1811963A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06018F52 RID: 102226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F52")]
			[Address(RVA = "0x1196110", Offset = "0x1194D10", VA = "0x181196110")]
			public IllustObjectWrapper(SkinGroupCommonView.IllustObjectType initType, EnumIntDictionary<SkinGroupCommonView.IllustObjectType, UICharacterIllust> illustDict, bool isStaticIllustWithSp)
			{
			}

			// Token: 0x06018F53 RID: 102227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F53")]
			[Address(RVA = "0x1195F60", Offset = "0x1194B60", VA = "0x181195F60")]
			public void ActivateIllust()
			{
			}

			// Token: 0x06018F54 RID: 102228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F54")]
			[Address(RVA = "0x1195FF0", Offset = "0x1194BF0", VA = "0x181195FF0")]
			public void SwitchIllustObjectType(SkinGroupCommonView.IllustObjectType type)
			{
			}

			// Token: 0x0401ED01 RID: 126209
			[Token(Token = "0x401ED01")]
			[FieldOffset(Offset = "0x10")]
			private EnumIntDictionary<SkinGroupCommonView.IllustObjectType, UICharacterIllust> m_illustDict;

			// Token: 0x0401ED02 RID: 126210
			[Token(Token = "0x401ED02")]
			[FieldOffset(Offset = "0x18")]
			private SkinGroupCommonView.IllustObjectType m_currentIllustObjectType;

			// Token: 0x0401ED03 RID: 126211
			[Token(Token = "0x401ED03")]
			[FieldOffset(Offset = "0x20")]
			private UISwitchTween m_staticIllustSwitchTween;

			// Token: 0x02003ED6 RID: 16086
			[Token(Token = "0x2003ED6")]
			private class SwitchTween : UISwitchTween
			{
				// Token: 0x06018F55 RID: 102229 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6018F55")]
				[Address(RVA = "0x11AAA50", Offset = "0x11A9650", VA = "0x1811AAA50")]
				public SwitchTween(CanvasGroup canvasDefault, CanvasGroup canvasSp)
				{
				}

				// Token: 0x06018F56 RID: 102230 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6018F56")]
				[Address(RVA = "0x11AA710", Offset = "0x11A9310", VA = "0x1811AA710", Slot = "5")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
				{
					return null;
				}

				// Token: 0x06018F57 RID: 102231 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6018F57")]
				[Address(RVA = "0x11AA850", Offset = "0x11A9450", VA = "0x1811AA850", Slot = "4")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
				{
					return null;
				}

				// Token: 0x06018F58 RID: 102232 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6018F58")]
				[Address(RVA = "0x11AA990", Offset = "0x11A9590", VA = "0x1811AA990", Slot = "10")]
				protected override void ResetToState(bool isShow)
				{
				}

				// Token: 0x06018F59 RID: 102233 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6018F59")]
				[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
				private void <>xLuaBaseProxy_ResetToState(bool P0)
				{
				}

				// Token: 0x0401ED04 RID: 126212
				[Token(Token = "0x401ED04")]
				private const float FADE_DURATION = 0.15f;

				// Token: 0x0401ED05 RID: 126213
				[Token(Token = "0x401ED05")]
				[FieldOffset(Offset = "0x48")]
				private CanvasGroup m_canvasDefault;

				// Token: 0x0401ED06 RID: 126214
				[Token(Token = "0x401ED06")]
				[FieldOffset(Offset = "0x50")]
				private CanvasGroup m_canvasSp;

				// Token: 0x0401ED07 RID: 126215
				[Token(Token = "0x401ED07")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x0401ED08 RID: 126216
				[Token(Token = "0x401ED08")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

				// Token: 0x0401ED09 RID: 126217
				[Token(Token = "0x401ED09")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

				// Token: 0x0401ED0A RID: 126218
				[Token(Token = "0x401ED0A")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_ResetToState;
			}
		}

		// Token: 0x02003ED7 RID: 16087
		[Token(Token = "0x2003ED7")]
		[Serializable]
		private class ListImage
		{
			// Token: 0x06018F5A RID: 102234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F5A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ListImage()
			{
			}

			// Token: 0x0401ED0B RID: 126219
			[Token(Token = "0x401ED0B")]
			[FieldOffset(Offset = "0x10")]
			public List<Image> listImage;
		}
	}
}
