using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Runes
{
	// Token: 0x020028BB RID: 10427
	[Token(Token = "0x20028BB")]
	public class AdvancedRuneHolder : IRuneDataHolder
	{
		// Token: 0x06011579 RID: 71033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011579")]
		[Address(RVA = "0x91BEA0", Offset = "0x91AAA0", VA = "0x18091BEA0")]
		public void AddPackedRuneData(RuneTable.PackedRuneData runeData)
		{
		}

		// Token: 0x0601157A RID: 71034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601157A")]
		[Address(RVA = "0x91BF00", Offset = "0x91AB00", VA = "0x18091BF00")]
		public void AddRuneHolder(IRuneDataHolder holder)
		{
		}

		// Token: 0x0601157B RID: 71035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601157B")]
		[Address(RVA = "0x91BFC0", Offset = "0x91ABC0", VA = "0x18091BFC0")]
		public void Reset()
		{
		}

		// Token: 0x0601157C RID: 71036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601157C")]
		[Address(RVA = "0x91BF90", Offset = "0x91AB90", VA = "0x18091BF90", Slot = "4")]
		public void ForeachRuneData(Action<RuneData> visitor)
		{
		}

		// Token: 0x0601157D RID: 71037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601157D")]
		[Address(RVA = "0x91BF60", Offset = "0x91AB60", VA = "0x18091BF60", Slot = "5")]
		public void ForeachPackedRuneData(Action<RuneTable.PackedRuneData> visitor)
		{
		}

		// Token: 0x0601157E RID: 71038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601157E")]
		[Address(RVA = "0x91C5A0", Offset = "0x91B1A0", VA = "0x18091C5A0")]
		private void _HolderForeachRuneData(Action<RuneData> visitor)
		{
		}

		// Token: 0x0601157F RID: 71039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601157F")]
		[Address(RVA = "0x91C450", Offset = "0x91B050", VA = "0x18091C450")]
		private void _HolderForeachPackedRuneData(Action<RuneTable.PackedRuneData> visitor)
		{
		}

		// Token: 0x06011580 RID: 71040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011580")]
		[Address(RVA = "0x91C060", Offset = "0x91AC60", VA = "0x18091C060")]
		private void _DataForeachRuneData(Action<RuneData> visitor)
		{
		}

		// Token: 0x06011581 RID: 71041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011581")]
		[Address(RVA = "0x91C2E0", Offset = "0x91AEE0", VA = "0x18091C2E0")]
		private void _DataForeachRuneData(Action<RuneTable.PackedRuneData> visitor)
		{
		}

		// Token: 0x06011582 RID: 71042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011582")]
		[Address(RVA = "0x91C6F0", Offset = "0x91B2F0", VA = "0x18091C6F0")]
		public AdvancedRuneHolder()
		{
		}

		// Token: 0x0401361D RID: 79389
		[Token(Token = "0x401361D")]
		[FieldOffset(Offset = "0x10")]
		private List<RuneTable.PackedRuneData> m_runeDataPackList;

		// Token: 0x0401361E RID: 79390
		[Token(Token = "0x401361E")]
		[FieldOffset(Offset = "0x18")]
		private List<IRuneDataHolder> m_runeDataHolders;
	}
}
