using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000326 RID: 806
	[Token(Token = "0x2000326")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SignatureDescription
	{
		// Token: 0x06001AB8 RID: 6840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SignatureDescription()
		{
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x4B4F3B0", Offset = "0x4B4DFB0", VA = "0x184B4F3B0")]
		public SignatureDescription(SecurityElement el)
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DF")]
		public string KeyAlgorithm
		{
			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		public string DigestAlgorithm
		{
			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		public string FormatterAlgorithm
		{
			[Token(Token = "0x6001ABE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABF")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		public string DeformatterAlgorithm
		{
			[Token(Token = "0x6001AC0")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AC1")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AC2")]
		[Address(RVA = "0x4B4F000", Offset = "0x4B4DC00", VA = "0x184B4F000", Slot = "4")]
		public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AC3")]
		[Address(RVA = "0x4B4F260", Offset = "0x4B4DE60", VA = "0x184B4F260", Slot = "5")]
		public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AC4")]
		[Address(RVA = "0x4B4F150", Offset = "0x4B4DD50", VA = "0x184B4F150", Slot = "6")]
		public virtual HashAlgorithm CreateDigest()
		{
			return null;
		}

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _strKey;

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _strDigest;

		// Token: 0x04000E4C RID: 3660
		[Token(Token = "0x4000E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _strFormatter;

		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _strDeformatter;
	}
}
