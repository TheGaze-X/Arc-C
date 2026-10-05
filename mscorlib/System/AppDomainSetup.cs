using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public sealed class AppDomainSetup
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public AppDomainSetup()
		{
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x4D2D0C0", Offset = "0x4D2BCC0", VA = "0x184D2D0C0")]
		private static string GetAppBase(string appBase)
		{
			return null;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000166")]
		public string ApplicationBase
		{
			[Token(Token = "0x6000F87")]
			[Address(RVA = "0x4D2D4F0", Offset = "0x4D2C0F0", VA = "0x184D2D4F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string application_base;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string application_name;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string cache_path;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string configuration_file;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string dynamic_base;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string license_file;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string private_bin_path;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string private_bin_path_probe;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string shadow_copy_directories;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string shadow_copy_files;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool publisher_policy;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool path_changed;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int loader_optimization;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool disallow_binding_redirects;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool disallow_code_downloads;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private object _activationArguments;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object domain_initializer;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private object application_trust;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string[] domain_initializer_args;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool disallow_appbase_probe;

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private byte[] configuration_bytes;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private byte[] serialized_non_primitives;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string manager_assembly;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string manager_type;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string[] partial_visible_assemblies;
	}
}
