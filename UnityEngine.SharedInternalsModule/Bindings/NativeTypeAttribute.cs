using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	internal class NativeTypeAttribute : Attribute
	{
		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public string Header
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public string IntermediateScriptingStructName
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public CodegenOptions CodegenOptions
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x59CC020", Offset = "0x59CAC20", VA = "0x1859CC020")]
		public NativeTypeAttribute()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59CBFB0", Offset = "0x59CABB0", VA = "0x1859CBFB0")]
		public NativeTypeAttribute(CodegenOptions codegenOptions)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x59CBE80", Offset = "0x59CAA80", VA = "0x1859CBE80")]
		public NativeTypeAttribute(string header)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x59CBFE0", Offset = "0x59CABE0", VA = "0x1859CBFE0")]
		public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
		{
		}
	}
}
