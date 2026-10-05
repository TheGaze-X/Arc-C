using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200118F RID: 4495
	[Token(Token = "0x200118F")]
	public class RoguelikeChaosModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06006F7D RID: 28541 RVA: 0x000326D0 File Offset: 0x000308D0
		[Token(Token = "0x17000D3D")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F7D")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F7E")]
		[Address(RVA = "0x21107A0", Offset = "0x210F3A0", VA = "0x1821107A0")]
		public RoguelikeChaosRangeData GetChaosRangeByValue(int chaosValue)
		{
			return null;
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0x2110930", Offset = "0x210F530", VA = "0x182110930")]
		public RoguelikeChaosModuleData()
		{
		}

		// Token: 0x0400604C RID: 24652
		[Token(Token = "0x400604C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeChaosData> chaosDatas;

		// Token: 0x0400604D RID: 24653
		[Token(Token = "0x400604D")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeChaosRangeData> chaosRanges;

		// Token: 0x0400604E RID: 24654
		[Token(Token = "0x400604E")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Dictionary<int, RoguelikeChaosPredefineLevelInfo>> levelInfoDict;

		// Token: 0x0400604F RID: 24655
		[Token(Token = "0x400604F")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeChaosModuleConsts moduleConsts;
	}
}
