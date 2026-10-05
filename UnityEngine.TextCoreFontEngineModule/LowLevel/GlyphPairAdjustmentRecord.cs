using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
	[UsedByNativeCode]
	[Serializable]
	public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x1700002A")]
		public GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x59D1AD0", Offset = "0x59D06D0", VA = "0x1859D1AD0")]
			get
			{
				return default(GlyphAdjustmentRecord);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x1700002B")]
		public GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x59D1AE0", Offset = "0x59D06E0", VA = "0x1859D1AE0")]
			get
			{
				return default(GlyphAdjustmentRecord);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x59D1A60", Offset = "0x59D0660", VA = "0x1859D1A60", Slot = "2")]
		[ExcludeFromDocs]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x59D1920", Offset = "0x59D0520", VA = "0x1859D1920", Slot = "0")]
		[ExcludeFromDocs]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x59D19A0", Offset = "0x59D05A0", VA = "0x1859D19A0", Slot = "4")]
		[ExcludeFromDocs]
		public bool Equals(GlyphPairAdjustmentRecord other)
		{
			return default(bool);
		}

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("firstAdjustmentRecord")]
		[SerializeField]
		private GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x14")]
		[NativeName("secondAdjustmentRecord")]
		[SerializeField]
		private GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FontFeatureLookupFlags m_FeatureLookupFlags;
	}
}
