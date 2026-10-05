using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativePropertyAttribute : NativeMethodAttribute
	{
		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public TargetType TargetType
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public NativePropertyAttribute()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x59CBDF0", Offset = "0x59CA9F0", VA = "0x1859CBDF0")]
		public NativePropertyAttribute(string name)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59CBE00", Offset = "0x59CAA00", VA = "0x1859CBE00")]
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x59CBE40", Offset = "0x59CAA40", VA = "0x1859CBE40")]
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType, bool isThreadSafe)
		{
		}
	}
}
