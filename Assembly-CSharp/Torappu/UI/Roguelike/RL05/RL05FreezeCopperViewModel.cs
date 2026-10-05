using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055A3 RID: 21923
	[Token(Token = "0x20055A3")]
	public class RL05FreezeCopperViewModel : IHotfixable
	{
		// Token: 0x06020322 RID: 131874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020322")]
		[Address(RVA = "0x1A54580", Offset = "0x1A53180", VA = "0x181A54580")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06020323 RID: 131875 RVA: 0x000B4E70 File Offset: 0x000B3070
		[Token(Token = "0x6020323")]
		[Address(RVA = "0x1A54AD0", Offset = "0x1A536D0", VA = "0x181A54AD0")]
		public bool TrySelectCopper(string instId)
		{
			return default(bool);
		}

		// Token: 0x06020324 RID: 131876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020324")]
		[Address(RVA = "0x1A54CA0", Offset = "0x1A538A0", VA = "0x181A54CA0")]
		private void _CalcFreezeCost()
		{
		}

		// Token: 0x06020325 RID: 131877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020325")]
		[Address(RVA = "0x1A54DA0", Offset = "0x1A539A0", VA = "0x181A54DA0")]
		public RL05FreezeCopperViewModel()
		{
		}

		// Token: 0x0402B86F RID: 178287
		[Token(Token = "0x402B86F")]
		public const int DEFAULT_SEQUENCE_NUM = 0;

		// Token: 0x0402B870 RID: 178288
		[Token(Token = "0x402B870")]
		private const int FREEZE_REPLACE_COUNT = 1;

		// Token: 0x0402B871 RID: 178289
		[Token(Token = "0x402B871")]
		[FieldOffset(Offset = "0x10")]
		public int sequenceNum;

		// Token: 0x0402B872 RID: 178290
		[Token(Token = "0x402B872")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402B873 RID: 178291
		[Token(Token = "0x402B873")]
		[FieldOffset(Offset = "0x20")]
		public List<string> selectedCopperList;

		// Token: 0x0402B874 RID: 178292
		[Token(Token = "0x402B874")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikePlayerCopperItemViewModel> copperItemList;

		// Token: 0x0402B875 RID: 178293
		[Token(Token = "0x402B875")]
		[FieldOffset(Offset = "0x30")]
		public int refreshCost;

		// Token: 0x0402B876 RID: 178294
		[Token(Token = "0x402B876")]
		[FieldOffset(Offset = "0x34")]
		public int refreshItemCount;

		// Token: 0x0402B877 RID: 178295
		[Token(Token = "0x402B877")]
		[FieldOffset(Offset = "0x38")]
		public string freezeCountDesc;

		// Token: 0x0402B878 RID: 178296
		[Token(Token = "0x402B878")]
		[FieldOffset(Offset = "0x40")]
		public int freezeCost;

		// Token: 0x0402B879 RID: 178297
		[Token(Token = "0x402B879")]
		[FieldOffset(Offset = "0x44")]
		public int freezeItemCount;

		// Token: 0x0402B87A RID: 178298
		[Token(Token = "0x402B87A")]
		[FieldOffset(Offset = "0x48")]
		public int freezeMaxCount;

		// Token: 0x0402B87B RID: 178299
		[Token(Token = "0x402B87B")]
		[FieldOffset(Offset = "0x50")]
		private int[] m_freezeCostList;

		// Token: 0x0402B87C RID: 178300
		[Token(Token = "0x402B87C")]
		[FieldOffset(Offset = "0x58")]
		private HashSet<string> m_copperIdSet;

		// Token: 0x0402B87D RID: 178301
		[Token(Token = "0x402B87D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B87E RID: 178302
		[Token(Token = "0x402B87E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TrySelectCopper;

		// Token: 0x0402B87F RID: 178303
		[Token(Token = "0x402B87F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcFreezeCost;

		// Token: 0x0402B880 RID: 178304
		[Token(Token = "0x402B880")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
