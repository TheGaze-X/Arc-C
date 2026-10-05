using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	[ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Delegate, Inherited = false)]
	public sealed class ComVisibleAttribute : System.Attribute
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002225")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public ComVisibleAttribute(bool visibility)
		{
		}

		// Token: 0x04001337 RID: 4919
		[Token(Token = "0x4001337")]
		[FieldOffset(Offset = "0x10")]
		internal bool _val;
	}
}
