using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A9A RID: 31386
	[Token(Token = "0x2007A9A")]
	public class Act12sidePhotoStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BF8C RID: 180108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF8C")]
		[Address(RVA = "0x27E11A0", Offset = "0x27DFDA0", VA = "0x1827E11A0")]
		public Act12sidePhotoStateBean()
		{
		}

		// Token: 0x0403FB09 RID: 260873
		[Token(Token = "0x403FB09")]
		[FieldOffset(Offset = "0x10")]
		public Act12SideData.PhotoInfo photoInfo;

		// Token: 0x0403FB0A RID: 260874
		[Token(Token = "0x403FB0A")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;

		// Token: 0x0403FB0B RID: 260875
		[Token(Token = "0x403FB0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
