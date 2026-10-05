using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Extern
{
	// Token: 0x02005560 RID: 21856
	[Token(Token = "0x2005560")]
	public class RoguelikeTopicEntryResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020202 RID: 131586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020202")]
		[Address(RVA = "0x1A45130", Offset = "0x1A43D30", VA = "0x181A45130")]
		public Sprite GetHomeEntry()
		{
			return null;
		}

		// Token: 0x06020203 RID: 131587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020203")]
		[Address(RVA = "0x1A45060", Offset = "0x1A43C60", VA = "0x181A45060")]
		public Sprite GetHomeEntryMultiMode()
		{
			return null;
		}

		// Token: 0x06020204 RID: 131588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020204")]
		[Address(RVA = "0x1A45200", Offset = "0x1A43E00", VA = "0x181A45200")]
		public Sprite GetZoneHomeDailySprite()
		{
			return null;
		}

		// Token: 0x06020205 RID: 131589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020205")]
		[Address(RVA = "0x1A452D0", Offset = "0x1A43ED0", VA = "0x181A452D0")]
		public RoguelikeTopicEntryResHolder()
		{
		}

		// Token: 0x0402B65F RID: 177759
		[Token(Token = "0x402B65F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeEntry;

		// Token: 0x0402B660 RID: 177760
		[Token(Token = "0x402B660")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeEntryMultiMode;

		// Token: 0x0402B661 RID: 177761
		[Token(Token = "0x402B661")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _zoneHomeDaily;

		// Token: 0x0402B662 RID: 177762
		[Token(Token = "0x402B662")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHomeEntry;

		// Token: 0x0402B663 RID: 177763
		[Token(Token = "0x402B663")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetHomeEntryMultiMode;

		// Token: 0x0402B664 RID: 177764
		[Token(Token = "0x402B664")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetZoneHomeDailySprite;

		// Token: 0x0402B665 RID: 177765
		[Token(Token = "0x402B665")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
