using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200552F RID: 21807
	[Token(Token = "0x200552F")]
	public class DefaultRoguelikeSquadBattleStartHandler : IRoguelikeSquadBattleStartHandler, IHotfixable
	{
		// Token: 0x06020123 RID: 131363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020123")]
		[Address(RVA = "0x1A2FE10", Offset = "0x1A2EA10", VA = "0x181A2FE10", Slot = "5")]
		public virtual void CheckAndHandle(RoguelikeSquadStateBean bean, Action<List<RequestSquadSlot>> battleStarter)
		{
		}

		// Token: 0x06020124 RID: 131364 RVA: 0x000B47B0 File Offset: 0x000B29B0
		[Token(Token = "0x6020124")]
		[Address(RVA = "0x1A30490", Offset = "0x1A2F090", VA = "0x181A30490", Slot = "6")]
		protected virtual bool NeedCustomCheck(RoguelikeSquadStateBean bean)
		{
			return default(bool);
		}

		// Token: 0x06020125 RID: 131365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020125")]
		[Address(RVA = "0x1A30400", Offset = "0x1A2F000", VA = "0x181A30400", Slot = "7")]
		protected virtual void HandleCustomCheck(RoguelikeSquadStateBean bean, List<RequestSquadSlot> filterdSlots, Action<List<RequestSquadSlot>> battleStarter)
		{
		}

		// Token: 0x06020126 RID: 131366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020126")]
		[Address(RVA = "0x1A30270", Offset = "0x1A2EE70", VA = "0x181A30270", Slot = "8")]
		protected virtual List<RequestSquadSlot> GenerateFilteredSlots(RoguelikeSquadStateBean bean)
		{
			return null;
		}

		// Token: 0x06020127 RID: 131367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020127")]
		[Address(RVA = "0x1A30150", Offset = "0x1A2ED50", VA = "0x181A30150", Slot = "9")]
		protected virtual RequestSquadSlot CreateSlot(RoguelikeCharCardViewModel card)
		{
			return null;
		}

		// Token: 0x06020128 RID: 131368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020128")]
		[Address(RVA = "0x1A30500", Offset = "0x1A2F100", VA = "0x181A30500")]
		private void _HandleEmptySquad(Action<List<RequestSquadSlot>> continueAction)
		{
		}

		// Token: 0x06020129 RID: 131369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020129")]
		[Address(RVA = "0x1A30700", Offset = "0x1A2F300", VA = "0x181A30700")]
		public DefaultRoguelikeSquadBattleStartHandler()
		{
		}

		// Token: 0x0402B4FD RID: 177405
		[Token(Token = "0x402B4FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckAndHandle;

		// Token: 0x0402B4FE RID: 177406
		[Token(Token = "0x402B4FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NeedCustomCheck;

		// Token: 0x0402B4FF RID: 177407
		[Token(Token = "0x402B4FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleCustomCheck;

		// Token: 0x0402B500 RID: 177408
		[Token(Token = "0x402B500")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateFilteredSlots;

		// Token: 0x0402B501 RID: 177409
		[Token(Token = "0x402B501")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateSlot;

		// Token: 0x0402B502 RID: 177410
		[Token(Token = "0x402B502")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleEmptySquad;

		// Token: 0x0402B503 RID: 177411
		[Token(Token = "0x402B503")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
