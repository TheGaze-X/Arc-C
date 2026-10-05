using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200515C RID: 20828
	[Token(Token = "0x200515C")]
	public class DeepSeaChangeTechBranchRequest
	{
		// Token: 0x0601EC7E RID: 126078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC7E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaChangeTechBranchRequest()
		{
		}

		// Token: 0x04029447 RID: 169031
		[Token(Token = "0x4029447")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04029448 RID: 169032
		[Token(Token = "0x4029448")]
		[FieldOffset(Offset = "0x18")]
		public List<TechBranchData> branches;
	}
}
