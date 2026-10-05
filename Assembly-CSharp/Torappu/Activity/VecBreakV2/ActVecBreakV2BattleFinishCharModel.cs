using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DE6 RID: 28134
	[Token(Token = "0x2006DE6")]
	public class ActVecBreakV2BattleFinishCharModel : CommonCharCardViewModel, IHotfixable
	{
		// Token: 0x060280F7 RID: 164087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280F7")]
		[Address(RVA = "0x234C7A0", Offset = "0x234B3A0", VA = "0x18234C7A0")]
		public void FillData(SquadItemStruct squadItem)
		{
		}

		// Token: 0x060280F8 RID: 164088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280F8")]
		[Address(RVA = "0x234C880", Offset = "0x234B480", VA = "0x18234C880")]
		public ActVecBreakV2BattleFinishCharModel()
		{
		}

		// Token: 0x04038D15 RID: 232725
		[Token(Token = "0x4038D15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FillData;

		// Token: 0x04038D16 RID: 232726
		[Token(Token = "0x4038D16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
