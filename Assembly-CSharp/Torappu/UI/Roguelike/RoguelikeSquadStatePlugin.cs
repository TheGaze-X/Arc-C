using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005534 RID: 21812
	[Token(Token = "0x2005534")]
	public abstract class RoguelikeSquadStatePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x06020145 RID: 131397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B3A")]
		public virtual List<ICheckNodeUnlockStrategy> dynamicCheckNodeUnlockStrategies
		{
			[Token(Token = "0x6020145")]
			[Address(RVA = "0x1A3CF70", Offset = "0x1A3BB70", VA = "0x181A3CF70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020146 RID: 131398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020146")]
		[Address(RVA = "0x1A3CDA0", Offset = "0x1A3B9A0", VA = "0x181A3CDA0", Slot = "5")]
		public virtual IRoguelikeSquadBattleStartHandler GetCustomSquadStartBattleHandler()
		{
			return null;
		}

		// Token: 0x06020147 RID: 131399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020147")]
		[Address(RVA = "0x1A3CEA0", Offset = "0x1A3BAA0", VA = "0x181A3CEA0", Slot = "6")]
		public virtual List<RoguelikeTopicExtraBuffData> GetTopicExtraBuffs(string topicId)
		{
			return null;
		}

		// Token: 0x06020148 RID: 131400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020148")]
		[Address(RVA = "0x1A3CF10", Offset = "0x1A3BB10", VA = "0x181A3CF10")]
		protected RoguelikeSquadStatePlugin()
		{
		}

		// Token: 0x0402B525 RID: 177445
		[Token(Token = "0x402B525")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dynamicCheckNodeUnlockStrategies;

		// Token: 0x0402B526 RID: 177446
		[Token(Token = "0x402B526")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCustomSquadStartBattleHandler;

		// Token: 0x0402B527 RID: 177447
		[Token(Token = "0x402B527")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTopicExtraBuffs;

		// Token: 0x0402B528 RID: 177448
		[Token(Token = "0x402B528")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
