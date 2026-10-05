using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	public sealed class GuidAttribute : System.Attribute
	{
		// Token: 0x06002227 RID: 8743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public GuidAttribute(string guid)
		{
		}

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		[FieldOffset(Offset = "0x10")]
		internal string _val;
	}
}
