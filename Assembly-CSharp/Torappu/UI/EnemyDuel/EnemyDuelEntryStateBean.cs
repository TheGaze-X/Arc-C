using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F8D RID: 20365
	[Token(Token = "0x2004F8D")]
	public class EnemyDuelEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601E48C RID: 124044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E48C")]
		[Address(RVA = "0x17FDF70", Offset = "0x17FCB70", VA = "0x1817FDF70")]
		public EnemyDuelEntryStateBean()
		{
		}

		// Token: 0x040286A4 RID: 165540
		[Token(Token = "0x40286A4")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelEntryProperty m_prop;

		// Token: 0x040286A5 RID: 165541
		[Token(Token = "0x40286A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
