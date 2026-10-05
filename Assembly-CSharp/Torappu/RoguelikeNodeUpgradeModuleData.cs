using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011B0 RID: 4528
	[Token(Token = "0x20011B0")]
	public class RoguelikeNodeUpgradeModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06006F9C RID: 28572 RVA: 0x00032748 File Offset: 0x00030948
		[Token(Token = "0x17000D42")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F9C")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeNodeUpgradeModuleData()
		{
		}

		// Token: 0x040060F4 RID: 24820
		[Token(Token = "0x40060F4")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeNodeUpgradeData> nodeUpgradeDataMap;
	}
}
