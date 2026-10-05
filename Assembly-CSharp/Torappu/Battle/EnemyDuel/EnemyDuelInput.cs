using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C4 RID: 9924
	[Token(Token = "0x20026C4")]
	[Serializable]
	public class EnemyDuelInput : IHotfixable
	{
		// Token: 0x060102D0 RID: 66256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102D0")]
		[Address(RVA = "0x7E71D0", Offset = "0x7E5DD0", VA = "0x1807E71D0")]
		public EnemyDuelInput()
		{
		}

		// Token: 0x0401209A RID: 73882
		[Token(Token = "0x401209A")]
		[FieldOffset(Offset = "0x10")]
		public int randomSeed;

		// Token: 0x0401209B RID: 73883
		[Token(Token = "0x401209B")]
		[FieldOffset(Offset = "0x18")]
		public string subModeID;

		// Token: 0x0401209C RID: 73884
		[Token(Token = "0x401209C")]
		[FieldOffset(Offset = "0x20")]
		public string sceneId;

		// Token: 0x0401209D RID: 73885
		[Token(Token = "0x401209D")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyDuelServicePlayer> players;

		// Token: 0x0401209E RID: 73886
		[Token(Token = "0x401209E")]
		[FieldOffset(Offset = "0x30")]
		public bool isRoomOwner;

		// Token: 0x0401209F RID: 73887
		[Token(Token = "0x401209F")]
		[FieldOffset(Offset = "0x38")]
		public List<string> npcIds;

		// Token: 0x040120A0 RID: 73888
		[Token(Token = "0x40120A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
