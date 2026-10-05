using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DC9 RID: 28105
	[Token(Token = "0x2006DC9")]
	public class ActVecBreakV2AchvSquadCharModel : CommonCharCardViewModel, IHotfixable
	{
		// Token: 0x0602805C RID: 163932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602805C")]
		[Address(RVA = "0x2349600", Offset = "0x2348200", VA = "0x182349600")]
		public void LoadData(VecBreakV2SeasonRecordCharInfo playerCharInfo)
		{
		}

		// Token: 0x0602805D RID: 163933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602805D")]
		[Address(RVA = "0x2349A50", Offset = "0x2348650", VA = "0x182349A50")]
		public ActVecBreakV2AchvSquadCharModel()
		{
		}

		// Token: 0x04038BF2 RID: 232434
		[Token(Token = "0x4038BF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038BF3 RID: 232435
		[Token(Token = "0x4038BF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
