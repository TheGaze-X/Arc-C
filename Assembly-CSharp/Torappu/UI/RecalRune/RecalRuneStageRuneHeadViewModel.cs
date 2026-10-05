using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200479E RID: 18334
	[Token(Token = "0x200479E")]
	public class RecalRuneStageRuneHeadViewModel : IRecalRunePack, IHotfixable, IComparable<IRecalRunePack>
	{
		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x0601BC59 RID: 113753 RVA: 0x000A6320 File Offset: 0x000A4520
		[Token(Token = "0x1700420A")]
		public RecalRuneStageRunePackType packType
		{
			[Token(Token = "0x601BC59")]
			[Address(RVA = "0x1530920", Offset = "0x152F520", VA = "0x181530920", Slot = "4")]
			get
			{
				return RecalRuneStageRunePackType.RUNE;
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x0601BC5A RID: 113754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700420B")]
		public string packId
		{
			[Token(Token = "0x601BC5A")]
			[Address(RVA = "0x1530840", Offset = "0x152F440", VA = "0x181530840", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x0601BC5B RID: 113755 RVA: 0x000A6338 File Offset: 0x000A4538
		[Token(Token = "0x1700420C")]
		public bool even
		{
			[Token(Token = "0x601BC5B")]
			[Address(RVA = "0x15307E0", Offset = "0x152F3E0", VA = "0x1815307E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601BC5C RID: 113756 RVA: 0x000A6350 File Offset: 0x000A4550
		[Token(Token = "0x601BC5C")]
		[Address(RVA = "0x1530640", Offset = "0x152F240", VA = "0x181530640", Slot = "6")]
		public int CompareTo(IRecalRunePack other)
		{
			return 0;
		}

		// Token: 0x0601BC5D RID: 113757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC5D")]
		[Address(RVA = "0x1530780", Offset = "0x152F380", VA = "0x181530780")]
		public RecalRuneStageRuneHeadViewModel()
		{
		}

		// Token: 0x04024184 RID: 147844
		[Token(Token = "0x4024184")]
		[FieldOffset(Offset = "0x10")]
		public string content;

		// Token: 0x04024185 RID: 147845
		[Token(Token = "0x4024185")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_packType;

		// Token: 0x04024186 RID: 147846
		[Token(Token = "0x4024186")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_packId;

		// Token: 0x04024187 RID: 147847
		[Token(Token = "0x4024187")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_even;

		// Token: 0x04024188 RID: 147848
		[Token(Token = "0x4024188")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04024189 RID: 147849
		[Token(Token = "0x4024189")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
