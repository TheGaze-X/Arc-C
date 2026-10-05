using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D25 RID: 15653
	[Token(Token = "0x2003D25")]
	public class TrainingCampStageSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601867E RID: 99966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601867E")]
		[Address(RVA = "0x10D3D60", Offset = "0x10D2960", VA = "0x1810D3D60")]
		public TrainingCampStageSelectStateBean()
		{
		}

		// Token: 0x0401DDAC RID: 122284
		[Token(Token = "0x401DDAC")]
		[FieldOffset(Offset = "0x10")]
		public TrainingCampStageSelectProperty property;

		// Token: 0x0401DDAD RID: 122285
		[Token(Token = "0x401DDAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
