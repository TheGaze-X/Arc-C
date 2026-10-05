using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005244 RID: 21060
	[Token(Token = "0x2005244")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeDungeonTransitionPendingChecker
	{
		// Token: 0x0601F134 RID: 127284 RVA: 0x000B0D60 File Offset: 0x000AEF60
		[Token(Token = "0x601F134")]
		[Address(RVA = "0x18D3930", Offset = "0x18D2530", VA = "0x1818D3930")]
		public static bool DoCheckPendingValid()
		{
			return default(bool);
		}

		// Token: 0x04029AC9 RID: 170697
		[Token(Token = "0x4029AC9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<RoguelikeDungeonTransitionPendingChecker.IRoguelikeDungeonTransitionEventRule> s_eventRules;

		// Token: 0x04029ACA RID: 170698
		[Token(Token = "0x4029ACA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoCheckPendingValid;

		// Token: 0x02005245 RID: 21061
		[Token(Token = "0x2005245")]
		private interface IRoguelikeDungeonTransitionEventRule : IHotfixable
		{
			// Token: 0x170048AD RID: 18605
			// (get) Token: 0x0601F136 RID: 127286
			[Token(Token = "0x170048AD")]
			PlayerRoguelikePlayerEventType checkEventType { [Token(Token = "0x601F136")] get; }

			// Token: 0x0601F137 RID: 127287
			[Token(Token = "0x601F137")]
			bool DoCheckEvent(List<PlayerRoguelikePendingEvent> pendingEvents);
		}

		// Token: 0x02005246 RID: 21062
		[Token(Token = "0x2005246")]
		private class RoguelikeDungeonTransitionDefaultEventRule : RoguelikeDungeonTransitionPendingChecker.IRoguelikeDungeonTransitionEventRule, IHotfixable
		{
			// Token: 0x170048AE RID: 18606
			// (get) Token: 0x0601F138 RID: 127288 RVA: 0x000B0D78 File Offset: 0x000AEF78
			[Token(Token = "0x170048AE")]
			public PlayerRoguelikePlayerEventType checkEventType
			{
				[Token(Token = "0x601F138")]
				[Address(RVA = "0x18D38D0", Offset = "0x18D24D0", VA = "0x1818D38D0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return PlayerRoguelikePlayerEventType.GAME_INIT_MODE_RELIC;
				}
			}

			// Token: 0x0601F139 RID: 127289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F139")]
			[Address(RVA = "0x18D3860", Offset = "0x18D2460", VA = "0x1818D3860")]
			public RoguelikeDungeonTransitionDefaultEventRule(PlayerRoguelikePlayerEventType eventType)
			{
			}

			// Token: 0x0601F13A RID: 127290 RVA: 0x000B0D90 File Offset: 0x000AEF90
			[Token(Token = "0x601F13A")]
			[Address(RVA = "0x18D3690", Offset = "0x18D2290", VA = "0x1818D3690", Slot = "5")]
			public bool DoCheckEvent(List<PlayerRoguelikePendingEvent> pendingEvents)
			{
				return default(bool);
			}

			// Token: 0x04029ACC RID: 170700
			[Token(Token = "0x4029ACC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_checkEventType;

			// Token: 0x04029ACD RID: 170701
			[Token(Token = "0x4029ACD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029ACE RID: 170702
			[Token(Token = "0x4029ACE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_DoCheckEvent;
		}
	}
}
