using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act4fun
{
	// Token: 0x0200720B RID: 29195
	[Token(Token = "0x200720B")]
	public class Act4FunBattleMaterial
	{
		// Token: 0x06029647 RID: 169543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029647")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4FunBattleMaterial()
		{
		}

		// Token: 0x0403B1FD RID: 242173
		[Token(Token = "0x403B1FD")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x0403B1FE RID: 242174
		[Token(Token = "0x403B1FE")]
		[FieldOffset(Offset = "0x18")]
		public string materialId;

		// Token: 0x0403B1FF RID: 242175
		[Token(Token = "0x403B1FF")]
		[FieldOffset(Offset = "0x20")]
		public int materialType;

		// Token: 0x0403B200 RID: 242176
		[Token(Token = "0x403B200")]
		[FieldOffset(Offset = "0x28")]
		public Act4FunNormalMatEffect normalEffect;
	}
}
