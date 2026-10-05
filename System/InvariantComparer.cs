using System;
using System.Collections;
using System.Globalization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[Serializable]
	internal class InvariantComparer : IComparer
	{
		// Token: 0x0600038E RID: 910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x50CD290", Offset = "0x50CBE90", VA = "0x1850CD290")]
		internal InvariantComparer()
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x50CD070", Offset = "0x50CBC70", VA = "0x1850CD070", Slot = "4")]
		public int Compare(object a, object b)
		{
			return 0;
		}

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x10")]
		private CompareInfo m_compareInfo;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly InvariantComparer Default;
	}
}
