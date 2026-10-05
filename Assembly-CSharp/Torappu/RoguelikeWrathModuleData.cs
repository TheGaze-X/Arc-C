using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011BD RID: 4541
	[Token(Token = "0x20011BD")]
	public class RoguelikeWrathModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06006FA7 RID: 28583 RVA: 0x00032778 File Offset: 0x00030978
		[Token(Token = "0x17000D44")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006FA7")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA8")]
		[Address(RVA = "0x21148F0", Offset = "0x21134F0", VA = "0x1821148F0")]
		public RoguelikeWrathModuleData()
		{
		}

		// Token: 0x04006134 RID: 24884
		[Token(Token = "0x4006134")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeWrathData> wrathData;

		// Token: 0x04006135 RID: 24885
		[Token(Token = "0x4006135")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeWrathModuleConsts moduleConsts;
	}
}
