using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	[System.Serializable]
	public class X509Certificate : System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x4B6B360", Offset = "0x4B69F60", VA = "0x184B6B360", Slot = "7")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x4B6C1D0", Offset = "0x4B6ADD0", VA = "0x184B6C1D0")]
		public X509Certificate()
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x4B6C340", Offset = "0x4B6AF40", VA = "0x184B6C340")]
		public X509Certificate(byte[] data)
		{
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x4B6C1B0", Offset = "0x4B6ADB0", VA = "0x184B6C1B0")]
		public X509Certificate(byte[] rawData, string password)
		{
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x4B6C4D0", Offset = "0x4B6B0D0", VA = "0x184B6C4D0")]
		public X509Certificate(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x4B6C270", Offset = "0x4B6AE70", VA = "0x184B6C270")]
		internal X509Certificate(X509CertificateImpl impl)
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x4B6C250", Offset = "0x4B6AE50", VA = "0x184B6C250")]
		public X509Certificate(string fileName)
		{
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x4B6BF90", Offset = "0x4B6AB90", VA = "0x184B6BF90")]
		public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		{
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x4B6BDC0", Offset = "0x4B6A9C0", VA = "0x184B6BDC0")]
		public X509Certificate(X509Certificate cert)
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x4B6C160", Offset = "0x4B6AD60", VA = "0x184B6C160")]
		public X509Certificate(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x4B6B540", Offset = "0x4B6A140", VA = "0x184B6B540", Slot = "6")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x4B6B4F0", Offset = "0x4B6A0F0", VA = "0x184B6B4F0", Slot = "5")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700030F")]
		public string Issuer
		{
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x4B6C700", Offset = "0x4B6B300", VA = "0x184B6C700")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000310")]
		public string Subject
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x4B6C7E0", Offset = "0x4B6B3E0", VA = "0x184B6C7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x4B6A320", Offset = "0x4B68F20", VA = "0x184B6A320", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x4B6A360", Offset = "0x4B68F60", VA = "0x184B6A360", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x4B6A4A0", Offset = "0x4B690A0", VA = "0x184B6A4A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000127E0 File Offset: 0x000109E0
		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x4B6A3A0", Offset = "0x4B68FA0", VA = "0x184B6A3A0", Slot = "9")]
		public virtual bool Equals(X509Certificate other)
		{
			return default(bool);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x4B6A580", Offset = "0x4B69180", VA = "0x184B6A580", Slot = "10")]
		public virtual byte[] Export(X509ContentType contentType, string password)
		{
			return null;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0x4B6A9A0", Offset = "0x4B695A0", VA = "0x184B6A9A0", Slot = "11")]
		public virtual byte[] GetCertHash()
		{
			return null;
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x4B6A910", Offset = "0x4B69510", VA = "0x184B6A910", Slot = "12")]
		public virtual string GetCertHashString()
		{
			return null;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x4B6B0A0", Offset = "0x4B69CA0", VA = "0x184B6B0A0")]
		private byte[] GetRawCertHash()
		{
			return null;
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x4B6AFF0", Offset = "0x4B69BF0", VA = "0x184B6AFF0", Slot = "13")]
		public virtual byte[] GetRawCertData()
		{
			return null;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x4B6AA30", Offset = "0x4B69630", VA = "0x184B6AA30", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x4B6AC00", Offset = "0x4B69800", VA = "0x184B6AC00", Slot = "14")]
		public virtual string GetKeyAlgorithm()
		{
			return null;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x4B6AB10", Offset = "0x4B69710", VA = "0x184B6AB10", Slot = "15")]
		public virtual byte[] GetKeyAlgorithmParameters()
		{
			return null;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x4B6AF00", Offset = "0x4B69B00", VA = "0x184B6AF00", Slot = "16")]
		public virtual byte[] GetPublicKey()
		{
			return null;
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x4B6B250", Offset = "0x4B69E50", VA = "0x184B6B250", Slot = "17")]
		public virtual byte[] GetSerialNumber()
		{
			return null;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x4B6B1C0", Offset = "0x4B69DC0", VA = "0x184B6B1C0", Slot = "18")]
		public virtual string GetSerialNumberString()
		{
			return null;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x4B6B130", Offset = "0x4B69D30", VA = "0x184B6B130")]
		private byte[] GetRawSerialNumber()
		{
			return null;
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x4B6B600", Offset = "0x4B6A200", VA = "0x184B6B600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x4B6B640", Offset = "0x4B6A240", VA = "0x184B6B640", Slot = "19")]
		public virtual string ToString(bool fVerbose)
		{
			return null;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x4B6ACE0", Offset = "0x4B698E0", VA = "0x184B6ACE0")]
		internal System.DateTime GetNotAfter()
		{
			return default(System.DateTime);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x4B6ADF0", Offset = "0x4B699F0", VA = "0x184B6ADF0")]
		internal System.DateTime GetNotBefore()
		{
			return default(System.DateTime);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x4B6A770", Offset = "0x4B69370", VA = "0x184B6A770")]
		protected static string FormatDate(System.DateTime date)
		{
			return null;
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x4B6BC20", Offset = "0x4B6A820", VA = "0x184B6BC20")]
		internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
		{
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x4B6BD50", Offset = "0x4B6A950", VA = "0x184B6BD50")]
		private void VerifyContentType(X509ContentType contentType)
		{
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x4B6B310", Offset = "0x4B69F10", VA = "0x184B6B310")]
		internal void ImportHandle(X509CertificateImpl impl)
		{
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000311")]
		internal X509CertificateImpl Impl
		{
			[Token(Token = "0x6001BD6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x17000312")]
		internal bool IsValid
		{
			[Token(Token = "0x6001BD7")]
			[Address(RVA = "0x4B6C6B0", Offset = "0x4B6B2B0", VA = "0x184B6C6B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x4B6B590", Offset = "0x4B6A190", VA = "0x184B6B590")]
		internal void ThrowIfInvalid()
		{
		}

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x10")]
		private X509CertificateImpl impl;

		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x18")]
		private byte[] lazyCertHash;

		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x20")]
		private byte[] lazySerialNumber;

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0x28")]
		private string lazyIssuer;

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x30")]
		private string lazySubject;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x38")]
		private string lazyKeyAlgorithm;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x40")]
		private byte[] lazyKeyAlgorithmParameters;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x48")]
		private byte[] lazyPublicKey;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x50")]
		private System.DateTime lazyNotBefore;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x58")]
		private System.DateTime lazyNotAfter;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		internal const X509KeyStorageFlags KeyStorageFlagsAll = X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet;
	}
}
