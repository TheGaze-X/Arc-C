using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.TemplateCharSelect.Common;

namespace Torappu.UI
{
	// Token: 0x020035D1 RID: 13777
	[Token(Token = "0x20035D1")]
	public interface ICommonSquadPage : IHotfixable
	{
		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x06015EAD RID: 89773
		[Token(Token = "0x1700349C")]
		ICommonSquadPage.ISquadInputs squadInput { [Token(Token = "0x6015EAD")] get; }

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x06015EAE RID: 89774
		[Token(Token = "0x1700349D")]
		UICompDialogMgr dlgMgr { [Token(Token = "0x6015EAE")] get; }

		// Token: 0x020035D2 RID: 13778
		[Token(Token = "0x20035D2")]
		public interface ISquadInputs : IHotfixable
		{
			// Token: 0x1700349E RID: 13470
			// (get) Token: 0x06015EAF RID: 89775
			// (set) Token: 0x06015EB0 RID: 89776
			[Token(Token = "0x1700349E")]
			StageId stageId { [Token(Token = "0x6015EAF")] get; [Token(Token = "0x6015EB0")] set; }

			// Token: 0x1700349F RID: 13471
			// (get) Token: 0x06015EB1 RID: 89777
			// (set) Token: 0x06015EB2 RID: 89778
			[Token(Token = "0x1700349F")]
			BattleStageInfo overrideStageInfo { [Token(Token = "0x6015EB1")] get; [Token(Token = "0x6015EB2")] set; }

			// Token: 0x170034A0 RID: 13472
			// (get) Token: 0x06015EB3 RID: 89779
			// (set) Token: 0x06015EB4 RID: 89780
			[Token(Token = "0x170034A0")]
			BattleActivityMeta actMeta { [Token(Token = "0x6015EB3")] get; [Token(Token = "0x6015EB4")] set; }

			// Token: 0x170034A1 RID: 13473
			// (get) Token: 0x06015EB5 RID: 89781
			// (set) Token: 0x06015EB6 RID: 89782
			[Token(Token = "0x170034A1")]
			BattleStageMeta stageMeta { [Token(Token = "0x6015EB5")] get; [Token(Token = "0x6015EB6")] set; }

			// Token: 0x170034A2 RID: 13474
			// (get) Token: 0x06015EB7 RID: 89783
			// (set) Token: 0x06015EB8 RID: 89784
			[Token(Token = "0x170034A2")]
			DataBundle battleBundleToJumpBack { [Token(Token = "0x6015EB7")] get; [Token(Token = "0x6015EB8")] set; }

			// Token: 0x170034A3 RID: 13475
			// (get) Token: 0x06015EB9 RID: 89785
			// (set) Token: 0x06015EBA RID: 89786
			[Token(Token = "0x170034A3")]
			CommonSquadResHolder commonSquadResHolder { [Token(Token = "0x6015EB9")] get; [Token(Token = "0x6015EBA")] set; }

			// Token: 0x170034A4 RID: 13476
			// (get) Token: 0x06015EBB RID: 89787
			// (set) Token: 0x06015EBC RID: 89788
			[Token(Token = "0x170034A4")]
			CommonCharSelectResHolder charSelectResHolder { [Token(Token = "0x6015EBB")] get; [Token(Token = "0x6015EBC")] set; }

			// Token: 0x170034A5 RID: 13477
			// (get) Token: 0x06015EBD RID: 89789
			// (set) Token: 0x06015EBE RID: 89790
			[Token(Token = "0x170034A5")]
			List<RuneTable.PackedRuneData> runeList { [Token(Token = "0x6015EBD")] get; [Token(Token = "0x6015EBE")] set; }

			// Token: 0x170034A6 RID: 13478
			// (get) Token: 0x06015EBF RID: 89791
			[Token(Token = "0x170034A6")]
			Type squadPluginType { [Token(Token = "0x6015EBF")] get; }

			// Token: 0x170034A7 RID: 13479
			// (get) Token: 0x06015EC0 RID: 89792
			[Token(Token = "0x170034A7")]
			bool isEmpty { [Token(Token = "0x6015EC0")] get; }

			// Token: 0x06015EC1 RID: 89793
			[Token(Token = "0x6015EC1")]
			ICommonSquadPage.ISquadInputs SetPlugin<TPlugin>() where TPlugin : ICommonSquadPlugin, new();
		}
	}
}
