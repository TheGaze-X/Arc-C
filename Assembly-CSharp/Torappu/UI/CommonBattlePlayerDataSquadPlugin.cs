using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035DE RID: 13790
	[Token(Token = "0x20035DE")]
	public abstract class CommonBattlePlayerDataSquadPlugin<TChar> : CommonSquadPlugin<TChar>, ICommonBattlePlayerDataSquad, ICommonSquadPlugin, IHotfixable where TChar : class, ICommonSquadChar, new()
	{
		// Token: 0x06015F24 RID: 89892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F24")]
		protected override TChar GetCharViewModelFromCharSelect(TemplateCharSelectCardViewModel selectChar)
		{
			return null;
		}

		// Token: 0x06015F25 RID: 89893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F25")]
		public virtual BattlePlayerData ParseBattleSquad(string stageId, List<AdvancedCharacterInst> advancedCharList)
		{
			return null;
		}

		// Token: 0x06015F26 RID: 89894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F26")]
		public virtual List<AdvancedCharacterInst> GenAdvancedCharList(CommonSquadSingleSquadViewModel curSelectSquad)
		{
			return null;
		}

		// Token: 0x06015F27 RID: 89895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F27")]
		protected virtual BattlePlayerData TryGenBattlePlayerData(string stageId, List<AdvancedCharacterInst> charList)
		{
			return null;
		}

		// Token: 0x06015F28 RID: 89896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F28")]
		public virtual AdvancedCharacterInst ConvertToCharInst(ICommonSquadChar charViewModel)
		{
			return null;
		}

		// Token: 0x06015F29 RID: 89897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F29")]
		protected CommonBattlePlayerDataSquadPlugin()
		{
		}

		// Token: 0x0401A61A RID: 108058
		[Token(Token = "0x401A61A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCharViewModelFromCharSelect;

		// Token: 0x0401A61B RID: 108059
		[Token(Token = "0x401A61B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ParseBattleSquad;

		// Token: 0x0401A61C RID: 108060
		[Token(Token = "0x401A61C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenAdvancedCharList;

		// Token: 0x0401A61D RID: 108061
		[Token(Token = "0x401A61D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGenBattlePlayerData;

		// Token: 0x0401A61E RID: 108062
		[Token(Token = "0x401A61E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ConvertToCharInst;

		// Token: 0x0401A61F RID: 108063
		[Token(Token = "0x401A61F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
