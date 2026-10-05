using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057CF RID: 22479
	[Token(Token = "0x20057CF")]
	public class RoguelikeInitMonthTeamContext : RoguelikeInitConfirmContext
	{
		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x06020E09 RID: 134665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D1A")]
		public override List<RoguelikeInitChar.Model> charList
		{
			[Token(Token = "0x6020E09")]
			[Address(RVA = "0x1B3D0E0", Offset = "0x1B3BCE0", VA = "0x181B3D0E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x06020E0A RID: 134666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D1B")]
		public override string name
		{
			[Token(Token = "0x6020E0A")]
			[Address(RVA = "0x1B3D140", Offset = "0x1B3BD40", VA = "0x181B3D140", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020E0B RID: 134667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E0B")]
		[Address(RVA = "0x1B3CD30", Offset = "0x1B3B930", VA = "0x181B3CD30", Slot = "4")]
		public override void Load(PlayerRoguelikePendingEvent evt)
		{
		}

		// Token: 0x06020E0C RID: 134668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E0C")]
		[Address(RVA = "0x1B3D030", Offset = "0x1B3BC30", VA = "0x181B3D030")]
		public RoguelikeInitMonthTeamContext()
		{
		}

		// Token: 0x06020E0D RID: 134669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020E0D")]
		[Address(RVA = "0x1B39340", Offset = "0x1B37F40", VA = "0x181B39340")]
		private List<RoguelikeInitChar.Model> <>xLuaBaseProxy_get_charList()
		{
			return null;
		}

		// Token: 0x0402CACB RID: 182987
		[Token(Token = "0x402CACB")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeInitChar.Model> m_chars;

		// Token: 0x0402CACC RID: 182988
		[Token(Token = "0x402CACC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charList;

		// Token: 0x0402CACD RID: 182989
		[Token(Token = "0x402CACD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CACE RID: 182990
		[Token(Token = "0x402CACE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CACF RID: 182991
		[Token(Token = "0x402CACF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
