using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001183 RID: 4483
	[Token(Token = "0x2001183")]
	public class RoguelikeSanCheckModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x000326A0 File Offset: 0x000308A0
		[Token(Token = "0x17000D3B")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F72")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F73")]
		[Address(RVA = "0x2112480", Offset = "0x2111080", VA = "0x182112480")]
		public RoguelikeSanRangeData GetSanRangeBySanValue(int sanValue)
		{
			return null;
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F74")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSanCheckModuleData()
		{
		}

		// Token: 0x04006014 RID: 24596
		[Token(Token = "0x4006014")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeSanRangeData> sanRanges;

		// Token: 0x04006015 RID: 24597
		[Token(Token = "0x4006015")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeSanCheckConsts moduleConsts;
	}
}
