using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A25 RID: 18981
	[Token(Token = "0x2004A25")]
	public class InformantResultCustomerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C8D7 RID: 116951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8D7")]
		[Address(RVA = "0x16019D0", Offset = "0x16005D0", VA = "0x1816019D0")]
		public void Render(InformantResultCustomerItemViewModel itemViewModel)
		{
		}

		// Token: 0x0601C8D8 RID: 116952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8D8")]
		[Address(RVA = "0x1601BC0", Offset = "0x16007C0", VA = "0x181601BC0")]
		public InformantResultCustomerItemView()
		{
		}

		// Token: 0x0402571D RID: 153373
		[Token(Token = "0x402571D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCustomerIcon;

		// Token: 0x0402571E RID: 153374
		[Token(Token = "0x402571E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objGood;

		// Token: 0x0402571F RID: 153375
		[Token(Token = "0x402571F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objOk;

		// Token: 0x04025720 RID: 153376
		[Token(Token = "0x4025720")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objTitleNormal;

		// Token: 0x04025721 RID: 153377
		[Token(Token = "0x4025721")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objTitleSpecial;

		// Token: 0x04025722 RID: 153378
		[Token(Token = "0x4025722")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtTitleNormal;

		// Token: 0x04025723 RID: 153379
		[Token(Token = "0x4025723")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtTitleSpecial;

		// Token: 0x04025724 RID: 153380
		[Token(Token = "0x4025724")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtCustomerName;

		// Token: 0x04025725 RID: 153381
		[Token(Token = "0x4025725")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtGetCount;

		// Token: 0x04025726 RID: 153382
		[Token(Token = "0x4025726")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04025727 RID: 153383
		[Token(Token = "0x4025727")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025728 RID: 153384
		[Token(Token = "0x4025728")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
