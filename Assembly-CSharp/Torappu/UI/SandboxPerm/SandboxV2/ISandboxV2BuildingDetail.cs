using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042CD RID: 17101
	[Token(Token = "0x20042CD")]
	public interface ISandboxV2BuildingDetail
	{
		// Token: 0x0601A4F5 RID: 107765
		[Token(Token = "0x601A4F5")]
		bool IsConstructTipSelected(SandboxV2ConstructTipType tipType);

		// Token: 0x0601A4F6 RID: 107766
		[Token(Token = "0x601A4F6")]
		int GetConstructTipCount(SandboxV2ConstructTipType tipType);

		// Token: 0x0601A4F7 RID: 107767
		[Token(Token = "0x601A4F7")]
		IEnumerable<SandboxV2DungeonBuildingTrapInfo> IterBuildingTrapInfo();

		// Token: 0x0601A4F8 RID: 107768
		[Token(Token = "0x601A4F8")]
		bool IsBuildingDetailEmpty();

		// Token: 0x0601A4F9 RID: 107769
		[Token(Token = "0x601A4F9")]
		SandboxV2NodeType GetNodeType();

		// Token: 0x0601A4FA RID: 107770
		[Token(Token = "0x601A4FA")]
		string GetNodeTypeName();
	}
}
