using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028FE RID: 10494
	[Token(Token = "0x20028FE")]
	public class EAttributesAdditiveMul : BasicEnemyRune
	{
		// Token: 0x060116BC RID: 71356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116BC")]
		[Address(RVA = "0x93B170", Offset = "0x939D70", VA = "0x18093B170", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116BD RID: 71357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116BD")]
		[Address(RVA = "0x93B200", Offset = "0x939E00", VA = "0x18093B200")]
		public EAttributesAdditiveMul()
		{
		}

		// Token: 0x0401376B RID: 79723
		[Token(Token = "0x401376B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x0401376C RID: 79724
		[Token(Token = "0x401376C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
