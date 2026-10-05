using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005636 RID: 22070
	[Token(Token = "0x2005636")]
	public class RL05SquadStatePlugin : RoguelikeSquadStatePlugin
	{
		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x06020632 RID: 132658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BCC")]
		public override List<ICheckNodeUnlockStrategy> dynamicCheckNodeUnlockStrategies
		{
			[Token(Token = "0x6020632")]
			[Address(RVA = "0x1A88360", Offset = "0x1A86F60", VA = "0x181A88360", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020633 RID: 132659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020633")]
		[Address(RVA = "0x1A87D30", Offset = "0x1A86930", VA = "0x181A87D30", Slot = "5")]
		public override IRoguelikeSquadBattleStartHandler GetCustomSquadStartBattleHandler()
		{
			return null;
		}

		// Token: 0x06020634 RID: 132660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020634")]
		[Address(RVA = "0x1A87E20", Offset = "0x1A86A20", VA = "0x181A87E20", Slot = "6")]
		public override List<RoguelikeTopicExtraBuffData> GetTopicExtraBuffs(string topicId)
		{
			return null;
		}

		// Token: 0x06020635 RID: 132661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020635")]
		[Address(RVA = "0x1A88300", Offset = "0x1A86F00", VA = "0x181A88300")]
		public RL05SquadStatePlugin()
		{
		}

		// Token: 0x06020636 RID: 132662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020636")]
		[Address(RVA = "0x1A882F0", Offset = "0x1A86EF0", VA = "0x181A882F0")]
		private List<ICheckNodeUnlockStrategy> <>xLuaBaseProxy_get_dynamicCheckNodeUnlockStrategies()
		{
			return null;
		}

		// Token: 0x06020637 RID: 132663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020637")]
		[Address(RVA = "0x1A882D0", Offset = "0x1A86ED0", VA = "0x181A882D0")]
		private IRoguelikeSquadBattleStartHandler <>xLuaBaseProxy_GetCustomSquadStartBattleHandler()
		{
			return null;
		}

		// Token: 0x06020638 RID: 132664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020638")]
		[Address(RVA = "0x1A882E0", Offset = "0x1A86EE0", VA = "0x181A882E0")]
		private List<RoguelikeTopicExtraBuffData> <>xLuaBaseProxy_GetTopicExtraBuffs(string P0)
		{
			return null;
		}

		// Token: 0x0402BD7F RID: 179583
		[Token(Token = "0x402BD7F")]
		[FieldOffset(Offset = "0x18")]
		private List<ICheckNodeUnlockStrategy> m_dynamicCheckNodeUnlockStrategies;

		// Token: 0x0402BD80 RID: 179584
		[Token(Token = "0x402BD80")]
		[FieldOffset(Offset = "0x20")]
		private RL05SquadBattleStartHandler m_startBattleHanlder;

		// Token: 0x0402BD81 RID: 179585
		[Token(Token = "0x402BD81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dynamicCheckNodeUnlockStrategies;

		// Token: 0x0402BD82 RID: 179586
		[Token(Token = "0x402BD82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCustomSquadStartBattleHandler;

		// Token: 0x0402BD83 RID: 179587
		[Token(Token = "0x402BD83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTopicExtraBuffs;

		// Token: 0x0402BD84 RID: 179588
		[Token(Token = "0x402BD84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
