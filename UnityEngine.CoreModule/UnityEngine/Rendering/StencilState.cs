using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	public struct StencilState : IEquatable<StencilState>
	{
		// Token: 0x170002CD RID: 717
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CD")]
		public bool enabled
		{
			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x5988040", Offset = "0x5986C40", VA = "0x185988040")]
			set
			{
			}
		}

		// Token: 0x170002CE RID: 718
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CE")]
		public byte readMask
		{
			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x3188710", Offset = "0x3187310", VA = "0x183188710")]
			set
			{
			}
		}

		// Token: 0x170002CF RID: 719
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CF")]
		public byte writeMask
		{
			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x55F8480", Offset = "0x55F7080", VA = "0x1855F8480")]
			set
			{
			}
		}

		// Token: 0x170002D0 RID: 720
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D0")]
		public CompareFunction compareFunctionFront
		{
			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x33E8CA0", Offset = "0x33E78A0", VA = "0x1833E8CA0")]
			set
			{
			}
		}

		// Token: 0x170002D1 RID: 721
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D1")]
		public StencilOp passOperationFront
		{
			[Token(Token = "0x6000E44")]
			[Address(RVA = "0x59880C0", Offset = "0x5986CC0", VA = "0x1859880C0")]
			set
			{
			}
		}

		// Token: 0x170002D2 RID: 722
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D2")]
		public StencilOp failOperationFront
		{
			[Token(Token = "0x6000E45")]
			[Address(RVA = "0x59880B0", Offset = "0x5986CB0", VA = "0x1859880B0")]
			set
			{
			}
		}

		// Token: 0x170002D3 RID: 723
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D3")]
		public StencilOp zFailOperationFront
		{
			[Token(Token = "0x6000E46")]
			[Address(RVA = "0x59880E0", Offset = "0x5986CE0", VA = "0x1859880E0")]
			set
			{
			}
		}

		// Token: 0x170002D4 RID: 724
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D4")]
		public CompareFunction compareFunctionBack
		{
			[Token(Token = "0x6000E47")]
			[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
			set
			{
			}
		}

		// Token: 0x170002D5 RID: 725
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D5")]
		public StencilOp passOperationBack
		{
			[Token(Token = "0x6000E48")]
			[Address(RVA = "0x53811A0", Offset = "0x537FDA0", VA = "0x1853811A0")]
			set
			{
			}
		}

		// Token: 0x170002D6 RID: 726
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D6")]
		public StencilOp failOperationBack
		{
			[Token(Token = "0x6000E49")]
			[Address(RVA = "0x59880A0", Offset = "0x5986CA0", VA = "0x1859880A0")]
			set
			{
			}
		}

		// Token: 0x170002D7 RID: 727
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D7")]
		public StencilOp zFailOperationBack
		{
			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0x59880D0", Offset = "0x5986CD0", VA = "0x1859880D0")]
			set
			{
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x5987D50", Offset = "0x5986950", VA = "0x185987D50", Slot = "4")]
		public bool Equals(StencilState other)
		{
			return default(bool);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x5987DC0", Offset = "0x59869C0", VA = "0x185987DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x5987F40", Offset = "0x5986B40", VA = "0x185987F40", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x0")]
		private byte m_Enabled;

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x1")]
		private byte m_ReadMask;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x2")]
		private byte m_WriteMask;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x3")]
		private byte m_Padding;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x4")]
		private byte m_CompareFunctionFront;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x5")]
		private byte m_PassOperationFront;

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x6")]
		private byte m_FailOperationFront;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x7")]
		private byte m_ZFailOperationFront;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x8")]
		private byte m_CompareFunctionBack;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x9")]
		private byte m_PassOperationBack;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0xA")]
		private byte m_FailOperationBack;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0xB")]
		private byte m_ZFailOperationBack;
	}
}
