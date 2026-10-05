using System;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004705 RID: 18181
	[Token(Token = "0x2004705")]
	public class BuildConfigTagGroupViewModel
	{
		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x0601B918 RID: 112920 RVA: 0x000A5828 File Offset: 0x000A3A28
		[Token(Token = "0x170041A1")]
		public int selectTagCount
		{
			[Token(Token = "0x601B918")]
			[Address(RVA = "0x14DA010", Offset = "0x14D8C10", VA = "0x1814DA010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x0601B919 RID: 112921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041A2")]
		public SpecialRecruitPool getRecruitTagDataBySearch
		{
			[Token(Token = "0x601B919")]
			[Address(RVA = "0x14D9ED0", Offset = "0x14D8AD0", VA = "0x1814D9ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B91A RID: 112922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B91A")]
		[Address(RVA = "0xED4B00", Offset = "0xED3700", VA = "0x180ED4B00")]
		public BuildConfigTagGroupViewModel()
		{
		}

		// Token: 0x04023B44 RID: 146244
		[Token(Token = "0x4023B44")]
		[FieldOffset(Offset = "0x10")]
		public BuildConfigTagViewModel[] tags;

		// Token: 0x04023B45 RID: 146245
		[Token(Token = "0x4023B45")]
		[FieldOffset(Offset = "0x18")]
		public BuildConfigTagViewModel specialTag;

		// Token: 0x04023B46 RID: 146246
		[Token(Token = "0x4023B46")]
		[FieldOffset(Offset = "0x20")]
		private SpecialRecruitPool m_recruitTagData;

		// Token: 0x04023B47 RID: 146247
		[Token(Token = "0x4023B47")]
		[FieldOffset(Offset = "0x28")]
		private int m_currentOrder;
	}
}
