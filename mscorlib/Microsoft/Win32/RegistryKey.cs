using System;
using System.Text;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public sealed class RegistryKey : System.MarshalByRefObject, System.IDisposable
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x4AD2D90", Offset = "0x4AD1990", VA = "0x184AD2D90")]
		private void ClosePerfDataKey()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x4AD46C0", Offset = "0x4AD32C0", VA = "0x184AD46C0")]
		private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view)
		{
			return null;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4AD4290", Offset = "0x4AD2E90", VA = "0x184AD4290")]
		private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure)
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x4AD4490", Offset = "0x4AD3090", VA = "0x184AD4490")]
		private int InternalSubKeyCountCore()
		{
			return 0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x4AD3640", Offset = "0x4AD2240", VA = "0x184AD3640")]
		private string[] InternalGetSubKeyNamesCore(int subkeys)
		{
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x4AD3880", Offset = "0x4AD2480", VA = "0x184AD3880")]
		private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand)
		{
			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x4AD4DD0", Offset = "0x4AD39D0", VA = "0x184AD4DD0")]
		private void Win32Error(int errorCode, string str)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4AD32E0", Offset = "0x4AD1EE0", VA = "0x184AD32E0")]
		private static int GetRegistryKeyAccess(bool isWritable)
		{
			return 0;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x4AD5400", Offset = "0x4AD4000", VA = "0x184AD5400")]
		private RegistryKey(Microsoft.Win32.SafeHandles.SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x4AD2DF0", Offset = "0x4AD19F0", VA = "0x184AD2DF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x4AD4830", Offset = "0x4AD3430", VA = "0x184AD4830")]
		public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x4AD4A20", Offset = "0x4AD3620", VA = "0x184AD4A20")]
		public RegistryKey OpenSubKey(string name, bool writable)
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4AD4560", Offset = "0x4AD3160", VA = "0x184AD4560")]
		private int InternalSubKeyCount()
		{
			return 0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x4AD3300", Offset = "0x4AD1F00", VA = "0x184AD3300")]
		public string[] GetSubKeyNames()
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x4AD3300", Offset = "0x4AD1F00", VA = "0x184AD3300")]
		private string[] InternalGetSubKeyNames()
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x4AD3510", Offset = "0x4AD2110", VA = "0x184AD3510")]
		public object GetValue(string name, object defaultValue, RegistryValueOptions options)
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x4AD41E0", Offset = "0x4AD2DE0", VA = "0x184AD41E0")]
		private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity)
		{
			return null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x4AD4BD0", Offset = "0x4AD37D0", VA = "0x184AD4BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x4AD2FA0", Offset = "0x4AD1BA0", VA = "0x184AD2FA0")]
		private static string FixupName(string name)
		{
			return null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x4AD31B0", Offset = "0x4AD1DB0", VA = "0x184AD31B0")]
		private static void FixupPath(System.Text.StringBuilder path)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x4AD2F40", Offset = "0x4AD1B40", VA = "0x184AD2F40")]
		private void EnsureNotDisposed()
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x4AD34B0", Offset = "0x4AD20B0", VA = "0x184AD34B0")]
		private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable)
		{
			return RegistryKeyPermissionCheck.Default;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x4AD4C40", Offset = "0x4AD3840", VA = "0x184AD4C40")]
		private static void ValidateKeyName(string name)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x4AD4D60", Offset = "0x4AD3960", VA = "0x184AD4D60")]
		private static void ValidateKeyView(RegistryView view)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x4AD46A0", Offset = "0x4AD32A0", VA = "0x184AD46A0")]
		private bool IsSystemKey()
		{
			return default(bool);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x4AD4680", Offset = "0x4AD3280", VA = "0x184AD4680")]
		private bool IsPerfDataKey()
		{
			return default(bool);
		}

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly System.IntPtr HKEY_CLASSES_ROOT;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly System.IntPtr HKEY_CURRENT_USER;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly System.IntPtr HKEY_LOCAL_MACHINE;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly System.IntPtr HKEY_USERS;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly System.IntPtr HKEY_PERFORMANCE_DATA;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly System.IntPtr HKEY_CURRENT_CONFIG;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly System.IntPtr HKEY_DYN_DATA;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x38")]
		private static readonly string[] s_hkeyNames;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x18")]
		private Microsoft.Win32.SafeHandles.SafeRegistryHandle _hkey;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x20")]
		private string _keyName;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x28")]
		private bool _remoteKey;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x2C")]
		private RegistryKey.StateFlags _state;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x30")]
		private RegistryKeyPermissionCheck _checkMode;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x34")]
		private RegistryView _regView;

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		[System.Flags]
		private enum StateFlags
		{
			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			Dirty = 1,
			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			SystemKey = 2,
			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			WriteAccess = 4,
			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			PerfData = 8
		}
	}
}
