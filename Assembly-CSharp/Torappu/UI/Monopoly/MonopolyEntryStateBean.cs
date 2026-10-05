using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047E9 RID: 18409
	[Token(Token = "0x20047E9")]
	public class MonopolyEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x0601BD95 RID: 114069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004237")]
		public MonopolyEntryProperty prop
		{
			[Token(Token = "0x601BD95")]
			[Address(RVA = "0x1525340", Offset = "0x1523F40", VA = "0x181525340")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BD96 RID: 114070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD96")]
		[Address(RVA = "0x15251F0", Offset = "0x1523DF0", VA = "0x1815251F0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601BD97 RID: 114071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD97")]
		[Address(RVA = "0x15252A0", Offset = "0x1523EA0", VA = "0x1815252A0")]
		public MonopolyEntryStateBean()
		{
		}

		// Token: 0x040243E1 RID: 148449
		[Token(Token = "0x40243E1")]
		[FieldOffset(Offset = "0x10")]
		private MonopolyEntryProperty m_prop;

		// Token: 0x040243E2 RID: 148450
		[Token(Token = "0x40243E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x040243E3 RID: 148451
		[Token(Token = "0x40243E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040243E4 RID: 148452
		[Token(Token = "0x40243E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
