using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002824 RID: 10276
	[Token(Token = "0x2002824")]
	public class DialogDefaultPlugin : DialogController.DialogControllerGameModePlugin
	{
		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x0601119A RID: 70042 RVA: 0x000694E0 File Offset: 0x000676E0
		[Token(Token = "0x170025B6")]
		public override GameModeMeta.GameModeType mode
		{
			[Token(Token = "0x601119A")]
			[Address(RVA = "0x907C30", Offset = "0x906830", VA = "0x180907C30", Slot = "4")]
			get
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}
		}

		// Token: 0x0601119B RID: 70043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601119B")]
		[Address(RVA = "0x907AF0", Offset = "0x9066F0", VA = "0x180907AF0", Slot = "5")]
		public override Dictionary<string, BattleStoryTree.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0601119C RID: 70044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601119C")]
		[Address(RVA = "0x9079A0", Offset = "0x9065A0", VA = "0x1809079A0", Slot = "8")]
		public override string GetBeforeBattleSignal()
		{
			return null;
		}

		// Token: 0x0601119D RID: 70045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601119D")]
		[Address(RVA = "0x907850", Offset = "0x906450", VA = "0x180907850", Slot = "9")]
		public override string GetAfterBattleSignal()
		{
			return null;
		}

		// Token: 0x0601119E RID: 70046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601119E")]
		[Address(RVA = "0x907BD0", Offset = "0x9067D0", VA = "0x180907BD0")]
		public DialogDefaultPlugin()
		{
		}

		// Token: 0x0601119F RID: 70047 RVA: 0x000694F8 File Offset: 0x000676F8
		[Token(Token = "0x601119F")]
		[Address(RVA = "0x907BC0", Offset = "0x9067C0", VA = "0x180907BC0")]
		private GameModeMeta.GameModeType <>xLuaBaseProxy_get_mode()
		{
			return GameModeMeta.GameModeType.DEFAULT;
		}

		// Token: 0x060111A0 RID: 70048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111A0")]
		[Address(RVA = "0x907BB0", Offset = "0x9067B0", VA = "0x180907BB0")]
		private Dictionary<string, BattleStoryTree.Executor> <>xLuaBaseProxy_GetExecutors()
		{
			return null;
		}

		// Token: 0x060111A1 RID: 70049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111A1")]
		[Address(RVA = "0x907BA0", Offset = "0x9067A0", VA = "0x180907BA0")]
		private string <>xLuaBaseProxy_GetBeforeBattleSignal()
		{
			return null;
		}

		// Token: 0x060111A2 RID: 70050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111A2")]
		[Address(RVA = "0x907B90", Offset = "0x906790", VA = "0x180907B90")]
		private string <>xLuaBaseProxy_GetAfterBattleSignal()
		{
			return null;
		}

		// Token: 0x040132A8 RID: 78504
		[Token(Token = "0x40132A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mode;

		// Token: 0x040132A9 RID: 78505
		[Token(Token = "0x40132A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x040132AA RID: 78506
		[Token(Token = "0x40132AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBeforeBattleSignal;

		// Token: 0x040132AB RID: 78507
		[Token(Token = "0x40132AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAfterBattleSignal;

		// Token: 0x040132AC RID: 78508
		[Token(Token = "0x40132AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
