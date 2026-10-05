using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D7F RID: 15743
	[Token(Token = "0x2003D7F")]
	public class TemplateActivityConfirmMissionRequest
	{
		// Token: 0x060187E5 RID: 100325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187E5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TemplateActivityConfirmMissionRequest()
		{
		}

		// Token: 0x0401E02D RID: 122925
		[Token(Token = "0x401E02D")]
		[FieldOffset(Offset = "0x10")]
		public List<string> missionIds;
	}
}
