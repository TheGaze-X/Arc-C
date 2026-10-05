using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CA7 RID: 3239
	[Token(Token = "0x2000CA7")]
	public class Act1VWeightedResItemBundle : IItemWithWeight
	{
		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06006983 RID: 27011 RVA: 0x00030D68 File Offset: 0x0002EF68
		[Token(Token = "0x17000CFB")]
		private float weightValue
		{
			[Token(Token = "0x6006983")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006984")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VWeightedResItemBundle()
		{
		}

		// Token: 0x04004229 RID: 16937
		[Token(Token = "0x4004229")]
		[FieldOffset(Offset = "0x10")]
		public float weight;

		// Token: 0x0400422A RID: 16938
		[Token(Token = "0x400422A")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> resources;
	}
}
