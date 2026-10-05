using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000375 RID: 885
	[Token(Token = "0x2000375")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SoapServices
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000353")]
		public static string XmlNsForClrTypeWithAssembly
		{
			[Token(Token = "0x6001D11")]
			[Address(RVA = "0x4B909C0", Offset = "0x4B8F5C0", VA = "0x184B909C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000354")]
		public static string XmlNsForClrTypeWithNs
		{
			[Token(Token = "0x6001D12")]
			[Address(RVA = "0x4B90A20", Offset = "0x4B8F620", VA = "0x184B90A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000355")]
		public static string XmlNsForClrTypeWithNsAndAssembly
		{
			[Token(Token = "0x6001D13")]
			[Address(RVA = "0x4B909F0", Offset = "0x4B8F5F0", VA = "0x184B909F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x4B8F470", Offset = "0x4B8E070", VA = "0x184B8F470")]
		public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			return null;
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x4B8F8C0", Offset = "0x4B8E4C0", VA = "0x184B8F8C0")]
		private static string GetNameKey(string name, string namspace)
		{
			return null;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x4B8F6D0", Offset = "0x4B8E2D0", VA = "0x184B8F6D0")]
		private static string GetAssemblyName(System.Reflection.MethodBase mb)
		{
			return null;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000129F0 File Offset: 0x00010BF0
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x4B8F920", Offset = "0x4B8E520", VA = "0x184B8F920")]
		public static bool GetXmlElementForInteropType(System.Type type, out string xmlElement, out string xmlNamespace)
		{
			return default(bool);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x4B8FA40", Offset = "0x4B8E640", VA = "0x184B8FA40")]
		public static string GetXmlNamespaceForMethodCall(System.Reflection.MethodBase mb)
		{
			return null;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x4B8FB10", Offset = "0x4B8E710", VA = "0x184B8FB10")]
		public static string GetXmlNamespaceForMethodResponse(System.Reflection.MethodBase mb)
		{
			return null;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00012A08 File Offset: 0x00010C08
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x4B8FBE0", Offset = "0x4B8E7E0", VA = "0x184B8FBE0")]
		public static bool GetXmlTypeForInteropType(System.Type type, out string xmlType, out string xmlTypeNamespace)
		{
			return default(bool);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x4B903D0", Offset = "0x4B8EFD0", VA = "0x184B903D0")]
		public static void PreLoad(System.Reflection.Assembly assembly)
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x4B8FCD0", Offset = "0x4B8E8D0", VA = "0x184B8FCD0")]
		public static void PreLoad(System.Type type)
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x4B904A0", Offset = "0x4B8F0A0", VA = "0x184B904A0")]
		public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, System.Type type)
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x4B90650", Offset = "0x4B8F250", VA = "0x184B90650")]
		public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, System.Type type)
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x4B8F600", Offset = "0x4B8E200", VA = "0x184B8F600")]
		private static string EncodeNs(string ns)
		{
			return null;
		}

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Collections.Hashtable _xmlTypes;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Collections.Hashtable _xmlElements;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Collections.Hashtable _soapActions;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static System.Collections.Hashtable _soapActionsMethods;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static System.Collections.Hashtable _typeInfos;

		// Token: 0x02000376 RID: 886
		[Token(Token = "0x2000376")]
		private class TypeInfo
		{
			// Token: 0x06001D21 RID: 7457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D21")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TypeInfo()
			{
			}

			// Token: 0x04000F8F RID: 3983
			[Token(Token = "0x4000F8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public System.Collections.Hashtable Attributes;

			// Token: 0x04000F90 RID: 3984
			[Token(Token = "0x4000F90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public System.Collections.Hashtable Elements;
		}
	}
}
