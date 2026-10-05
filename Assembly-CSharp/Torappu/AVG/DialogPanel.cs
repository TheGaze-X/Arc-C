using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001ED0 RID: 7888
	[Token(Token = "0x2001ED0")]
	[RequireComponent(typeof(CanvasGroup))]
	public class DialogPanel : ExecutorComponent, IAVGDataSubscriber<AVGStoryCache>, IHotfixable
	{
		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x0600C385 RID: 50053 RVA: 0x00047C40 File Offset: 0x00045E40
		// (set) Token: 0x0600C386 RID: 50054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001763")]
		public bool isHidden
		{
			[Token(Token = "0x600C385")]
			[Address(RVA = "0x3412D80", Offset = "0x3411980", VA = "0x183412D80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C386")]
			[Address(RVA = "0x3412E50", Offset = "0x3411A50", VA = "0x183412E50")]
			set
			{
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x0600C387 RID: 50055 RVA: 0x00047C58 File Offset: 0x00045E58
		[Token(Token = "0x17001764")]
		public bool isTyping
		{
			[Token(Token = "0x600C387")]
			[Address(RVA = "0x3412DE0", Offset = "0x34119E0", VA = "0x183412DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C388 RID: 50056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C388")]
		[Address(RVA = "0x340FC70", Offset = "0x340E870", VA = "0x18340FC70", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C389 RID: 50057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C389")]
		[Address(RVA = "0x3410340", Offset = "0x340EF40", VA = "0x183410340", Slot = "5")]
		public override void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600C38A RID: 50058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38A")]
		[Address(RVA = "0x340FFF0", Offset = "0x340EBF0", VA = "0x18340FFF0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C38B RID: 50059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38B")]
		[Address(RVA = "0x34128F0", Offset = "0x34114F0", VA = "0x1834128F0")]
		private void _SetTypeWriterDelay(object arg)
		{
		}

		// Token: 0x0600C38C RID: 50060 RVA: 0x00047C70 File Offset: 0x00045E70
		[Token(Token = "0x600C38C")]
		[Address(RVA = "0x34112A0", Offset = "0x340FEA0", VA = "0x1834112A0")]
		private bool _ExecuteAside(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x00047C88 File Offset: 0x00045E88
		[Token(Token = "0x600C38D")]
		[Address(RVA = "0x3411540", Offset = "0x3410140", VA = "0x183411540")]
		private bool _ExecuteDialog(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x00047CA0 File Offset: 0x00045EA0
		[Token(Token = "0x600C38E")]
		[Address(RVA = "0x3411C10", Offset = "0x3410810", VA = "0x183411C10")]
		private bool _ExecuteMultiline(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x00047CB8 File Offset: 0x00045EB8
		[Token(Token = "0x600C38F")]
		[Address(RVA = "0x34118F0", Offset = "0x34104F0", VA = "0x1834118F0")]
		private bool _ExecuteEndtip(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C390 RID: 50064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C390")]
		[Address(RVA = "0x34126A0", Offset = "0x34112A0", VA = "0x1834126A0")]
		private void _ResetMultiline()
		{
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x00047CD0 File Offset: 0x00045ED0
		[Token(Token = "0x600C391")]
		[Address(RVA = "0x34110D0", Offset = "0x340FCD0", VA = "0x1834110D0")]
		private float _CalculateTextHeight(Text textComponent, string text)
		{
			return 0f;
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x00047CE8 File Offset: 0x00045EE8
		[Token(Token = "0x600C392")]
		[Address(RVA = "0x3410FA0", Offset = "0x340FBA0", VA = "0x183410FA0")]
		private float _CalcMessageLayoutDelta(string content)
		{
			return 0f;
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x00047D00 File Offset: 0x00045F00
		[Token(Token = "0x600C393")]
		[Address(RVA = "0x3411020", Offset = "0x340FC20", VA = "0x183411020")]
		private float _CalcMessageWarnDelta(string content)
		{
			return 0f;
		}

		// Token: 0x0600C394 RID: 50068 RVA: 0x00047D18 File Offset: 0x00045F18
		[Token(Token = "0x600C394")]
		[Address(RVA = "0x3412190", Offset = "0x3410D90", VA = "0x183412190")]
		private float _GetTextContainerHeightOffset()
		{
			return 0f;
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C395")]
		[Address(RVA = "0x3410B10", Offset = "0x340F710", VA = "0x183410B10")]
		private void _ApplyMessagePosition(float x, float messageHeightDelta, float heightOffset)
		{
		}

		// Token: 0x0600C396 RID: 50070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C396")]
		[Address(RVA = "0x3410C50", Offset = "0x340F850", VA = "0x183410C50")]
		private void _ApplyNamePosition(float nameHeightDelta)
		{
		}

		// Token: 0x0600C397 RID: 50071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C397")]
		[Address(RVA = "0x340FEC0", Offset = "0x340EAC0", VA = "0x18340FEC0", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C398 RID: 50072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C398")]
		[Address(RVA = "0x340FC00", Offset = "0x340E800", VA = "0x18340FC00", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C399")]
		[Address(RVA = "0x3412280", Offset = "0x3410E80", VA = "0x183412280", Slot = "14")]
		protected virtual void _OnClicked(object arg)
		{
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39A")]
		[Address(RVA = "0x3410520", Offset = "0x340F120", VA = "0x183410520", Slot = "13")]
		public void OnValueChanged(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x00047D30 File Offset: 0x00045F30
		[Token(Token = "0x600C39B")]
		[Address(RVA = "0x34129A0", Offset = "0x34115A0", VA = "0x1834129A0")]
		private bool _TryResolveDialogPreset(int presetId, out AVGDialogPresetData preset)
		{
			return default(bool);
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39C")]
		[Address(RVA = "0x3410ED0", Offset = "0x340FAD0", VA = "0x183410ED0")]
		private void _BindStoryCacheIfNeeded()
		{
		}

		// Token: 0x0600C39D RID: 50077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39D")]
		[Address(RVA = "0x3412BD0", Offset = "0x34117D0", VA = "0x183412BD0")]
		private void _UnbindStoryCacheIfNeeded()
		{
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39E")]
		[Address(RVA = "0x3410890", Offset = "0x340F490", VA = "0x183410890")]
		private void _ApplyDialogFontSize(int size)
		{
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C39F")]
		[Address(RVA = "0x3410990", Offset = "0x340F590", VA = "0x183410990")]
		private void _ApplyDialogPreset(AVGDialogPresetData preset)
		{
		}

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A0")]
		[Address(RVA = "0x3412440", Offset = "0x3411040", VA = "0x183412440")]
		private void _RefreshCurrentLayout()
		{
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A1")]
		[Address(RVA = "0x3410D80", Offset = "0x340F980", VA = "0x183410D80")]
		private void _ApplyTextContainerHeight(float minHeight)
		{
		}

		// Token: 0x0600C3A2 RID: 50082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A2")]
		[Address(RVA = "0x3412390", Offset = "0x3410F90", VA = "0x183412390")]
		private void _OnTypeWriterEnd()
		{
		}

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A3")]
		[Address(RVA = "0x3412750", Offset = "0x3411350", VA = "0x183412750")]
		private void _SetHiddenInternal(bool value, bool force)
		{
		}

		// Token: 0x0600C3A4 RID: 50084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A4")]
		[Address(RVA = "0x340FA70", Offset = "0x340E670", VA = "0x18340FA70")]
		private void Awake()
		{
		}

		// Token: 0x0600C3A5 RID: 50085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A5")]
		[Address(RVA = "0x3412CA0", Offset = "0x34118A0", VA = "0x183412CA0")]
		public DialogPanel()
		{
		}

		// Token: 0x0600C3A6 RID: 50086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A6")]
		[Address(RVA = "0x33F0E70", Offset = "0x33EFA70", VA = "0x1833F0E70")]
		private void <>xLuaBaseProxy_OnStoryBegin(Story P0)
		{
		}

		// Token: 0x0600C3A7 RID: 50087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A7")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C3A8 RID: 50088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A8")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400C5BE RID: 50622
		[Token(Token = "0x400C5BE")]
		private const float MESSAGE_ASIDE_X_POS = -86f;

		// Token: 0x0400C5BF RID: 50623
		[Token(Token = "0x400C5BF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _name;

		// Token: 0x0400C5C0 RID: 50624
		[Token(Token = "0x400C5C0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AVGTypeWriterText _typeWriter;

		// Token: 0x0400C5C1 RID: 50625
		[Token(Token = "0x400C5C1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _hideDuration;

		// Token: 0x0400C5C2 RID: 50626
		[Token(Token = "0x400C5C2")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _autoWaitBaseTime;

		// Token: 0x0400C5C3 RID: 50627
		[Token(Token = "0x400C5C3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _autoWaitTimePerText;

		// Token: 0x0400C5C4 RID: 50628
		[Token(Token = "0x400C5C4")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Ease _hideEase;

		// Token: 0x0400C5C5 RID: 50629
		[Token(Token = "0x400C5C5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _message;

		// Token: 0x0400C5C6 RID: 50630
		[Token(Token = "0x400C5C6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _messageBottomPadding;

		// Token: 0x0400C5C7 RID: 50631
		[Token(Token = "0x400C5C7")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _messageTextMaxHeight;

		// Token: 0x0400C5C8 RID: 50632
		[Token(Token = "0x400C5C8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _nameTextMaxHeight;

		// Token: 0x0400C5C9 RID: 50633
		[Token(Token = "0x400C5C9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _textContainer;

		// Token: 0x0400C5CA RID: 50634
		[Token(Token = "0x400C5CA")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hidden;

		// Token: 0x0400C5CB RID: 50635
		[Token(Token = "0x400C5CB")]
		[FieldOffset(Offset = "0x94")]
		private float m_messageOriginYPos;

		// Token: 0x0400C5CC RID: 50636
		[Token(Token = "0x400C5CC")]
		[FieldOffset(Offset = "0x98")]
		private float m_messageOriginXPos;

		// Token: 0x0400C5CD RID: 50637
		[Token(Token = "0x400C5CD")]
		[FieldOffset(Offset = "0x9C")]
		private float m_nameOriginYPos;

		// Token: 0x0400C5CE RID: 50638
		[Token(Token = "0x400C5CE")]
		[FieldOffset(Offset = "0xA0")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400C5CF RID: 50639
		[Token(Token = "0x400C5CF")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_ismultiline;

		// Token: 0x0400C5D0 RID: 50640
		[Token(Token = "0x400C5D0")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedMultiline;

		// Token: 0x0400C5D1 RID: 50641
		[Token(Token = "0x400C5D1")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_multilineEnd;

		// Token: 0x0400C5D2 RID: 50642
		[Token(Token = "0x400C5D2")]
		[FieldOffset(Offset = "0xBC")]
		private int m_cachedDialogPresetId;

		// Token: 0x0400C5D3 RID: 50643
		[Token(Token = "0x400C5D3")]
		[FieldOffset(Offset = "0xC0")]
		private float m_textContainerOriginHeight;

		// Token: 0x0400C5D4 RID: 50644
		[Token(Token = "0x400C5D4")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_missingDialogPresetLogged;

		// Token: 0x0400C5D5 RID: 50645
		[Token(Token = "0x400C5D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x0400C5D6 RID: 50646
		[Token(Token = "0x400C5D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isHidden;

		// Token: 0x0400C5D7 RID: 50647
		[Token(Token = "0x400C5D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isTyping;

		// Token: 0x0400C5D8 RID: 50648
		[Token(Token = "0x400C5D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C5D9 RID: 50649
		[Token(Token = "0x400C5D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400C5DA RID: 50650
		[Token(Token = "0x400C5DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C5DB RID: 50651
		[Token(Token = "0x400C5DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetTypeWriterDelay;

		// Token: 0x0400C5DC RID: 50652
		[Token(Token = "0x400C5DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteAside;

		// Token: 0x0400C5DD RID: 50653
		[Token(Token = "0x400C5DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteDialog;

		// Token: 0x0400C5DE RID: 50654
		[Token(Token = "0x400C5DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExecuteMultiline;

		// Token: 0x0400C5DF RID: 50655
		[Token(Token = "0x400C5DF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExecuteEndtip;

		// Token: 0x0400C5E0 RID: 50656
		[Token(Token = "0x400C5E0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResetMultiline;

		// Token: 0x0400C5E1 RID: 50657
		[Token(Token = "0x400C5E1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CalculateTextHeight;

		// Token: 0x0400C5E2 RID: 50658
		[Token(Token = "0x400C5E2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CalcMessageLayoutDelta;

		// Token: 0x0400C5E3 RID: 50659
		[Token(Token = "0x400C5E3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CalcMessageWarnDelta;

		// Token: 0x0400C5E4 RID: 50660
		[Token(Token = "0x400C5E4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetTextContainerHeightOffset;

		// Token: 0x0400C5E5 RID: 50661
		[Token(Token = "0x400C5E5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ApplyMessagePosition;

		// Token: 0x0400C5E6 RID: 50662
		[Token(Token = "0x400C5E6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ApplyNamePosition;

		// Token: 0x0400C5E7 RID: 50663
		[Token(Token = "0x400C5E7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C5E8 RID: 50664
		[Token(Token = "0x400C5E8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C5E9 RID: 50665
		[Token(Token = "0x400C5E9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnClicked;

		// Token: 0x0400C5EA RID: 50666
		[Token(Token = "0x400C5EA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400C5EB RID: 50667
		[Token(Token = "0x400C5EB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryResolveDialogPreset;

		// Token: 0x0400C5EC RID: 50668
		[Token(Token = "0x400C5EC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__BindStoryCacheIfNeeded;

		// Token: 0x0400C5ED RID: 50669
		[Token(Token = "0x400C5ED")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UnbindStoryCacheIfNeeded;

		// Token: 0x0400C5EE RID: 50670
		[Token(Token = "0x400C5EE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ApplyDialogFontSize;

		// Token: 0x0400C5EF RID: 50671
		[Token(Token = "0x400C5EF")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ApplyDialogPreset;

		// Token: 0x0400C5F0 RID: 50672
		[Token(Token = "0x400C5F0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RefreshCurrentLayout;

		// Token: 0x0400C5F1 RID: 50673
		[Token(Token = "0x400C5F1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ApplyTextContainerHeight;

		// Token: 0x0400C5F2 RID: 50674
		[Token(Token = "0x400C5F2")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnTypeWriterEnd;

		// Token: 0x0400C5F3 RID: 50675
		[Token(Token = "0x400C5F3")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__SetHiddenInternal;

		// Token: 0x0400C5F4 RID: 50676
		[Token(Token = "0x400C5F4")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400C5F5 RID: 50677
		[Token(Token = "0x400C5F5")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
