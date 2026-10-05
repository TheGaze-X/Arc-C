using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UniEquip
{
	// Token: 0x02002A31 RID: 10801
	[Token(Token = "0x2002A31")]
	[Hotfix(HotfixFlag.Stateless)]
	public class UniEquip
	{
		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x06011EBF RID: 73407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700276C")]
		public BattleUniEquipData eData
		{
			[Token(Token = "0x6011EBF")]
			[Address(RVA = "0x9D8AB0", Offset = "0x9D76B0", VA = "0x1809D8AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011EC0 RID: 73408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EC0")]
		[Address(RVA = "0x9D8A30", Offset = "0x9D7630", VA = "0x1809D8A30")]
		public UniEquip(BattleUniEquipData data)
		{
		}

		// Token: 0x04014343 RID: 82755
		[Token(Token = "0x4014343")]
		[FieldOffset(Offset = "0x10")]
		private BattleUniEquipData m_eData;

		// Token: 0x04014344 RID: 82756
		[Token(Token = "0x4014344")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eData;

		// Token: 0x04014345 RID: 82757
		[Token(Token = "0x4014345")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
