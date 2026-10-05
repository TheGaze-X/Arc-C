using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E80 RID: 16000
	[Token(Token = "0x2003E80")]
	public class SpecialOperatorElitePointView : SpecialOperatorPointViewBase
	{
		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x06018DCF RID: 101839 RVA: 0x0009C3A8 File Offset: 0x0009A5A8
		[Token(Token = "0x17003B57")]
		public override SpecialOperatorPointViewType viewType
		{
			[Token(Token = "0x6018DCF")]
			[Address(RVA = "0x1194E50", Offset = "0x1193A50", VA = "0x181194E50", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018DD0 RID: 101840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD0")]
		[Address(RVA = "0x1194C60", Offset = "0x1193860", VA = "0x181194C60", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06018DD1 RID: 101841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD1")]
		[Address(RVA = "0x1194DB0", Offset = "0x11939B0", VA = "0x181194DB0")]
		public SpecialOperatorElitePointView()
		{
		}

		// Token: 0x06018DD2 RID: 101842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD2")]
		[Address(RVA = "0x118ED40", Offset = "0x118D940", VA = "0x18118ED40")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0401E9E4 RID: 125412
		[Token(Token = "0x401E9E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgElite;

		// Token: 0x0401E9E5 RID: 125413
		[Token(Token = "0x401E9E5")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E9E6 RID: 125414
		[Token(Token = "0x401E9E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0401E9E7 RID: 125415
		[Token(Token = "0x401E9E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401E9E8 RID: 125416
		[Token(Token = "0x401E9E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
