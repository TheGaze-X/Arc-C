using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001265 RID: 4709
	[Token(Token = "0x2001265")]
	[Serializable]
	public class RuneTable
	{
		// Token: 0x060071E5 RID: 29157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RuneTable()
		{
		}

		// Token: 0x040067DF RID: 26591
		[Token(Token = "0x40067DF")]
		[FieldOffset(Offset = "0x10")]
		public List<RuneTable.RuneStageExtraData> runeStages;

		// Token: 0x02001266 RID: 4710
		[Token(Token = "0x2001266")]
		[Serializable]
		public class PackedRuneInput : IRuneDataHolder
		{
			// Token: 0x060071E6 RID: 29158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071E6")]
			[Address(RVA = "0x2209180", Offset = "0x2207D80", VA = "0x182209180", Slot = "5")]
			public void ForeachPackedRuneData(Action<RuneTable.PackedRuneData> visitor)
			{
			}

			// Token: 0x060071E7 RID: 29159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071E7")]
			[Address(RVA = "0x2209230", Offset = "0x2207E30", VA = "0x182209230", Slot = "4")]
			public void ForeachRuneData(Action<RuneData> visitor)
			{
			}

			// Token: 0x060071E8 RID: 29160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071E8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PackedRuneInput()
			{
			}

			// Token: 0x040067E0 RID: 26592
			[Token(Token = "0x40067E0")]
			[FieldOffset(Offset = "0x10")]
			public List<RuneTable.PackedRuneData> runes;
		}

		// Token: 0x02001267 RID: 4711
		[Token(Token = "0x2001267")]
		[Serializable]
		public class PackedRuneData
		{
			// Token: 0x060071E9 RID: 29161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071E9")]
			[Address(RVA = "0x2208E90", Offset = "0x2207A90", VA = "0x182208E90")]
			public RuneTable.PackedRuneData Duplicate()
			{
				return null;
			}

			// Token: 0x060071EA RID: 29162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071EA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PackedRuneData()
			{
			}

			// Token: 0x040067E1 RID: 26593
			[Token(Token = "0x40067E1")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040067E2 RID: 26594
			[Token(Token = "0x40067E2")]
			[FieldOffset(Offset = "0x18")]
			public float points;

			// Token: 0x040067E3 RID: 26595
			[Token(Token = "0x40067E3")]
			[FieldOffset(Offset = "0x20")]
			public string mutexGroupKey;

			// Token: 0x040067E4 RID: 26596
			[Token(Token = "0x40067E4")]
			[FieldOffset(Offset = "0x28")]
			public string description;

			// Token: 0x040067E5 RID: 26597
			[Token(Token = "0x40067E5")]
			[FieldOffset(Offset = "0x30")]
			public List<RuneData> runes;
		}

		// Token: 0x02001268 RID: 4712
		[Token(Token = "0x2001268")]
		[Serializable]
		public class RuneStageExtraData
		{
			// Token: 0x060071EB RID: 29163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071EB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneStageExtraData()
			{
			}

			// Token: 0x040067E6 RID: 26598
			[Token(Token = "0x40067E6")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040067E7 RID: 26599
			[Token(Token = "0x40067E7")]
			[FieldOffset(Offset = "0x18")]
			public List<RuneTable.PackedRuneData> runes;
		}
	}
}
