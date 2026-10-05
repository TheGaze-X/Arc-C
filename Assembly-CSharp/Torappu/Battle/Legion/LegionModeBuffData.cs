using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A24 RID: 10788
	[Token(Token = "0x2002A24")]
	[Serializable]
	public class LegionModeBuffData
	{
		// Token: 0x06011EA4 RID: 73380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LegionModeBuffData()
		{
		}

		// Token: 0x040142D9 RID: 82649
		[Token(Token = "0x40142D9")]
		[FieldOffset(Offset = "0x10")]
		public List<LegionModeBuffData.LegionModeBuffDataPart> dataParts;

		// Token: 0x02002A25 RID: 10789
		[Token(Token = "0x2002A25")]
		[Serializable]
		public class LegionModeBuffDataPart
		{
			// Token: 0x06011EA5 RID: 73381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011EA5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LegionModeBuffDataPart()
			{
			}

			// Token: 0x040142DA RID: 82650
			[Token(Token = "0x40142DA")]
			[FieldOffset(Offset = "0x10")]
			public bool isInheritable;

			// Token: 0x040142DB RID: 82651
			[Token(Token = "0x40142DB")]
			[FieldOffset(Offset = "0x11")]
			public bool isRedrawWhenReplace;

			// Token: 0x040142DC RID: 82652
			[Token(Token = "0x40142DC")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x040142DD RID: 82653
			[Token(Token = "0x40142DD")]
			[FieldOffset(Offset = "0x20")]
			public string descriptionHead;

			// Token: 0x040142DE RID: 82654
			[Token(Token = "0x40142DE")]
			[FieldOffset(Offset = "0x28")]
			public List<LegionModeBuffData.LegionModeBuffDataPart.LegionModeBuffLevelPhase> levelPhases;

			// Token: 0x02002A26 RID: 10790
			[Token(Token = "0x2002A26")]
			[Serializable]
			public class LegionModeBuffLevelPhase
			{
				// Token: 0x06011EA6 RID: 73382 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6011EA6")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public LegionModeBuffLevelPhase()
				{
				}

				// Token: 0x040142DF RID: 82655
				[Token(Token = "0x40142DF")]
				[FieldOffset(Offset = "0x10")]
				public List<Blackboard.DataPair> blackboard;
			}
		}
	}
}
