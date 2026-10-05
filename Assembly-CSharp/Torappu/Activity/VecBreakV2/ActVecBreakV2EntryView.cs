using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E38 RID: 28216
	[Token(Token = "0x2006E38")]
	public class ActVecBreakV2EntryView : DataBinder<ActVecBreakV2EntryProp>
	{
		// Token: 0x06028291 RID: 164497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028291")]
		[Address(RVA = "0x2374C80", Offset = "0x2373880", VA = "0x182374C80", Slot = "7")]
		public override void OnValueChanged(ActVecBreakV2EntryProp property)
		{
		}

		// Token: 0x06028292 RID: 164498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028292")]
		[Address(RVA = "0x2374EC0", Offset = "0x2373AC0", VA = "0x182374EC0")]
		private void _InitIfNot(string actId)
		{
		}

		// Token: 0x06028293 RID: 164499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028293")]
		[Address(RVA = "0x2375290", Offset = "0x2373E90", VA = "0x182375290")]
		public ActVecBreakV2EntryView()
		{
		}

		// Token: 0x04039077 RID: 233591
		[Token(Token = "0x4039077")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActVecBreakV2EntryZoneView _offenseZoneView;

		// Token: 0x04039078 RID: 233592
		[Token(Token = "0x4039078")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActVecBreakV2EntryZoneView _defenseZoneView;

		// Token: 0x04039079 RID: 233593
		[Token(Token = "0x4039079")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActVecBreakV2EntryZoneView _hardZoneView;

		// Token: 0x0403907A RID: 233594
		[Token(Token = "0x403907A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgMedalIcon;

		// Token: 0x0403907B RID: 233595
		[Token(Token = "0x403907B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgMedalEntry;

		// Token: 0x0403907C RID: 233596
		[Token(Token = "0x403907C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgSeasonIcon;

		// Token: 0x0403907D RID: 233597
		[Token(Token = "0x403907D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgSeasonIcon2;

		// Token: 0x0403907E RID: 233598
		[Token(Token = "0x403907E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgSeasonCode;

		// Token: 0x0403907F RID: 233599
		[Token(Token = "0x403907F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgSeasonDeco;

		// Token: 0x04039080 RID: 233600
		[Token(Token = "0x4039080")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgSeasonDeco2;

		// Token: 0x04039081 RID: 233601
		[Token(Token = "0x4039081")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgSeasonScreen;

		// Token: 0x04039082 RID: 233602
		[Token(Token = "0x4039082")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Graphic[] _theme1GraphicList;

		// Token: 0x04039083 RID: 233603
		[Token(Token = "0x4039083")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Graphic[] _theme2GraphicList;

		// Token: 0x04039084 RID: 233604
		[Token(Token = "0x4039084")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _subTitleNameText;

		// Token: 0x04039085 RID: 233605
		[Token(Token = "0x4039085")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039086 RID: 233606
		[Token(Token = "0x4039086")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04039087 RID: 233607
		[Token(Token = "0x4039087")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039088 RID: 233608
		[Token(Token = "0x4039088")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039089 RID: 233609
		[Token(Token = "0x4039089")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
