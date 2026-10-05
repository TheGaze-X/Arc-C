using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005993 RID: 22931
	[Token(Token = "0x2005993")]
	public class CrisisV2EntryMainView : DataBinder<CrisisV2EntryProperty>
	{
		// Token: 0x060216D5 RID: 136917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D5")]
		[Address(RVA = "0x1BC06B0", Offset = "0x1BBF2B0", VA = "0x181BC06B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060216D6 RID: 136918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D6")]
		[Address(RVA = "0x1BBFE00", Offset = "0x1BBEA00", VA = "0x181BBFE00", Slot = "7")]
		public override void OnValueChanged(CrisisV2EntryProperty property)
		{
		}

		// Token: 0x060216D7 RID: 136919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D7")]
		[Address(RVA = "0x1BC0830", Offset = "0x1BBF430", VA = "0x181BC0830")]
		private void _SetGraphicListColor(Graphic[] graphicList, Color color)
		{
		}

		// Token: 0x060216D8 RID: 136920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D8")]
		[Address(RVA = "0x1BBFD60", Offset = "0x1BBE960", VA = "0x181BBFD60")]
		public void OnClickMain()
		{
		}

		// Token: 0x060216D9 RID: 136921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D9")]
		[Address(RVA = "0x1BC0990", Offset = "0x1BBF590", VA = "0x181BC0990")]
		public CrisisV2EntryMainView()
		{
		}

		// Token: 0x0402D9A8 RID: 186792
		[Token(Token = "0x402D9A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("MainBtn")]
		private UIAtlasImage _mainBtnBack;

		// Token: 0x0402D9A9 RID: 186793
		[Token(Token = "0x402D9A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("MainBtn")]
		private Text _mainBtnZoneText;

		// Token: 0x0402D9AA RID: 186794
		[Token(Token = "0x402D9AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("MainBtn")]
		private Text _mainBtnTitleText;

		// Token: 0x0402D9AB RID: 186795
		[Token(Token = "0x402D9AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("MainBtn")]
		private Text _mainBtnScore;

		// Token: 0x0402D9AC RID: 186796
		[Token(Token = "0x402D9AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("MainBtn")]
		private GameObject _noScorePart;

		// Token: 0x0402D9AD RID: 186797
		[Token(Token = "0x402D9AD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("MainBtn")]
		private GameObject _haveScorePart;

		// Token: 0x0402D9AE RID: 186798
		[Token(Token = "0x402D9AE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("MainBtn")]
		private GameObject _haveRewardPart;

		// Token: 0x0402D9AF RID: 186799
		[Token(Token = "0x402D9AF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("MainBtn")]
		private CrisisV2DiagramView _diagramPrefab;

		// Token: 0x0402D9B0 RID: 186800
		[Token(Token = "0x402D9B0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("MainBtn")]
		private RectTransform _diagramContainer;

		// Token: 0x0402D9B1 RID: 186801
		[Token(Token = "0x402D9B1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Back")]
		private UIAtlasImage _backLeft;

		// Token: 0x0402D9B2 RID: 186802
		[Token(Token = "0x402D9B2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Back")]
		private UIAtlasImage _backRight;

		// Token: 0x0402D9B3 RID: 186803
		[Token(Token = "0x402D9B3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Title")]
		private UIAtlasImage _titleImg;

		// Token: 0x0402D9B4 RID: 186804
		[Token(Token = "0x402D9B4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Title")]
		private Text _remainTime;

		// Token: 0x0402D9B5 RID: 186805
		[Token(Token = "0x402D9B5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Title")]
		private Text _endingTime;

		// Token: 0x0402D9B6 RID: 186806
		[Token(Token = "0x402D9B6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _tempContent;

		// Token: 0x0402D9B7 RID: 186807
		[Token(Token = "0x402D9B7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _medalIcon;

		// Token: 0x0402D9B8 RID: 186808
		[Token(Token = "0x402D9B8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _shopCoin;

		// Token: 0x0402D9B9 RID: 186809
		[Token(Token = "0x402D9B9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _shopCoinName;

		// Token: 0x0402D9BA RID: 186810
		[Token(Token = "0x402D9BA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Graphic[] _themeColor1GraphiList;

		// Token: 0x0402D9BB RID: 186811
		[Token(Token = "0x402D9BB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Graphic[] _themeColor2GraphiList;

		// Token: 0x0402D9BC RID: 186812
		[Token(Token = "0x402D9BC")]
		[FieldOffset(Offset = "0xC0")]
		private CrisisV2EntryTempButtonAdapter m_adapter;

		// Token: 0x0402D9BD RID: 186813
		[Token(Token = "0x402D9BD")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402D9BE RID: 186814
		[Token(Token = "0x402D9BE")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402D9BF RID: 186815
		[Token(Token = "0x402D9BF")]
		[FieldOffset(Offset = "0xE8")]
		private CrisisV2DiagramView m_diagram;

		// Token: 0x0402D9C0 RID: 186816
		[Token(Token = "0x402D9C0")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isInited;

		// Token: 0x0402D9C1 RID: 186817
		[Token(Token = "0x402D9C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D9C2 RID: 186818
		[Token(Token = "0x402D9C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402D9C3 RID: 186819
		[Token(Token = "0x402D9C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetGraphicListColor;

		// Token: 0x0402D9C4 RID: 186820
		[Token(Token = "0x402D9C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickMain;

		// Token: 0x0402D9C5 RID: 186821
		[Token(Token = "0x402D9C5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
