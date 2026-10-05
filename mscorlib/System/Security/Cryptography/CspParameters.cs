using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class CspParameters
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00011A18 File Offset: 0x0000FC18
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A5")]
		public CspProviderFlags Flags
		{
			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return CspProviderFlags.NoFlags;
			}
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x4B26480", Offset = "0x4B25080", VA = "0x184B26480")]
			set
			{
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A6")]
		public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity
		{
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A7")]
		public SecureString KeyPassword
		{
			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018FC")]
			[Address(RVA = "0x4B26570", Offset = "0x4B25170", VA = "0x184B26570")]
			set
			{
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00011A30 File Offset: 0x0000FC30
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A8")]
		public System.IntPtr ParentWindowHandle
		{
			[Token(Token = "0x60018FD")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60018FE")]
			[Address(RVA = "0x4B265D0", Offset = "0x4B251D0", VA = "0x184B265D0")]
			set
			{
			}
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x4B26100", Offset = "0x4B24D00", VA = "0x184B26100")]
		public CspParameters()
		{
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x4B260A0", Offset = "0x4B24CA0", VA = "0x184B260A0")]
		public CspParameters(int dwTypeIn)
		{
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x4B261E0", Offset = "0x4B24DE0", VA = "0x184B261E0")]
		public CspParameters(int dwTypeIn, string strProviderNameIn)
		{
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001902")]
		[Address(RVA = "0x4B26370", Offset = "0x4B24F70", VA = "0x184B26370")]
		public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
		{
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001903")]
		[Address(RVA = "0x4B263E0", Offset = "0x4B24FE0", VA = "0x184B263E0")]
		public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword)
		{
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001904")]
		[Address(RVA = "0x4B26250", Offset = "0x4B24E50", VA = "0x184B26250")]
		public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.IntPtr parentWindowHandle)
		{
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001905")]
		[Address(RVA = "0x4B26160", Offset = "0x4B24D60", VA = "0x184B26160")]
		internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		{
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001906")]
		[Address(RVA = "0x4B262E0", Offset = "0x4B24EE0", VA = "0x184B262E0")]
		internal CspParameters(CspParameters parameters)
		{
		}

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ProviderType;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProviderName;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string KeyContainerName;

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int KeyNumber;

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_flags;

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private System.Security.AccessControl.CryptoKeySecurity m_cryptoKeySecurity;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SecureString m_keyPassword;

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.IntPtr m_parentWindowHandle;
	}
}
