using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FD5 RID: 20437
	[Token(Token = "0x2004FD5")]
	public class EnemyDuelBetEnemyViewModel : IHotfixable
	{
		// Token: 0x0601E58F RID: 124303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E58F")]
		[Address(RVA = "0x18135A0", Offset = "0x18121A0", VA = "0x1818135A0")]
		public void LoadData(EnemyDuelEnemyGenerationData enemyData, Dictionary<string, ActivityEnemyDuelEnemyData> enemyTable)
		{
		}

		// Token: 0x0601E590 RID: 124304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E590")]
		[Address(RVA = "0x1813750", Offset = "0x1812350", VA = "0x181813750")]
		public EnemyDuelBetEnemyViewModel()
		{
		}

		// Token: 0x0402890D RID: 166157
		[Token(Token = "0x402890D")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x0402890E RID: 166158
		[Token(Token = "0x402890E")]
		[FieldOffset(Offset = "0x18")]
		public string enemyIconId;

		// Token: 0x0402890F RID: 166159
		[Token(Token = "0x402890F")]
		[FieldOffset(Offset = "0x20")]
		public int enemyCount;

		// Token: 0x04028910 RID: 166160
		[Token(Token = "0x4028910")]
		[FieldOffset(Offset = "0x28")]
		public string enemyName;

		// Token: 0x04028911 RID: 166161
		[Token(Token = "0x4028911")]
		[FieldOffset(Offset = "0x30")]
		public string enemyDesc;

		// Token: 0x04028912 RID: 166162
		[Token(Token = "0x4028912")]
		[FieldOffset(Offset = "0x38")]
		public string enemyTagType;

		// Token: 0x04028913 RID: 166163
		[Token(Token = "0x4028913")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028914 RID: 166164
		[Token(Token = "0x4028914")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
