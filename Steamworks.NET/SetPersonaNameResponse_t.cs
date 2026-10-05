using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[CallbackIdentity(347)]
	public struct SetPersonaNameResponse_t
	{
		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		public const int k_iCallback = 347;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x1")]
		public bool m_bLocalSuccess;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
}
