using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent>
	{
		// Token: 0x06000136 RID: 310 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4E7A460", Offset = "0x4E79060", VA = "0x184E7A460", Slot = "4")]
		public bool Equals(PostProcessEvent x, PostProcessEvent y)
		{
			return default(bool);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x21DABC0", Offset = "0x21D97C0", VA = "0x1821DABC0", Slot = "5")]
		public int GetHashCode(PostProcessEvent obj)
		{
			return 0;
		}
	}
}
