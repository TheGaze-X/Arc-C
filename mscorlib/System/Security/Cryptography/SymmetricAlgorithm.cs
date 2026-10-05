using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class SymmetricAlgorithm : System.IDisposable
	{
		// Token: 0x06001ACD RID: 6861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x4B4FA10", Offset = "0x4B4E610", VA = "0x184B4FA10")]
		protected SymmetricAlgorithm()
		{
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x4B4F8F0", Offset = "0x4B4E4F0", VA = "0x184B4F8F0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x4B4F500", Offset = "0x4B4E100", VA = "0x184B4F500")]
		public void Clear()
		{
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x4B4F880", Offset = "0x4B4E480", VA = "0x184B4F880", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00012390 File Offset: 0x00010590
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E3")]
		public virtual int BlockSize
		{
			[Token(Token = "0x6001AD1")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AD2")]
			[Address(RVA = "0x4B4FCA0", Offset = "0x4B4E8A0", VA = "0x184B4FCA0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000123A8 File Offset: 0x000105A8
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E4")]
		public virtual int FeedbackSize
		{
			[Token(Token = "0x6001AD3")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AD4")]
			[Address(RVA = "0x4B4FDD0", Offset = "0x4B4E9D0", VA = "0x184B4FDD0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		public virtual byte[] IV
		{
			[Token(Token = "0x6001AD5")]
			[Address(RVA = "0x4B4FA40", Offset = "0x4B4E640", VA = "0x184B4FA40", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AD6")]
			[Address(RVA = "0x4B4FE60", Offset = "0x4B4EA60", VA = "0x184B4FE60", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		public virtual byte[] Key
		{
			[Token(Token = "0x6001AD7")]
			[Address(RVA = "0x4B4FAF0", Offset = "0x4B4E6F0", VA = "0x184B4FAF0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AD8")]
			[Address(RVA = "0x4B50090", Offset = "0x4B4EC90", VA = "0x184B50090", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002E7")]
		public virtual KeySizes[] LegalBlockSizes
		{
			[Token(Token = "0x6001AD9")]
			[Address(RVA = "0x4B4FBA0", Offset = "0x4B4E7A0", VA = "0x184B4FBA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002E8")]
		public virtual KeySizes[] LegalKeySizes
		{
			[Token(Token = "0x6001ADA")]
			[Address(RVA = "0x4B4FC20", Offset = "0x4B4E820", VA = "0x184B4FC20", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x000123C0 File Offset: 0x000105C0
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E9")]
		public virtual int KeySize
		{
			[Token(Token = "0x6001ADB")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001ADC")]
			[Address(RVA = "0x4B4FFF0", Offset = "0x4B4EBF0", VA = "0x184B4FFF0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000123D8 File Offset: 0x000105D8
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		public virtual CipherMode Mode
		{
			[Token(Token = "0x6001ADD")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80", Slot = "18")]
			get
			{
				return (CipherMode)0;
			}
			[Token(Token = "0x6001ADE")]
			[Address(RVA = "0x4B50240", Offset = "0x4B4EE40", VA = "0x184B50240", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x000123F0 File Offset: 0x000105F0
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EB")]
		public virtual PaddingMode Padding
		{
			[Token(Token = "0x6001ADF")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220", Slot = "20")]
			get
			{
				return (PaddingMode)0;
			}
			[Token(Token = "0x6001AE0")]
			[Address(RVA = "0x4B502D0", Offset = "0x4B4EED0", VA = "0x184B502D0", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x4B4F960", Offset = "0x4B4E560", VA = "0x184B4F960")]
		public bool ValidKeySize(int bitLength)
		{
			return default(bool);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x4B4F720", Offset = "0x4B4E320", VA = "0x184B4F720")]
		public static SymmetricAlgorithm Create()
		{
			return null;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x4B4F770", Offset = "0x4B4E370", VA = "0x184B4F770")]
		public static SymmetricAlgorithm Create(string algName)
		{
			return null;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x4B4F670", Offset = "0x4B4E270", VA = "0x184B4F670", Slot = "22")]
		public virtual ICryptoTransform CreateEncryptor()
		{
			return null;
		}

		// Token: 0x06001AE5 RID: 6885
		[Token(Token = "0x6001AE5")]
		public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x4B4F5C0", Offset = "0x4B4E1C0", VA = "0x184B4F5C0", Slot = "24")]
		public virtual ICryptoTransform CreateDecryptor()
		{
			return null;
		}

		// Token: 0x06001AE7 RID: 6887
		[Token(Token = "0x6001AE7")]
		public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

		// Token: 0x06001AE8 RID: 6888
		[Token(Token = "0x6001AE8")]
		public abstract void GenerateKey();

		// Token: 0x06001AE9 RID: 6889
		[Token(Token = "0x6001AE9")]
		public abstract void GenerateIV();

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int BlockSizeValue;

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected int FeedbackSizeValue;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected byte[] IVValue;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected byte[] KeyValue;

		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected KeySizes[] LegalBlockSizesValue;

		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected KeySizes[] LegalKeySizesValue;

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected int KeySizeValue;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected CipherMode ModeValue;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected PaddingMode PaddingValue;
	}
}
