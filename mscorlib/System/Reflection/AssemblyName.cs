using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Mono;

namespace System.Reflection
{
	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Runtime.InteropServices.ComDefaultInterface(typeof(System.Runtime.InteropServices._AssemblyName))]
	[System.Serializable]
	[StructLayout(0)]
	public sealed class AssemblyName : System.ICloneable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.InteropServices._AssemblyName
	{
		// Token: 0x0600263A RID: 9786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x4C09A00", Offset = "0x4C08600", VA = "0x184C09A00")]
		public AssemblyName()
		{
		}

		// Token: 0x0600263B RID: 9787
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x4C09730", Offset = "0x4C08330", VA = "0x184C09730")]
		[MethodImpl(4096)]
		private static extern bool ParseAssemblyName(System.IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined);

		// Token: 0x0600263C RID: 9788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x4C097A0", Offset = "0x4C083A0", VA = "0x184C097A0")]
		public AssemblyName(string assemblyName)
		{
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x4C09A20", Offset = "0x4C08620", VA = "0x184C09A20")]
		internal AssemblyName(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000546")]
		public string Name
		{
			[Token(Token = "0x600263E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600263F")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000547")]
		public string CodeBase
		{
			[Token(Token = "0x6002640")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000548")]
		public System.Globalization.CultureInfo CultureInfo
		{
			[Token(Token = "0x6002641")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002642")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000154E0 File Offset: 0x000136E0
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000549")]
		public AssemblyNameFlags Flags
		{
			[Token(Token = "0x6002643")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return AssemblyNameFlags.None;
			}
			[Token(Token = "0x6002644")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700054A")]
		public string FullName
		{
			[Token(Token = "0x6002645")]
			[Address(RVA = "0x4C0A020", Offset = "0x4C08C20", VA = "0x184C0A020")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054B")]
		public System.Version Version
		{
			[Token(Token = "0x6002646")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002647")]
			[Address(RVA = "0x4C0A4F0", Offset = "0x4C090F0", VA = "0x184C0A4F0")]
			set
			{
			}
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x4C09770", Offset = "0x4C08370", VA = "0x184C09770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002649")]
		[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
		public byte[] GetPublicKey()
		{
			return null;
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x4C094B0", Offset = "0x4C080B0", VA = "0x184C094B0")]
		public byte[] GetPublicKeyToken()
		{
			return null;
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x000154F8 File Offset: 0x000136F8
		[Token(Token = "0x1700054C")]
		private bool IsPublicKeyValid
		{
			[Token(Token = "0x600264B")]
			[Address(RVA = "0x4C0A460", Offset = "0x4C09060", VA = "0x184C0A460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600264C")]
		[Address(RVA = "0x4C095C0", Offset = "0x4C081C0", VA = "0x184C095C0")]
		private byte[] InternalGetPublicKeyToken()
		{
			return null;
		}

		// Token: 0x0600264D RID: 9805
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x4C0A4E0", Offset = "0x4C090E0", VA = "0x184C0A4E0")]
		[MethodImpl(4096)]
		private unsafe static extern void get_public_token(byte* token, byte* pubkey, int len);

		// Token: 0x0600264E RID: 9806 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x4C08B30", Offset = "0x4C07730", VA = "0x184C08B30")]
		private byte[] ComputePublicKeyToken()
		{
			return null;
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264F")]
		[Address(RVA = "0x4C09740", Offset = "0x4C08340", VA = "0x184C09740")]
		public void SetPublicKey(byte[] publicKey)
		{
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002650")]
		[Address(RVA = "0x4C091C0", Offset = "0x4C07DC0", VA = "0x184C091C0", Slot = "5")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x4C08A20", Offset = "0x4C07620", VA = "0x184C08A20", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x4C096B0", Offset = "0x4C082B0", VA = "0x184C096B0", Slot = "6")]
		public void OnDeserialization(object sender)
		{
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x4C08FE0", Offset = "0x4C07BE0", VA = "0x184C08FE0")]
		public static AssemblyName GetAssemblyName(string assemblyFile)
		{
			return null;
		}

		// Token: 0x06002654 RID: 9812
		[Token(Token = "0x6002654")]
		[Address(RVA = "0x4C091B0", Offset = "0x4C07DB0", VA = "0x184C091B0")]
		[MethodImpl(4096)]
		private unsafe static extern MonoAssemblyName* GetNativeName(System.IntPtr assembly_ptr);

		// Token: 0x06002655 RID: 9813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x4C08CE0", Offset = "0x4C078E0", VA = "0x184C08CE0")]
		internal unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x4C08BC0", Offset = "0x4C077C0", VA = "0x184C08BC0")]
		internal static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			return null;
		}

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string codebase;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int major;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int minor;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x40015E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int build;

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x40015E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int revision;

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x40015E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private System.Globalization.CultureInfo cultureinfo;

		// Token: 0x040015E5 RID: 5605
		[Token(Token = "0x40015E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AssemblyNameFlags flags;

		// Token: 0x040015E6 RID: 5606
		[Token(Token = "0x40015E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private System.Configuration.Assemblies.AssemblyHashAlgorithm hashalg;

		// Token: 0x040015E7 RID: 5607
		[Token(Token = "0x40015E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private StrongNameKeyPair keypair;

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private byte[] publicKey;

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private byte[] keyToken;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private System.Configuration.Assemblies.AssemblyVersionCompatibility versioncompat;

		// Token: 0x040015EB RID: 5611
		[Token(Token = "0x40015EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Version version;

		// Token: 0x040015EC RID: 5612
		[Token(Token = "0x40015EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ProcessorArchitecture processor_architecture;

		// Token: 0x040015ED RID: 5613
		[Token(Token = "0x40015ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private AssemblyContentType contentType;
	}
}
