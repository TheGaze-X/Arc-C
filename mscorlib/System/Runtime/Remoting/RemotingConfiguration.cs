using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000368 RID: 872
	[Token(Token = "0x2000368")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public static class RemotingConfiguration
	{
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034B")]
		public static string ApplicationName
		{
			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x4B669D0", Offset = "0x4B655D0", VA = "0x184B669D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C94")]
			[Address(RVA = "0x4B66B00", Offset = "0x4B65700", VA = "0x184B66B00")]
			set
			{
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700034C")]
		public static string ProcessId
		{
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x4B66A20", Offset = "0x4B65620", VA = "0x184B66A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x4B64870", Offset = "0x4B63470", VA = "0x184B64870")]
		internal static void LoadDefaultDelayedChannels()
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00012948 File Offset: 0x00010B48
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x4B643C0", Offset = "0x4B62FC0", VA = "0x184B643C0")]
		public static bool IsActivationAllowed(System.Type svrType)
		{
			return default(bool);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x4B64510", Offset = "0x4B63110", VA = "0x184B64510")]
		public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(System.Type svrType)
		{
			return null;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x4B646C0", Offset = "0x4B632C0", VA = "0x184B646C0")]
		public static WellKnownClientTypeEntry IsWellKnownClientType(System.Type svrType)
		{
			return null;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x4B64BE0", Offset = "0x4B637E0", VA = "0x184B64BE0")]
		public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x4B64EA0", Offset = "0x4B63AA0", VA = "0x184B64EA0")]
		public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x4B66020", Offset = "0x4B64C20", VA = "0x184B66020")]
		public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x4B662E0", Offset = "0x4B64EE0", VA = "0x184B662E0")]
		public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x4B64FF0", Offset = "0x4B63BF0", VA = "0x184B64FF0")]
		internal static void RegisterChannelTemplate(ChannelData channel)
		{
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x4B658D0", Offset = "0x4B644D0", VA = "0x184B658D0")]
		internal static void RegisterClientProviderTemplate(ProviderData prov)
		{
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x4B65980", Offset = "0x4B64580", VA = "0x184B65980")]
		internal static void RegisterServerProviderTemplate(ProviderData prov)
		{
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x4B650A0", Offset = "0x4B63CA0", VA = "0x184B650A0")]
		internal static void RegisterChannels(System.Collections.ArrayList channels, bool onlyDelayed)
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x4B65A30", Offset = "0x4B64630", VA = "0x184B65A30")]
		internal static void RegisterTypes(System.Collections.ArrayList types)
		{
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00012960 File Offset: 0x00010B60
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x4B64330", Offset = "0x4B62F30", VA = "0x184B64330")]
		public static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			return default(bool);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x4B66470", Offset = "0x4B65070", VA = "0x184B66470")]
		internal static void SetCustomErrorsMode(string mode)
		{
		}

		// Token: 0x04000F57 RID: 3927
		[Token(Token = "0x4000F57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string applicationID;

		// Token: 0x04000F58 RID: 3928
		[Token(Token = "0x4000F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string applicationName;

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string processGuid;

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool defaultConfigRead;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private static bool defaultDelayedConfigRead;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static CustomErrorsModes _errorMode;

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static System.Collections.Hashtable wellKnownClientEntries;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static System.Collections.Hashtable activatedClientEntries;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static System.Collections.Hashtable wellKnownServiceEntries;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static System.Collections.Hashtable activatedServiceEntries;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static System.Collections.Hashtable channelTemplates;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static System.Collections.Hashtable clientProviderTemplates;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static System.Collections.Hashtable serverProviderTemplates;
	}
}
