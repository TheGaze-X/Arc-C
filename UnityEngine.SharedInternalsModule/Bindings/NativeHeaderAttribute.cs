using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	[VisibleToOtherModules]
	internal class NativeHeaderAttribute : Attribute
	{
		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public string Header
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59CBA20", Offset = "0x59CA620", VA = "0x1859CBA20")]
		public NativeHeaderAttribute(string header)
		{
		}
	}
}
