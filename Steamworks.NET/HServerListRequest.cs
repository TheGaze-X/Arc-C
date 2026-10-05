using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	[Serializable]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		// Token: 0x06000AB1 RID: 2737 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public HServerListRequest(IntPtr value)
		{
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x4EDEA80", Offset = "0x4EDD680", VA = "0x184EDEA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0000932C File Offset: 0x0000752C
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x4EDE9D0", Offset = "0x4EDD5D0", VA = "0x184EDE9D0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00009344 File Offset: 0x00007544
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000935C File Offset: 0x0000755C
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450")]
		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00009374 File Offset: 0x00007574
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x4EDEAF0", Offset = "0x4EDD6F0", VA = "0x184EDEAF0")]
		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000938C File Offset: 0x0000758C
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator HServerListRequest(IntPtr value)
		{
			return default(HServerListRequest);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000093A4 File Offset: 0x000075A4
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator IntPtr(HServerListRequest that)
		{
			return 0;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000093BC File Offset: 0x000075BC
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x4EDE9C0", Offset = "0x4EDD5C0", VA = "0x184EDE9C0", Slot = "4")]
		public bool Equals(HServerListRequest other)
		{
			return default(bool);
		}

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HServerListRequest Invalid;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr m_HServerListRequest;
	}
}
