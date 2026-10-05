using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200041A RID: 1050
	[Token(Token = "0x200041A")]
	internal enum BinaryTypeEnum
	{
		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		Primitive,
		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		String,
		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x4001132")]
		Object,
		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		ObjectUrt,
		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		ObjectUser,
		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		ObjectArray,
		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		StringArray,
		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		PrimitiveArray
	}
}
