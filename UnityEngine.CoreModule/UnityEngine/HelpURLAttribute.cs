using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	[UsedByNativeCode]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class HelpURLAttribute : Attribute
	{
		// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x594AFB0", Offset = "0x5949BB0", VA = "0x18594AFB0")]
		public HelpURLAttribute(string url)
		{
		}

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x10")]
		internal readonly string m_Url;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x18")]
		internal readonly bool m_Dispatcher;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x20")]
		internal readonly string m_DispatchingFieldName;
	}
}
