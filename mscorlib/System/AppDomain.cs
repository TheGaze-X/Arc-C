using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[StructLayout(0)]
	public sealed class AppDomain : System.MarshalByRefObject
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		[Intrinsic]
		internal static bool IsAppXModel()
		{
			return default(bool);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private AppDomain()
		{
		}

		// Token: 0x06000F2B RID: 3883
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x4D2F000", Offset = "0x4D2DC00", VA = "0x184D2F000")]
		[MethodImpl(4096)]
		private extern System.AppDomainSetup getSetup();

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000152")]
		internal System.AppDomainSetup SetupInformationNoCopy
		{
			[Token(Token = "0x6000F2C")]
			[Address(RVA = "0x4D2F000", Offset = "0x4D2DC00", VA = "0x184D2F000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000153")]
		public string BaseDirectory
		{
			[Token(Token = "0x6000F2D")]
			[Address(RVA = "0x4D2F010", Offset = "0x4D2DC10", VA = "0x184D2F010", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F2E RID: 3886
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x4D2EDF0", Offset = "0x4D2D9F0", VA = "0x184D2EDF0")]
		[MethodImpl(4096)]
		private extern string getFriendlyName();

		// Token: 0x06000F2F RID: 3887
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x4D2EFE0", Offset = "0x4D2DBE0", VA = "0x184D2EFE0")]
		[MethodImpl(4096)]
		private static extern System.AppDomain getCurDomain();

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000154")]
		public static System.AppDomain CurrentDomain
		{
			[Token(Token = "0x6000F30")]
			[Address(RVA = "0x4D2EFE0", Offset = "0x4D2DBE0", VA = "0x184D2EFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F31 RID: 3889
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x4D2DE50", Offset = "0x4D2CA50", VA = "0x184D2DE50")]
		[MethodImpl(4096)]
		private extern System.Reflection.Assembly[] GetAssemblies(bool refOnly);

		// Token: 0x06000F32 RID: 3890 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x4D2DE40", Offset = "0x4D2CA40", VA = "0x184D2DE40", Slot = "7")]
		public System.Reflection.Assembly[] GetAssemblies()
		{
			return null;
		}

		// Token: 0x06000F33 RID: 3891
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x4D2DE60", Offset = "0x4D2CA60", VA = "0x184D2DE60", Slot = "8")]
		[MethodImpl(4096)]
		public extern object GetData(string name);

		// Token: 0x06000F34 RID: 3892 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		public override object InitializeLifetimeService()
		{
			return null;
		}

		// Token: 0x06000F35 RID: 3893
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x4D2E2A0", Offset = "0x4D2CEA0", VA = "0x184D2E2A0")]
		[MethodImpl(4096)]
		internal extern System.Reflection.Assembly LoadAssembly(string assemblyRef, System.Security.Policy.Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark);

		// Token: 0x06000F36 RID: 3894 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x4D2E3D0", Offset = "0x4D2CFD0", VA = "0x184D2E3D0", Slot = "9")]
		public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef)
		{
			return null;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x4D2E2B0", Offset = "0x4D2CEB0", VA = "0x184D2E2B0")]
		internal System.Reflection.Assembly LoadSatellite(System.Reflection.AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x4D2E670", Offset = "0x4D2D270", VA = "0x184D2E670", Slot = "10")]
		[System.Obsolete("Use an overload that does not take an Evidence parameter")]
		[MethodImpl(8)]
		public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity)
		{
			return null;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x4D2E520", Offset = "0x4D2D120", VA = "0x184D2E520", Slot = "11")]
		[MethodImpl(8)]
		public System.Reflection.Assembly Load(string assemblyString)
		{
			return null;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x4D2E3E0", Offset = "0x4D2CFE0", VA = "0x184D2E3E0")]
		internal System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x06000F3B RID: 3899
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x4D2E050", Offset = "0x4D2CC50", VA = "0x184D2E050")]
		[MethodImpl(4096)]
		private static extern System.AppDomain InternalSetDomainByID(int domain_id);

		// Token: 0x06000F3C RID: 3900
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x4D2E060", Offset = "0x4D2CC60", VA = "0x184D2E060")]
		[MethodImpl(4096)]
		private static extern System.AppDomain InternalSetDomain(System.AppDomain context);

		// Token: 0x06000F3D RID: 3901
		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x4D2E030", Offset = "0x4D2CC30", VA = "0x184D2E030")]
		[MethodImpl(4096)]
		internal static extern void InternalPushDomainRefByID(int domain_id);

		// Token: 0x06000F3E RID: 3902
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x4D2E020", Offset = "0x4D2CC20", VA = "0x184D2E020")]
		[MethodImpl(4096)]
		internal static extern void InternalPopDomainRef();

		// Token: 0x06000F3F RID: 3903
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x4D2E040", Offset = "0x4D2CC40", VA = "0x184D2E040")]
		[MethodImpl(4096)]
		internal static extern System.Runtime.Remoting.Contexts.Context InternalSetContext(System.Runtime.Remoting.Contexts.Context context);

		// Token: 0x06000F40 RID: 3904
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x4D2E000", Offset = "0x4D2CC00", VA = "0x184D2E000")]
		[MethodImpl(4096)]
		internal static extern System.Runtime.Remoting.Contexts.Context InternalGetContext();

		// Token: 0x06000F41 RID: 3905
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x4D2E000", Offset = "0x4D2CC00", VA = "0x184D2E000")]
		[MethodImpl(4096)]
		internal static extern System.Runtime.Remoting.Contexts.Context InternalGetDefaultContext();

		// Token: 0x06000F42 RID: 3906
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x4D2E010", Offset = "0x4D2CC10", VA = "0x184D2E010")]
		[MethodImpl(4096)]
		internal static extern string InternalGetProcessGuid(string newguid);

		// Token: 0x06000F43 RID: 3907 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x4D2E070", Offset = "0x4D2CC70", VA = "0x184D2E070")]
		internal static object InvokeInDomainByID(int domain_id, System.Reflection.MethodInfo method, object obj, object[] args)
		{
			return null;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x4D2DF50", Offset = "0x4D2CB50", VA = "0x184D2DF50")]
		internal static string GetProcessGuid()
		{
			return null;
		}

		// Token: 0x06000F45 RID: 3909
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		private static extern bool InternalIsFinalizingForUnload(int domain_id);

		// Token: 0x06000F46 RID: 3910 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x4D2E280", Offset = "0x4D2CE80", VA = "0x184D2E280")]
		public bool IsFinalizingForUnload()
		{
			return default(bool);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x4D2EFF0", Offset = "0x4D2DBF0", VA = "0x184D2EFF0")]
		private int getDomainID()
		{
			return 0;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x4D2EDF0", Offset = "0x4D2D9F0", VA = "0x184D2EDF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x4D2D500", Offset = "0x4D2C100", VA = "0x184D2D500")]
		private void DoAssemblyLoad(System.Reflection.Assembly assembly)
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x4D2D590", Offset = "0x4D2C190", VA = "0x184D2D590")]
		private System.Reflection.Assembly DoAssemblyResolve(string name, System.Reflection.Assembly requestingAssembly, bool refonly)
		{
			return null;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x4D2DAF0", Offset = "0x4D2C6F0", VA = "0x184D2DAF0")]
		internal System.Reflection.Assembly DoTypeResolve(string name)
		{
			return null;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x4D2D980", Offset = "0x4D2C580", VA = "0x184D2D980")]
		internal System.Reflection.Assembly DoResourceResolve(string name, System.Reflection.Assembly requesting)
		{
			return null;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x4D2D960", Offset = "0x4D2C560", VA = "0x184D2D960")]
		private void DoDomainUnload()
		{
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x4D2DE70", Offset = "0x4D2CA70", VA = "0x184D2DE70")]
		internal byte[] GetMarshalledDomainObjRef()
		{
			return null;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x4D2EC90", Offset = "0x4D2D890", VA = "0x184D2EC90")]
		internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm)
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000F50 RID: 3920 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F51 RID: 3921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event System.AssemblyLoadEventHandler AssemblyLoad
		{
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x4D2EE00", Offset = "0x4D2DA00", VA = "0x184D2EE00", Slot = "12")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F51")]
			[Address(RVA = "0x4D2F040", Offset = "0x4D2DC40", VA = "0x184D2F040", Slot = "13")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000F52 RID: 3922 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event System.EventHandler DomainUnload
		{
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x4D2EEA0", Offset = "0x4D2DAA0", VA = "0x184D2EEA0", Slot = "14")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0x4D2F0E0", Offset = "0x4D2DCE0", VA = "0x184D2F0E0", Slot = "15")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000F54 RID: 3924 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event System.UnhandledExceptionEventHandler UnhandledException
		{
			[Token(Token = "0x6000F54")]
			[Address(RVA = "0x4D2EF40", Offset = "0x4D2DB40", VA = "0x184D2EF40", Slot = "16")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x4D2F180", Offset = "0x4D2DD80", VA = "0x184D2F180", Slot = "17")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.IntPtr _mono_app_domain;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _process_guid;

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		[System.ThreadStatic]
		private static System.Collections.Generic.Dictionary<string, object> type_resolve_in_progress;

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		[System.ThreadStatic]
		private static System.Collections.Generic.Dictionary<string, object> assembly_resolve_in_progress;

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		[System.ThreadStatic]
		private static System.Collections.Generic.Dictionary<string, object> assembly_resolve_in_progress_refonly;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object _evidence;

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object _granted;

		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _principalPolicy;

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.ResolveEventHandler AssemblyResolve;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.EventHandler ProcessExit;

		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.ResolveEventHandler ResourceResolve;

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.ResolveEventHandler TypeResolve;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs> FirstChanceException;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object _domain_manager;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.ResolveEventHandler ReflectionOnlyAssemblyResolve;

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private object _activation;

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private object _applicationIdentity;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private System.Collections.Generic.List<string> compatibility_switch;
	}
}
