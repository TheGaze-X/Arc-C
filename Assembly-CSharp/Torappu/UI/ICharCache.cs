using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;

namespace Torappu.UI
{
	// Token: 0x020035D3 RID: 13779
	[Token(Token = "0x20035D3")]
	public interface ICharCache<T> : ISquadMemberCompInfo, IHotfixable where T : ICommonSquadChar, new()
	{
		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x06015EC2 RID: 89794
		[Token(Token = "0x170034A8")]
		int charInstId { [Token(Token = "0x6015EC2")] get; }

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x06015EC3 RID: 89795
		[Token(Token = "0x170034A9")]
		string charId { [Token(Token = "0x6015EC3")] get; }

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x06015EC4 RID: 89796
		[Token(Token = "0x170034AA")]
		string tmplId { [Token(Token = "0x6015EC4")] get; }

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x06015EC5 RID: 89797
		[Token(Token = "0x170034AB")]
		ListDict<string, SquadSlotTmplPatch> tmpl { [Token(Token = "0x6015EC5")] get; }

		// Token: 0x06015EC6 RID: 89798
		[Token(Token = "0x6015EC6")]
		string GetSkillId(string tmplId);

		// Token: 0x06015EC7 RID: 89799
		[Token(Token = "0x6015EC7")]
		string GetEquipId(string tmplId);

		// Token: 0x06015EC8 RID: 89800
		[Token(Token = "0x6015EC8")]
		void EncodeToCache(ICommonSquadChar cardViewModel);

		// Token: 0x06015EC9 RID: 89801
		[Token(Token = "0x6015EC9")]
		T DecodeFromCache(CommonSquadGroupViewModel commonSquadGroupViewModel);
	}
}
