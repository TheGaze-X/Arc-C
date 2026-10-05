using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000865 RID: 2149
	[Token(Token = "0x2000865")]
	public class SkinGachaItemViewModel : IHotfixable
	{
		// Token: 0x060064FF RID: 25855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0x1F01920", Offset = "0x1F00520", VA = "0x181F01920")]
		public SkinGachaItemViewModel()
		{
		}

		// Token: 0x04003187 RID: 12679
		[Token(Token = "0x4003187")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04003188 RID: 12680
		[Token(Token = "0x4003188")]
		[FieldOffset(Offset = "0x18")]
		public List<SkinGachaItemSkinViewModel> skins;

		// Token: 0x04003189 RID: 12681
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x20")]
		public string displayStr;

		// Token: 0x0400318A RID: 12682
		[Token(Token = "0x400318A")]
		[FieldOffset(Offset = "0x28")]
		public string chooseSkinVoucherId;

		// Token: 0x0400318B RID: 12683
		[Token(Token = "0x400318B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
