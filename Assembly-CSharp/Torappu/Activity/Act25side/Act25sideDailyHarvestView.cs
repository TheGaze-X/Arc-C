using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200750F RID: 29967
	[Token(Token = "0x200750F")]
	public class Act25sideDailyHarvestView : DataBinder<Act25sideDailyHarvestProperty>
	{
		// Token: 0x0602A3B5 RID: 172981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B5")]
		[Address(RVA = "0x25DC850", Offset = "0x25DB450", VA = "0x1825DC850", Slot = "7")]
		public override void OnValueChanged(Act25sideDailyHarvestProperty property)
		{
		}

		// Token: 0x0602A3B6 RID: 172982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B6")]
		[Address(RVA = "0x25DD040", Offset = "0x25DBC40", VA = "0x1825DD040")]
		private void _RenderView(Act25sideDailyHarvestViewModel viewModel)
		{
		}

		// Token: 0x0602A3B7 RID: 172983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B7")]
		[Address(RVA = "0x25DD360", Offset = "0x25DBF60", VA = "0x1825DD360")]
		private void _SetCountDown(long remainSecs)
		{
		}

		// Token: 0x0602A3B8 RID: 172984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B8")]
		[Address(RVA = "0x25DC980", Offset = "0x25DB580", VA = "0x1825DC980")]
		private void _DealWithTimeout()
		{
		}

		// Token: 0x0602A3B9 RID: 172985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B9")]
		[Address(RVA = "0x25DD510", Offset = "0x25DC110", VA = "0x1825DD510")]
		private void _TickHarvestCountDown(CountDownTask.TickValue tickValue)
		{
		}

		// Token: 0x0602A3BA RID: 172986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3BA")]
		[Address(RVA = "0x25DCF40", Offset = "0x25DBB40", VA = "0x1825DCF40")]
		private void _RefreshSliderBar(CountDownTask.TickValue tickValue)
		{
		}

		// Token: 0x0602A3BB RID: 172987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3BB")]
		[Address(RVA = "0x25DCB90", Offset = "0x25DB790", VA = "0x1825DCB90")]
		private void _RefreshPanel()
		{
		}

		// Token: 0x0602A3BC RID: 172988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3BC")]
		[Address(RVA = "0x25DCB10", Offset = "0x25DB710", VA = "0x1825DCB10")]
		private void _ProcessLastDay()
		{
		}

		// Token: 0x0602A3BD RID: 172989 RVA: 0x000D7B98 File Offset: 0x000D5D98
		[Token(Token = "0x602A3BD")]
		[Address(RVA = "0x25DCA20", Offset = "0x25DB620", VA = "0x1825DCA20")]
		private int _GetCurrentRatio()
		{
			return 0;
		}

		// Token: 0x0602A3BE RID: 172990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3BE")]
		[Address(RVA = "0x25DC7C0", Offset = "0x25DB3C0", VA = "0x1825DC7C0")]
		public void OnHarvestClick()
		{
		}

		// Token: 0x0602A3BF RID: 172991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3BF")]
		[Address(RVA = "0x25DC910", Offset = "0x25DB510", VA = "0x1825DC910")]
		private void Update()
		{
		}

		// Token: 0x0602A3C0 RID: 172992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3C0")]
		[Address(RVA = "0x25DD780", Offset = "0x25DC380", VA = "0x1825DD780")]
		public Act25sideDailyHarvestView()
		{
		}

		// Token: 0x0403CB05 RID: 248581
		[Token(Token = "0x403CB05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelProcessing;

		// Token: 0x0403CB06 RID: 248582
		[Token(Token = "0x403CB06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelDone;

		// Token: 0x0403CB07 RID: 248583
		[Token(Token = "0x403CB07")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTimer;

		// Token: 0x0403CB08 RID: 248584
		[Token(Token = "0x403CB08")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _rewardCount;

		// Token: 0x0403CB09 RID: 248585
		[Token(Token = "0x403CB09")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _rewardRatio;

		// Token: 0x0403CB0A RID: 248586
		[Token(Token = "0x403CB0A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _nextDayBonusRatio;

		// Token: 0x0403CB0B RID: 248587
		[Token(Token = "0x403CB0B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0403CB0C RID: 248588
		[Token(Token = "0x403CB0C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x0403CB0D RID: 248589
		[Token(Token = "0x403CB0D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pauseObj;

		// Token: 0x0403CB0E RID: 248590
		[Token(Token = "0x403CB0E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _processObj;

		// Token: 0x0403CB0F RID: 248591
		[Token(Token = "0x403CB0F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _nextRatio;

		// Token: 0x0403CB10 RID: 248592
		[Token(Token = "0x403CB10")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _rewardFinishCount;

		// Token: 0x0403CB11 RID: 248593
		[Token(Token = "0x403CB11")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action eventOnHarvest;

		// Token: 0x0403CB12 RID: 248594
		[Token(Token = "0x403CB12")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403CB13 RID: 248595
		[Token(Token = "0x403CB13")]
		[FieldOffset(Offset = "0x98")]
		private CountDownTask m_harvestTask;

		// Token: 0x0403CB14 RID: 248596
		[Token(Token = "0x403CB14")]
		[FieldOffset(Offset = "0xA0")]
		private Act25sideDailyHarvestViewModel m_cachedModel;

		// Token: 0x0403CB15 RID: 248597
		[Token(Token = "0x403CB15")]
		[FieldOffset(Offset = "0xA8")]
		private Act25SideData m_cachedCfg;

		// Token: 0x0403CB16 RID: 248598
		[Token(Token = "0x403CB16")]
		[FieldOffset(Offset = "0xB0")]
		private Act25SideData.DailyFarmData m_cachendHarvestData;

		// Token: 0x0403CB17 RID: 248599
		[Token(Token = "0x403CB17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CB18 RID: 248600
		[Token(Token = "0x403CB18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0403CB19 RID: 248601
		[Token(Token = "0x403CB19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetCountDown;

		// Token: 0x0403CB1A RID: 248602
		[Token(Token = "0x403CB1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DealWithTimeout;

		// Token: 0x0403CB1B RID: 248603
		[Token(Token = "0x403CB1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TickHarvestCountDown;

		// Token: 0x0403CB1C RID: 248604
		[Token(Token = "0x403CB1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshSliderBar;

		// Token: 0x0403CB1D RID: 248605
		[Token(Token = "0x403CB1D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshPanel;

		// Token: 0x0403CB1E RID: 248606
		[Token(Token = "0x403CB1E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ProcessLastDay;

		// Token: 0x0403CB1F RID: 248607
		[Token(Token = "0x403CB1F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetCurrentRatio;

		// Token: 0x0403CB20 RID: 248608
		[Token(Token = "0x403CB20")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnHarvestClick;

		// Token: 0x0403CB21 RID: 248609
		[Token(Token = "0x403CB21")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403CB22 RID: 248610
		[Token(Token = "0x403CB22")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
