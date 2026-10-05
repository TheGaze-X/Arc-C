using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028FF RID: 10495
	[Token(Token = "0x20028FF")]
	public class EAttribuesAdd : BasicEnemyRune
	{
		// Token: 0x060116BE RID: 71358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116BE")]
		[Address(RVA = "0x93AE90", Offset = "0x939A90", VA = "0x18093AE90", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116BF RID: 71359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116BF")]
		[Address(RVA = "0x93AF30", Offset = "0x939B30", VA = "0x18093AF30")]
		public EAttribuesAdd()
		{
		}

		// Token: 0x0401376D RID: 79725
		[Token(Token = "0x401376D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x0401376E RID: 79726
		[Token(Token = "0x401376E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
