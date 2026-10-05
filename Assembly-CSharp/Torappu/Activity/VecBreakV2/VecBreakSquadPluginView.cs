using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E83 RID: 28291
	[Token(Token = "0x2006E83")]
	public class VecBreakSquadPluginView : SquadHomePluginView
	{
		// Token: 0x06028438 RID: 164920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028438")]
		[Address(RVA = "0x23A30B0", Offset = "0x23A1CB0", VA = "0x1823A30B0", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x06028439 RID: 164921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028439")]
		[Address(RVA = "0x23A3490", Offset = "0x23A2090", VA = "0x1823A3490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602843A RID: 164922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602843A")]
		[Address(RVA = "0x23A32F0", Offset = "0x23A1EF0", VA = "0x1823A32F0")]
		private void _EventOnOpenDetail()
		{
		}

		// Token: 0x0602843B RID: 164923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602843B")]
		[Address(RVA = "0x23A3740", Offset = "0x23A2340", VA = "0x1823A3740")]
		public VecBreakSquadPluginView()
		{
		}

		// Token: 0x0403939B RID: 234395
		[Token(Token = "0x403939B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _buffViewContainer;

		// Token: 0x0403939C RID: 234396
		[Token(Token = "0x403939C")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403939D RID: 234397
		[Token(Token = "0x403939D")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403939E RID: 234398
		[Token(Token = "0x403939E")]
		[FieldOffset(Offset = "0x50")]
		private VecBreakV2SquadBuffView m_buffView;

		// Token: 0x0403939F RID: 234399
		[Token(Token = "0x403939F")]
		[FieldOffset(Offset = "0x58")]
		private VecBreakV2SquadBuffViewModel m_viewModel;

		// Token: 0x040393A0 RID: 234400
		[Token(Token = "0x40393A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040393A1 RID: 234401
		[Token(Token = "0x40393A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040393A2 RID: 234402
		[Token(Token = "0x40393A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnOpenDetail;

		// Token: 0x040393A3 RID: 234403
		[Token(Token = "0x40393A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
