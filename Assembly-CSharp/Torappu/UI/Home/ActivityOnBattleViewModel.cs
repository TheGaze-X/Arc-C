using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B58 RID: 19288
	[Token(Token = "0x2004B58")]
	public class ActivityOnBattleViewModel : IHotfixable
	{
		// Token: 0x0601D0B1 RID: 118961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B1")]
		[Address(RVA = "0x16659C0", Offset = "0x16645C0", VA = "0x1816659C0")]
		public void LoadData()
		{
		}

		// Token: 0x0601D0B2 RID: 118962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B2")]
		[Address(RVA = "0x1665D90", Offset = "0x1664990", VA = "0x181665D90")]
		private void _LoadActivityModels()
		{
		}

		// Token: 0x0601D0B3 RID: 118963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B3")]
		[Address(RVA = "0x1666210", Offset = "0x1664E10", VA = "0x181666210")]
		private void _LoadCrisisV2Models()
		{
		}

		// Token: 0x0601D0B4 RID: 118964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B4")]
		[Address(RVA = "0x1666910", Offset = "0x1665510", VA = "0x181666910")]
		private void _LoadRoguelikeModels()
		{
		}

		// Token: 0x0601D0B5 RID: 118965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B5")]
		[Address(RVA = "0x1666BF0", Offset = "0x16657F0", VA = "0x181666BF0")]
		private void _LoadSandboxPermModels()
		{
		}

		// Token: 0x0601D0B6 RID: 118966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B6")]
		[Address(RVA = "0x16663C0", Offset = "0x1664FC0", VA = "0x1816663C0")]
		private void _LoadMainlineModels()
		{
		}

		// Token: 0x0601D0B7 RID: 118967 RVA: 0x000AA190 File Offset: 0x000A8390
		[Token(Token = "0x601D0B7")]
		[Address(RVA = "0x1666F50", Offset = "0x1665B50", VA = "0x181666F50")]
		private static int _ModelComparer(HomeActTabOnBattle.Options lhs, HomeActTabOnBattle.Options rhs)
		{
			return 0;
		}

		// Token: 0x0601D0B8 RID: 118968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B8")]
		[Address(RVA = "0x1667070", Offset = "0x1665C70", VA = "0x181667070")]
		public ActivityOnBattleViewModel()
		{
		}

		// Token: 0x04026180 RID: 156032
		[Token(Token = "0x4026180")]
		private const int MAX_DISPLAY_COUNT = 2;

		// Token: 0x04026181 RID: 156033
		[Token(Token = "0x4026181")]
		[FieldOffset(Offset = "0x10")]
		public List<HomeActTabOnBattle.Options> tabModels;

		// Token: 0x04026182 RID: 156034
		[Token(Token = "0x4026182")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026183 RID: 156035
		[Token(Token = "0x4026183")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadActivityModels;

		// Token: 0x04026184 RID: 156036
		[Token(Token = "0x4026184")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadCrisisV2Models;

		// Token: 0x04026185 RID: 156037
		[Token(Token = "0x4026185")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadRoguelikeModels;

		// Token: 0x04026186 RID: 156038
		[Token(Token = "0x4026186")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadSandboxPermModels;

		// Token: 0x04026187 RID: 156039
		[Token(Token = "0x4026187")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadMainlineModels;

		// Token: 0x04026188 RID: 156040
		[Token(Token = "0x4026188")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ModelComparer;

		// Token: 0x04026189 RID: 156041
		[Token(Token = "0x4026189")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
