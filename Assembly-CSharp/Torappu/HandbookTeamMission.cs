using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200109B RID: 4251
	[Token(Token = "0x200109B")]
	[Serializable]
	public class HandbookTeamMission
	{
		// Token: 0x06006E27 RID: 28199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E27")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookTeamMission()
		{
		}

		// Token: 0x04005AB4 RID: 23220
		[Token(Token = "0x4005AB4")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005AB5 RID: 23221
		[Token(Token = "0x4005AB5")]
		[FieldOffset(Offset = "0x18")]
		public int sort;

		// Token: 0x04005AB6 RID: 23222
		[Token(Token = "0x4005AB6")]
		[FieldOffset(Offset = "0x20")]
		public string powerId;

		// Token: 0x04005AB7 RID: 23223
		[Token(Token = "0x4005AB7")]
		[FieldOffset(Offset = "0x28")]
		public string powerName;

		// Token: 0x04005AB8 RID: 23224
		[Token(Token = "0x4005AB8")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle item;

		// Token: 0x04005AB9 RID: 23225
		[Token(Token = "0x4005AB9")]
		[FieldOffset(Offset = "0x38")]
		public int favorPoint;
	}
}
