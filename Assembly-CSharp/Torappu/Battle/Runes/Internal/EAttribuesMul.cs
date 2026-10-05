using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028FD RID: 10493
	[Token(Token = "0x20028FD")]
	public class EAttribuesMul : BasicEnemyRune
	{
		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x060116B8 RID: 71352 RVA: 0x0006B238 File Offset: 0x00069438
		[Token(Token = "0x17002681")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116B8")]
			[Address(RVA = "0x93B110", Offset = "0x939D10", VA = "0x18093B110", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116B9 RID: 71353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116B9")]
		[Address(RVA = "0x93AFD0", Offset = "0x939BD0", VA = "0x18093AFD0", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116BA RID: 71354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116BA")]
		[Address(RVA = "0x93B070", Offset = "0x939C70", VA = "0x18093B070")]
		public EAttribuesMul()
		{
		}

		// Token: 0x060116BB RID: 71355 RVA: 0x0006B250 File Offset: 0x00069450
		[Token(Token = "0x60116BB")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013768 RID: 79720
		[Token(Token = "0x4013768")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013769 RID: 79721
		[Token(Token = "0x4013769")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x0401376A RID: 79722
		[Token(Token = "0x401376A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
