using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[UsedByNativeCode]
	[Serializable]
	[StructLayout(0)]
	public class Glyph
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x1700001F")]
		public uint index
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x17000020")]
		public GlyphMetrics metrics
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x59D1AE0", Offset = "0x59D06E0", VA = "0x1859D1AE0")]
			get
			{
				return default(GlyphMetrics);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x59D1F10", Offset = "0x59D0B10", VA = "0x1859D1F10")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x17000021")]
		public GlyphRect glyphRect
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x59957A0", Offset = "0x59943A0", VA = "0x1859957A0")]
			get
			{
				return default(GlyphRect);
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x4C97D70", Offset = "0x4C96970", VA = "0x184C97D70")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x17000022")]
		public float scale
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x59BA3D0", Offset = "0x59B8FD0", VA = "0x1859BA3D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1692890", Offset = "0x1691490", VA = "0x181692890")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000023CC File Offset: 0x000005CC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x17000023")]
		public int atlasIndex
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x59D1F00", Offset = "0x59D0B00", VA = "0x1859D1F00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			set
			{
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x59D1EC0", Offset = "0x59D0AC0", VA = "0x1859D1EC0")]
		public Glyph()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x59D1E00", Offset = "0x59D0A00", VA = "0x1859D1E00")]
		internal Glyph(GlyphMarshallingStruct glyphStruct)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x59D1E50", Offset = "0x59D0A50", VA = "0x1859D1E50")]
		public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
		{
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NativeName("index")]
		[SerializeField]
		private uint m_Index;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[NativeName("metrics")]
		private GlyphMetrics m_Metrics;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[NativeName("glyphRect")]
		private GlyphRect m_GlyphRect;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NativeName("scale")]
		[SerializeField]
		private float m_Scale;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[NativeName("atlasIndex")]
		private int m_AtlasIndex;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NativeName("type")]
		[SerializeField]
		private GlyphClassDefinitionType m_ClassDefinitionType;
	}
}
