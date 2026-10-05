using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class CryptoAPITransform : ICryptoTransform, System.IDisposable
	{
		// Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x4A7B1B0", Offset = "0x4A79DB0", VA = "0x184A7B1B0")]
		internal CryptoAPITransform()
		{
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x170002EE")]
		public bool CanReuseTransform
		{
			[Token(Token = "0x6001B12")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x170002EF")]
		public bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x6001B13")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x170002F0")]
		public int InputBlockSize
		{
			[Token(Token = "0x6001B14")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x170002F1")]
		public System.IntPtr KeyHandle
		{
			[Token(Token = "0x6001B15")]
			[Address(RVA = "0x4B3B430", Offset = "0x4B3A030", VA = "0x184B3B430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x00012570 File Offset: 0x00010770
		[Token(Token = "0x170002F2")]
		public int OutputBlockSize
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x4B3B3D0", Offset = "0x4B39FD0", VA = "0x184B3B3D0", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x4B3B3C0", Offset = "0x4B39FC0", VA = "0x184B3B3C0")]
		public void Clear()
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x4B3B3C0", Offset = "0x4B39FC0", VA = "0x184B3B3C0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public void Reset()
		{
		}

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_disposed;
	}
}
