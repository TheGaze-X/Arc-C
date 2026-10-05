using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007510 RID: 29968
	[Token(Token = "0x2007510")]
	public class Act25sideHarvestButtonView : DataBinder<Act25sideDailyHarvestProperty>
	{
		// Token: 0x0602A3C1 RID: 172993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C1")]
		[Address(RVA = "0x25DE890", Offset = "0x25DD490", VA = "0x1825DE890")]
		private void _SetCountDown()
		{
		}

		// Token: 0x0602A3C2 RID: 172994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C2")]
		[Address(RVA = "0x25DE3C0", Offset = "0x25DCFC0", VA = "0x1825DE3C0")]
		private void _DealWithTimeout()
		{
		}

		// Token: 0x0602A3C3 RID: 172995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C3")]
		[Address(RVA = "0x25DE7D0", Offset = "0x25DD3D0", VA = "0x1825DE7D0")]
		private void _ResetAnim()
		{
		}

		// Token: 0x0602A3C4 RID: 172996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C4")]
		[Address(RVA = "0x25DEA00", Offset = "0x25DD600", VA = "0x1825DEA00")]
		private void _TryStartAnim(bool isAvailable)
		{
		}

		// Token: 0x0602A3C5 RID: 172997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C5")]
		[Address(RVA = "0x25DE0A0", Offset = "0x25DCCA0", VA = "0x1825DE0A0", Slot = "7")]
		public override void OnValueChanged(Act25sideDailyHarvestProperty property)
		{
		}

		// Token: 0x0602A3C6 RID: 172998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C6")]
		[Address(RVA = "0x25DE660", Offset = "0x25DD260", VA = "0x1825DE660")]
		private void _RefreshPanel(Act25sideDailyHarvestViewModel viewModel)
		{
		}

		// Token: 0x0602A3C7 RID: 172999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C7")]
		[Address(RVA = "0x25DE420", Offset = "0x25DD020", VA = "0x1825DE420")]
		private void _ProcessLastDay(Act25sideDailyHarvestViewModel viewModel)
		{
		}

		// Token: 0x0602A3C8 RID: 173000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C8")]
		[Address(RVA = "0x25DE020", Offset = "0x25DCC20", VA = "0x1825DE020")]
		public void OnHarvestClick()
		{
		}

		// Token: 0x0602A3C9 RID: 173001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C9")]
		[Address(RVA = "0x25DE350", Offset = "0x25DCF50", VA = "0x1825DE350")]
		private void Update()
		{
		}

		// Token: 0x0602A3CA RID: 173002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3CA")]
		[Address(RVA = "0x25DEBC0", Offset = "0x25DD7C0", VA = "0x1825DEBC0")]
		public Act25sideHarvestButtonView()
		{
		}

		// Token: 0x0403CB23 RID: 248611
		[Token(Token = "0x403CB23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelProcessing;

		// Token: 0x0403CB24 RID: 248612
		[Token(Token = "0x403CB24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelDone;

		// Token: 0x0403CB25 RID: 248613
		[Token(Token = "0x403CB25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objMax;

		// Token: 0x0403CB26 RID: 248614
		[Token(Token = "0x403CB26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _processAnim;

		// Token: 0x0403CB27 RID: 248615
		[Token(Token = "0x403CB27")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _harvestAnim;

		// Token: 0x0403CB28 RID: 248616
		[Token(Token = "0x403CB28")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _processText;

		// Token: 0x0403CB29 RID: 248617
		[Token(Token = "0x403CB29")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _btn;

		// Token: 0x0403CB2A RID: 248618
		[Token(Token = "0x403CB2A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _processDots;

		// Token: 0x0403CB2B RID: 248619
		[Token(Token = "0x403CB2B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _endDots;

		// Token: 0x0403CB2C RID: 248620
		[Token(Token = "0x403CB2C")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action eventOnHarvest;

		// Token: 0x0403CB2D RID: 248621
		[Token(Token = "0x403CB2D")]
		[FieldOffset(Offset = "0x80")]
		private CountDownTask m_harvestTask;

		// Token: 0x0403CB2E RID: 248622
		[Token(Token = "0x403CB2E")]
		[FieldOffset(Offset = "0x88")]
		private Act25sideDailyHarvestViewModel m_cachedModel;

		// Token: 0x0403CB2F RID: 248623
		[Token(Token = "0x403CB2F")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_processTween;

		// Token: 0x0403CB30 RID: 248624
		[Token(Token = "0x403CB30")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_harvestTween;

		// Token: 0x0403CB31 RID: 248625
		[Token(Token = "0x403CB31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetCountDown;

		// Token: 0x0403CB32 RID: 248626
		[Token(Token = "0x403CB32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DealWithTimeout;

		// Token: 0x0403CB33 RID: 248627
		[Token(Token = "0x403CB33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetAnim;

		// Token: 0x0403CB34 RID: 248628
		[Token(Token = "0x403CB34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryStartAnim;

		// Token: 0x0403CB35 RID: 248629
		[Token(Token = "0x403CB35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CB36 RID: 248630
		[Token(Token = "0x403CB36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshPanel;

		// Token: 0x0403CB37 RID: 248631
		[Token(Token = "0x403CB37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ProcessLastDay;

		// Token: 0x0403CB38 RID: 248632
		[Token(Token = "0x403CB38")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnHarvestClick;

		// Token: 0x0403CB39 RID: 248633
		[Token(Token = "0x403CB39")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403CB3A RID: 248634
		[Token(Token = "0x403CB3A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
