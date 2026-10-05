using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011AE RID: 4526
	[Token(Token = "0x20011AE")]
	public class RoguelikeDisasterModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x00032730 File Offset: 0x00030930
		[Token(Token = "0x17000D41")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F99")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeDisasterModuleData()
		{
		}

		// Token: 0x040060E9 RID: 24809
		[Token(Token = "0x40060E9")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeDisasterData> disasterData;
	}
}
