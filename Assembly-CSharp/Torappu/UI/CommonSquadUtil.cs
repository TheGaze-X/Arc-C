using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035C6 RID: 13766
	[Token(Token = "0x20035C6")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CommonSquadUtil
	{
		// Token: 0x06015E88 RID: 89736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E88")]
		public static string MigrateSkillIfTmplChanged<T>(ICharacterCardViewModel curCard, ICharCache<T> savedSlot) where T : ICommonSquadChar, new()
		{
			return null;
		}

		// Token: 0x06015E89 RID: 89737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E89")]
		public static string MigrateEquipIfTmplChanged<T>(ICharacterCardViewModel curCard, ICharCache<T> savedSlot) where T : ICommonSquadChar, new()
		{
			return null;
		}

		// Token: 0x06015E8A RID: 89738 RVA: 0x0008EA28 File Offset: 0x0008CC28
		[Token(Token = "0x6015E8A")]
		[Address(RVA = "0xE66430", Offset = "0xE65030", VA = "0x180E66430")]
		public static SquadFriendListItem.LockedStyle GenLockedStyle4CharRuneInvalid()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x06015E8B RID: 89739 RVA: 0x0008EA40 File Offset: 0x0008CC40
		[Token(Token = "0x6015E8B")]
		[Address(RVA = "0xE666E0", Offset = "0xE652E0", VA = "0x180E666E0")]
		public static bool RestrictTargetSquadMembers(CommonSquadGroupViewModel commonSquadGroupModel, CommonSquadSingleSquadViewModel squad, ExternalRuneChecker runeChecker, int maxNumInSquadIncludingAssist)
		{
			return default(bool);
		}

		// Token: 0x06015E8C RID: 89740 RVA: 0x0008EA58 File Offset: 0x0008CC58
		[Token(Token = "0x6015E8C")]
		[Address(RVA = "0xE669C0", Offset = "0xE655C0", VA = "0x180E669C0")]
		public static int TryFetchCharSelectFocusInstId(CommonSquadSingleSquadViewModel squad, CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return 0;
		}

		// Token: 0x06015E8D RID: 89741 RVA: 0x0008EA70 File Offset: 0x0008CC70
		[Token(Token = "0x6015E8D")]
		[Address(RVA = "0xE662D0", Offset = "0xE64ED0", VA = "0x180E662D0")]
		public static EvolvePhaseAndLevel CalcEvolveMaxPhaseAndLevel(CommonSquadSingleSquadViewModel singleSquadViewModel)
		{
			return default(EvolvePhaseAndLevel);
		}

		// Token: 0x06015E8E RID: 89742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E8E")]
		[Address(RVA = "0xE66590", Offset = "0xE65190", VA = "0x180E66590")]
		public static ICharacterCardViewModel PickRandomCharacter(CommonSquadSingleSquadViewModel squad)
		{
			return null;
		}

		// Token: 0x0401A581 RID: 107905
		[Token(Token = "0x401A581")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_MigrateSkillIfTmplChanged;

		// Token: 0x0401A582 RID: 107906
		[Token(Token = "0x401A582")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MigrateEquipIfTmplChanged;

		// Token: 0x0401A583 RID: 107907
		[Token(Token = "0x401A583")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenLockedStyle4CharRuneInvalid;

		// Token: 0x0401A584 RID: 107908
		[Token(Token = "0x401A584")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RestrictTargetSquadMembers;

		// Token: 0x0401A585 RID: 107909
		[Token(Token = "0x401A585")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryFetchCharSelectFocusInstId;

		// Token: 0x0401A586 RID: 107910
		[Token(Token = "0x401A586")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalcEvolveMaxPhaseAndLevel;

		// Token: 0x0401A587 RID: 107911
		[Token(Token = "0x401A587")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PickRandomCharacter;

		// Token: 0x020035C7 RID: 13767
		[Token(Token = "0x20035C7")]
		public static class CommonSquadConsts
		{
			// Token: 0x0401A588 RID: 107912
			[Token(Token = "0x401A588")]
			public const string KEY_IS_PRACTISE = "KEY_IS_PRACTISE";

			// Token: 0x0401A589 RID: 107913
			[Token(Token = "0x401A589")]
			public const string KEY_IS_AUTO_BATTLE = "KEY_IS_AUTO_BATTLE";

			// Token: 0x0401A58A RID: 107914
			[Token(Token = "0x401A58A")]
			public const int MSG_CHAR_SELECT_CLICK = 1;

			// Token: 0x0401A58B RID: 107915
			[Token(Token = "0x401A58B")]
			public const int MSG_ASSIST_BTN_CLICK = 2;

			// Token: 0x0401A58C RID: 107916
			[Token(Token = "0x401A58C")]
			public const int MSG_ASSIST_CLEAR_CLICK = 3;

			// Token: 0x0401A58D RID: 107917
			[Token(Token = "0x401A58D")]
			public const int MSG_START_BTN_CLICK = 4;

			// Token: 0x0401A58E RID: 107918
			[Token(Token = "0x401A58E")]
			public const int MSG_TOP_MENU_BACK_BTN_CLICK = 5;

			// Token: 0x0401A58F RID: 107919
			[Token(Token = "0x401A58F")]
			public const int MSG_TOP_MENU_ROUTE_TO_OTHER = 6;

			// Token: 0x0401A590 RID: 107920
			[Token(Token = "0x401A590")]
			public const int MSG_ACT1VHALFIDLE_OPEN_TRAP_SELECT = 10001;
		}
	}
}
