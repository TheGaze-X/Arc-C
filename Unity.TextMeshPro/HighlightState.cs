using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public struct HighlightState
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xDD17F0", Offset = "0xDD03F0", VA = "0x180DD17F0")]
		public HighlightState(Color32 color, TMP_Offset padding)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x5880D10", Offset = "0x587F910", VA = "0x185880D10")]
		public static bool operator ==(HighlightState lhs, HighlightState rhs)
		{
			return default(bool);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5880E00", Offset = "0x587FA00", VA = "0x185880E00")]
		public static bool operator !=(HighlightState lhs, HighlightState rhs)
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x5880CB0", Offset = "0x587F8B0", VA = "0x185880CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x5880BB0", Offset = "0x587F7B0", VA = "0x185880BB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5880C20", Offset = "0x587F820", VA = "0x185880C20")]
		public bool Equals(HighlightState other)
		{
			return default(bool);
		}

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		public Color32 color;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x4")]
		public TMP_Offset padding;
	}
}
