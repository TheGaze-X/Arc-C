using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200547A RID: 21626
	[Token(Token = "0x200547A")]
	public interface IRoguelikeCharCardViewPluginContext : IHotfixable
	{
		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x0601FD40 RID: 130368
		[Token(Token = "0x17004AA2")]
		RoguelikeCharCardViewPluginPriority pluginPriority { [Token(Token = "0x601FD40")] get; }

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x0601FD41 RID: 130369
		[Token(Token = "0x17004AA3")]
		List<RoguelikeCharCardComparer> additionalComparers { [Token(Token = "0x601FD41")] get; }

		// Token: 0x0601FD42 RID: 130370
		[Token(Token = "0x601FD42")]
		IRoguelikeCharCardPlugin ConstructPlugin();

		// Token: 0x0601FD43 RID: 130371
		[Token(Token = "0x601FD43")]
		void LoadData(string topicId);

		// Token: 0x0601FD44 RID: 130372
		[Token(Token = "0x601FD44")]
		bool CheckCharSelectValid(RoguelikeSelectCharViewModel groupModel, RoguelikeCharCardViewModel charModel, out string invalidToast);

		// Token: 0x0601FD45 RID: 130373
		[Token(Token = "0x601FD45")]
		RoguelikeMenuButtonPluginBase GetCustomPendingEventSelectMenuPlugin(RoguelikeCharSelectStateBean.ShowConfig showConfig);

		// Token: 0x0601FD46 RID: 130374
		[Token(Token = "0x601FD46")]
		RoguelikeSquadStartBattleButtonPluginBase GetCustomSquadStartBattleButtonPlugin();

		// Token: 0x0601FD47 RID: 130375
		[Token(Token = "0x601FD47")]
		RoguelikeSelectCharStashTicketButtonBase GetCustomStashTicketButtonPlugin();

		// Token: 0x0601FD48 RID: 130376
		[Token(Token = "0x601FD48")]
		UIGuidebookTrigger GetCustomSelectCharGuideBookTriggerAsset(ILoadAsset assetLoader);

		// Token: 0x0601FD49 RID: 130377
		[Token(Token = "0x601FD49")]
		string GetCustomSelectCharGuideBookSubSignal();

		// Token: 0x0601FD4A RID: 130378
		[Token(Token = "0x601FD4A")]
		bool OverrideSquadTroopCount(List<RoguelikeCharCardViewModel> curCharInSquad, out int squadTroopCount);
	}
}
