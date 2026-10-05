using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005038 RID: 20536
	[Token(Token = "0x2005038")]
	public class EnemyDuelMatchStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601E750 RID: 124752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E750")]
		[Address(RVA = "0x1822820", Offset = "0x1821420", VA = "0x181822820")]
		public EnemyDuelMatchStateBean()
		{
		}

		// Token: 0x04028C34 RID: 166964
		[Token(Token = "0x4028C34")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelMatchProperty prop;

		// Token: 0x04028C35 RID: 166965
		[Token(Token = "0x4028C35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
