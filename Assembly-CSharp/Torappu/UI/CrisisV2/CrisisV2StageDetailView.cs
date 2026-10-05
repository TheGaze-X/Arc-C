using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005992 RID: 22930
	[Token(Token = "0x2005992")]
	public class CrisisV2StageDetailView : DataBinder<CrisisV2StageDetailProperty>
	{
		// Token: 0x060216D3 RID: 136915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D3")]
		[Address(RVA = "0x1BCFA10", Offset = "0x1BCE610", VA = "0x181BCFA10", Slot = "7")]
		public override void OnValueChanged(CrisisV2StageDetailProperty property)
		{
		}

		// Token: 0x060216D4 RID: 136916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D4")]
		[Address(RVA = "0x1BCFC90", Offset = "0x1BCE890", VA = "0x181BCFC90")]
		public CrisisV2StageDetailView()
		{
		}

		// Token: 0x0402D99F RID: 186783
		[Token(Token = "0x402D99F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _stageLogo;

		// Token: 0x0402D9A0 RID: 186784
		[Token(Token = "0x402D9A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x0402D9A1 RID: 186785
		[Token(Token = "0x402D9A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0402D9A2 RID: 186786
		[Token(Token = "0x402D9A2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stageDesc;

		// Token: 0x0402D9A3 RID: 186787
		[Token(Token = "0x402D9A3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIDynImage _stagePreviewImage;

		// Token: 0x0402D9A4 RID: 186788
		[Token(Token = "0x402D9A4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _seasonDecor;

		// Token: 0x0402D9A5 RID: 186789
		[Token(Token = "0x402D9A5")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402D9A6 RID: 186790
		[Token(Token = "0x402D9A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402D9A7 RID: 186791
		[Token(Token = "0x402D9A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
