using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200553D RID: 21821
	[Token(Token = "0x200553D")]
	public class RoguelikeStashedTicketUseParamBuilder : IHotfixable
	{
		// Token: 0x06020161 RID: 131425 RVA: 0x000B4858 File Offset: 0x000B2A58
		[Token(Token = "0x6020161")]
		[Address(RVA = "0x1A3FEB0", Offset = "0x1A3EAB0", VA = "0x181A3FEB0")]
		public RoguelikeStashedTicketUseParam Build(string topicId)
		{
			return default(RoguelikeStashedTicketUseParam);
		}

		// Token: 0x06020162 RID: 131426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020162")]
		[Address(RVA = "0x1A3FCB0", Offset = "0x1A3E8B0", VA = "0x181A3FCB0", Slot = "4")]
		protected virtual List<IRoguelikeStashedTicketItemViewModel> BuildStashedTicketList(string topicId, RoguelikeTopicDetail topicData, PlayerRoguelikeV2.CurrentData playerCurrent)
		{
			return null;
		}

		// Token: 0x06020163 RID: 131427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020163")]
		[Address(RVA = "0x1A3FB10", Offset = "0x1A3E710", VA = "0x181A3FB10", Slot = "5")]
		protected virtual RoguelikeStashedTicketUseDesParam BuildDescParams(string topicId, RoguelikeTopicDetail topicData, PlayerRoguelikeV2.CurrentData playerCurrent)
		{
			return null;
		}

		// Token: 0x06020164 RID: 131428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020164")]
		[Address(RVA = "0x1A400F0", Offset = "0x1A3ECF0", VA = "0x181A400F0")]
		public RoguelikeStashedTicketUseParamBuilder()
		{
		}

		// Token: 0x0402B578 RID: 177528
		[Token(Token = "0x402B578")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Build;

		// Token: 0x0402B579 RID: 177529
		[Token(Token = "0x402B579")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BuildStashedTicketList;

		// Token: 0x0402B57A RID: 177530
		[Token(Token = "0x402B57A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BuildDescParams;

		// Token: 0x0402B57B RID: 177531
		[Token(Token = "0x402B57B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
