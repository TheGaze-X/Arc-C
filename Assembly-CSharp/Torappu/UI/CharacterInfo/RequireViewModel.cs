using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F24 RID: 24356
	[Token(Token = "0x2005F24")]
	public class RequireViewModel
	{
		// Token: 0x0602347D RID: 144509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602347D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RequireViewModel()
		{
		}

		// Token: 0x04030A36 RID: 199222
		[Token(Token = "0x4030A36")]
		[FieldOffset(Offset = "0x10")]
		public LvlUpRequireType requireType;

		// Token: 0x04030A37 RID: 199223
		[Token(Token = "0x4030A37")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel itemModel;

		// Token: 0x04030A38 RID: 199224
		[Token(Token = "0x4030A38")]
		[FieldOffset(Offset = "0x20")]
		public string textTitle;

		// Token: 0x04030A39 RID: 199225
		[Token(Token = "0x4030A39")]
		[FieldOffset(Offset = "0x28")]
		public bool isSatisfied;

		// Token: 0x04030A3A RID: 199226
		[Token(Token = "0x4030A3A")]
		[FieldOffset(Offset = "0x30")]
		public long currentCount;

		// Token: 0x04030A3B RID: 199227
		[Token(Token = "0x4030A3B")]
		[FieldOffset(Offset = "0x38")]
		public EvolvePhase evolvePhase;

		// Token: 0x04030A3C RID: 199228
		[Token(Token = "0x4030A3C")]
		[FieldOffset(Offset = "0x40")]
		public long requireCount;

		// Token: 0x04030A3D RID: 199229
		[Token(Token = "0x4030A3D")]
		[FieldOffset(Offset = "0x48")]
		public bool showRequireCount;
	}
}
