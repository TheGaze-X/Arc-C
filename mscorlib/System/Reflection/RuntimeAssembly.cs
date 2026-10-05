using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComDefaultInterface(typeof(System.Runtime.InteropServices._Assembly))]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	internal class RuntimeAssembly : Assembly
	{
		// Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x4C1F7B0", Offset = "0x4C1E3B0", VA = "0x184C1F7B0")]
		protected RuntimeAssembly()
		{
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x4C1F370", Offset = "0x4C1DF70", VA = "0x184C1F370", Slot = "13")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x4C1F690", Offset = "0x4C1E290", VA = "0x184C1F690")]
		internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, System.Security.Policy.Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x4C1F590", Offset = "0x4C1E190", VA = "0x184C1F590")]
		internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, System.Security.Policy.Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x4C1F270", Offset = "0x4C1DE70", VA = "0x184C1F270", Slot = "22")]
		public override AssemblyName GetName(bool copiedName)
		{
			return null;
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x4C1F430", Offset = "0x4C1E030", VA = "0x184C1F430", Slot = "29")]
		public override System.Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x4C1EF80", Offset = "0x4C1DB80", VA = "0x184C1EF80", Slot = "30")]
		public override Module GetModule(string name)
		{
			return null;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x4C1F120", Offset = "0x4C1DD20", VA = "0x184C1F120", Slot = "31")]
		public override Module[] GetModules(bool getResourceModules)
		{
			return null;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x4C1E8F0", Offset = "0x4C1D4F0", VA = "0x184C1E8F0")]
		internal static byte[] GetAotId()
		{
			return null;
		}

		// Token: 0x06002678 RID: 9848
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x4C1E940", Offset = "0x4C1D540", VA = "0x184C1E940")]
		[MethodImpl(4096)]
		private static extern string get_code_base(Assembly a, bool escaped);

		// Token: 0x06002679 RID: 9849
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x4C1F8A0", Offset = "0x4C1E4A0", VA = "0x184C1F8A0")]
		[MethodImpl(4096)]
		private extern string get_location();

		// Token: 0x0600267A RID: 9850
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x4C1F840", Offset = "0x4C1E440", VA = "0x184C1F840")]
		[MethodImpl(4096)]
		internal static extern string get_fullname(Assembly a);

		// Token: 0x0600267B RID: 9851
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal static extern bool GetAotIdInternal(byte[] aotid);

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600267C RID: 9852
		[Token(Token = "0x17000551")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override extern bool ReflectionOnly { [Token(Token = "0x600267C")] [Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0", Slot = "28")] [MethodImpl(4096)] get; }

		// Token: 0x0600267D RID: 9853 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x4C1E940", Offset = "0x4C1D540", VA = "0x184C1E940")]
		internal static string GetCodeBase(Assembly a, bool escaped)
		{
			return null;
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000552")]
		public override string CodeBase
		{
			[Token(Token = "0x600267E")]
			[Address(RVA = "0x4C1F820", Offset = "0x4C1E420", VA = "0x184C1F820", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000553")]
		public override string EscapedCodeBase
		{
			[Token(Token = "0x600267F")]
			[Address(RVA = "0x4C1F830", Offset = "0x4C1E430", VA = "0x184C1F830", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000554")]
		public override string FullName
		{
			[Token(Token = "0x6002680")]
			[Address(RVA = "0x4C1F840", Offset = "0x4C1E440", VA = "0x184C1F840", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x17000555")]
		internal override System.IntPtr MonoAssembly
		{
			[Token(Token = "0x6002681")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000556")]
		public override string Location
		{
			[Token(Token = "0x6002682")]
			[Address(RVA = "0x4C1F850", Offset = "0x4C1E450", VA = "0x184C1F850", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002683 RID: 9859
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x4C1EA30", Offset = "0x4C1D630", VA = "0x184C1EA30")]
		[MethodImpl(4096)]
		private extern bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info);

		// Token: 0x06002684 RID: 9860 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x4C1EA40", Offset = "0x4C1D640", VA = "0x184C1EA40", Slot = "27")]
		public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			return null;
		}

		// Token: 0x06002685 RID: 9861
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x4C1EBA0", Offset = "0x4C1D7A0", VA = "0x184C1EBA0", Slot = "26")]
		[MethodImpl(4096)]
		public override extern string[] GetManifestResourceNames();

		// Token: 0x06002686 RID: 9862
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x4C1EB90", Offset = "0x4C1D790", VA = "0x184C1EB90")]
		[MethodImpl(4096)]
		internal extern System.IntPtr GetManifestResourceInternal(string name, out int size, out Module module);

		// Token: 0x06002687 RID: 9863 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002687")]
		[Address(RVA = "0x4C1EBB0", Offset = "0x4C1D7B0", VA = "0x184C1EBB0", Slot = "17")]
		public override System.IO.Stream GetManifestResourceStream(string name)
		{
			return null;
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x4C1F520", Offset = "0x4C1E120", VA = "0x184C1F520", Slot = "14")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x4C1E950", Offset = "0x4C1D550", VA = "0x184C1E950", Slot = "15")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x4C1E9B0", Offset = "0x4C1D5B0", VA = "0x184C1E9B0", Slot = "16")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x0600268B RID: 9867
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x4C1F110", Offset = "0x4C1DD10", VA = "0x184C1F110", Slot = "25")]
		[MethodImpl(4096)]
		internal override extern Module[] GetModulesInternal();

		// Token: 0x0600268C RID: 9868 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x4C1EA20", Offset = "0x4C1D620", VA = "0x184C1EA20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x4C1E800", Offset = "0x4C1D400", VA = "0x184C1E800", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x4C1F750", Offset = "0x4C1E350", VA = "0x184C1F750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.IntPtr _mono_assembly;

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _evidence;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Assembly.ResolveEventHolder resolve_event_holder;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object _minimum;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _optional;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _refuse;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _granted;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object _denied;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal bool fromByteArray;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string assemblyName;

		// Token: 0x02000532 RID: 1330
		[Token(Token = "0x2000532")]
		internal class UnmanagedMemoryStreamForModule : System.IO.UnmanagedMemoryStream
		{
			// Token: 0x0600268F RID: 9871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600268F")]
			[Address(RVA = "0x4C285E0", Offset = "0x4C271E0", VA = "0x184C285E0")]
			public unsafe UnmanagedMemoryStreamForModule(byte* pointer, long length, Module module)
			{
			}

			// Token: 0x06002690 RID: 9872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002690")]
			[Address(RVA = "0x4C28590", Offset = "0x4C27190", VA = "0x184C28590", Slot = "19")]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x04001609 RID: 5641
			[Token(Token = "0x4001609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Module module;
		}
	}
}
