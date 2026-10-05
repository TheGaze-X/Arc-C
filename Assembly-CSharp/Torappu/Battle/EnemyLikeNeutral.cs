using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025F0 RID: 9712
	[Token(Token = "0x20025F0")]
	public class EnemyLikeNeutral : Enemy
	{
		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600FCE4 RID: 64740 RVA: 0x0005F970 File Offset: 0x0005DB70
		[Token(Token = "0x17002202")]
		public override bool isEnemyLikeNeutral
		{
			[Token(Token = "0x600FCE4")]
			[Address(RVA = "0x743A80", Offset = "0x742680", VA = "0x180743A80", Slot = "200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FCE5 RID: 64741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCE5")]
		[Address(RVA = "0x743A00", Offset = "0x742600", VA = "0x180743A00")]
		public EnemyLikeNeutral()
		{
		}

		// Token: 0x0600FCE6 RID: 64742 RVA: 0x0005F988 File Offset: 0x0005DB88
		[Token(Token = "0x600FCE6")]
		[Address(RVA = "0x7439F0", Offset = "0x7425F0", VA = "0x1807439F0")]
		private bool <>xLuaBaseProxy_get_isEnemyLikeNeutral()
		{
			return default(bool);
		}

		// Token: 0x04011904 RID: 71940
		[Token(Token = "0x4011904")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEnemyLikeNeutral;

		// Token: 0x04011905 RID: 71941
		[Token(Token = "0x4011905")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
