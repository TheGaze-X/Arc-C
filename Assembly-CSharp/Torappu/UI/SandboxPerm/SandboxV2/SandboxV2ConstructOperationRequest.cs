using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043D8 RID: 17368
	[Token(Token = "0x20043D8")]
	public class SandboxV2ConstructOperationRequest
	{
		// Token: 0x0601A982 RID: 108930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A982")]
		[Address(RVA = "0x13A9380", Offset = "0x13A7F80", VA = "0x1813A9380")]
		public SandboxV2ConstructOperationRequest()
		{
		}

		// Token: 0x04021E79 RID: 138873
		[Token(Token = "0x4021E79")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E7A RID: 138874
		[Token(Token = "0x4021E7A")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x04021E7B RID: 138875
		[Token(Token = "0x4021E7B")]
		[FieldOffset(Offset = "0x20")]
		public JArray operation;

		// Token: 0x04021E7C RID: 138876
		[Token(Token = "0x4021E7C")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<int, Dictionary<string, int>> catchedAnimals;
	}
}
