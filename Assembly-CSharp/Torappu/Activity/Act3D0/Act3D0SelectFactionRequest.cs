using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073D8 RID: 29656
	[Token(Token = "0x20073D8")]
	public class Act3D0SelectFactionRequest
	{
		// Token: 0x06029E3A RID: 171578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E3A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3D0SelectFactionRequest()
		{
		}

		// Token: 0x0403C096 RID: 245910
		[Token(Token = "0x403C096")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403C097 RID: 245911
		[Token(Token = "0x403C097")]
		[FieldOffset(Offset = "0x18")]
		public string faction;
	}
}
