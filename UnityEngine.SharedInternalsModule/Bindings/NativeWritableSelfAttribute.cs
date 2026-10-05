using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal sealed class NativeWritableSelfAttribute : Attribute
	{
		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public bool WritableSelf
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4E17ED0", Offset = "0x4E16AD0", VA = "0x184E17ED0")]
		public NativeWritableSelfAttribute()
		{
		}
	}
}
