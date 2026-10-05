using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004363 RID: 17251
	[Token(Token = "0x2004363")]
	public class SandboxV2RacerBornTalentModel : SandboxV2RacerTalentModel
	{
		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0601A799 RID: 108441 RVA: 0x000A1E80 File Offset: 0x000A0080
		[Token(Token = "0x17003ED3")]
		public override SandboxV2RacerTalentType type
		{
			[Token(Token = "0x601A799")]
			[Address(RVA = "0x138D2C0", Offset = "0x138BEC0", VA = "0x18138D2C0", Slot = "4")]
			get
			{
				return SandboxV2RacerTalentType.BORN;
			}
		}

		// Token: 0x0601A79A RID: 108442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A79A")]
		[Address(RVA = "0x138D220", Offset = "0x138BE20", VA = "0x18138D220")]
		public SandboxV2RacerBornTalentModel()
		{
		}

		// Token: 0x04021B03 RID: 137987
		[Token(Token = "0x4021B03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04021B04 RID: 137988
		[Token(Token = "0x4021B04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
