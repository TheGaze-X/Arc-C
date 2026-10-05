using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004754 RID: 18260
	[Token(Token = "0x2004754")]
	[Serializable]
	public class RecruitImageData
	{
		// Token: 0x0601BA6A RID: 113258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA6A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecruitImageData()
		{
		}

		// Token: 0x04023E3C RID: 147004
		[Token(Token = "0x4023E3C")]
		[FieldOffset(Offset = "0x10")]
		public List<RecruitImage> imageList;

		// Token: 0x04023E3D RID: 147005
		[Token(Token = "0x4023E3D")]
		[FieldOffset(Offset = "0x18")]
		public List<RecruitImage> spinePath;
	}
}
