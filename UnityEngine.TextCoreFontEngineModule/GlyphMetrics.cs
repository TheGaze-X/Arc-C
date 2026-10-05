using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[UsedByNativeCode]
	[Serializable]
	public struct GlyphMetrics : IEquatable<GlyphMetrics>
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x1700001A")]
		public float width
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x592C440", Offset = "0x592B040", VA = "0x18592C440")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x1700001B")]
		public float height
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x1700001C")]
		public float horizontalBearingX
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x592C420", Offset = "0x592B020", VA = "0x18592C420")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x1700001D")]
		public float horizontalBearingY
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x5917F50", Offset = "0x5916B50", VA = "0x185917F50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x1700001E")]
		public float horizontalAdvance
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x5911BF0", Offset = "0x59107F0", VA = "0x185911BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x59D18F0", Offset = "0x59D04F0", VA = "0x1859D18F0")]
		public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x59D1890", Offset = "0x59D0490", VA = "0x1859D1890", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x59D1820", Offset = "0x59D0420", VA = "0x1859D1820", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59D1790", Offset = "0x59D0390", VA = "0x1859D1790", Slot = "4")]
		public bool Equals(GlyphMetrics other)
		{
			return default(bool);
		}

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("width")]
		[SerializeField]
		private float m_Width;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x4")]
		[NativeName("height")]
		[SerializeField]
		private float m_Height;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("horizontalBearingX")]
		[SerializeField]
		private float m_HorizontalBearingX;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("horizontalBearingY")]
		[SerializeField]
		private float m_HorizontalBearingY;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[NativeName("horizontalAdvance")]
		private float m_HorizontalAdvance;
	}
}
