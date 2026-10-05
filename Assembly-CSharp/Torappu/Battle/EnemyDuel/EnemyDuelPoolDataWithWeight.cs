using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C7 RID: 9927
	[Token(Token = "0x20026C7")]
	public class EnemyDuelPoolDataWithWeight : IItemWithWeight, IHotfixable
	{
		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x060102D4 RID: 66260 RVA: 0x00062A48 File Offset: 0x00060C48
		// (set) Token: 0x060102D5 RID: 66261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700233F")]
		public float weightValue
		{
			[Token(Token = "0x60102D4")]
			[Address(RVA = "0x7E8440", Offset = "0x7E7040", VA = "0x1807E8440", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60102D5")]
			[Address(RVA = "0x7E84A0", Offset = "0x7E70A0", VA = "0x1807E84A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060102D6 RID: 66262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102D6")]
		[Address(RVA = "0x7E83E0", Offset = "0x7E6FE0", VA = "0x1807E83E0")]
		public EnemyDuelPoolDataWithWeight()
		{
		}

		// Token: 0x040120B0 RID: 73904
		[Token(Token = "0x40120B0")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x040120B2 RID: 73906
		[Token(Token = "0x40120B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_weightValue;

		// Token: 0x040120B3 RID: 73907
		[Token(Token = "0x40120B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_weightValue;

		// Token: 0x040120B4 RID: 73908
		[Token(Token = "0x40120B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
