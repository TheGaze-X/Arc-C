using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BC7 RID: 23495
	[Token(Token = "0x2005BC7")]
	public interface ICommonFriendAssistPlugin : IHotfixable
	{
		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x0602211F RID: 139551
		[Token(Token = "0x17004FB7")]
		string tips { [Token(Token = "0x602211F")] get; }

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x06022120 RID: 139552
		[Token(Token = "0x17004FB8")]
		bool profValid { [Token(Token = "0x6022120")] get; }

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x06022121 RID: 139553
		// (set) Token: 0x06022122 RID: 139554
		[Token(Token = "0x17004FB9")]
		ProfessionCategory defaultProf { [Token(Token = "0x6022121")] get; [Token(Token = "0x6022122")] set; }

		// Token: 0x06022123 RID: 139555
		[Token(Token = "0x6022123")]
		void FetchAssistData(ProfessionCategory profession, bool refreshFlag, Action<CommonFriendAssistData> result);

		// Token: 0x06022124 RID: 139556
		[Token(Token = "0x6022124")]
		void ApplyAssistChoose(SquadAssistData assist, Action done);

		// Token: 0x06022125 RID: 139557
		[Token(Token = "0x6022125")]
		bool CheckCanReqAssist(out long cdRemainTs);
	}
}
