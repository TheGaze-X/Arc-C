using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	public struct SpinWait
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0000E610 File Offset: 0x0000C810
		[Token(Token = "0x170001A4")]
		public int Count
		{
			[Token(Token = "0x60011E2")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x170001A5")]
		public bool NextSpinWillYield
		{
			[Token(Token = "0x60011E3")]
			[Address(RVA = "0x4D5B620", Offset = "0x4D5A220", VA = "0x184D5B620")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x4D5B450", Offset = "0x4D5A050", VA = "0x184D5B450")]
		public void SpinOnce()
		{
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x4D5B4A0", Offset = "0x4D5A0A0", VA = "0x184D5B4A0")]
		public void SpinOnce(int sleep1Threshold)
		{
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x4D5B2C0", Offset = "0x4D59EC0", VA = "0x184D5B2C0")]
		private void SpinOnceCore(int sleep1Threshold)
		{
		}

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int SpinCountforSpinBeforeWait;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x0")]
		private int _count;
	}
}
