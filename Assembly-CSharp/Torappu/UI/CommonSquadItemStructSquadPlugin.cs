using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035DF RID: 13791
	[Token(Token = "0x20035DF")]
	public abstract class CommonSquadItemStructSquadPlugin<TChar> : CommonSquadPlugin<TChar>, ICommonSquadItemStructSquad, ICommonSquadPlugin, IHotfixable where TChar : CommonCharCardViewModelWithParser, new()
	{
		// Token: 0x06015F2A RID: 89898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F2A")]
		public virtual SquadItemStruct[] ParseBattleSquad()
		{
			return null;
		}

		// Token: 0x06015F2B RID: 89899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F2B")]
		protected virtual void FillSquadMembersByPlayerData(ref ICommonSquadChar[] squads)
		{
		}

		// Token: 0x06015F2C RID: 89900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F2C")]
		protected CommonSquadItemStructSquadPlugin()
		{
		}

		// Token: 0x0401A620 RID: 108064
		[Token(Token = "0x401A620")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ParseBattleSquad;

		// Token: 0x0401A621 RID: 108065
		[Token(Token = "0x401A621")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FillSquadMembersByPlayerData;

		// Token: 0x0401A622 RID: 108066
		[Token(Token = "0x401A622")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
