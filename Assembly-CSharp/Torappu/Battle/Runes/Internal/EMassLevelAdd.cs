using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002902 RID: 10498
	[Token(Token = "0x2002902")]
	public class EMassLevelAdd : BasicEnemyRune
	{
		// Token: 0x060116C6 RID: 71366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116C6")]
		[Address(RVA = "0x93B6B0", Offset = "0x93A2B0", VA = "0x18093B6B0", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116C7 RID: 71367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116C7")]
		[Address(RVA = "0x93B810", Offset = "0x93A410", VA = "0x18093B810")]
		public EMassLevelAdd()
		{
		}

		// Token: 0x04013774 RID: 79732
		[Token(Token = "0x4013774")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013775 RID: 79733
		[Token(Token = "0x4013775")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
