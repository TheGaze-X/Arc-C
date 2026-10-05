using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.RL04;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046B3 RID: 18099
	[Token(Token = "0x20046B3")]
	public interface INodeConfigFetcher
	{
		// Token: 0x0601B738 RID: 112440
		[Token(Token = "0x601B738")]
		RL04NodeUpgradeConfig GetNodeConfig(RoguelikeEventType type);
	}
}
