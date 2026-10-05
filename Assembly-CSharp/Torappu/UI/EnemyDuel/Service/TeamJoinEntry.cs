using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005066 RID: 20582
	[Token(Token = "0x2005066")]
	public struct TeamJoinEntry
	{
		// Token: 0x04028DDA RID: 167386
		[Token(Token = "0x4028DDA")]
		[FieldOffset(Offset = "0x0")]
		public string teamId;

		// Token: 0x04028DDB RID: 167387
		[Token(Token = "0x4028DDB")]
		[FieldOffset(Offset = "0x8")]
		public string svrAddress;

		// Token: 0x04028DDC RID: 167388
		[Token(Token = "0x4028DDC")]
		[FieldOffset(Offset = "0x10")]
		public string svrToken;

		// Token: 0x04028DDD RID: 167389
		[Token(Token = "0x4028DDD")]
		[FieldOffset(Offset = "0x18")]
		public Action<bool> onceJoinComplete;
	}
}
