using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200473F RID: 18239
	[Token(Token = "0x200473F")]
	public class RecruitAvailDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA2A RID: 113194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA2A")]
		[Address(RVA = "0x14F56E0", Offset = "0x14F42E0", VA = "0x1814F56E0")]
		public void Render(List<GachaDetailData.GachaAvailChar.GachaPerAvail> perAvailList, string recruit6StarHint)
		{
		}

		// Token: 0x0601BA2B RID: 113195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA2B")]
		[Address(RVA = "0x14F5890", Offset = "0x14F4490", VA = "0x1814F5890")]
		public RecruitAvailDetailView()
		{
		}

		// Token: 0x04023D80 RID: 146816
		[Token(Token = "0x4023D80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RecruitAvailDetailObj _charDetailObj;

		// Token: 0x04023D81 RID: 146817
		[Token(Token = "0x4023D81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023D82 RID: 146818
		[Token(Token = "0x4023D82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023D83 RID: 146819
		[Token(Token = "0x4023D83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
