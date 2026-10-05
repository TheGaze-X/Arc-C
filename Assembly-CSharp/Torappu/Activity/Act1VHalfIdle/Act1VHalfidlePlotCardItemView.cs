using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007754 RID: 30548
	[Token(Token = "0x2007754")]
	public class Act1VHalfidlePlotCardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AE87 RID: 175751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE87")]
		[Address(RVA = "0x26B8A40", Offset = "0x26B7640", VA = "0x1826B8A40")]
		public void Render(Act1VHalfidlePlotViewModel viewModel, bool showTrackpoint)
		{
		}

		// Token: 0x0602AE88 RID: 175752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE88")]
		[Address(RVA = "0x26B87F0", Offset = "0x26B73F0", VA = "0x1826B87F0")]
		public void EventOnPlotClick()
		{
		}

		// Token: 0x0602AE89 RID: 175753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE89")]
		[Address(RVA = "0x26B88C0", Offset = "0x26B74C0", VA = "0x1826B88C0")]
		public void RegisterBtnAddTutorialGO()
		{
		}

		// Token: 0x0602AE8A RID: 175754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE8A")]
		[Address(RVA = "0x26B8980", Offset = "0x26B7580", VA = "0x1826B8980")]
		public void RegisterBtnPlotTutorialGO()
		{
		}

		// Token: 0x0602AE8B RID: 175755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE8B")]
		[Address(RVA = "0x26B8E70", Offset = "0x26B7A70", VA = "0x1826B8E70")]
		public Act1VHalfidlePlotCardItemView()
		{
		}

		// Token: 0x0403DDFC RID: 253436
		[Token(Token = "0x403DDFC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x0403DDFD RID: 253437
		[Token(Token = "0x403DDFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x0403DDFE RID: 253438
		[Token(Token = "0x403DDFE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x0403DDFF RID: 253439
		[Token(Token = "0x403DDFF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0403DE00 RID: 253440
		[Token(Token = "0x403DE00")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _typeName;

		// Token: 0x0403DE01 RID: 253441
		[Token(Token = "0x403DE01")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0403DE02 RID: 253442
		[Token(Token = "0x403DE02")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _rarityIcon;

		// Token: 0x0403DE03 RID: 253443
		[Token(Token = "0x403DE03")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _emptyMaterial;

		// Token: 0x0403DE04 RID: 253444
		[Token(Token = "0x403DE04")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlMaterial;

		// Token: 0x0403DE05 RID: 253445
		[Token(Token = "0x403DE05")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _materialIcon;

		// Token: 0x0403DE06 RID: 253446
		[Token(Token = "0x403DE06")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _plotName;

		// Token: 0x0403DE07 RID: 253447
		[Token(Token = "0x403DE07")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x0403DE08 RID: 253448
		[Token(Token = "0x403DE08")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _selectedOrder;

		// Token: 0x0403DE09 RID: 253449
		[Token(Token = "0x403DE09")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _btnPlotItem;

		// Token: 0x0403DE0A RID: 253450
		[Token(Token = "0x403DE0A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _glowObj;

		// Token: 0x0403DE0B RID: 253451
		[Token(Token = "0x403DE0B")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<string> onPlotClick;

		// Token: 0x0403DE0C RID: 253452
		[Token(Token = "0x403DE0C")]
		[FieldOffset(Offset = "0x98")]
		private Act1VHalfidlePlotViewModel m_viewModel;

		// Token: 0x0403DE0D RID: 253453
		[Token(Token = "0x403DE0D")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedPlotId;

		// Token: 0x0403DE0E RID: 253454
		[Token(Token = "0x403DE0E")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DE0F RID: 253455
		[Token(Token = "0x403DE0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DE10 RID: 253456
		[Token(Token = "0x403DE10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnPlotClick;

		// Token: 0x0403DE11 RID: 253457
		[Token(Token = "0x403DE11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterBtnAddTutorialGO;

		// Token: 0x0403DE12 RID: 253458
		[Token(Token = "0x403DE12")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterBtnPlotTutorialGO;

		// Token: 0x0403DE13 RID: 253459
		[Token(Token = "0x403DE13")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
