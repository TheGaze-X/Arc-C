using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005194 RID: 20884
	[Token(Token = "0x2005194")]
	public class ExpeditionReturnDialogData : IHotfixable
	{
		// Token: 0x0601EDB3 RID: 126387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDB3")]
		[Address(RVA = "0x189E460", Offset = "0x189D060", VA = "0x18189E460")]
		public void LoadData(UIRoguelikeExpeditionReturnDialogBase.Options options)
		{
		}

		// Token: 0x0601EDB4 RID: 126388 RVA: 0x000AFF38 File Offset: 0x000AE138
		[Token(Token = "0x601EDB4")]
		[Address(RVA = "0x189E8A0", Offset = "0x189D4A0", VA = "0x18189E8A0")]
		public bool MoveNext(out ExpeditionReturnDialogSingleData single, out bool isLast)
		{
			return default(bool);
		}

		// Token: 0x0601EDB5 RID: 126389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDB5")]
		[Address(RVA = "0x189E9B0", Offset = "0x189D5B0", VA = "0x18189E9B0")]
		public void RemoveDuplicatesByType(PlayerRoguelikeV2.CurrentData.Troop.ExpedType type)
		{
		}

		// Token: 0x0601EDB6 RID: 126390 RVA: 0x000AFF50 File Offset: 0x000AE150
		[Token(Token = "0x601EDB6")]
		[Address(RVA = "0x189EBF0", Offset = "0x189D7F0", VA = "0x18189EBF0")]
		private static int _SingleDataComparison(KeyValuePair<string, ExpeditionReturnDialogSingleData> lhs, KeyValuePair<string, ExpeditionReturnDialogSingleData> rhs)
		{
			return 0;
		}

		// Token: 0x0601EDB7 RID: 126391 RVA: 0x000AFF68 File Offset: 0x000AE168
		[Token(Token = "0x601EDB7")]
		[Address(RVA = "0x189EB20", Offset = "0x189D720", VA = "0x18189EB20")]
		private static int _ExpedTypeSort(PlayerRoguelikeV2.CurrentData.Troop.ExpedType type)
		{
			return 0;
		}

		// Token: 0x0601EDB8 RID: 126392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDB8")]
		[Address(RVA = "0x189ECC0", Offset = "0x189D8C0", VA = "0x18189ECC0")]
		public ExpeditionReturnDialogData()
		{
		}

		// Token: 0x0402964B RID: 169547
		[Token(Token = "0x402964B")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, ExpeditionReturnDialogSingleData> m_singles;

		// Token: 0x0402964C RID: 169548
		[Token(Token = "0x402964C")]
		[FieldOffset(Offset = "0x18")]
		private int m_count;

		// Token: 0x0402964D RID: 169549
		[Token(Token = "0x402964D")]
		[FieldOffset(Offset = "0x1C")]
		private int m_current;

		// Token: 0x0402964E RID: 169550
		[Token(Token = "0x402964E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402964F RID: 169551
		[Token(Token = "0x402964F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MoveNext;

		// Token: 0x04029650 RID: 169552
		[Token(Token = "0x4029650")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RemoveDuplicatesByType;

		// Token: 0x04029651 RID: 169553
		[Token(Token = "0x4029651")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SingleDataComparison;

		// Token: 0x04029652 RID: 169554
		[Token(Token = "0x4029652")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExpedTypeSort;

		// Token: 0x04029653 RID: 169555
		[Token(Token = "0x4029653")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
