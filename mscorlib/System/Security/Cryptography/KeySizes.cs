using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x20002F3")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class KeySizes
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x000119A0 File Offset: 0x0000FBA0
		[Token(Token = "0x170002A2")]
		public int MinSize
		{
			[Token(Token = "0x60018E5")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x000119B8 File Offset: 0x0000FBB8
		[Token(Token = "0x170002A3")]
		public int MaxSize
		{
			[Token(Token = "0x60018E6")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x000119D0 File Offset: 0x0000FBD0
		[Token(Token = "0x170002A4")]
		public int SkipSize
		{
			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x4B2E6C0", Offset = "0x4B2D2C0", VA = "0x184B2E6C0")]
		public KeySizes(int minSize, int maxSize, int skipSize)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000119E8 File Offset: 0x0000FBE8
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x4B2E690", Offset = "0x4B2D290", VA = "0x184B2E690")]
		internal bool IsLegal(int keySize)
		{
			return default(bool);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x4B2E600", Offset = "0x4B2D200", VA = "0x184B2E600")]
		internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size)
		{
			return default(bool);
		}

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_minSize;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_maxSize;

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_skipSize;
	}
}
