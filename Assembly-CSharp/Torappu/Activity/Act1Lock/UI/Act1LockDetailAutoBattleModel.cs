using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078C6 RID: 30918
	[Token(Token = "0x20078C6")]
	public class Act1LockDetailAutoBattleModel
	{
		// Token: 0x0602B5BD RID: 177597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5BD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1LockDetailAutoBattleModel()
		{
		}

		// Token: 0x0403EB39 RID: 256825
		[Token(Token = "0x403EB39")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403EB3A RID: 256826
		[Token(Token = "0x403EB3A")]
		[FieldOffset(Offset = "0x18")]
		public bool isAutoBattle;

		// Token: 0x0403EB3B RID: 256827
		[Token(Token = "0x403EB3B")]
		[FieldOffset(Offset = "0x19")]
		public bool canAutoBattle;

		// Token: 0x0403EB3C RID: 256828
		[Token(Token = "0x403EB3C")]
		[FieldOffset(Offset = "0x1A")]
		public bool shouldAutoBattleHidden;
	}
}
