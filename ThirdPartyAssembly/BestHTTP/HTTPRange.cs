using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	public sealed class HTTPRange
	{
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x00010B18 File Offset: 0x0000ED18
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000556")]
		public int FirstBytePos
		{
			[Token(Token = "0x6002695")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002696")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x00010B30 File Offset: 0x0000ED30
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000557")]
		public int LastBytePos
		{
			[Token(Token = "0x6002697")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002698")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x00010B48 File Offset: 0x0000ED48
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000558")]
		public int ContentLength
		{
			[Token(Token = "0x6002699")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600269A")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x00010B60 File Offset: 0x0000ED60
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000559")]
		public bool IsValid
		{
			[Token(Token = "0x600269B")]
			[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600269C")]
			[Address(RVA = "0x1241210", Offset = "0x123FE10", VA = "0x181241210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x538B7E0", Offset = "0x538A3E0", VA = "0x18538B7E0")]
		internal HTTPRange()
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x538B7B0", Offset = "0x538A3B0", VA = "0x18538B7B0")]
		internal HTTPRange(int contentLength)
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x538B750", Offset = "0x538A350", VA = "0x18538B750")]
		internal HTTPRange(int firstBytePosition, int lastBytePosition, int contentLength)
		{
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x538B540", Offset = "0x538A140", VA = "0x18538B540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
