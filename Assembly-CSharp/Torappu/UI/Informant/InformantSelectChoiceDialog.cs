using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A31 RID: 18993
	[Token(Token = "0x2004A31")]
	public class InformantSelectChoiceDialog : UICompDialog<InformantSelectChoiceDialogInput>, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x0601C906 RID: 116998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C906")]
		[Address(RVA = "0x16155F0", Offset = "0x16141F0", VA = "0x1816155F0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C907 RID: 116999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C907")]
		[Address(RVA = "0x1615CC0", Offset = "0x16148C0", VA = "0x181615CC0", Slot = "18")]
		protected override void OnRender(InformantSelectChoiceDialogInput input)
		{
		}

		// Token: 0x0601C908 RID: 117000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C908")]
		[Address(RVA = "0x16156E0", Offset = "0x16142E0", VA = "0x1816156E0", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601C909 RID: 117001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C909")]
		[Address(RVA = "0x16162E0", Offset = "0x1614EE0", VA = "0x1816162E0")]
		private void _EventOnChoiceClicked(int choiceIndex)
		{
		}

		// Token: 0x0601C90A RID: 117002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C90A")]
		[Address(RVA = "0x1616DC0", Offset = "0x16159C0", VA = "0x181616DC0")]
		private void _HandleSelectChoice(int choiceIndex)
		{
		}

		// Token: 0x0601C90B RID: 117003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C90B")]
		[Address(RVA = "0x1617280", Offset = "0x1615E80", VA = "0x181617280")]
		private void _OnSelectChoiceSucc(InformantSelectChoiceResponse response)
		{
		}

		// Token: 0x0601C90C RID: 117004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C90C")]
		[Address(RVA = "0x1617700", Offset = "0x1616300", VA = "0x181617700")]
		private IEnumerator _PlayAttrChangeAudio(float delayTime)
		{
			return null;
		}

		// Token: 0x0601C90D RID: 117005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C90D")]
		[Address(RVA = "0x1616BF0", Offset = "0x16157F0", VA = "0x181616BF0")]
		private void _EventOnSettle()
		{
		}

		// Token: 0x0601C90E RID: 117006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C90E")]
		[Address(RVA = "0x1617020", Offset = "0x1615C20", VA = "0x181617020")]
		private void _HandleSettle()
		{
		}

		// Token: 0x0601C90F RID: 117007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C90F")]
		[Address(RVA = "0x1616B50", Offset = "0x1615750", VA = "0x181616B50")]
		private void _EventOnRequestOrOpenInsight()
		{
		}

		// Token: 0x0601C910 RID: 117008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C910")]
		[Address(RVA = "0x1616820", Offset = "0x1615420", VA = "0x181616820")]
		private void _EventOnRequestInsight()
		{
		}

		// Token: 0x0601C911 RID: 117009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C911")]
		[Address(RVA = "0x1616550", Offset = "0x1615150", VA = "0x181616550")]
		private void _EventOnOpenInsight()
		{
		}

		// Token: 0x0601C912 RID: 117010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C912")]
		[Address(RVA = "0x16164A0", Offset = "0x16150A0", VA = "0x1816164A0")]
		private void _EventOnCloseInsight()
		{
		}

		// Token: 0x0601C913 RID: 117011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C913")]
		[Address(RVA = "0x1616210", Offset = "0x1614E10", VA = "0x181616210")]
		private void _EventOnBackgroundClicked()
		{
		}

		// Token: 0x0601C914 RID: 117012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C914")]
		[Address(RVA = "0x16177B0", Offset = "0x16163B0", VA = "0x1816177B0")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x0601C915 RID: 117013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C915")]
		[Address(RVA = "0x16179A0", Offset = "0x16165A0", VA = "0x1816179A0")]
		private void _TutorialOnly_EntryAnimRouted()
		{
		}

		// Token: 0x0601C916 RID: 117014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C916")]
		[Address(RVA = "0x1617A50", Offset = "0x1616650", VA = "0x181617A50")]
		private void _TutorialOnly_PatienceNoticeAnimRouted()
		{
		}

		// Token: 0x0601C917 RID: 117015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C917")]
		[Address(RVA = "0x1617B00", Offset = "0x1616700", VA = "0x181617B00")]
		public InformantSelectChoiceDialog()
		{
		}

		// Token: 0x0601C91B RID: 117019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C91B")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402579B RID: 153499
		[Token(Token = "0x402579B")]
		[NonSerialized]
		public const int EVENT_ON_CHOICE_CLICKED = 0;

		// Token: 0x0402579C RID: 153500
		[Token(Token = "0x402579C")]
		[NonSerialized]
		public const int EVENT_ON_SETTLE = 1;

		// Token: 0x0402579D RID: 153501
		[Token(Token = "0x402579D")]
		[NonSerialized]
		public const int EVENT_ON_REQUEST_OR_OPEN_INSIGHT = 2;

		// Token: 0x0402579E RID: 153502
		[Token(Token = "0x402579E")]
		[NonSerialized]
		public const int EVENT_ON_CLOSE_INSIGHT = 3;

		// Token: 0x0402579F RID: 153503
		[Token(Token = "0x402579F")]
		[NonSerialized]
		public const int EVENT_ON_BACKGROUND_CLICKED = 4;

		// Token: 0x040257A0 RID: 153504
		[Token(Token = "0x40257A0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InformantSelectChoiceView _view;

		// Token: 0x040257A1 RID: 153505
		[Token(Token = "0x40257A1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040257A2 RID: 153506
		[Token(Token = "0x40257A2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnimSimple;

		// Token: 0x040257A3 RID: 153507
		[Token(Token = "0x40257A3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _selectChoiceAnim;

		// Token: 0x040257A4 RID: 153508
		[Token(Token = "0x40257A4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _insightOpenAnim;

		// Token: 0x040257A5 RID: 153509
		[Token(Token = "0x40257A5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _patienceNoticeAnim;

		// Token: 0x040257A6 RID: 153510
		[Token(Token = "0x40257A6")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _noPatienceSelectChoiceAnim;

		// Token: 0x040257A7 RID: 153511
		[Token(Token = "0x40257A7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _attrChangeAudioDelay;

		// Token: 0x040257A8 RID: 153512
		[Token(Token = "0x40257A8")]
		[FieldOffset(Offset = "0xE0")]
		private InformantSelectChoiceProperty m_property;

		// Token: 0x040257A9 RID: 153513
		[Token(Token = "0x40257A9")]
		[FieldOffset(Offset = "0xE8")]
		private string m_actId;

		// Token: 0x040257AA RID: 153514
		[Token(Token = "0x40257AA")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_selectChoiceTween;

		// Token: 0x040257AB RID: 153515
		[Token(Token = "0x40257AB")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_insightOpenTween;

		// Token: 0x040257AC RID: 153516
		[Token(Token = "0x40257AC")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_enterAnimTween;

		// Token: 0x040257AD RID: 153517
		[Token(Token = "0x40257AD")]
		[FieldOffset(Offset = "0x108")]
		private Tween m_patienceNoticeTween;

		// Token: 0x040257AE RID: 153518
		[Token(Token = "0x40257AE")]
		[FieldOffset(Offset = "0x110")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x040257AF RID: 153519
		[Token(Token = "0x40257AF")]
		[FieldOffset(Offset = "0x120")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040257B0 RID: 153520
		[Token(Token = "0x40257B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040257B1 RID: 153521
		[Token(Token = "0x40257B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040257B2 RID: 153522
		[Token(Token = "0x40257B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040257B3 RID: 153523
		[Token(Token = "0x40257B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnChoiceClicked;

		// Token: 0x040257B4 RID: 153524
		[Token(Token = "0x40257B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleSelectChoice;

		// Token: 0x040257B5 RID: 153525
		[Token(Token = "0x40257B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSelectChoiceSucc;

		// Token: 0x040257B6 RID: 153526
		[Token(Token = "0x40257B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayAttrChangeAudio;

		// Token: 0x040257B7 RID: 153527
		[Token(Token = "0x40257B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnSettle;

		// Token: 0x040257B8 RID: 153528
		[Token(Token = "0x40257B8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleSettle;

		// Token: 0x040257B9 RID: 153529
		[Token(Token = "0x40257B9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnRequestOrOpenInsight;

		// Token: 0x040257BA RID: 153530
		[Token(Token = "0x40257BA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnRequestInsight;

		// Token: 0x040257BB RID: 153531
		[Token(Token = "0x40257BB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnOpenInsight;

		// Token: 0x040257BC RID: 153532
		[Token(Token = "0x40257BC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnCloseInsight;

		// Token: 0x040257BD RID: 153533
		[Token(Token = "0x40257BD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnBackgroundClicked;

		// Token: 0x040257BE RID: 153534
		[Token(Token = "0x40257BE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x040257BF RID: 153535
		[Token(Token = "0x40257BF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TutorialOnly_EntryAnimRouted;

		// Token: 0x040257C0 RID: 153536
		[Token(Token = "0x40257C0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TutorialOnly_PatienceNoticeAnimRouted;

		// Token: 0x040257C1 RID: 153537
		[Token(Token = "0x40257C1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
