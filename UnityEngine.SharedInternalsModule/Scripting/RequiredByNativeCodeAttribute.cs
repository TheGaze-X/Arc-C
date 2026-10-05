using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	[VisibleToOtherModules]
	internal class RequiredByNativeCodeAttribute : Attribute
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RequiredByNativeCodeAttribute()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public RequiredByNativeCodeAttribute(string name)
		{
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public string Name
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public bool Optional
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public bool GenerateProxy
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
