using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004BF RID: 1215
	[Token(Token = "0x20004BF")]
	[System.AttributeUsage(System.AttributeTargets.Assembly)]
	[System.Serializable]
	public sealed class DefaultDependencyAttribute : System.Attribute
	{
		// Token: 0x0600234B RID: 9035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public DefaultDependencyAttribute(LoadHint loadHintArgument)
		{
		}

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x10")]
		private LoadHint loadHint;
	}
}
