using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E53 RID: 24147
	[Token(Token = "0x2005E53")]
	public class ItemRepoChooseCharStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06022FC4 RID: 143300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FC4")]
		[Address(RVA = "0x1D81EA0", Offset = "0x1D80AA0", VA = "0x181D81EA0")]
		public ItemRepoChooseCharStateBean()
		{
		}

		// Token: 0x0403031B RID: 197403
		[Token(Token = "0x403031B")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemViewModel;

		// Token: 0x0403031C RID: 197404
		[Token(Token = "0x403031C")]
		[FieldOffset(Offset = "0x18")]
		public UIStringEvent clickEvent;

		// Token: 0x0403031D RID: 197405
		[Token(Token = "0x403031D")]
		[FieldOffset(Offset = "0x20")]
		public string titleText;

		// Token: 0x0403031E RID: 197406
		[Token(Token = "0x403031E")]
		[FieldOffset(Offset = "0x28")]
		public bool clickable;

		// Token: 0x0403031F RID: 197407
		[Token(Token = "0x403031F")]
		[FieldOffset(Offset = "0x30")]
		public string pickedItemId;

		// Token: 0x04030320 RID: 197408
		[Token(Token = "0x4030320")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
