using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B8F RID: 27535
	[Token(Token = "0x2006B8F")]
	public class FragmentItemModel : ArchiveItemModel, IComparable
	{
		// Token: 0x06027552 RID: 161106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027552")]
		[Address(RVA = "0x228B900", Offset = "0x228A500", VA = "0x18228B900", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027553 RID: 161107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027553")]
		[Address(RVA = "0x228B8A0", Offset = "0x228A4A0", VA = "0x18228B8A0", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027554 RID: 161108 RVA: 0x000CE118 File Offset: 0x000CC318
		[Token(Token = "0x6027554")]
		[Address(RVA = "0x228B700", Offset = "0x228A300", VA = "0x18228B700", Slot = "7")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06027555 RID: 161109 RVA: 0x000CE130 File Offset: 0x000CC330
		[Token(Token = "0x6027555")]
		[Address(RVA = "0x228B9F0", Offset = "0x228A5F0", VA = "0x18228B9F0")]
		private static int _TypeComparison(RoguelikeFragmentType x, RoguelikeFragmentType y)
		{
			return 0;
		}

		// Token: 0x06027556 RID: 161110 RVA: 0x000CE148 File Offset: 0x000CC348
		[Token(Token = "0x6027556")]
		[Address(RVA = "0x228B960", Offset = "0x228A560", VA = "0x18228B960")]
		private static int _GetFragmentTypeValue(RoguelikeFragmentType type)
		{
			return 0;
		}

		// Token: 0x06027557 RID: 161111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027557")]
		[Address(RVA = "0x228BA80", Offset = "0x228A680", VA = "0x18228BA80")]
		public FragmentItemModel()
		{
		}

		// Token: 0x04037B83 RID: 228227
		[Token(Token = "0x4037B83")]
		[FieldOffset(Offset = "0x30")]
		public string fragmentId;

		// Token: 0x04037B84 RID: 228228
		[Token(Token = "0x4037B84")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeFragmentType type;

		// Token: 0x04037B85 RID: 228229
		[Token(Token = "0x4037B85")]
		[FieldOffset(Offset = "0x3C")]
		public int weight;

		// Token: 0x04037B86 RID: 228230
		[Token(Token = "0x4037B86")]
		[FieldOffset(Offset = "0x40")]
		public int value;

		// Token: 0x04037B87 RID: 228231
		[Token(Token = "0x4037B87")]
		[FieldOffset(Offset = "0x48")]
		public string name;

		// Token: 0x04037B88 RID: 228232
		[Token(Token = "0x4037B88")]
		[FieldOffset(Offset = "0x50")]
		public string iconId;

		// Token: 0x04037B89 RID: 228233
		[Token(Token = "0x4037B89")]
		[FieldOffset(Offset = "0x58")]
		public string desc;

		// Token: 0x04037B8A RID: 228234
		[Token(Token = "0x4037B8A")]
		[FieldOffset(Offset = "0x60")]
		public string usage;

		// Token: 0x04037B8B RID: 228235
		[Token(Token = "0x4037B8B")]
		[FieldOffset(Offset = "0x68")]
		public int sortId;

		// Token: 0x04037B8C RID: 228236
		[Token(Token = "0x4037B8C")]
		[FieldOffset(Offset = "0x6C")]
		public RoguelikeArchiveItemUnlockStatus status;

		// Token: 0x04037B8D RID: 228237
		[Token(Token = "0x4037B8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037B8E RID: 228238
		[Token(Token = "0x4037B8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037B8F RID: 228239
		[Token(Token = "0x4037B8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04037B90 RID: 228240
		[Token(Token = "0x4037B90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TypeComparison;

		// Token: 0x04037B91 RID: 228241
		[Token(Token = "0x4037B91")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetFragmentTypeValue;

		// Token: 0x04037B92 RID: 228242
		[Token(Token = "0x4037B92")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
