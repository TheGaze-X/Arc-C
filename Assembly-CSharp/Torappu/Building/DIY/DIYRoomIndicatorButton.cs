using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x020018E5 RID: 6373
	[Token(Token = "0x20018E5")]
	public class DIYRoomIndicatorButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A0B8 RID: 41144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0B8")]
		[Address(RVA = "0x31A6D40", Offset = "0x31A5940", VA = "0x1831A6D40")]
		public DIYRoomIndicatorButton()
		{
		}

		// Token: 0x040096E6 RID: 38630
		[Token(Token = "0x40096E6")]
		[FieldOffset(Offset = "0x18")]
		public DIYRoomIndicatorButton.ButtonType buttonType;

		// Token: 0x040096E7 RID: 38631
		[Token(Token = "0x40096E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020018E6 RID: 6374
		[Token(Token = "0x20018E6")]
		public enum ButtonType
		{
			// Token: 0x040096E9 RID: 38633
			[Token(Token = "0x40096E9")]
			NONE,
			// Token: 0x040096EA RID: 38634
			[Token(Token = "0x40096EA")]
			RESET,
			// Token: 0x040096EB RID: 38635
			[Token(Token = "0x40096EB")]
			UNEQUIP,
			// Token: 0x040096EC RID: 38636
			[Token(Token = "0x40096EC")]
			COMFIRM,
			// Token: 0x040096ED RID: 38637
			[Token(Token = "0x40096ED")]
			ROTATE,
			// Token: 0x040096EE RID: 38638
			[Token(Token = "0x40096EE")]
			DRAG
		}
	}
}
