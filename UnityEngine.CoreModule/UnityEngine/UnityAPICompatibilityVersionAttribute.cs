using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public class UnityAPICompatibilityVersionAttribute : Attribute
	{
		// Token: 0x06000A06 RID: 2566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		[Obsolete("This overload of the attribute has been deprecated. Use the constructor that takes the version and a boolean", true)]
		public UnityAPICompatibilityVersionAttribute(string version)
		{
		}

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x10")]
		private string _version;
	}
}
