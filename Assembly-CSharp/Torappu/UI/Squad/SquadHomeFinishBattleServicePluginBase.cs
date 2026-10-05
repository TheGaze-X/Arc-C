using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E28 RID: 15912
	[Token(Token = "0x2003E28")]
	public abstract class SquadHomeFinishBattleServicePluginBase : IHotfixable
	{
		// Token: 0x06018BC8 RID: 101320
		[Token(Token = "0x6018BC8")]
		public abstract IFinishBattleServiceConfig CreateFinishBattleServiceConfig();

		// Token: 0x06018BC9 RID: 101321
		[Token(Token = "0x6018BC9")]
		public abstract void SetParams(SquadHomeFinishBattleServicePluginBase.Param param);

		// Token: 0x06018BCA RID: 101322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BCA")]
		[Address(RVA = "0x1140D40", Offset = "0x113F940", VA = "0x181140D40")]
		protected SquadHomeFinishBattleServicePluginBase()
		{
		}

		// Token: 0x0401E63D RID: 124477
		[Token(Token = "0x401E63D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E29 RID: 15913
		[Token(Token = "0x2003E29")]
		public class Param
		{
			// Token: 0x06018BCB RID: 101323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018BCB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401E63E RID: 124478
			[Token(Token = "0x401E63E")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;
		}
	}
}
