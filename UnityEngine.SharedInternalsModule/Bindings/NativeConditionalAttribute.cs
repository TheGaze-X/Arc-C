using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeConditionalAttribute : Attribute
	{
		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public string Condition
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public string StubReturnStatement
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public bool Enabled
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x59CB9E0", Offset = "0x59CA5E0", VA = "0x1859CB9E0")]
		public NativeConditionalAttribute(string condition)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59CB990", Offset = "0x59CA590", VA = "0x1859CB990")]
		public NativeConditionalAttribute(string condition, string stubReturnStatement)
		{
		}
	}
}
