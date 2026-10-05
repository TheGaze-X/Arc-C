using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	internal class NativeNameAttribute : Attribute
	{
		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public string Name
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59CBCD0", Offset = "0x59CA8D0", VA = "0x1859CBCD0")]
		public NativeNameAttribute(string name)
		{
		}
	}
}
