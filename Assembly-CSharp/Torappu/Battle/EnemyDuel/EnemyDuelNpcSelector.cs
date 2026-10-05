using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026CB RID: 9931
	[Token(Token = "0x20026CB")]
	public class EnemyDuelNpcSelector : IHotfixable
	{
		// Token: 0x060102D8 RID: 66264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102D8")]
		[Address(RVA = "0x7E7460", Offset = "0x7E6060", VA = "0x1807E7460")]
		public EnemyDuelNpcSelector(string dataNpcId, string dataEnemyId)
		{
		}

		// Token: 0x060102D9 RID: 66265 RVA: 0x00062A60 File Offset: 0x00060C60
		[Token(Token = "0x60102D9")]
		[Address(RVA = "0x7E7230", Offset = "0x7E5E30", VA = "0x1807E7230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060102DA RID: 66266 RVA: 0x00062A78 File Offset: 0x00060C78
		[Token(Token = "0x60102DA")]
		[Address(RVA = "0x7E7360", Offset = "0x7E5F60", VA = "0x1807E7360", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060102DB RID: 66267 RVA: 0x00062A90 File Offset: 0x00060C90
		[Token(Token = "0x60102DB")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450")]
		private bool <>xLuaBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		// Token: 0x060102DC RID: 66268 RVA: 0x00062AA8 File Offset: 0x00060CA8
		[Token(Token = "0x60102DC")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0")]
		private int <>xLuaBaseProxy_GetHashCode()
		{
			return 0;
		}

		// Token: 0x040120C5 RID: 73925
		[Token(Token = "0x40120C5")]
		[FieldOffset(Offset = "0x10")]
		private readonly string npcId;

		// Token: 0x040120C6 RID: 73926
		[Token(Token = "0x40120C6")]
		[FieldOffset(Offset = "0x18")]
		private readonly string enemyId;

		// Token: 0x040120C7 RID: 73927
		[Token(Token = "0x40120C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040120C8 RID: 73928
		[Token(Token = "0x40120C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Equals;

		// Token: 0x040120C9 RID: 73929
		[Token(Token = "0x40120C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetHashCode;
	}
}
