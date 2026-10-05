using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200718E RID: 29070
	[Token(Token = "0x200718E")]
	public class Act9D0CustomTopMenu : Act9D0CustomTopMenuBase, IHotfixable
	{
		// Token: 0x06029424 RID: 168996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029424")]
		[Address(RVA = "0x24926D0", Offset = "0x24912D0", VA = "0x1824926D0", Slot = "4")]
		protected override void InitTopMenu()
		{
		}

		// Token: 0x06029425 RID: 168997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029425")]
		[Address(RVA = "0x24927D0", Offset = "0x24913D0", VA = "0x1824927D0")]
		public void OnClickBack()
		{
		}

		// Token: 0x06029426 RID: 168998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029426")]
		[Address(RVA = "0x24928E0", Offset = "0x24914E0", VA = "0x1824928E0")]
		public void OnClickHome()
		{
		}

		// Token: 0x06029427 RID: 168999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029427")]
		[Address(RVA = "0x2492960", Offset = "0x2491560", VA = "0x182492960")]
		public Act9D0CustomTopMenu()
		{
		}

		// Token: 0x0403AED5 RID: 241365
		[Token(Token = "0x403AED5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _btnBack;

		// Token: 0x0403AED6 RID: 241366
		[Token(Token = "0x403AED6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitTopMenu;

		// Token: 0x0403AED7 RID: 241367
		[Token(Token = "0x403AED7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickBack;

		// Token: 0x0403AED8 RID: 241368
		[Token(Token = "0x403AED8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickHome;

		// Token: 0x0403AED9 RID: 241369
		[Token(Token = "0x403AED9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
