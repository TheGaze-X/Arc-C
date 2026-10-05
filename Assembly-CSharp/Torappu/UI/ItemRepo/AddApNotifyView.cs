using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E3F RID: 24127
	[Token(Token = "0x2005E3F")]
	public class AddApNotifyView : UINotifyView<AddApNotifyView.Param>
	{
		// Token: 0x06022F5A RID: 143194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F5A")]
		[Address(RVA = "0x1D769E0", Offset = "0x1D755E0", VA = "0x181D769E0", Slot = "9")]
		protected override void Render(AddApNotifyView.Param param)
		{
		}

		// Token: 0x06022F5B RID: 143195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F5B")]
		[Address(RVA = "0x1D76B30", Offset = "0x1D75730", VA = "0x181D76B30")]
		public AddApNotifyView()
		{
		}

		// Token: 0x040302B0 RID: 197296
		[Token(Token = "0x40302B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text apDeltaText;

		// Token: 0x040302B1 RID: 197297
		[Token(Token = "0x40302B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040302B2 RID: 197298
		[Token(Token = "0x40302B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E40 RID: 24128
		[Token(Token = "0x2005E40")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06022F5C RID: 143196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022F5C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x040302B3 RID: 197299
			[Token(Token = "0x40302B3")]
			[FieldOffset(Offset = "0x10")]
			public int startAp;

			// Token: 0x040302B4 RID: 197300
			[Token(Token = "0x40302B4")]
			[FieldOffset(Offset = "0x14")]
			public int endAp;
		}
	}
}
