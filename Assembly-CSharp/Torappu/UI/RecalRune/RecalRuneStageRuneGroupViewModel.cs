using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200479C RID: 18332
	[Token(Token = "0x200479C")]
	public class RecalRuneStageRuneGroupViewModel : IRecalRuneRuneGroup, IHotfixable
	{
		// Token: 0x0601BC4D RID: 113741 RVA: 0x000A6290 File Offset: 0x000A4490
		[Token(Token = "0x601BC4D")]
		[Address(RVA = "0x1530510", Offset = "0x152F110", VA = "0x181530510", Slot = "4")]
		public bool IsEssential()
		{
			return default(bool);
		}

		// Token: 0x0601BC4E RID: 113742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BC4E")]
		[Address(RVA = "0x15304B0", Offset = "0x152F0B0", VA = "0x1815304B0", Slot = "5")]
		public List<RecalRuneStageRuneItemViewModel> GetGroupItems()
		{
			return null;
		}

		// Token: 0x0601BC4F RID: 113743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC4F")]
		[Address(RVA = "0x1530590", Offset = "0x152F190", VA = "0x181530590")]
		public RecalRuneStageRuneGroupViewModel()
		{
		}

		// Token: 0x04024168 RID: 147816
		[Token(Token = "0x4024168")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<RecalRuneStageRuneItemViewModel> items;

		// Token: 0x04024169 RID: 147817
		[Token(Token = "0x4024169")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x0402416A RID: 147818
		[Token(Token = "0x402416A")]
		[FieldOffset(Offset = "0x20")]
		public RecalRuneStageRuneItemViewModel selectedItem;

		// Token: 0x0402416B RID: 147819
		[Token(Token = "0x402416B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEssential;

		// Token: 0x0402416C RID: 147820
		[Token(Token = "0x402416C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGroupItems;

		// Token: 0x0402416D RID: 147821
		[Token(Token = "0x402416D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
