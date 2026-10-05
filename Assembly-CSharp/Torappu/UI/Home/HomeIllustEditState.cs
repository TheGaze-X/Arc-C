using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B11 RID: 19217
	[Token(Token = "0x2004B11")]
	public class HomeIllustEditState : HomeReplaceableState, HomeIllustEditFrame.IDragEvent
	{
		// Token: 0x0601CE53 RID: 118355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE53")]
		[Address(RVA = "0x1654F80", Offset = "0x1653B80", VA = "0x181654F80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CE54 RID: 118356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE54")]
		[Address(RVA = "0x16566C0", Offset = "0x16552C0", VA = "0x1816566C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CE55 RID: 118357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE55")]
		[Address(RVA = "0x1655110", Offset = "0x1653D10", VA = "0x181655110", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CE56 RID: 118358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE56")]
		[Address(RVA = "0x16553E0", Offset = "0x1653FE0", VA = "0x1816553E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CE57 RID: 118359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE57")]
		[Address(RVA = "0x1654A60", Offset = "0x1653660", VA = "0x181654A60", Slot = "33")]
		public void BeginDragFromFrame(PointerEventData eventData)
		{
		}

		// Token: 0x0601CE58 RID: 118360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE58")]
		[Address(RVA = "0x16555A0", Offset = "0x16541A0", VA = "0x1816555A0")]
		private void Update()
		{
		}

		// Token: 0x0601CE59 RID: 118361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE59")]
		[Address(RVA = "0x1654B90", Offset = "0x1653790", VA = "0x181654B90")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0601CE5A RID: 118362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE5A")]
		[Address(RVA = "0x1654BF0", Offset = "0x16537F0", VA = "0x181654BF0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601CE5B RID: 118363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE5B")]
		[Address(RVA = "0x1654D80", Offset = "0x1653980", VA = "0x181654D80")]
		public void EventOnResetClicked()
		{
		}

		// Token: 0x0601CE5C RID: 118364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE5C")]
		[Address(RVA = "0x1657060", Offset = "0x1655C60", VA = "0x181657060")]
		private void _UpdatePos()
		{
		}

		// Token: 0x0601CE5D RID: 118365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE5D")]
		[Address(RVA = "0x1657210", Offset = "0x1655E10", VA = "0x181657210")]
		private void _UpdateSize()
		{
		}

		// Token: 0x0601CE5E RID: 118366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE5E")]
		[Address(RVA = "0x1656BA0", Offset = "0x16557A0", VA = "0x181656BA0")]
		private void _SyncStatusToIllust()
		{
		}

		// Token: 0x0601CE5F RID: 118367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE5F")]
		[Address(RVA = "0x1656C90", Offset = "0x1655890", VA = "0x181656C90")]
		private void _SyncStatusToText()
		{
		}

		// Token: 0x0601CE60 RID: 118368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE60")]
		[Address(RVA = "0x1655BF0", Offset = "0x16547F0", VA = "0x181655BF0")]
		private void _CheckIfPosChanged(out bool xChanged, out bool yChanged)
		{
		}

		// Token: 0x0601CE61 RID: 118369 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
		[Token(Token = "0x601CE61")]
		[Address(RVA = "0x1655D70", Offset = "0x1654970", VA = "0x181655D70")]
		private bool _CheckIfSizeChanged()
		{
			return default(bool);
		}

		// Token: 0x0601CE62 RID: 118370 RVA: 0x000A9C08 File Offset: 0x000A7E08
		[Token(Token = "0x601CE62")]
		[Address(RVA = "0x16562B0", Offset = "0x1654EB0", VA = "0x1816562B0")]
		private static HomeIllustEditState.AdjustConfig _GenAdjustConfig(HomeIllustView.IllustHandler handler)
		{
			return default(HomeIllustEditState.AdjustConfig);
		}

		// Token: 0x0601CE63 RID: 118371 RVA: 0x000A9C20 File Offset: 0x000A7E20
		[Token(Token = "0x601CE63")]
		[Address(RVA = "0x1655F70", Offset = "0x1654B70", VA = "0x181655F70")]
		private HomeIllustEditState.DragPosStatus _CreateEditStatusFromBeginDrag(PointerEventData eventData)
		{
			return default(HomeIllustEditState.DragPosStatus);
		}

		// Token: 0x0601CE64 RID: 118372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE64")]
		[Address(RVA = "0x16558D0", Offset = "0x16544D0", VA = "0x1816558D0")]
		private void _CancelEditing()
		{
		}

		// Token: 0x0601CE65 RID: 118373 RVA: 0x000A9C38 File Offset: 0x000A7E38
		[Token(Token = "0x601CE65")]
		[Address(RVA = "0x1656990", Offset = "0x1655590", VA = "0x181656990")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601CE66 RID: 118374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE66")]
		[Address(RVA = "0x1656A60", Offset = "0x1655660", VA = "0x181656A60")]
		private void _OnCancel()
		{
		}

		// Token: 0x0601CE67 RID: 118375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE67")]
		[Address(RVA = "0x1655810", Offset = "0x1654410", VA = "0x181655810")]
		private void _CancelDragging()
		{
		}

		// Token: 0x0601CE68 RID: 118376 RVA: 0x000A9C50 File Offset: 0x000A7E50
		[Token(Token = "0x601CE68")]
		[Address(RVA = "0x1655E90", Offset = "0x1654A90", VA = "0x181655E90")]
		private static Vector2 _ConvertScreenPosToIllust(Vector2 sp, RectTransform illustContainer, Camera illustCam)
		{
			return default(Vector2);
		}

		// Token: 0x0601CE69 RID: 118377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE69")]
		[Address(RVA = "0x1654FE0", Offset = "0x1653BE0", VA = "0x181654FE0", Slot = "30")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x0601CE6A RID: 118378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE6A")]
		[Address(RVA = "0x1655090", Offset = "0x1653C90", VA = "0x181655090", Slot = "32")]
		protected override void HideFastMode()
		{
		}

		// Token: 0x0601CE6B RID: 118379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE6B")]
		[Address(RVA = "0x1655450", Offset = "0x1654050", VA = "0x181655450", Slot = "29")]
		protected override IEnumerator ShowEffect(HomeReplaceableState extractState)
		{
			return null;
		}

		// Token: 0x0601CE6C RID: 118380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE6C")]
		[Address(RVA = "0x1655510", Offset = "0x1654110", VA = "0x181655510", Slot = "31")]
		protected override void ShowFastMode()
		{
		}

		// Token: 0x0601CE6D RID: 118381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE6D")]
		[Address(RVA = "0x1657360", Offset = "0x1655F60", VA = "0x181657360")]
		public HomeIllustEditState()
		{
		}

		// Token: 0x0601CE6E RID: 118382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE6E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CE6F RID: 118383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE6F")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04025E83 RID: 155267
		[Token(Token = "0x4025E83")]
		private const float MIN_SIZE = 630f;

		// Token: 0x04025E84 RID: 155268
		[Token(Token = "0x4025E84")]
		private const int MIN_SLIDE = 100;

		// Token: 0x04025E85 RID: 155269
		[Token(Token = "0x4025E85")]
		private const int MAX_SLIDE = 300;

		// Token: 0x04025E86 RID: 155270
		[Token(Token = "0x4025E86")]
		private const float MAX_POS = 2200f;

		// Token: 0x04025E87 RID: 155271
		[Token(Token = "0x4025E87")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04025E88 RID: 155272
		[Token(Token = "0x4025E88")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _sizeSlider;

		// Token: 0x04025E89 RID: 155273
		[Token(Token = "0x4025E89")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeIllustEditFrame _editFrame;

		// Token: 0x04025E8A RID: 155274
		[Token(Token = "0x4025E8A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _rectCancel;

		// Token: 0x04025E8B RID: 155275
		[Token(Token = "0x4025E8B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textPos;

		// Token: 0x04025E8C RID: 155276
		[Token(Token = "0x4025E8C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textSize;

		// Token: 0x04025E8D RID: 155277
		[Token(Token = "0x4025E8D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textMinSlide;

		// Token: 0x04025E8E RID: 155278
		[Token(Token = "0x4025E8E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textMaxSlide;

		// Token: 0x04025E8F RID: 155279
		[Token(Token = "0x4025E8F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _colorChanging;

		// Token: 0x04025E90 RID: 155280
		[Token(Token = "0x4025E90")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _colorChanged;

		// Token: 0x04025E91 RID: 155281
		[Token(Token = "0x4025E91")]
		[FieldOffset(Offset = "0xC0")]
		private HomeIllustView.IllustHandler m_illustHandler;

		// Token: 0x04025E92 RID: 155282
		[Token(Token = "0x4025E92")]
		[FieldOffset(Offset = "0xC8")]
		private HomeIllustEditState.AdjustConfig m_adjustConfig;

		// Token: 0x04025E93 RID: 155283
		[Token(Token = "0x4025E93")]
		[FieldOffset(Offset = "0x100")]
		private UIIllustLayoutInfo m_editingInfo;

		// Token: 0x04025E94 RID: 155284
		[Token(Token = "0x4025E94")]
		[FieldOffset(Offset = "0x110")]
		private HomeIllustEditState.DragPosStatus m_dragStatus;

		// Token: 0x04025E95 RID: 155285
		[Token(Token = "0x4025E95")]
		[FieldOffset(Offset = "0x150")]
		private HomeIllustEditState.LayoutTween m_tweenInUpdate;

		// Token: 0x04025E96 RID: 155286
		[Token(Token = "0x4025E96")]
		[FieldOffset(Offset = "0x1A0")]
		private bool m_isInited;

		// Token: 0x04025E97 RID: 155287
		[Token(Token = "0x4025E97")]
		[FieldOffset(Offset = "0x1A8")]
		private string m_rawColorPos;

		// Token: 0x04025E98 RID: 155288
		[Token(Token = "0x4025E98")]
		[FieldOffset(Offset = "0x1B0")]
		private string m_rawColorSize;

		// Token: 0x04025E99 RID: 155289
		[Token(Token = "0x4025E99")]
		[FieldOffset(Offset = "0x1B8")]
		private string m_colorChanging;

		// Token: 0x04025E9A RID: 155290
		[Token(Token = "0x4025E9A")]
		[FieldOffset(Offset = "0x1C0")]
		private string m_colorChanged;

		// Token: 0x04025E9B RID: 155291
		[Token(Token = "0x4025E9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025E9C RID: 155292
		[Token(Token = "0x4025E9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025E9D RID: 155293
		[Token(Token = "0x4025E9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025E9E RID: 155294
		[Token(Token = "0x4025E9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025E9F RID: 155295
		[Token(Token = "0x4025E9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BeginDragFromFrame;

		// Token: 0x04025EA0 RID: 155296
		[Token(Token = "0x4025EA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04025EA1 RID: 155297
		[Token(Token = "0x4025EA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x04025EA2 RID: 155298
		[Token(Token = "0x4025EA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x04025EA3 RID: 155299
		[Token(Token = "0x4025EA3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnResetClicked;

		// Token: 0x04025EA4 RID: 155300
		[Token(Token = "0x4025EA4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdatePos;

		// Token: 0x04025EA5 RID: 155301
		[Token(Token = "0x4025EA5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateSize;

		// Token: 0x04025EA6 RID: 155302
		[Token(Token = "0x4025EA6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SyncStatusToIllust;

		// Token: 0x04025EA7 RID: 155303
		[Token(Token = "0x4025EA7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SyncStatusToText;

		// Token: 0x04025EA8 RID: 155304
		[Token(Token = "0x4025EA8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckIfPosChanged;

		// Token: 0x04025EA9 RID: 155305
		[Token(Token = "0x4025EA9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIfSizeChanged;

		// Token: 0x04025EAA RID: 155306
		[Token(Token = "0x4025EAA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenAdjustConfig;

		// Token: 0x04025EAB RID: 155307
		[Token(Token = "0x4025EAB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CreateEditStatusFromBeginDrag;

		// Token: 0x04025EAC RID: 155308
		[Token(Token = "0x4025EAC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CancelEditing;

		// Token: 0x04025EAD RID: 155309
		[Token(Token = "0x4025EAD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04025EAE RID: 155310
		[Token(Token = "0x4025EAE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x04025EAF RID: 155311
		[Token(Token = "0x4025EAF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CancelDragging;

		// Token: 0x04025EB0 RID: 155312
		[Token(Token = "0x4025EB0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ConvertScreenPosToIllust;

		// Token: 0x04025EB1 RID: 155313
		[Token(Token = "0x4025EB1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x04025EB2 RID: 155314
		[Token(Token = "0x4025EB2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_HideFastMode;

		// Token: 0x04025EB3 RID: 155315
		[Token(Token = "0x4025EB3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x04025EB4 RID: 155316
		[Token(Token = "0x4025EB4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ShowFastMode;

		// Token: 0x04025EB5 RID: 155317
		[Token(Token = "0x4025EB5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B12 RID: 19218
		[Token(Token = "0x2004B12")]
		private struct AdjustConfig
		{
			// Token: 0x0601CE70 RID: 118384 RVA: 0x000A9C68 File Offset: 0x000A7E68
			[Token(Token = "0x601CE70")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0601CE71 RID: 118385 RVA: 0x000A9C80 File Offset: 0x000A7E80
			[Token(Token = "0x601CE71")]
			[Address(RVA = "0x164E8B0", Offset = "0x164D4B0", VA = "0x18164E8B0")]
			public int GetSlideValBySize(float curSize)
			{
				return 0;
			}

			// Token: 0x0601CE72 RID: 118386 RVA: 0x000A9C98 File Offset: 0x000A7E98
			[Token(Token = "0x601CE72")]
			[Address(RVA = "0x164E830", Offset = "0x164D430", VA = "0x18164E830")]
			public float GetSizeBySlideValue(float slide)
			{
				return 0f;
			}

			// Token: 0x04025EB6 RID: 155318
			[Token(Token = "0x4025EB6")]
			[FieldOffset(Offset = "0x0")]
			public string illustId;

			// Token: 0x04025EB7 RID: 155319
			[Token(Token = "0x4025EB7")]
			[FieldOffset(Offset = "0x8")]
			public float maxSize;

			// Token: 0x04025EB8 RID: 155320
			[Token(Token = "0x4025EB8")]
			[FieldOffset(Offset = "0xC")]
			public float minSize;

			// Token: 0x04025EB9 RID: 155321
			[Token(Token = "0x4025EB9")]
			[FieldOffset(Offset = "0x10")]
			public float rawSize;

			// Token: 0x04025EBA RID: 155322
			[Token(Token = "0x4025EBA")]
			[FieldOffset(Offset = "0x14")]
			public float unit;

			// Token: 0x04025EBB RID: 155323
			[Token(Token = "0x4025EBB")]
			[FieldOffset(Offset = "0x18")]
			public float dftSize;

			// Token: 0x04025EBC RID: 155324
			[Token(Token = "0x4025EBC")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 dftPos;

			// Token: 0x04025EBD RID: 155325
			[Token(Token = "0x4025EBD")]
			[FieldOffset(Offset = "0x24")]
			public int dftSlide;

			// Token: 0x04025EBE RID: 155326
			[Token(Token = "0x4025EBE")]
			[FieldOffset(Offset = "0x28")]
			public UIIllustLayoutInfo beginLayout;
		}

		// Token: 0x02004B13 RID: 19219
		[Token(Token = "0x2004B13")]
		private struct DragPosStatus
		{
			// Token: 0x0601CE73 RID: 118387 RVA: 0x000A9CB0 File Offset: 0x000A7EB0
			[Token(Token = "0x601CE73")]
			[Address(RVA = "0x164E980", Offset = "0x164D580", VA = "0x18164E980")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04025EBF RID: 155327
			[Token(Token = "0x4025EBF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HomeIllustEditState.DragPosStatus EMPTY;

			// Token: 0x04025EC0 RID: 155328
			[Token(Token = "0x4025EC0")]
			[FieldOffset(Offset = "0x0")]
			public UICharacterIllust target;

			// Token: 0x04025EC1 RID: 155329
			[Token(Token = "0x4025EC1")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform illustContainer;

			// Token: 0x04025EC2 RID: 155330
			[Token(Token = "0x4025EC2")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 startTouchPos;

			// Token: 0x04025EC3 RID: 155331
			[Token(Token = "0x4025EC3")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 startIllustPos;

			// Token: 0x04025EC4 RID: 155332
			[Token(Token = "0x4025EC4")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 curTouchPos;

			// Token: 0x04025EC5 RID: 155333
			[Token(Token = "0x4025EC5")]
			[FieldOffset(Offset = "0x28")]
			public Camera localCam;

			// Token: 0x04025EC6 RID: 155334
			[Token(Token = "0x4025EC6")]
			[FieldOffset(Offset = "0x30")]
			public Camera illustCam;

			// Token: 0x04025EC7 RID: 155335
			[Token(Token = "0x4025EC7")]
			[FieldOffset(Offset = "0x38")]
			public int pointerId;
		}

		// Token: 0x02004B14 RID: 19220
		[Token(Token = "0x2004B14")]
		private struct LayoutTween
		{
			// Token: 0x17004422 RID: 17442
			// (get) Token: 0x0601CE75 RID: 118389 RVA: 0x000A9CC8 File Offset: 0x000A7EC8
			// (set) Token: 0x0601CE76 RID: 118390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004422")]
			public bool isActive
			{
				[Token(Token = "0x601CE75")]
				[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x601CE76")]
				[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601CE77 RID: 118391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CE77")]
			[Address(RVA = "0x1664540", Offset = "0x1663140", VA = "0x181664540")]
			public void Tick()
			{
			}

			// Token: 0x0601CE78 RID: 118392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CE78")]
			[Address(RVA = "0x1664370", Offset = "0x1662F70", VA = "0x181664370")]
			public void Clear()
			{
			}

			// Token: 0x0601CE79 RID: 118393 RVA: 0x000A9CE0 File Offset: 0x000A7EE0
			[Token(Token = "0x601CE79")]
			[Address(RVA = "0x16643B0", Offset = "0x1662FB0", VA = "0x1816643B0")]
			public static HomeIllustEditState.LayoutTween Start(HomeIllustView.IllustHandler handler, HomeIllustEditFrame editFrame, UIIllustLayoutInfo start, UIIllustLayoutInfo end, float duration = 0.2f)
			{
				return default(HomeIllustEditState.LayoutTween);
			}

			// Token: 0x04025EC8 RID: 155336
			[Token(Token = "0x4025EC8")]
			public const float DEFAULT_DUR = 0.2f;

			// Token: 0x04025EC9 RID: 155337
			[Token(Token = "0x4025EC9")]
			[FieldOffset(Offset = "0x0")]
			private UIIllustLayoutInfo m_start;

			// Token: 0x04025ECA RID: 155338
			[Token(Token = "0x4025ECA")]
			[FieldOffset(Offset = "0x10")]
			private UIIllustLayoutInfo m_end;

			// Token: 0x04025ECB RID: 155339
			[Token(Token = "0x4025ECB")]
			[FieldOffset(Offset = "0x20")]
			private long m_startTick;

			// Token: 0x04025ECC RID: 155340
			[Token(Token = "0x4025ECC")]
			[FieldOffset(Offset = "0x28")]
			private long m_endTick;

			// Token: 0x04025ECD RID: 155341
			[Token(Token = "0x4025ECD")]
			[FieldOffset(Offset = "0x30")]
			private HomeIllustView.IllustHandler m_handler;

			// Token: 0x04025ECE RID: 155342
			[Token(Token = "0x4025ECE")]
			[FieldOffset(Offset = "0x38")]
			private Interpolator.EasingFunction m_easeFunc;

			// Token: 0x04025ECF RID: 155343
			[Token(Token = "0x4025ECF")]
			[FieldOffset(Offset = "0x40")]
			private HomeIllustEditFrame m_editFrame;
		}
	}
}
