using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003ED9 RID: 16089
	[Token(Token = "0x2003ED9")]
	public class SkinPreviewPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018F5D RID: 102237 RVA: 0x0009C768 File Offset: 0x0009A968
		[Token(Token = "0x6018F5D")]
		[Address(RVA = "0x119C110", Offset = "0x119AD10", VA = "0x18119C110")]
		public bool IsShow()
		{
			return default(bool);
		}

		// Token: 0x06018F5E RID: 102238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F5E")]
		[Address(RVA = "0x119C290", Offset = "0x119AE90", VA = "0x18119C290")]
		public void Show(SkinPreviewPanel.Input input)
		{
		}

		// Token: 0x06018F5F RID: 102239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F5F")]
		[Address(RVA = "0x119C190", Offset = "0x119AD90", VA = "0x18119C190")]
		public void NotifySkinSelectChanged(CharUISkinStruct curSelection)
		{
		}

		// Token: 0x06018F60 RID: 102240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F60")]
		[Address(RVA = "0x119BF70", Offset = "0x119AB70", VA = "0x18119BF70")]
		public void Hide()
		{
		}

		// Token: 0x06018F61 RID: 102241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F61")]
		[Address(RVA = "0x119D390", Offset = "0x119BF90", VA = "0x18119D390")]
		private void _StopCheckAnimButtonsWatcher()
		{
		}

		// Token: 0x06018F62 RID: 102242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F62")]
		[Address(RVA = "0x119D310", Offset = "0x119BF10", VA = "0x18119D310")]
		private void _StartCheckAnimButtonsWatcher()
		{
		}

		// Token: 0x06018F63 RID: 102243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F63")]
		[Address(RVA = "0x119D410", Offset = "0x119C010", VA = "0x18119D410")]
		private void _UpdateAnimButtonsActive(DynIllustAction actionType)
		{
		}

		// Token: 0x06018F64 RID: 102244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F64")]
		[Address(RVA = "0x119D110", Offset = "0x119BD10", VA = "0x18119D110")]
		private void _ResetPreviewArgs()
		{
		}

		// Token: 0x06018F65 RID: 102245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F65")]
		[Address(RVA = "0x119D030", Offset = "0x119BC30", VA = "0x18119D030")]
		private void _ResetIllustWrapperPos()
		{
		}

		// Token: 0x06018F66 RID: 102246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F66")]
		[Address(RVA = "0x119C9C0", Offset = "0x119B5C0", VA = "0x18119C9C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018F67 RID: 102247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F67")]
		[Address(RVA = "0x119CF70", Offset = "0x119BB70", VA = "0x18119CF70")]
		private IEnumerator _PlayDynEntranceCoro()
		{
			return null;
		}

		// Token: 0x06018F68 RID: 102248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F68")]
		[Address(RVA = "0x119CC40", Offset = "0x119B840", VA = "0x18119CC40")]
		private void _OnAnimEnterFinished()
		{
		}

		// Token: 0x06018F69 RID: 102249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F69")]
		[Address(RVA = "0x119CD40", Offset = "0x119B940", VA = "0x18119CD40")]
		private void _OnScaleChanged(float scale)
		{
		}

		// Token: 0x06018F6A RID: 102250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F6A")]
		[Address(RVA = "0x119CED0", Offset = "0x119BAD0", VA = "0x18119CED0")]
		private void _OnScaleStart(float scale)
		{
		}

		// Token: 0x06018F6B RID: 102251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F6B")]
		[Address(RVA = "0x119CE30", Offset = "0x119BA30", VA = "0x18119CE30")]
		private void _OnScaleEnd(float scale)
		{
		}

		// Token: 0x06018F6C RID: 102252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F6C")]
		[Address(RVA = "0x119BEF0", Offset = "0x119AAF0", VA = "0x18119BEF0")]
		public void EventOnBtnBack()
		{
		}

		// Token: 0x06018F6D RID: 102253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F6D")]
		[Address(RVA = "0x119B650", Offset = "0x119A250", VA = "0x18119B650")]
		public void EventOnBtnAnimEnter()
		{
		}

		// Token: 0x06018F6E RID: 102254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F6E")]
		[Address(RVA = "0x119BDC0", Offset = "0x119A9C0", VA = "0x18119BDC0")]
		public void EventOnBtnAnimSpecial()
		{
		}

		// Token: 0x06018F6F RID: 102255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F6F")]
		[Address(RVA = "0x119B880", Offset = "0x119A480", VA = "0x18119B880")]
		public void EventOnBtnAnimInteract()
		{
		}

		// Token: 0x06018F70 RID: 102256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F70")]
		[Address(RVA = "0x119BAB0", Offset = "0x119A6B0", VA = "0x18119BAB0")]
		public void EventOnBtnAnimSpDynIllustInteract()
		{
		}

		// Token: 0x06018F71 RID: 102257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F71")]
		[Address(RVA = "0x119D5C0", Offset = "0x119C1C0", VA = "0x18119D5C0")]
		public SkinPreviewPanel()
		{
		}

		// Token: 0x0401ED0E RID: 126222
		[Token(Token = "0x401ED0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 _wrapperStandardPos;

		// Token: 0x0401ED0F RID: 126223
		[Token(Token = "0x401ED0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFadeFloatPanel _floatPanel;

		// Token: 0x0401ED10 RID: 126224
		[Token(Token = "0x401ED10")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIWrappedScrollRect _scrollContainer;

		// Token: 0x0401ED11 RID: 126225
		[Token(Token = "0x401ED11")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoIllustWrapper _illustWrapper;

		// Token: 0x0401ED12 RID: 126226
		[Token(Token = "0x401ED12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UITouchZoom _panelTouchZoom;

		// Token: 0x0401ED13 RID: 126227
		[Token(Token = "0x401ED13")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AdvancedAutoHideComponent _autoHideComp;

		// Token: 0x0401ED14 RID: 126228
		[Token(Token = "0x401ED14")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _animBtnPanelGo;

		// Token: 0x0401ED15 RID: 126229
		[Token(Token = "0x401ED15")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _btnAnimEnterGo;

		// Token: 0x0401ED16 RID: 126230
		[Token(Token = "0x401ED16")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _btnDynIllustInteractGo;

		// Token: 0x0401ED17 RID: 126231
		[Token(Token = "0x401ED17")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnSpDynIllustInteractGo;

		// Token: 0x0401ED18 RID: 126232
		[Token(Token = "0x401ED18")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _interactIndexNumText;

		// Token: 0x0401ED19 RID: 126233
		[Token(Token = "0x401ED19")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _btnBackRt;

		// Token: 0x0401ED1A RID: 126234
		[Token(Token = "0x401ED1A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _spDynIllustInteractAnim;

		// Token: 0x0401ED1B RID: 126235
		[Token(Token = "0x401ED1B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _animBtnDisableAlpha;

		// Token: 0x0401ED1C RID: 126236
		[Token(Token = "0x401ED1C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _specialAnimBtnCanvasGroup;

		// Token: 0x0401ED1D RID: 126237
		[Token(Token = "0x401ED1D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup[] _interactAnimBtnCanvasGroups;

		// Token: 0x0401ED1E RID: 126238
		[Token(Token = "0x401ED1E")]
		private const float DEFAULT_SCALE = 1f;

		// Token: 0x0401ED1F RID: 126239
		[Token(Token = "0x401ED1F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 ILLUST_PADDING;

		// Token: 0x0401ED20 RID: 126240
		[Token(Token = "0x401ED20")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401ED21 RID: 126241
		[Token(Token = "0x401ED21")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401ED22 RID: 126242
		[Token(Token = "0x401ED22")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_hasInited;

		// Token: 0x0401ED23 RID: 126243
		[Token(Token = "0x401ED23")]
		[FieldOffset(Offset = "0xC4")]
		private Vector2 m_initWrapperSize;

		// Token: 0x0401ED24 RID: 126244
		[Token(Token = "0x401ED24")]
		[FieldOffset(Offset = "0xD0")]
		private CharUISkinStruct m_skinStruct;

		// Token: 0x0401ED25 RID: 126245
		[Token(Token = "0x401ED25")]
		[FieldOffset(Offset = "0xE8")]
		private SkinPreviewPanel.IllustType m_illustType;

		// Token: 0x0401ED26 RID: 126246
		[Token(Token = "0x401ED26")]
		[FieldOffset(Offset = "0xEC")]
		private int m_cachedHideMessage;

		// Token: 0x0401ED27 RID: 126247
		[Token(Token = "0x401ED27")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_cachedEnableMessage;

		// Token: 0x0401ED28 RID: 126248
		[Token(Token = "0x401ED28")]
		[FieldOffset(Offset = "0xF8")]
		private SkinPreviewPanel.IllustInteractContext m_illustInteractContext;

		// Token: 0x0401ED29 RID: 126249
		[Token(Token = "0x401ED29")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_spDynIllustInteractTween;

		// Token: 0x0401ED2A RID: 126250
		[Token(Token = "0x401ED2A")]
		[FieldOffset(Offset = "0x108")]
		private SkinPreviewPanel.AnimButtonActiveWatcher m_animButtonActiveWatcher;

		// Token: 0x0401ED2B RID: 126251
		[Token(Token = "0x401ED2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsShow;

		// Token: 0x0401ED2C RID: 126252
		[Token(Token = "0x401ED2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401ED2D RID: 126253
		[Token(Token = "0x401ED2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifySkinSelectChanged;

		// Token: 0x0401ED2E RID: 126254
		[Token(Token = "0x401ED2E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401ED2F RID: 126255
		[Token(Token = "0x401ED2F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StopCheckAnimButtonsWatcher;

		// Token: 0x0401ED30 RID: 126256
		[Token(Token = "0x401ED30")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StartCheckAnimButtonsWatcher;

		// Token: 0x0401ED31 RID: 126257
		[Token(Token = "0x401ED31")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateAnimButtonsActive;

		// Token: 0x0401ED32 RID: 126258
		[Token(Token = "0x401ED32")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ResetPreviewArgs;

		// Token: 0x0401ED33 RID: 126259
		[Token(Token = "0x401ED33")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetIllustWrapperPos;

		// Token: 0x0401ED34 RID: 126260
		[Token(Token = "0x401ED34")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401ED35 RID: 126261
		[Token(Token = "0x401ED35")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayDynEntranceCoro;

		// Token: 0x0401ED36 RID: 126262
		[Token(Token = "0x401ED36")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnAnimEnterFinished;

		// Token: 0x0401ED37 RID: 126263
		[Token(Token = "0x401ED37")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnScaleChanged;

		// Token: 0x0401ED38 RID: 126264
		[Token(Token = "0x401ED38")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnScaleStart;

		// Token: 0x0401ED39 RID: 126265
		[Token(Token = "0x401ED39")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnScaleEnd;

		// Token: 0x0401ED3A RID: 126266
		[Token(Token = "0x401ED3A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnBtnBack;

		// Token: 0x0401ED3B RID: 126267
		[Token(Token = "0x401ED3B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnBtnAnimEnter;

		// Token: 0x0401ED3C RID: 126268
		[Token(Token = "0x401ED3C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnBtnAnimSpecial;

		// Token: 0x0401ED3D RID: 126269
		[Token(Token = "0x401ED3D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnBtnAnimInteract;

		// Token: 0x0401ED3E RID: 126270
		[Token(Token = "0x401ED3E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnBtnAnimSpDynIllustInteract;

		// Token: 0x0401ED3F RID: 126271
		[Token(Token = "0x401ED3F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EDA RID: 16090
		[Token(Token = "0x2003EDA")]
		public enum IllustType
		{
			// Token: 0x0401ED41 RID: 126273
			[Token(Token = "0x401ED41")]
			SHOW_DYN,
			// Token: 0x0401ED42 RID: 126274
			[Token(Token = "0x401ED42")]
			FORCE_STATIC,
			// Token: 0x0401ED43 RID: 126275
			[Token(Token = "0x401ED43")]
			PLAYER_CONFIG
		}

		// Token: 0x02003EDB RID: 16091
		[Token(Token = "0x2003EDB")]
		public struct Input
		{
			// Token: 0x0401ED44 RID: 126276
			[Token(Token = "0x401ED44")]
			[FieldOffset(Offset = "0x0")]
			public CharUISkinStruct skinStruct;

			// Token: 0x0401ED45 RID: 126277
			[Token(Token = "0x401ED45")]
			[FieldOffset(Offset = "0x18")]
			public UICharacterIllustLoader loader;

			// Token: 0x0401ED46 RID: 126278
			[Token(Token = "0x401ED46")]
			[FieldOffset(Offset = "0x20")]
			public SkinPreviewPanel.IllustType illustType;

			// Token: 0x0401ED47 RID: 126279
			[Token(Token = "0x401ED47")]
			[FieldOffset(Offset = "0x24")]
			public bool enableMessage;

			// Token: 0x0401ED48 RID: 126280
			[Token(Token = "0x401ED48")]
			[FieldOffset(Offset = "0x28")]
			public int showMessage;

			// Token: 0x0401ED49 RID: 126281
			[Token(Token = "0x401ED49")]
			[FieldOffset(Offset = "0x2C")]
			public int hideMessage;
		}

		// Token: 0x02003EDC RID: 16092
		[Token(Token = "0x2003EDC")]
		private class IllustInteractContext
		{
			// Token: 0x17003B84 RID: 15236
			// (get) Token: 0x06018F73 RID: 102259 RVA: 0x0009C780 File Offset: 0x0009A980
			[Token(Token = "0x17003B84")]
			public int currentCharWordIndex
			{
				[Token(Token = "0x6018F73")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17003B85 RID: 15237
			// (get) Token: 0x06018F74 RID: 102260 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003B85")]
			public CharWordData currentCharWord
			{
				[Token(Token = "0x6018F74")]
				[Address(RVA = "0x1195F00", Offset = "0x1194B00", VA = "0x181195F00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003B86 RID: 15238
			// (get) Token: 0x06018F75 RID: 102261 RVA: 0x0009C798 File Offset: 0x0009A998
			[Token(Token = "0x17003B86")]
			public CharUISkinStruct skinStruct
			{
				[Token(Token = "0x6018F75")]
				[Address(RVA = "0x1195F40", Offset = "0x1194B40", VA = "0x181195F40")]
				get
				{
					return default(CharUISkinStruct);
				}
			}

			// Token: 0x06018F76 RID: 102262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F76")]
			[Address(RVA = "0x1195D30", Offset = "0x1194930", VA = "0x181195D30")]
			public void Reset(CharUISkinStruct skinStruct)
			{
			}

			// Token: 0x06018F77 RID: 102263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F77")]
			[Address(RVA = "0x1195CD0", Offset = "0x11948D0", VA = "0x181195CD0")]
			public void MoveToNextCharword()
			{
			}

			// Token: 0x06018F78 RID: 102264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F78")]
			[Address(RVA = "0x1195E70", Offset = "0x1194A70", VA = "0x181195E70")]
			public IllustInteractContext()
			{
			}

			// Token: 0x0401ED4A RID: 126282
			[Token(Token = "0x401ED4A")]
			[FieldOffset(Offset = "0x10")]
			private List<CharWordData> m_charWords;

			// Token: 0x0401ED4B RID: 126283
			[Token(Token = "0x401ED4B")]
			[FieldOffset(Offset = "0x18")]
			private int m_currentCharWordIndex;

			// Token: 0x0401ED4C RID: 126284
			[Token(Token = "0x401ED4C")]
			[FieldOffset(Offset = "0x20")]
			private CharUISkinStruct m_skinStruct;
		}

		// Token: 0x02003EDD RID: 16093
		[Token(Token = "0x2003EDD")]
		private class AnimButtonActiveWatcher : ITimeWatcher
		{
			// Token: 0x06018F79 RID: 102265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F79")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public AnimButtonActiveWatcher(SkinPreviewPanel skinPreviewPanel)
			{
			}

			// Token: 0x06018F7A RID: 102266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F7A")]
			[Address(RVA = "0x1195920", Offset = "0x1194520", VA = "0x181195920", Slot = "4")]
			public void UpdateTime(float deltaTime)
			{
			}

			// Token: 0x0401ED4D RID: 126285
			[Token(Token = "0x401ED4D")]
			[FieldOffset(Offset = "0x10")]
			private SkinPreviewPanel m_closure;
		}
	}
}
