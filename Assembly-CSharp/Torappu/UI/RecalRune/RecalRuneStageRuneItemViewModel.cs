using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200479D RID: 18333
	[Token(Token = "0x200479D")]
	public class RecalRuneStageRuneItemViewModel : IRecalRuneRuneGroup, IHotfixable, IRecalRunePack, IComparable<IRecalRunePack>, IComparable<RecalRuneStageRuneItemViewModel>
	{
		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x0601BC50 RID: 113744 RVA: 0x000A62A8 File Offset: 0x000A44A8
		[Token(Token = "0x17004207")]
		public RecalRuneStageRunePackType packType
		{
			[Token(Token = "0x601BC50")]
			[Address(RVA = "0x1530E80", Offset = "0x152FA80", VA = "0x181530E80", Slot = "6")]
			get
			{
				return RecalRuneStageRunePackType.RUNE;
			}
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x0601BC51 RID: 113745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004208")]
		public string packId
		{
			[Token(Token = "0x601BC51")]
			[Address(RVA = "0x1530E20", Offset = "0x152FA20", VA = "0x181530E20", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x0601BC52 RID: 113746 RVA: 0x000A62C0 File Offset: 0x000A44C0
		// (set) Token: 0x0601BC53 RID: 113747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004209")]
		public bool even
		{
			[Token(Token = "0x601BC52")]
			[Address(RVA = "0x1530DC0", Offset = "0x152F9C0", VA = "0x181530DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601BC53")]
			[Address(RVA = "0x1530EE0", Offset = "0x152FAE0", VA = "0x181530EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BC54 RID: 113748 RVA: 0x000A62D8 File Offset: 0x000A44D8
		[Token(Token = "0x601BC54")]
		[Address(RVA = "0x1530D00", Offset = "0x152F900", VA = "0x181530D00", Slot = "4")]
		public bool IsEssential()
		{
			return default(bool);
		}

		// Token: 0x0601BC55 RID: 113749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BC55")]
		[Address(RVA = "0x1530C20", Offset = "0x152F820", VA = "0x181530C20", Slot = "5")]
		public List<RecalRuneStageRuneItemViewModel> GetGroupItems()
		{
			return null;
		}

		// Token: 0x0601BC56 RID: 113750 RVA: 0x000A62F0 File Offset: 0x000A44F0
		[Token(Token = "0x601BC56")]
		[Address(RVA = "0x1530B60", Offset = "0x152F760", VA = "0x181530B60", Slot = "9")]
		public int CompareTo(RecalRuneStageRuneItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601BC57 RID: 113751 RVA: 0x000A6308 File Offset: 0x000A4508
		[Token(Token = "0x601BC57")]
		[Address(RVA = "0x1530990", Offset = "0x152F590", VA = "0x181530990", Slot = "8")]
		public int CompareTo(IRecalRunePack other)
		{
			return 0;
		}

		// Token: 0x0601BC58 RID: 113752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC58")]
		[Address(RVA = "0x1530D60", Offset = "0x152F960", VA = "0x181530D60")]
		public RecalRuneStageRuneItemViewModel()
		{
		}

		// Token: 0x0402416E RID: 147822
		[Token(Token = "0x402416E")]
		[FieldOffset(Offset = "0x10")]
		public string runeId;

		// Token: 0x0402416F RID: 147823
		[Token(Token = "0x402416F")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x04024170 RID: 147824
		[Token(Token = "0x4024170")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04024171 RID: 147825
		[Token(Token = "0x4024171")]
		[FieldOffset(Offset = "0x24")]
		public int score;

		// Token: 0x04024172 RID: 147826
		[Token(Token = "0x4024172")]
		[FieldOffset(Offset = "0x28")]
		public bool essential;

		// Token: 0x04024173 RID: 147827
		[Token(Token = "0x4024173")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x04024174 RID: 147828
		[Token(Token = "0x4024174")]
		[FieldOffset(Offset = "0x38")]
		public RuneTable.PackedRuneData packedRune;

		// Token: 0x04024175 RID: 147829
		[Token(Token = "0x4024175")]
		[FieldOffset(Offset = "0x40")]
		public string description;

		// Token: 0x04024176 RID: 147830
		[Token(Token = "0x4024176")]
		[FieldOffset(Offset = "0x48")]
		public bool passed;

		// Token: 0x04024177 RID: 147831
		[Token(Token = "0x4024177")]
		[FieldOffset(Offset = "0x50")]
		public RecalRuneStageRuneGroupViewModel parentGroup;

		// Token: 0x04024178 RID: 147832
		[Token(Token = "0x4024178")]
		[FieldOffset(Offset = "0x58")]
		public bool selected;

		// Token: 0x0402417A RID: 147834
		[Token(Token = "0x402417A")]
		[FieldOffset(Offset = "0x60")]
		private List<RecalRuneStageRuneItemViewModel> m_selfList;

		// Token: 0x0402417B RID: 147835
		[Token(Token = "0x402417B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_packType;

		// Token: 0x0402417C RID: 147836
		[Token(Token = "0x402417C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_packId;

		// Token: 0x0402417D RID: 147837
		[Token(Token = "0x402417D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_even;

		// Token: 0x0402417E RID: 147838
		[Token(Token = "0x402417E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_even;

		// Token: 0x0402417F RID: 147839
		[Token(Token = "0x402417F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsEssential;

		// Token: 0x04024180 RID: 147840
		[Token(Token = "0x4024180")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetGroupItems;

		// Token: 0x04024181 RID: 147841
		[Token(Token = "0x4024181")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04024182 RID: 147842
		[Token(Token = "0x4024182")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_CompareTo;

		// Token: 0x04024183 RID: 147843
		[Token(Token = "0x4024183")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
