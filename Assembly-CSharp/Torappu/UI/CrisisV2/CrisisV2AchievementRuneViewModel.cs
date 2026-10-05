using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200594D RID: 22861
	[Token(Token = "0x200594D")]
	public class CrisisV2AchievementRuneViewModel : IHotfixable, IComparable
	{
		// Token: 0x0602151F RID: 136479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602151F")]
		[Address(RVA = "0x1B9FB50", Offset = "0x1B9E750", VA = "0x181B9FB50")]
		public CrisisV2AchievementRuneViewModel(ICrisisV2RuneData data)
		{
		}

		// Token: 0x06021520 RID: 136480 RVA: 0x000B94F0 File Offset: 0x000B76F0
		[Token(Token = "0x6021520")]
		[Address(RVA = "0x1B9FA50", Offset = "0x1B9E650", VA = "0x181B9FA50", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0402D6E9 RID: 186089
		[Token(Token = "0x402D6E9")]
		[FieldOffset(Offset = "0x10")]
		public string iconId;

		// Token: 0x0402D6EA RID: 186090
		[Token(Token = "0x402D6EA")]
		[FieldOffset(Offset = "0x18")]
		public int score;

		// Token: 0x0402D6EB RID: 186091
		[Token(Token = "0x402D6EB")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x0402D6EC RID: 186092
		[Token(Token = "0x402D6EC")]
		[FieldOffset(Offset = "0x20")]
		private string m_runeId;

		// Token: 0x0402D6ED RID: 186093
		[Token(Token = "0x402D6ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D6EE RID: 186094
		[Token(Token = "0x402D6EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
