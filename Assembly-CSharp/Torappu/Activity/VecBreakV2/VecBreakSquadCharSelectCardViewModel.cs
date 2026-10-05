using System;
using Il2CppDummyDll;
using Torappu.CharWord;
using Torappu.UI.TemplateCharSelect.Common;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E7B RID: 28283
	[Token(Token = "0x2006E7B")]
	public class VecBreakSquadCharSelectCardViewModel : CommonCharSelectCardDefaultViewModel
	{
		// Token: 0x060283FE RID: 164862 RVA: 0x000D1058 File Offset: 0x000CF258
		[Token(Token = "0x60283FE")]
		[Address(RVA = "0x2399340", Offset = "0x2397F40", VA = "0x182399340")]
		public VoiceQuery GetVoiceQuery()
		{
			return default(VoiceQuery);
		}

		// Token: 0x060283FF RID: 164863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283FF")]
		[Address(RVA = "0x2399450", Offset = "0x2398050", VA = "0x182399450")]
		public VecBreakSquadCharSelectCardViewModel()
		{
		}

		// Token: 0x04039354 RID: 234324
		[Token(Token = "0x4039354")]
		[FieldOffset(Offset = "0x40")]
		public VecBreakStageDefendStatus defendStatus;

		// Token: 0x04039355 RID: 234325
		[Token(Token = "0x4039355")]
		[FieldOffset(Offset = "0x48")]
		public string defendHint;

		// Token: 0x04039356 RID: 234326
		[Token(Token = "0x4039356")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetVoiceQuery;

		// Token: 0x04039357 RID: 234327
		[Token(Token = "0x4039357")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
