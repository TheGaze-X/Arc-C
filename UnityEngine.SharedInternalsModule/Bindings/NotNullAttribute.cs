using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal class NotNullAttribute : Attribute
	{
		// Token: 0x17000012 RID: 18
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public string Exception
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public NotNullAttribute(string exception = "ArgumentNullException")
		{
		}
	}
}
