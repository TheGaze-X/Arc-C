using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049FD RID: 18941
	[Token(Token = "0x20049FD")]
	public class InformantCustomerInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C82B RID: 116779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C82B")]
		[Address(RVA = "0x15F5DF0", Offset = "0x15F49F0", VA = "0x1815F5DF0")]
		public void Render(InformantCustomerInfoViewModel model)
		{
		}

		// Token: 0x0601C82C RID: 116780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C82C")]
		[Address(RVA = "0x15F6060", Offset = "0x15F4C60", VA = "0x1815F6060")]
		public InformantCustomerInfoView()
		{
		}

		// Token: 0x040255BD RID: 153021
		[Token(Token = "0x40255BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _customerIcon;

		// Token: 0x040255BE RID: 153022
		[Token(Token = "0x40255BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTagName;

		// Token: 0x040255BF RID: 153023
		[Token(Token = "0x40255BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTagDesc;

		// Token: 0x040255C0 RID: 153024
		[Token(Token = "0x40255C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCustomerName;

		// Token: 0x040255C1 RID: 153025
		[Token(Token = "0x40255C1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCustomerDesc;

		// Token: 0x040255C2 RID: 153026
		[Token(Token = "0x40255C2")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040255C3 RID: 153027
		[Token(Token = "0x40255C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040255C4 RID: 153028
		[Token(Token = "0x40255C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
