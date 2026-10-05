using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004364 RID: 17252
	[Token(Token = "0x2004364")]
	public class SandboxV2RacerLearnedTalentModel : SandboxV2RacerTalentModel
	{
		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0601A79B RID: 108443 RVA: 0x000A1E98 File Offset: 0x000A0098
		[Token(Token = "0x17003ED4")]
		public override SandboxV2RacerTalentType type
		{
			[Token(Token = "0x601A79B")]
			[Address(RVA = "0x1395A20", Offset = "0x1394620", VA = "0x181395A20", Slot = "4")]
			get
			{
				return SandboxV2RacerTalentType.BORN;
			}
		}

		// Token: 0x0601A79C RID: 108444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A79C")]
		[Address(RVA = "0x1395980", Offset = "0x1394580", VA = "0x181395980")]
		public SandboxV2RacerLearnedTalentModel()
		{
		}

		// Token: 0x04021B05 RID: 137989
		[Token(Token = "0x4021B05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04021B06 RID: 137990
		[Token(Token = "0x4021B06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
