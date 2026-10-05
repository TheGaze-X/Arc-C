using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EB8 RID: 7864
	[Token(Token = "0x2001EB8")]
	public class AVGTutorialPanel : ExecutorComponent, IFadeTimeRatio
	{
		// Token: 0x0600C2D1 RID: 49873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C2D1")]
		[Address(RVA = "0x33FFF30", Offset = "0x33FEB30", VA = "0x1833FFF30", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C2D2")]
		[Address(RVA = "0x3400110", Offset = "0x33FED10", VA = "0x183400110", Slot = "9")]
		public override Dictionary<string, ExecutorComponent.SignalReceiver> GetSignalReceivers()
		{
			return null;
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D3")]
		[Address(RVA = "0x34002D0", Offset = "0x33FEED0", VA = "0x1834002D0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D4")]
		[Address(RVA = "0x34005B0", Offset = "0x33FF1B0", VA = "0x1834005B0", Slot = "6")]
		public override void OnStoryEnd(Story story)
		{
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x000478C8 File Offset: 0x00045AC8
		[Token(Token = "0x600C2D5")]
		[Address(RVA = "0x34018B0", Offset = "0x34004B0", VA = "0x1834018B0")]
		private bool _ExecuteTutorial(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x000478E0 File Offset: 0x00045AE0
		[Token(Token = "0x600C2D6")]
		[Address(RVA = "0x3403D90", Offset = "0x3402990", VA = "0x183403D90")]
		private static float? _TryGetValue(Dictionary<string, object> param, string key, float scaler)
		{
			return null;
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D7")]
		[Address(RVA = "0x33FFE60", Offset = "0x33FEA60", VA = "0x1833FFE60")]
		public void CommonFallback()
		{
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D8")]
		[Address(RVA = "0x34036B0", Offset = "0x34022B0", VA = "0x1834036B0")]
		private void _ReceiveTutorialSignal(Command command)
		{
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D9")]
		[Address(RVA = "0x34032A0", Offset = "0x3401EA0", VA = "0x1834032A0")]
		private void _RearrangePartialBlockers(Rect validArea)
		{
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2DA")]
		[Address(RVA = "0x3402A50", Offset = "0x3401650", VA = "0x183402A50")]
		private void _HidePartialBlockers()
		{
		}

		// Token: 0x0600C2DB RID: 49883 RVA: 0x000478F8 File Offset: 0x00045AF8
		[Token(Token = "0x600C2DB")]
		[Address(RVA = "0x3401370", Offset = "0x33FFF70", VA = "0x183401370")]
		private bool _ExecuteInputBlocker(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x00047910 File Offset: 0x00045B10
		[Token(Token = "0x600C2DC")]
		[Address(RVA = "0x3402BE0", Offset = "0x34017E0", VA = "0x183402BE0")]
		private bool _IsInputBlockerValidAreaSet(Command command, ref Vector2 validXY)
		{
			return default(bool);
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2DD")]
		[Address(RVA = "0x34027B0", Offset = "0x34013B0", VA = "0x1834027B0")]
		private void _GetCenterAnchorPos(Command command, ref Vector2 validXY)
		{
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x00047928 File Offset: 0x00045B28
		[Token(Token = "0x600C2DE")]
		[Address(RVA = "0x3403810", Offset = "0x3402410", VA = "0x183403810")]
		private bool _SetButtonTarget(string targetName, bool searchBtnInChildren)
		{
			return default(bool);
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2DF")]
		[Address(RVA = "0x34030E0", Offset = "0x3401CE0", VA = "0x1834030E0")]
		private void _OnHighlightClicked(object arg)
		{
		}

		// Token: 0x0600C2E0 RID: 49888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E0")]
		[Address(RVA = "0x3401100", Offset = "0x33FFD00", VA = "0x183401100")]
		private void _DoHighlightClicked()
		{
		}

		// Token: 0x0600C2E1 RID: 49889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E1")]
		[Address(RVA = "0x34031C0", Offset = "0x3401DC0", VA = "0x1834031C0")]
		private void _OnPopupDialogClicked(object arg)
		{
		}

		// Token: 0x0600C2E2 RID: 49890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E2")]
		[Address(RVA = "0x3401220", Offset = "0x33FFE20", VA = "0x183401220")]
		private void _DoPopupDialogClicked()
		{
		}

		// Token: 0x0600C2E3 RID: 49891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E3")]
		[Address(RVA = "0x3402EE0", Offset = "0x3401AE0", VA = "0x183402EE0")]
		private void _OnDragAnimationClicked(object arg)
		{
		}

		// Token: 0x0600C2E4 RID: 49892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E4")]
		[Address(RVA = "0x3400990", Offset = "0x33FF590", VA = "0x183400990")]
		private static void _AlignRectTransform(Graphic currentGraphic, Graphic targetGraphic)
		{
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E5")]
		[Address(RVA = "0x3403060", Offset = "0x3401C60", VA = "0x183403060")]
		private void _OnFakeButtonClicked()
		{
		}

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E6")]
		[Address(RVA = "0x3402B40", Offset = "0x3401740", VA = "0x183402B40")]
		private void _Hide()
		{
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E7")]
		[Address(RVA = "0x3400720", Offset = "0x33FF320", VA = "0x183400720")]
		public static void ResetAnchor(RectTransform transform, AVGTutorialPanel.AnchorType anchor)
		{
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E8")]
		[Address(RVA = "0x33FFED0", Offset = "0x33FEAD0", VA = "0x1833FFED0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E9")]
		[Address(RVA = "0x33FFC80", Offset = "0x33FE880", VA = "0x1833FFC80")]
		private void Awake()
		{
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EA")]
		[Address(RVA = "0x3400900", Offset = "0x33FF500", VA = "0x183400900")]
		private void Update()
		{
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x00047940 File Offset: 0x00045B40
		[Token(Token = "0x600C2EB")]
		[Address(RVA = "0x33FFD50", Offset = "0x33FE950", VA = "0x1833FFD50", Slot = "13")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C2EC RID: 49900 RVA: 0x00047958 File Offset: 0x00045B58
		[Token(Token = "0x600C2EC")]
		[Address(RVA = "0x3400230", Offset = "0x33FEE30", VA = "0x183400230", Slot = "14")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C2ED RID: 49901 RVA: 0x00047970 File Offset: 0x00045B70
		[Token(Token = "0x600C2ED")]
		[Address(RVA = "0x3400650", Offset = "0x33FF250", VA = "0x183400650")]
		public bool RegisterPlugin(AVGTutorialPanel.IAVGTutorialPanelPlugin plugin)
		{
			return default(bool);
		}

		// Token: 0x0600C2EE RID: 49902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EE")]
		[Address(RVA = "0x33FFDF0", Offset = "0x33FE9F0", VA = "0x1833FFDF0")]
		public void ClearPlugin()
		{
		}

		// Token: 0x0600C2EF RID: 49903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EF")]
		[Address(RVA = "0x3403E90", Offset = "0x3402A90", VA = "0x183403E90")]
		public AVGTutorialPanel()
		{
		}

		// Token: 0x0600C2F0 RID: 49904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C2F0")]
		[Address(RVA = "0x1C5FCE0", Offset = "0x1C5E8E0", VA = "0x181C5FCE0")]
		private Dictionary<string, ExecutorComponent.SignalReceiver> <>xLuaBaseProxy_GetSignalReceivers()
		{
			return null;
		}

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F1")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C2F2 RID: 49906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F2")]
		[Address(RVA = "0x33F0E80", Offset = "0x33EFA80", VA = "0x1833F0E80")]
		private void <>xLuaBaseProxy_OnStoryEnd(Story P0)
		{
		}

		// Token: 0x0400C4CA RID: 50378
		[Token(Token = "0x400C4CA")]
		private const AVGTutorialPanel.AnchorType DEFAULT_ANCHOR = AVGTutorialPanel.AnchorType.Center;

		// Token: 0x0400C4CB RID: 50379
		[Token(Token = "0x400C4CB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGFakeButton _fakeBtn;

		// Token: 0x0400C4CC RID: 50380
		[Token(Token = "0x400C4CC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Graphic _fakeGraphic;

		// Token: 0x0400C4CD RID: 50381
		[Token(Token = "0x400C4CD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AVGTutorialFocus _focus;

		// Token: 0x0400C4CE RID: 50382
		[Token(Token = "0x400C4CE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AVGTutorialPointer _pointer;

		// Token: 0x0400C4CF RID: 50383
		[Token(Token = "0x400C4CF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AVGTutorialDialog _dialog;

		// Token: 0x0400C4D0 RID: 50384
		[Token(Token = "0x400C4D0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Graphic _inputBlocker;

		// Token: 0x0400C4D1 RID: 50385
		[Token(Token = "0x400C4D1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Graphic _btnClickBlocker;

		// Token: 0x0400C4D2 RID: 50386
		[Token(Token = "0x400C4D2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Graphic[] _inputPartialBlockers;

		// Token: 0x0400C4D3 RID: 50387
		[Token(Token = "0x400C4D3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _inputBlockerBackground;

		// Token: 0x0400C4D4 RID: 50388
		[Token(Token = "0x400C4D4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _highlightDefaultProtectTime;

		// Token: 0x0400C4D5 RID: 50389
		[Token(Token = "0x400C4D5")]
		[FieldOffset(Offset = "0xA0")]
		private string m_waitForSignal;

		// Token: 0x0400C4D6 RID: 50390
		[Token(Token = "0x400C4D6")]
		[FieldOffset(Offset = "0xA8")]
		private string m_abortForSignal;

		// Token: 0x0400C4D7 RID: 50391
		[Token(Token = "0x400C4D7")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_waitForHighlightClick;

		// Token: 0x0400C4D8 RID: 50392
		[Token(Token = "0x400C4D8")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_waitForDialogClick;

		// Token: 0x0400C4D9 RID: 50393
		[Token(Token = "0x400C4D9")]
		[FieldOffset(Offset = "0xB2")]
		private bool m_waitForDragAnimationClick;

		// Token: 0x0400C4DA RID: 50394
		[Token(Token = "0x400C4DA")]
		[FieldOffset(Offset = "0xB4")]
		private float m_highlightProtectTime;

		// Token: 0x0400C4DB RID: 50395
		[Token(Token = "0x400C4DB")]
		[FieldOffset(Offset = "0xB8")]
		private AVGTutorialPanel.IAVGTutorialPanelPlugin m_plugin;

		// Token: 0x0400C4DC RID: 50396
		[Token(Token = "0x400C4DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C4DD RID: 50397
		[Token(Token = "0x400C4DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSignalReceivers;

		// Token: 0x0400C4DE RID: 50398
		[Token(Token = "0x400C4DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C4DF RID: 50399
		[Token(Token = "0x400C4DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400C4E0 RID: 50400
		[Token(Token = "0x400C4E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteTutorial;

		// Token: 0x0400C4E1 RID: 50401
		[Token(Token = "0x400C4E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetValue;

		// Token: 0x0400C4E2 RID: 50402
		[Token(Token = "0x400C4E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CommonFallback;

		// Token: 0x0400C4E3 RID: 50403
		[Token(Token = "0x400C4E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReceiveTutorialSignal;

		// Token: 0x0400C4E4 RID: 50404
		[Token(Token = "0x400C4E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RearrangePartialBlockers;

		// Token: 0x0400C4E5 RID: 50405
		[Token(Token = "0x400C4E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HidePartialBlockers;

		// Token: 0x0400C4E6 RID: 50406
		[Token(Token = "0x400C4E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExecuteInputBlocker;

		// Token: 0x0400C4E7 RID: 50407
		[Token(Token = "0x400C4E7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__IsInputBlockerValidAreaSet;

		// Token: 0x0400C4E8 RID: 50408
		[Token(Token = "0x400C4E8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetCenterAnchorPos;

		// Token: 0x0400C4E9 RID: 50409
		[Token(Token = "0x400C4E9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetButtonTarget;

		// Token: 0x0400C4EA RID: 50410
		[Token(Token = "0x400C4EA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnHighlightClicked;

		// Token: 0x0400C4EB RID: 50411
		[Token(Token = "0x400C4EB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DoHighlightClicked;

		// Token: 0x0400C4EC RID: 50412
		[Token(Token = "0x400C4EC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnPopupDialogClicked;

		// Token: 0x0400C4ED RID: 50413
		[Token(Token = "0x400C4ED")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DoPopupDialogClicked;

		// Token: 0x0400C4EE RID: 50414
		[Token(Token = "0x400C4EE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnDragAnimationClicked;

		// Token: 0x0400C4EF RID: 50415
		[Token(Token = "0x400C4EF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__AlignRectTransform;

		// Token: 0x0400C4F0 RID: 50416
		[Token(Token = "0x400C4F0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnFakeButtonClicked;

		// Token: 0x0400C4F1 RID: 50417
		[Token(Token = "0x400C4F1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__Hide;

		// Token: 0x0400C4F2 RID: 50418
		[Token(Token = "0x400C4F2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ResetAnchor;

		// Token: 0x0400C4F3 RID: 50419
		[Token(Token = "0x400C4F3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C4F4 RID: 50420
		[Token(Token = "0x400C4F4")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400C4F5 RID: 50421
		[Token(Token = "0x400C4F5")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400C4F6 RID: 50422
		[Token(Token = "0x400C4F6")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C4F7 RID: 50423
		[Token(Token = "0x400C4F7")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C4F8 RID: 50424
		[Token(Token = "0x400C4F8")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RegisterPlugin;

		// Token: 0x0400C4F9 RID: 50425
		[Token(Token = "0x400C4F9")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ClearPlugin;

		// Token: 0x0400C4FA RID: 50426
		[Token(Token = "0x400C4FA")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EB9 RID: 7865
		[Token(Token = "0x2001EB9")]
		public enum AnchorType
		{
			// Token: 0x0400C4FC RID: 50428
			[Token(Token = "0x400C4FC")]
			Center,
			// Token: 0x0400C4FD RID: 50429
			[Token(Token = "0x400C4FD")]
			TopLeft,
			// Token: 0x0400C4FE RID: 50430
			[Token(Token = "0x400C4FE")]
			TopRight,
			// Token: 0x0400C4FF RID: 50431
			[Token(Token = "0x400C4FF")]
			BottomRight,
			// Token: 0x0400C500 RID: 50432
			[Token(Token = "0x400C500")]
			BottomLeft,
			// Token: 0x0400C501 RID: 50433
			[Token(Token = "0x400C501")]
			Top,
			// Token: 0x0400C502 RID: 50434
			[Token(Token = "0x400C502")]
			Right,
			// Token: 0x0400C503 RID: 50435
			[Token(Token = "0x400C503")]
			Bottom,
			// Token: 0x0400C504 RID: 50436
			[Token(Token = "0x400C504")]
			Left
		}

		// Token: 0x02001EBA RID: 7866
		[Token(Token = "0x2001EBA")]
		private enum TutorialAnimStyle
		{
			// Token: 0x0400C506 RID: 50438
			[Token(Token = "0x400C506")]
			None,
			// Token: 0x0400C507 RID: 50439
			[Token(Token = "0x400C507")]
			Highlight,
			// Token: 0x0400C508 RID: 50440
			[Token(Token = "0x400C508")]
			Click,
			// Token: 0x0400C509 RID: 50441
			[Token(Token = "0x400C509")]
			Drag,
			// Token: 0x0400C50A RID: 50442
			[Token(Token = "0x400C50A")]
			NoWait
		}

		// Token: 0x02001EBB RID: 7867
		[Token(Token = "0x2001EBB")]
		public interface IAVGTutorialPanelPlugin
		{
			// Token: 0x0600C2F3 RID: 49907
			[Token(Token = "0x600C2F3")]
			bool TryGetInputBlockerPos(Command command, ref Vector2 pos);

			// Token: 0x0600C2F4 RID: 49908
			[Token(Token = "0x600C2F4")]
			bool TryGetFocusPos(Command command, ref Vector3 pos, ref AVGTutorialPanel.AnchorType ancher);

			// Token: 0x0600C2F5 RID: 49909
			[Token(Token = "0x600C2F5")]
			bool TryGetDragPos(Command command, ref Vector2 pos, bool isStartPos);

			// Token: 0x0600C2F6 RID: 49910
			[Token(Token = "0x600C2F6")]
			void OnReset();
		}
	}
}
