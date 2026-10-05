using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x06000CF5 RID: 3317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x59611F0", Offset = "0x595FDF0", VA = "0x1859611F0")]
		public MovedFromAttribute(bool autoUpdateAPI, [Optional] string sourceNamespace, [Optional] string sourceAssembly, [Optional] string sourceClassName)
		{
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x5961250", Offset = "0x595FE50", VA = "0x185961250")]
		public MovedFromAttribute(string sourceNamespace)
		{
		}

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MovedFromAttributeData data;
	}
}
