using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[UsedByNativeCode]
	[Serializable]
	public struct GlyphRect : IEquatable<GlyphRect>
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x17000015")]
		public int x
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x17000016")]
		public int y
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x566210", Offset = "0x564E10", VA = "0x180566210")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x17000017")]
		public int width
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x17000018")]
		public int height
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x4228C50", Offset = "0x4227850", VA = "0x184228C50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x17000019")]
		public static GlyphRect zero
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x59D1C70", Offset = "0x59D0870", VA = "0x1859D1C70")]
			get
			{
				return default(GlyphRect);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1CA1750", Offset = "0x1CA0350", VA = "0x181CA1750")]
		public GlyphRect(int x, int y, int width, int height)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x59D1BE0", Offset = "0x59D07E0", VA = "0x1859D1BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x59D1B80", Offset = "0x59D0780", VA = "0x1859D1B80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x59D1B00", Offset = "0x59D0700", VA = "0x1859D1B00", Slot = "4")]
		public bool Equals(GlyphRect other)
		{
			return default(bool);
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("x")]
		[SerializeField]
		private int m_X;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[NativeName("y")]
		private int m_Y;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("width")]
		[SerializeField]
		private int m_Width;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[NativeName("height")]
		private int m_Height;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GlyphRect s_ZeroGlyphRect;
	}
}
