using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C21 RID: 3105
	[Token(Token = "0x2000C21")]
	public class ActArchiveBuffItemData
	{
		// Token: 0x06006900 RID: 26880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006900")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveBuffItemData()
		{
		}

		// Token: 0x04003F9C RID: 16284
		[Token(Token = "0x4003F9C")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x04003F9D RID: 16285
		[Token(Token = "0x4003F9D")]
		[FieldOffset(Offset = "0x18")]
		public int buffGroupIndex;

		// Token: 0x04003F9E RID: 16286
		[Token(Token = "0x4003F9E")]
		[FieldOffset(Offset = "0x1C")]
		public int innerSortId;

		// Token: 0x04003F9F RID: 16287
		[Token(Token = "0x4003F9F")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04003FA0 RID: 16288
		[Token(Token = "0x4003FA0")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04003FA1 RID: 16289
		[Token(Token = "0x4003FA1")]
		[FieldOffset(Offset = "0x30")]
		public string usage;

		// Token: 0x04003FA2 RID: 16290
		[Token(Token = "0x4003FA2")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x04003FA3 RID: 16291
		[Token(Token = "0x4003FA3")]
		[FieldOffset(Offset = "0x40")]
		public string color;
	}
}
