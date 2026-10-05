using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013B3 RID: 5043
	[Token(Token = "0x20013B3")]
	public class UniEquipTypeInfo
	{
		// Token: 0x0600739E RID: 29598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipTypeInfo()
		{
		}

		// Token: 0x0400700C RID: 28684
		[Token(Token = "0x400700C")]
		[FieldOffset(Offset = "0x10")]
		public string uniEquipTypeName;

		// Token: 0x0400700D RID: 28685
		[Token(Token = "0x400700D")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0400700E RID: 28686
		[Token(Token = "0x400700E")]
		[FieldOffset(Offset = "0x1C")]
		public bool isSpecial;

		// Token: 0x0400700F RID: 28687
		[Token(Token = "0x400700F")]
		[FieldOffset(Offset = "0x1D")]
		public bool isInitial;
	}
}
