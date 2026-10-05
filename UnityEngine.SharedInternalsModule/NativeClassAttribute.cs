using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	[VisibleToOtherModules]
	internal sealed class NativeClassAttribute : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		private string QualifiedNativeName
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		private string Declaration
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59CB920", Offset = "0x59CA520", VA = "0x1859CB920")]
		public NativeClassAttribute(string qualifiedCppName)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public NativeClassAttribute(string qualifiedCppName, string declaration)
		{
		}
	}
}
