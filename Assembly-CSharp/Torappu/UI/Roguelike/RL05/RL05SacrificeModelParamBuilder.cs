using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005600 RID: 22016
	[Token(Token = "0x2005600")]
	public class RL05SacrificeModelParamBuilder : RoguelikeSacrificeModelParamBuilder
	{
		// Token: 0x06020501 RID: 132353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020501")]
		[Address(RVA = "0x1A6FBF0", Offset = "0x1A6E7F0", VA = "0x181A6FBF0", Slot = "4")]
		public override RoguelikeSacrificeModelParam Build(string topicId, RoguelikeSacrificeType sacrificeType)
		{
			return null;
		}

		// Token: 0x06020502 RID: 132354 RVA: 0x000B54E8 File Offset: 0x000B36E8
		[Token(Token = "0x6020502")]
		[Address(RVA = "0x1A6FF50", Offset = "0x1A6EB50", VA = "0x181A6FF50")]
		private static int _ItemComparison(KeyValuePair<string, IRoguelikeSacrifice> x, KeyValuePair<string, IRoguelikeSacrifice> y)
		{
			return 0;
		}

		// Token: 0x06020503 RID: 132355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020503")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RL05SacrificeModelParamBuilder()
		{
		}
	}
}
