using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading;
using Il2CppDummyDll;
using Mono;

namespace System.Reflection
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComDefaultInterface(typeof(System.Runtime.InteropServices._Assembly))]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public class Assembly : ICustomAttributeProvider, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Assembly
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700053E")]
		public virtual string CodeBase
		{
			[Token(Token = "0x6002603")]
			[Address(RVA = "0x4BCF780", Offset = "0x4BCE380", VA = "0x184BCF780", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700053F")]
		public virtual string EscapedCodeBase
		{
			[Token(Token = "0x6002604")]
			[Address(RVA = "0x4BCF7D0", Offset = "0x4BCE3D0", VA = "0x184BCF7D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000540")]
		public virtual string FullName
		{
			[Token(Token = "0x6002605")]
			[Address(RVA = "0x4BCF820", Offset = "0x4BCE420", VA = "0x184BCF820", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x17000541")]
		internal virtual System.IntPtr MonoAssembly
		{
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x4BCF8C0", Offset = "0x4BCE4C0", VA = "0x184BCF8C0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000542")]
		public virtual string Location
		{
			[Token(Token = "0x6002607")]
			[Address(RVA = "0x4BCF870", Offset = "0x4BCE470", VA = "0x184BCF870", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002608")]
		[Address(RVA = "0x4BCEEB0", Offset = "0x4BCDAB0", VA = "0x184BCEEB0", Slot = "13")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x4BCF550", Offset = "0x4BCE150", VA = "0x184BCF550", Slot = "14")]
		public virtual bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x4BCE950", Offset = "0x4BCD550", VA = "0x184BCE950", Slot = "15")]
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600260B")]
		[Address(RVA = "0x4BCE900", Offset = "0x4BCD500", VA = "0x184BCE900", Slot = "16")]
		public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600260C")]
		[Address(RVA = "0x4BCEAC0", Offset = "0x4BCD6C0", VA = "0x184BCEAC0", Slot = "17")]
		public virtual System.IO.Stream GetManifestResourceStream(string name)
		{
			return null;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x4BCEB40", Offset = "0x4BCD740", VA = "0x184BCEB40")]
		internal System.IO.Stream GetManifestResourceStream(System.Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x4BCEB10", Offset = "0x4BCD710", VA = "0x184BCEB10")]
		internal System.IO.Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck)
		{
			return null;
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x4BCEF50", Offset = "0x4BCDB50", VA = "0x184BCEF50")]
		internal string GetSimpleName()
		{
			return null;
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x4BCEF00", Offset = "0x4BCDB00", VA = "0x184BCEF00")]
		internal byte[] GetPublicKey()
		{
			return null;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x4BCF0E0", Offset = "0x4BCDCE0", VA = "0x184BCF0E0")]
		internal System.Version GetVersion()
		{
			return null;
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x4BCE9D0", Offset = "0x4BCD5D0", VA = "0x184BCE9D0")]
		private AssemblyNameFlags GetFlags()
		{
			return AssemblyNameFlags.None;
		}

		// Token: 0x06002613 RID: 9747
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x4BCF090", Offset = "0x4BCDC90", VA = "0x184BCF090", Slot = "18")]
		[MethodImpl(4096)]
		internal virtual extern System.Type[] GetTypes(bool exportedOnly);

		// Token: 0x06002614 RID: 9748 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x4BCF0A0", Offset = "0x4BCDCA0", VA = "0x184BCF0A0", Slot = "19")]
		public virtual System.Type[] GetTypes()
		{
			return null;
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x4BCF000", Offset = "0x4BCDC00", VA = "0x184BCF000", Slot = "20")]
		public virtual System.Type GetType(string name, bool throwOnError)
		{
			return null;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x4BCEFA0", Offset = "0x4BCDBA0", VA = "0x184BCEFA0", Slot = "21")]
		public virtual System.Type GetType(string name)
		{
			return null;
		}

		// Token: 0x06002617 RID: 9751
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x4BCF540", Offset = "0x4BCE140", VA = "0x184BCF540")]
		[MethodImpl(4096)]
		internal extern System.Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase);

		// Token: 0x06002618 RID: 9752
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x4BCF130", Offset = "0x4BCDD30", VA = "0x184BCF130")]
		[MethodImpl(4096)]
		internal static extern void InternalGetAssemblyName(string assemblyFile, out MonoAssemblyName aname, out string codebase);

		// Token: 0x06002619 RID: 9753 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x4BCEE20", Offset = "0x4BCDA20", VA = "0x184BCEE20", Slot = "22")]
		public virtual AssemblyName GetName(bool copiedName)
		{
			return null;
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x4BCEE70", Offset = "0x4BCDA70", VA = "0x184BCEE70", Slot = "23")]
		public virtual AssemblyName GetName()
		{
			return null;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x4BCE810", Offset = "0x4BCD410", VA = "0x184BCE810")]
		public static Assembly GetAssembly(System.Type type)
		{
			return null;
		}

		// Token: 0x0600261D RID: 9757
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x4B69290", Offset = "0x4B67E90", VA = "0x184B69290")]
		[MethodImpl(4096)]
		public static extern Assembly GetEntryAssembly();

		// Token: 0x0600261E RID: 9758 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x4BCF140", Offset = "0x4BCDD40", VA = "0x184BCF140")]
		internal RuntimeAssembly InternalGetSatelliteAssembly(string name, System.Globalization.CultureInfo culture, System.Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x0600261F RID: 9759
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x4BCF5A0", Offset = "0x4BCE1A0", VA = "0x184BCF5A0")]
		[MethodImpl(4096)]
		private static extern Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark);

		// Token: 0x06002620 RID: 9760 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x4BCF5B0", Offset = "0x4BCE1B0", VA = "0x184BCF5B0")]
		[System.Obsolete]
		[MethodImpl(8)]
		public static Assembly LoadFrom(string assemblyFile, System.Security.Policy.Evidence securityEvidence)
		{
			return null;
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x4BCF6D0", Offset = "0x4BCE2D0", VA = "0x184BCF6D0")]
		public static Assembly Load(string assemblyString)
		{
			return null;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x4BCF700", Offset = "0x4BCE300", VA = "0x184BCF700")]
		public static Assembly Load(AssemblyName assemblyRef)
		{
			return null;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002623")]
		[Address(RVA = "0x4BCF730", Offset = "0x4BCE330", VA = "0x184BCF730")]
		[MethodImpl(8)]
		public static Assembly ReflectionOnlyLoad(string assemblyString)
		{
			return null;
		}

		// Token: 0x06002624 RID: 9764
		[Token(Token = "0x6002624")]
		[Address(RVA = "0x4BCF960", Offset = "0x4BCE560", VA = "0x184BCF960")]
		[MethodImpl(4096)]
		private static extern Assembly load_with_partial_name(string name, System.Security.Policy.Evidence e);

		// Token: 0x06002625 RID: 9765 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002625")]
		[Address(RVA = "0x4BCF670", Offset = "0x4BCE270", VA = "0x184BCF670")]
		[System.Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static Assembly LoadWithPartialName(string partialName, System.Security.Policy.Evidence securityEvidence)
		{
			return null;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002626")]
		[Address(RVA = "0x4BCF5D0", Offset = "0x4BCE1D0", VA = "0x184BCF5D0")]
		internal static Assembly LoadWithPartialName(string partialName, System.Security.Policy.Evidence securityEvidence, bool oldBehavior)
		{
			return null;
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002627")]
		[Address(RVA = "0x4BCEDE0", Offset = "0x4BCD9E0", VA = "0x184BCEDE0", Slot = "24")]
		public Module[] GetModules()
		{
			return null;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x4BCED60", Offset = "0x4BCD960", VA = "0x184BCED60", Slot = "25")]
		internal virtual Module[] GetModulesInternal()
		{
			return null;
		}

		// Token: 0x06002629 RID: 9769
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x4BCE9A0", Offset = "0x4BCD5A0", VA = "0x184BCE9A0")]
		[MethodImpl(4096)]
		public static extern Assembly GetExecutingAssembly();

		// Token: 0x0600262A RID: 9770
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x4BCE8F0", Offset = "0x4BCD4F0", VA = "0x184BCE8F0")]
		[MethodImpl(4096)]
		public static extern Assembly GetCallingAssembly();

		// Token: 0x0600262B RID: 9771 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x4BCEA70", Offset = "0x4BCD670", VA = "0x184BCEA70", Slot = "26")]
		public virtual string[] GetManifestResourceNames()
		{
			return null;
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x4BCEA20", Offset = "0x4BCD620", VA = "0x184BCEA20", Slot = "27")]
		public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			return null;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x17000543")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual bool ReflectionOnly
		{
			[Token(Token = "0x600262D")]
			[Address(RVA = "0x4BCF910", Offset = "0x4BCE510", VA = "0x184BCF910", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x4BCE7A0", Offset = "0x4BCD3A0", VA = "0x184BCE7A0")]
		private static System.Exception CreateNIE()
		{
			return null;
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x17000544")]
		[MonoTODO]
		public bool IsFullyTrusted
		{
			[Token(Token = "0x6002631")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x4BCF060", Offset = "0x4BCDC60", VA = "0x184BCF060", Slot = "29")]
		public virtual System.Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x4BCED30", Offset = "0x4BCD930", VA = "0x184BCED30", Slot = "30")]
		public virtual Module GetModule(string name)
		{
			return null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x4BCEDB0", Offset = "0x4BCD9B0", VA = "0x184BCEDB0", Slot = "31")]
		public virtual Module[] GetModules(bool getResourceModules)
		{
			return null;
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x17000545")]
		public virtual bool IsDynamic
		{
			[Token(Token = "0x6002635")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x4BCF970", Offset = "0x4BCE570", VA = "0x184BCF970")]
		public static bool operator ==(Assembly left, Assembly right)
		{
			return default(bool);
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000154C8 File Offset: 0x000136C8
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x4BCFA00", Offset = "0x4BCE600", VA = "0x184BCFA00")]
		public static bool operator !=(Assembly left, Assembly right)
		{
			return default(bool);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Assembly()
		{
		}

		// Token: 0x0200052B RID: 1323
		[Token(Token = "0x200052B")]
		internal class ResolveEventHolder
		{
			// Token: 0x06002639 RID: 9785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002639")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ResolveEventHolder()
			{
			}
		}
	}
}
