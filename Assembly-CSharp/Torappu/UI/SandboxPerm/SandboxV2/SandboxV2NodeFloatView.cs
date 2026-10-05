using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200424D RID: 16973
	[Token(Token = "0x200424D")]
	public class SandboxV2NodeFloatView : MonoBehaviour, IAsyncDataView<SandboxV2NodeFloatView.RenderParam>, IAsyncShowEffect, IHotfixable
	{
		// Token: 0x0601A296 RID: 107158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A296")]
		[Address(RVA = "0x13084E0", Offset = "0x13070E0", VA = "0x1813084E0")]
		private void Update()
		{
		}

		// Token: 0x0601A297 RID: 107159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A297")]
		[Address(RVA = "0x13087F0", Offset = "0x13073F0", VA = "0x1813087F0")]
		private SandboxV2DungeonFloatViewModel _FetchNextFloatViewModel()
		{
			return null;
		}

		// Token: 0x0601A298 RID: 107160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A298")]
		[Address(RVA = "0x13086F0", Offset = "0x13072F0", VA = "0x1813086F0")]
		private SandboxV2DungeonFloatViewModel _FetchFirstNewFloatViewModel()
		{
			return null;
		}

		// Token: 0x0601A299 RID: 107161 RVA: 0x000A06B0 File Offset: 0x0009E8B0
		[Token(Token = "0x601A299")]
		[Address(RVA = "0x1308550", Offset = "0x1307150", VA = "0x181308550")]
		private bool _CheckCurrFloatViewModelExists()
		{
			return default(bool);
		}

		// Token: 0x0601A29A RID: 107162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A29A")]
		[Address(RVA = "0x130A500", Offset = "0x1309100", VA = "0x18130A500")]
		private void _StartCountdownTask()
		{
		}

		// Token: 0x0601A29B RID: 107163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A29B")]
		[Address(RVA = "0x1308680", Offset = "0x1307280", VA = "0x181308680")]
		private void _ClearCountdownTask()
		{
		}

		// Token: 0x0601A29C RID: 107164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A29C")]
		[Address(RVA = "0x1308980", Offset = "0x1307580", VA = "0x181308980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A29D RID: 107165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A29D")]
		[Address(RVA = "0x1308CC0", Offset = "0x13078C0", VA = "0x181308CC0")]
		private void _RenderBuffer(int bufferIndex, SandboxV2DungeonFloatViewModel floatViewModel)
		{
		}

		// Token: 0x0601A29E RID: 107166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A29E")]
		[Address(RVA = "0x1309150", Offset = "0x1307D50", VA = "0x181309150")]
		private void _RenderCurr()
		{
		}

		// Token: 0x0601A29F RID: 107167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A29F")]
		[Address(RVA = "0x13091F0", Offset = "0x1307DF0", VA = "0x1813091F0")]
		private void _RenderNext(SandboxV2DungeonFloatViewModel nextFloatViewModel)
		{
		}

		// Token: 0x0601A2A0 RID: 107168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2A0")]
		[Address(RVA = "0x1309330", Offset = "0x1307F30", VA = "0x181309330")]
		private void _Render(SandboxV2DungeonFloatGroupViewModel floatGroup)
		{
		}

		// Token: 0x0601A2A1 RID: 107169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2A1")]
		[Address(RVA = "0x130A420", Offset = "0x1309020", VA = "0x18130A420")]
		private void _SetShowStatus(bool isShow, bool fastMode, float delay = 0f)
		{
		}

		// Token: 0x0601A2A2 RID: 107170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2A2")]
		[Address(RVA = "0x1307CA0", Offset = "0x13068A0", VA = "0x181307CA0", Slot = "4")]
		public void AsyncSetData(SandboxV2NodeFloatView.RenderParam param)
		{
		}

		// Token: 0x0601A2A3 RID: 107171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2A3")]
		[Address(RVA = "0x13082F0", Offset = "0x1306EF0", VA = "0x1813082F0")]
		public void OnClick()
		{
		}

		// Token: 0x0601A2A4 RID: 107172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2A4")]
		[Address(RVA = "0x1308210", Offset = "0x1306E10", VA = "0x181308210", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601A2A5 RID: 107173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2A5")]
		[Address(RVA = "0x130A5B0", Offset = "0x13091B0", VA = "0x18130A5B0")]
		public SandboxV2NodeFloatView()
		{
		}

		// Token: 0x040210ED RID: 135405
		[Token(Token = "0x40210ED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _imgDeco;

		// Token: 0x040210EE RID: 135406
		[Token(Token = "0x40210EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _imgBadge;

		// Token: 0x040210EF RID: 135407
		[Token(Token = "0x40210EF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x040210F0 RID: 135408
		[Token(Token = "0x40210F0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgFrame;

		// Token: 0x040210F1 RID: 135409
		[Token(Token = "0x40210F1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image[] _imgIcon;

		// Token: 0x040210F2 RID: 135410
		[Token(Token = "0x40210F2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgHp;

		// Token: 0x040210F3 RID: 135411
		[Token(Token = "0x40210F3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgStack;

		// Token: 0x040210F4 RID: 135412
		[Token(Token = "0x40210F4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgShadow;

		// Token: 0x040210F5 RID: 135413
		[Token(Token = "0x40210F5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgOutline1;

		// Token: 0x040210F6 RID: 135414
		[Token(Token = "0x40210F6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgOutline2;

		// Token: 0x040210F7 RID: 135415
		[Token(Token = "0x40210F7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIColorGraphic _selectionOutline;

		// Token: 0x040210F8 RID: 135416
		[Token(Token = "0x40210F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _pnlEnemyRush;

		// Token: 0x040210F9 RID: 135417
		[Token(Token = "0x40210F9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private long _loopInterval;

		// Token: 0x040210FA RID: 135418
		[Token(Token = "0x40210FA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x040210FB RID: 135419
		[Token(Token = "0x40210FB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _asyncShowHandler;

		// Token: 0x040210FC RID: 135420
		[Token(Token = "0x40210FC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x040210FD RID: 135421
		[Token(Token = "0x40210FD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _selectionLoopAnim;

		// Token: 0x040210FE RID: 135422
		[Token(Token = "0x40210FE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CanvasGroup _canvasSelection;

		// Token: 0x040210FF RID: 135423
		[Token(Token = "0x40210FF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _canvasShow;

		// Token: 0x04021100 RID: 135424
		[Token(Token = "0x4021100")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_inited;

		// Token: 0x04021101 RID: 135425
		[Token(Token = "0x4021101")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedTopicId;

		// Token: 0x04021102 RID: 135426
		[Token(Token = "0x4021102")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedNodeId;

		// Token: 0x04021103 RID: 135427
		[Token(Token = "0x4021103")]
		[FieldOffset(Offset = "0xD8")]
		private SandboxV2DungeonViewConfig m_cachedDungeonViewConfig;

		// Token: 0x04021104 RID: 135428
		[Token(Token = "0x4021104")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021105 RID: 135429
		[Token(Token = "0x4021105")]
		[FieldOffset(Offset = "0xF0")]
		private SandboxV2NodeFloatView.TransSwitchTween m_switchTween;

		// Token: 0x04021106 RID: 135430
		[Token(Token = "0x4021106")]
		[FieldOffset(Offset = "0xF8")]
		private SandboxV2EnterAnimTween m_showTween;

		// Token: 0x04021107 RID: 135431
		[Token(Token = "0x4021107")]
		[FieldOffset(Offset = "0x100")]
		private SandboxV2NodeFloatView.SelectionSwitchTween m_selectionTween;

		// Token: 0x04021108 RID: 135432
		[Token(Token = "0x4021108")]
		[FieldOffset(Offset = "0x108")]
		private CountDownTask m_countDownTask;

		// Token: 0x04021109 RID: 135433
		[Token(Token = "0x4021109")]
		[FieldOffset(Offset = "0x110")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonChangeChecker;

		// Token: 0x0402110A RID: 135434
		[Token(Token = "0x402110A")]
		[FieldOffset(Offset = "0x120")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_floatSelectionChecker;

		// Token: 0x0402110B RID: 135435
		[Token(Token = "0x402110B")]
		[FieldOffset(Offset = "0x130")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_enterAnimChecker;

		// Token: 0x0402110C RID: 135436
		[Token(Token = "0x402110C")]
		[FieldOffset(Offset = "0x140")]
		private bool m_cachedFastMode;

		// Token: 0x0402110D RID: 135437
		[Token(Token = "0x402110D")]
		[FieldOffset(Offset = "0x141")]
		private bool m_cachedPlayedEnterAnim;

		// Token: 0x0402110E RID: 135438
		[Token(Token = "0x402110E")]
		[FieldOffset(Offset = "0x148")]
		private SandboxV2DungeonFloatViewModel m_currFloatViewModel;

		// Token: 0x0402110F RID: 135439
		[Token(Token = "0x402110F")]
		[FieldOffset(Offset = "0x150")]
		private SandboxV2DungeonFloatGroupViewModel m_cachedFloatGroupViewModel;

		// Token: 0x04021110 RID: 135440
		[Token(Token = "0x4021110")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04021111 RID: 135441
		[Token(Token = "0x4021111")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FetchNextFloatViewModel;

		// Token: 0x04021112 RID: 135442
		[Token(Token = "0x4021112")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FetchFirstNewFloatViewModel;

		// Token: 0x04021113 RID: 135443
		[Token(Token = "0x4021113")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCurrFloatViewModelExists;

		// Token: 0x04021114 RID: 135444
		[Token(Token = "0x4021114")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StartCountdownTask;

		// Token: 0x04021115 RID: 135445
		[Token(Token = "0x4021115")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearCountdownTask;

		// Token: 0x04021116 RID: 135446
		[Token(Token = "0x4021116")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021117 RID: 135447
		[Token(Token = "0x4021117")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderBuffer;

		// Token: 0x04021118 RID: 135448
		[Token(Token = "0x4021118")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderCurr;

		// Token: 0x04021119 RID: 135449
		[Token(Token = "0x4021119")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderNext;

		// Token: 0x0402111A RID: 135450
		[Token(Token = "0x402111A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402111B RID: 135451
		[Token(Token = "0x402111B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetShowStatus;

		// Token: 0x0402111C RID: 135452
		[Token(Token = "0x402111C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0402111D RID: 135453
		[Token(Token = "0x402111D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402111E RID: 135454
		[Token(Token = "0x402111E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x0402111F RID: 135455
		[Token(Token = "0x402111F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200424E RID: 16974
		[Token(Token = "0x200424E")]
		public struct RenderParam
		{
			// Token: 0x04021120 RID: 135456
			[Token(Token = "0x4021120")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2DungeonNodeViewModel nodeViewModel;

			// Token: 0x04021121 RID: 135457
			[Token(Token = "0x4021121")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2DungeonViewModel dungeonViewModel;
		}

		// Token: 0x0200424F RID: 16975
		[Token(Token = "0x200424F")]
		private class TransSwitchTween : UISwitchTween
		{
			// Token: 0x0601A2A8 RID: 107176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2A8")]
			[Address(RVA = "0x13262A0", Offset = "0x1324EA0", VA = "0x1813262A0")]
			public TransSwitchTween(SandboxV2NodeFloatView closure)
			{
			}

			// Token: 0x0601A2A9 RID: 107177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A2A9")]
			[Address(RVA = "0x1324E10", Offset = "0x1323A10", VA = "0x181324E10", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601A2AA RID: 107178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A2AA")]
			[Address(RVA = "0x1325300", Offset = "0x1323F00", VA = "0x181325300", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601A2AB RID: 107179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2AB")]
			[Address(RVA = "0x1324D10", Offset = "0x1323910", VA = "0x181324D10", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601A2AC RID: 107180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2AC")]
			[Address(RVA = "0x1324D90", Offset = "0x1323990", VA = "0x181324D90", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601A2AD RID: 107181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2AD")]
			[Address(RVA = "0x13257E0", Offset = "0x13243E0", VA = "0x1813257E0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601A2AE RID: 107182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2AE")]
			[Address(RVA = "0x1325B50", Offset = "0x1324750", VA = "0x181325B50")]
			public void SetBuffer(int index, SandboxV2NodeFloatView.TransSwitchTween.Buffer buffer)
			{
			}

			// Token: 0x0601A2B1 RID: 107185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2B1")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601A2B2 RID: 107186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2B2")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601A2B3 RID: 107187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2B3")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04021122 RID: 135458
			[Token(Token = "0x4021122")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2NodeFloatView m_closure;

			// Token: 0x04021123 RID: 135459
			[Token(Token = "0x4021123")]
			[FieldOffset(Offset = "0x50")]
			private SandboxV2NodeFloatView.TransSwitchTween.Buffer[] m_buffers;

			// Token: 0x04021124 RID: 135460
			[Token(Token = "0x4021124")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021125 RID: 135461
			[Token(Token = "0x4021125")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04021126 RID: 135462
			[Token(Token = "0x4021126")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04021127 RID: 135463
			[Token(Token = "0x4021127")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04021128 RID: 135464
			[Token(Token = "0x4021128")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04021129 RID: 135465
			[Token(Token = "0x4021129")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402112A RID: 135466
			[Token(Token = "0x402112A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetBuffer;

			// Token: 0x02004250 RID: 16976
			[Token(Token = "0x2004250")]
			public struct Buffer
			{
				// Token: 0x0402112B RID: 135467
				[Token(Token = "0x402112B")]
				[FieldOffset(Offset = "0x0")]
				public Color bkgColor;

				// Token: 0x0402112C RID: 135468
				[Token(Token = "0x402112C")]
				[FieldOffset(Offset = "0x10")]
				public Color frameColor;

				// Token: 0x0402112D RID: 135469
				[Token(Token = "0x402112D")]
				[FieldOffset(Offset = "0x20")]
				public Color outlineColor;

				// Token: 0x0402112E RID: 135470
				[Token(Token = "0x402112E")]
				[FieldOffset(Offset = "0x30")]
				public bool showHp;
			}
		}

		// Token: 0x02004252 RID: 16978
		[Token(Token = "0x2004252")]
		private class SelectionSwitchTween : UISwitchTween
		{
			// Token: 0x0601A2B8 RID: 107192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2B8")]
			[Address(RVA = "0x1324C80", Offset = "0x1323880", VA = "0x181324C80")]
			public SelectionSwitchTween(SandboxV2NodeFloatView closure)
			{
			}

			// Token: 0x0601A2B9 RID: 107193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A2B9")]
			[Address(RVA = "0x13248E0", Offset = "0x13234E0", VA = "0x1813248E0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601A2BA RID: 107194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A2BA")]
			[Address(RVA = "0x13249E0", Offset = "0x13235E0", VA = "0x1813249E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601A2BB RID: 107195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2BB")]
			[Address(RVA = "0x1324700", Offset = "0x1323300", VA = "0x181324700", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601A2BC RID: 107196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2BC")]
			[Address(RVA = "0x13247C0", Offset = "0x13233C0", VA = "0x1813247C0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601A2BD RID: 107197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2BD")]
			[Address(RVA = "0x1324AF0", Offset = "0x13236F0", VA = "0x181324AF0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601A2BE RID: 107198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2BE")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601A2BF RID: 107199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2BF")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601A2C0 RID: 107200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2C0")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04021132 RID: 135474
			[Token(Token = "0x4021132")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2NodeFloatView m_closure;

			// Token: 0x04021133 RID: 135475
			[Token(Token = "0x4021133")]
			[FieldOffset(Offset = "0x50")]
			private Tween m_selectionLoopTween;

			// Token: 0x04021134 RID: 135476
			[Token(Token = "0x4021134")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021135 RID: 135477
			[Token(Token = "0x4021135")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04021136 RID: 135478
			[Token(Token = "0x4021136")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04021137 RID: 135479
			[Token(Token = "0x4021137")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04021138 RID: 135480
			[Token(Token = "0x4021138")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04021139 RID: 135481
			[Token(Token = "0x4021139")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
