using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[IncludeMyAttributes]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public sealed class OnStateUpdateAttribute : Attribute
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public OnStateUpdateAttribute(string action)
		{
		}

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x10")]
		public string Action;
	}
}
