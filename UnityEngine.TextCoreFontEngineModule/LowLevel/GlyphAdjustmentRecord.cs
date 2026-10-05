using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[UsedByNativeCode]
	[Serializable]
	public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x17000028")]
		public uint glyphIndex
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x17000029")]
		public GlyphValueRecord glyphValueRecord
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x59D1780", Offset = "0x59D0380", VA = "0x1859D1780")]
			get
			{
				return default(GlyphValueRecord);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x59D1720", Offset = "0x59D0320", VA = "0x1859D1720", Slot = "2")]
		[ExcludeFromDocs]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x59D16B0", Offset = "0x59D02B0", VA = "0x1859D16B0", Slot = "0")]
		[ExcludeFromDocs]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x59D1620", Offset = "0x59D0220", VA = "0x1859D1620", Slot = "4")]
		[ExcludeFromDocs]
		public bool Equals(GlyphAdjustmentRecord other)
		{
			return default(bool);
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("glyphIndex")]
		[SerializeField]
		private uint m_GlyphIndex;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[NativeName("glyphValueRecord")]
		private GlyphValueRecord m_GlyphValueRecord;
	}
}
