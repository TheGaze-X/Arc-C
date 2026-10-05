using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200603E RID: 24638
	[Token(Token = "0x200603E")]
	public class CarvingMainCardDeskView : DataBinder<CarvingMainProperty>
	{
		// Token: 0x1700541D RID: 21533
		// (get) Token: 0x06023A18 RID: 145944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700541D")]
		public List<CarvingSlotView> cardSlotList
		{
			[Token(Token = "0x6023A18")]
			[Address(RVA = "0x1E4B930", Offset = "0x1E4A530", VA = "0x181E4B930")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023A19 RID: 145945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A19")]
		[Address(RVA = "0x1E4B440", Offset = "0x1E4A040", VA = "0x181E4B440")]
		private void _CreateSlotViewIfNot()
		{
		}

		// Token: 0x06023A1A RID: 145946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A1A")]
		[Address(RVA = "0x1E4B160", Offset = "0x1E49D60", VA = "0x181E4B160", Slot = "7")]
		public override void OnValueChanged(CarvingMainProperty property)
		{
		}

		// Token: 0x06023A1B RID: 145947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A1B")]
		[Address(RVA = "0x1E4B380", Offset = "0x1E49F80", VA = "0x181E4B380")]
		public void StateOnlyRegisterTutorialGO()
		{
		}

		// Token: 0x06023A1C RID: 145948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A1C")]
		[Address(RVA = "0x1E4B8C0", Offset = "0x1E4A4C0", VA = "0x181E4B8C0")]
		public CarvingMainCardDeskView()
		{
		}

		// Token: 0x04031568 RID: 202088
		[Token(Token = "0x4031568")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Slot")]
		private CarvingSlotView _slotViewPrefab;

		// Token: 0x04031569 RID: 202089
		[Token(Token = "0x4031569")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Slot")]
		private UIAnimationLocation _slotSampleCurve;

		// Token: 0x0403156A RID: 202090
		[Token(Token = "0x403156A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Slot")]
		private float[] _slotSamplePosList;

		// Token: 0x0403156B RID: 202091
		[Token(Token = "0x403156B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Slot")]
		private RectTransform _slotContainer;

		// Token: 0x0403156C RID: 202092
		[Token(Token = "0x403156C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CarvingSlotCardListView _slotCardListView;

		// Token: 0x0403156D RID: 202093
		[Token(Token = "0x403156D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelSlot;

		// Token: 0x0403156E RID: 202094
		[Token(Token = "0x403156E")]
		[FieldOffset(Offset = "0x58")]
		private List<CarvingSlotView> m_slotViews;

		// Token: 0x0403156F RID: 202095
		[Token(Token = "0x403156F")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031570 RID: 202096
		[Token(Token = "0x4031570")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardSlotList;

		// Token: 0x04031571 RID: 202097
		[Token(Token = "0x4031571")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateSlotViewIfNot;

		// Token: 0x04031572 RID: 202098
		[Token(Token = "0x4031572")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031573 RID: 202099
		[Token(Token = "0x4031573")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StateOnlyRegisterTutorialGO;

		// Token: 0x04031574 RID: 202100
		[Token(Token = "0x4031574")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200603F RID: 24639
		[Token(Token = "0x200603F")]
		public class CarvingSlot
		{
			// Token: 0x06023A1D RID: 145949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A1D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CarvingSlot()
			{
			}

			// Token: 0x04031575 RID: 202101
			[Token(Token = "0x4031575")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform boundRect;

			// Token: 0x04031576 RID: 202102
			[Token(Token = "0x4031576")]
			[FieldOffset(Offset = "0x18")]
			public int slotIdx;
		}
	}
}
