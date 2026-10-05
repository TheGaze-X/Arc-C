using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EAA RID: 24234
	[Token(Token = "0x2005EAA")]
	public class ItemRepoSelectCharBackAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x17005326 RID: 21286
		// (get) Token: 0x0602319F RID: 143775 RVA: 0x000BFF10 File Offset: 0x000BE110
		[Token(Token = "0x17005326")]
		public override int count
		{
			[Token(Token = "0x602319F")]
			[Address(RVA = "0x1D9E6D0", Offset = "0x1D9D2D0", VA = "0x181D9E6D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060231A0 RID: 143776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231A0")]
		[Address(RVA = "0x1D9E2D0", Offset = "0x1D9CED0", VA = "0x181D9E2D0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060231A1 RID: 143777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231A1")]
		[Address(RVA = "0x1D9E670", Offset = "0x1D9D270", VA = "0x181D9E670")]
		public ItemRepoSelectCharBackAdapter()
		{
		}

		// Token: 0x040305F5 RID: 198133
		[Token(Token = "0x40305F5")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemBundle> itemList;

		// Token: 0x040305F6 RID: 198134
		[Token(Token = "0x40305F6")]
		[FieldOffset(Offset = "0x28")]
		public UIStringEvent itemEvent;

		// Token: 0x040305F7 RID: 198135
		[Token(Token = "0x40305F7")]
		[FieldOffset(Offset = "0x30")]
		public bool clickable;

		// Token: 0x040305F8 RID: 198136
		[Token(Token = "0x40305F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x040305F9 RID: 198137
		[Token(Token = "0x40305F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040305FA RID: 198138
		[Token(Token = "0x40305FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
