using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200514F RID: 20815
	[Token(Token = "0x200514F")]
	public class DeepSeaActivateNodeRequest
	{
		// Token: 0x0601EC71 RID: 126065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC71")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaActivateNodeRequest()
		{
		}

		// Token: 0x0402942D RID: 169005
		[Token(Token = "0x402942D")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0402942E RID: 169006
		[Token(Token = "0x402942E")]
		[FieldOffset(Offset = "0x18")]
		public string placeId;

		// Token: 0x0402942F RID: 169007
		[Token(Token = "0x402942F")]
		[FieldOffset(Offset = "0x20")]
		public string nodeId;
	}
}
