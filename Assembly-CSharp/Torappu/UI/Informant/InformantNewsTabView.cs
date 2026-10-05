using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A1F RID: 18975
	[Token(Token = "0x2004A1F")]
	public class InformantNewsTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C8B4 RID: 116916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B4")]
		[Address(RVA = "0x16001A0", Offset = "0x15FEDA0", VA = "0x1816001A0")]
		public void Render(InformantNewsTabViewModel model)
		{
		}

		// Token: 0x0601C8B5 RID: 116917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B5")]
		[Address(RVA = "0x1600350", Offset = "0x15FEF50", VA = "0x181600350")]
		public InformantNewsTabView()
		{
		}

		// Token: 0x040256F2 RID: 153330
		[Token(Token = "0x40256F2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x040256F3 RID: 153331
		[Token(Token = "0x40256F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc1;

		// Token: 0x040256F4 RID: 153332
		[Token(Token = "0x40256F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc2;

		// Token: 0x040256F5 RID: 153333
		[Token(Token = "0x40256F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDays;

		// Token: 0x040256F6 RID: 153334
		[Token(Token = "0x40256F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgNewsIcon;

		// Token: 0x040256F7 RID: 153335
		[Token(Token = "0x40256F7")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040256F8 RID: 153336
		[Token(Token = "0x40256F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040256F9 RID: 153337
		[Token(Token = "0x40256F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
