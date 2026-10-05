using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	[Serializable]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		// Token: 0x06000B78 RID: 2936 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public ScreenshotHandle(uint value)
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0000A004 File Offset: 0x00008204
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x4F0D300", Offset = "0x4F0BF00", VA = "0x184F0D300", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0000A01C File Offset: 0x0000821C
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0000A034 File Offset: 0x00008234
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0000A04C File Offset: 0x0000824C
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x4F0D3E0", Offset = "0x4F0BFE0", VA = "0x184F0D3E0")]
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0000A064 File Offset: 0x00008264
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0000A07C File Offset: 0x0000827C
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(ScreenshotHandle that)
		{
			return 0U;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0000A094 File Offset: 0x00008294
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(ScreenshotHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0000A0AC File Offset: 0x000082AC
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(ScreenshotHandle other)
		{
			return 0;
		}

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ScreenshotHandle Invalid;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x0")]
		public uint m_ScreenshotHandle;
	}
}
