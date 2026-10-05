using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	internal class KeyPairPersistence
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x4ACA8F0", Offset = "0x4AC94F0", VA = "0x184ACA8F0")]
		public KeyPairPersistence(System.Security.Cryptography.CspParameters parameters)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4ACA840", Offset = "0x4AC9440", VA = "0x184ACA840")]
		public KeyPairPersistence(System.Security.Cryptography.CspParameters parameters, string keyPair)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700001E")]
		public string Filename
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x4ACAB10", Offset = "0x4AC9710", VA = "0x184ACAB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public string KeyValue
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x4ACB7F0", Offset = "0x4ACA3F0", VA = "0x184ACB7F0")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000020")]
		public System.Security.Cryptography.CspParameters Parameters
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4ACB240", Offset = "0x4AC9E40", VA = "0x184ACB240")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x4AC9EE0", Offset = "0x4AC8AE0", VA = "0x184AC9EE0")]
		public bool Load()
		{
			return default(bool);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x4ACA390", Offset = "0x4AC8F90", VA = "0x184ACA390")]
		public void Save()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x4ACA370", Offset = "0x4AC8F70", VA = "0x184ACA370")]
		public void Remove()
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000021")]
		private static string UserPath
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x4ACB290", Offset = "0x4AC9E90", VA = "0x184ACB290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000022")]
		private static string MachinePath
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x4ACACD0", Offset = "0x4AC98D0", VA = "0x184ACACD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal unsafe static extern bool _CanSecure(char* root);

		// Token: 0x06000173 RID: 371
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal unsafe static extern bool _ProtectUser(char* path);

		// Token: 0x06000174 RID: 372
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal unsafe static extern bool _ProtectMachine(char* path);

		// Token: 0x06000175 RID: 373
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal unsafe static extern bool _IsUserProtected(char* path);

		// Token: 0x06000176 RID: 374
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal unsafe static extern bool _IsMachineProtected(char* path);

		// Token: 0x06000177 RID: 375 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x4AC9A20", Offset = "0x4AC8620", VA = "0x184AC9A20")]
		private static bool CanSecure(string path)
		{
			return default(bool);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4ACA270", Offset = "0x4AC8E70", VA = "0x184ACA270")]
		private static bool ProtectUser(string path)
		{
			return default(bool);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4ACA170", Offset = "0x4AC8D70", VA = "0x184ACA170")]
		private static bool ProtectMachine(string path)
		{
			return default(bool);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4AC9DE0", Offset = "0x4AC89E0", VA = "0x184AC9DE0")]
		private static bool IsUserProtected(string path)
		{
			return default(bool);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4AC9CE0", Offset = "0x4AC88E0", VA = "0x184AC9CE0")]
		private static bool IsMachineProtected(string path)
		{
			return default(bool);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x17000023")]
		private bool CanChange
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1F00EC0", Offset = "0x1EFFAC0", VA = "0x181F00EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x17000024")]
		private bool UseDefaultKeyContainer
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x4ACB250", Offset = "0x4AC9E50", VA = "0x184ACB250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x17000025")]
		private bool UseMachineKeyStore
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x4ACB270", Offset = "0x4AC9E70", VA = "0x184ACB270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000026")]
		private string ContainerName
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x4ACA9A0", Offset = "0x4AC95A0", VA = "0x184ACA9A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4AC9AB0", Offset = "0x4AC86B0", VA = "0x184AC9AB0")]
		private System.Security.Cryptography.CspParameters Copy(System.Security.Cryptography.CspParameters p)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x4AC9B60", Offset = "0x4AC8760", VA = "0x184AC9B60")]
		private void FromXml(string xml)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x4ACA580", Offset = "0x4AC9180", VA = "0x184ACA580")]
		private string ToXml()
		{
			return null;
		}

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x0")]
		private static bool _userPathExists;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x8")]
		private static string _userPath;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x10")]
		private static bool _machinePathExists;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x18")]
		private static string _machinePath;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x10")]
		private System.Security.Cryptography.CspParameters _params;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x18")]
		private string _keyvalue;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x20")]
		private string _filename;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x28")]
		private string _container;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x20")]
		private static object lockobj;
	}
}
