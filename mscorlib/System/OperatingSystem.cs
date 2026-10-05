using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	[System.Serializable]
	public sealed class OperatingSystem : System.Runtime.Serialization.ISerializable, System.ICloneable
	{
		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x4CF5F60", Offset = "0x4CF4B60", VA = "0x184CF5F60")]
		public OperatingSystem(System.PlatformID platform, System.Version version)
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x4CF5F80", Offset = "0x4CF4B80", VA = "0x184CF5F80")]
		internal OperatingSystem(System.PlatformID platform, System.Version version, string servicePack)
		{
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x4CF5F00", Offset = "0x4CF4B00", VA = "0x184CF5F00", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x17000111")]
		public System.PlatformID Platform
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return System.PlatformID.Win32S;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000112")]
		public System.Version Version
		{
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x4CF5E70", Offset = "0x4CF4A70", VA = "0x184CF5E70", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x4CF5F50", Offset = "0x4CF4B50", VA = "0x184CF5F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000113")]
		public string VersionString
		{
			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x4CF6100", Offset = "0x4CF4D00", VA = "0x184CF6100")]
			get
			{
				return null;
			}
		}

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Version _version;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x18")]
		private readonly System.PlatformID _platform;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _servicePack;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x28")]
		private string _versionString;
	}
}
