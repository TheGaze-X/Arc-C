using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C6 RID: 9926
	[Token(Token = "0x20026C6")]
	[Serializable]
	public class EnemyDuelEnemyGenerationData : IHotfixable
	{
		// Token: 0x060102D2 RID: 66258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60102D2")]
		[Address(RVA = "0x7E6EA0", Offset = "0x7E5AA0", VA = "0x1807E6EA0")]
		public EnemyDuelEnemyGenerationData Duplicate()
		{
			return null;
		}

		// Token: 0x060102D3 RID: 66259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102D3")]
		[Address(RVA = "0x7E6FA0", Offset = "0x7E5BA0", VA = "0x1807E6FA0")]
		public EnemyDuelEnemyGenerationData()
		{
		}

		// Token: 0x040120A7 RID: 73895
		[Token(Token = "0x40120A7")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x040120A8 RID: 73896
		[Token(Token = "0x40120A8")]
		[FieldOffset(Offset = "0x18")]
		public float value;

		// Token: 0x040120A9 RID: 73897
		[Token(Token = "0x40120A9")]
		[FieldOffset(Offset = "0x1C")]
		public float increment;

		// Token: 0x040120AA RID: 73898
		[Token(Token = "0x40120AA")]
		[FieldOffset(Offset = "0x20")]
		public int priority;

		// Token: 0x040120AB RID: 73899
		[Token(Token = "0x40120AB")]
		[FieldOffset(Offset = "0x24")]
		public int count;

		// Token: 0x040120AC RID: 73900
		[Token(Token = "0x40120AC")]
		[FieldOffset(Offset = "0x28")]
		public bool isSurpriseAttacker;

		// Token: 0x040120AD RID: 73901
		[Token(Token = "0x40120AD")]
		[FieldOffset(Offset = "0x29")]
		public bool isGiant;

		// Token: 0x040120AE RID: 73902
		[Token(Token = "0x40120AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Duplicate;

		// Token: 0x040120AF RID: 73903
		[Token(Token = "0x40120AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
