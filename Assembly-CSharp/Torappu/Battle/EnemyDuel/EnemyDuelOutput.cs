using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C5 RID: 9925
	[Token(Token = "0x20026C5")]
	public class EnemyDuelOutput : IHotfixable
	{
		// Token: 0x060102D1 RID: 66257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102D1")]
		[Address(RVA = "0x7E7520", Offset = "0x7E6120", VA = "0x1807E7520")]
		public EnemyDuelOutput()
		{
		}

		// Token: 0x040120A1 RID: 73889
		[Token(Token = "0x40120A1")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x040120A2 RID: 73890
		[Token(Token = "0x40120A2")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;

		// Token: 0x040120A3 RID: 73891
		[Token(Token = "0x40120A3")]
		[FieldOffset(Offset = "0x20")]
		public string sceneId;

		// Token: 0x040120A4 RID: 73892
		[Token(Token = "0x40120A4")]
		[FieldOffset(Offset = "0x28")]
		public bool isRoomOwner;

		// Token: 0x040120A5 RID: 73893
		[Token(Token = "0x40120A5")]
		[FieldOffset(Offset = "0x29")]
		public bool isGiveUp;

		// Token: 0x040120A6 RID: 73894
		[Token(Token = "0x40120A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
