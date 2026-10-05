using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002900 RID: 10496
	[Token(Token = "0x2002900")]
	public class EAbnormalImmune : BasicEnemyRune
	{
		// Token: 0x060116C0 RID: 71360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116C0")]
		[Address(RVA = "0x93AB30", Offset = "0x939730", VA = "0x18093AB30", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116C1 RID: 71361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116C1")]
		[Address(RVA = "0x93ABD0", Offset = "0x9397D0", VA = "0x18093ABD0")]
		public EAbnormalImmune()
		{
		}

		// Token: 0x0401376F RID: 79727
		[Token(Token = "0x401376F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013770 RID: 79728
		[Token(Token = "0x4013770")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
