using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class Header
	{
		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string HeaderNamespace;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool MustUnderstand;

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Name;

		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object Value;
	}
}
