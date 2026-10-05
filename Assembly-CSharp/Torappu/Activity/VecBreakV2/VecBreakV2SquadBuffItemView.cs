using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E8C RID: 28300
	[Token(Token = "0x2006E8C")]
	public class VecBreakV2SquadBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028485 RID: 164997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028485")]
		[Address(RVA = "0x23A6E30", Offset = "0x23A5A30", VA = "0x1823A6E30")]
		public void Render(VecBreakV2SquadBuffItemModel itemModel)
		{
		}

		// Token: 0x06028486 RID: 164998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028486")]
		[Address(RVA = "0x23A6FB0", Offset = "0x23A5BB0", VA = "0x1823A6FB0")]
		public VecBreakV2SquadBuffItemView()
		{
		}

		// Token: 0x040393F5 RID: 234485
		[Token(Token = "0x40393F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPartGO;

		// Token: 0x040393F6 RID: 234486
		[Token(Token = "0x40393F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x040393F7 RID: 234487
		[Token(Token = "0x40393F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x040393F8 RID: 234488
		[Token(Token = "0x40393F8")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040393F9 RID: 234489
		[Token(Token = "0x40393F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040393FA RID: 234490
		[Token(Token = "0x40393FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
