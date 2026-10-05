using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.Firework;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x02007433 RID: 29747
	[Token(Token = "0x2007433")]
	public class Act38sideMapDecorFireworkCraftPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06029FB9 RID: 171961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB9")]
		[Address(RVA = "0x2583130", Offset = "0x2581D30", VA = "0x182583130", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029FBA RID: 171962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FBA")]
		[Address(RVA = "0x2582FE0", Offset = "0x2581BE0", VA = "0x182582FE0")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x06029FBB RID: 171963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FBB")]
		[Address(RVA = "0x25833B0", Offset = "0x2581FB0", VA = "0x1825833B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029FBC RID: 171964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FBC")]
		[Address(RVA = "0x2583660", Offset = "0x2582260", VA = "0x182583660")]
		public Act38sideMapDecorFireworkCraftPlugin()
		{
		}

		// Token: 0x0403C320 RID: 246560
		[Token(Token = "0x403C320")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelf;

		// Token: 0x0403C321 RID: 246561
		[Token(Token = "0x403C321")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgAnimIcon;

		// Token: 0x0403C322 RID: 246562
		[Token(Token = "0x403C322")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgAnimBkg;

		// Token: 0x0403C323 RID: 246563
		[Token(Token = "0x403C323")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403C324 RID: 246564
		[Token(Token = "0x403C324")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _plateContainer;

		// Token: 0x0403C325 RID: 246565
		[Token(Token = "0x403C325")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _buttonTarget;

		// Token: 0x0403C326 RID: 246566
		[Token(Token = "0x403C326")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C327 RID: 246567
		[Token(Token = "0x403C327")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedActId;

		// Token: 0x0403C328 RID: 246568
		[Token(Token = "0x403C328")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedAnimalId;

		// Token: 0x0403C329 RID: 246569
		[Token(Token = "0x403C329")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0403C32A RID: 246570
		[Token(Token = "0x403C32A")]
		[FieldOffset(Offset = "0x80")]
		private FireworkPlateView m_plateView;

		// Token: 0x0403C32B RID: 246571
		[Token(Token = "0x403C32B")]
		[FieldOffset(Offset = "0x88")]
		private FireworkPlateViewStyle m_style;

		// Token: 0x0403C32C RID: 246572
		[Token(Token = "0x403C32C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C32D RID: 246573
		[Token(Token = "0x403C32D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x0403C32E RID: 246574
		[Token(Token = "0x403C32E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C32F RID: 246575
		[Token(Token = "0x403C32F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
