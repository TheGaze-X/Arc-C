using System;
using Il2CppDummyDll;
using Torappu.Gacha;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200470E RID: 18190
	[Token(Token = "0x200470E")]
	public class RecruitTenGachaResultStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0601B941 RID: 112961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B941")]
		[Address(RVA = "0x14EC310", Offset = "0x14EAF10", VA = "0x1814EC310")]
		public RecruitTenGachaResultStateBean()
		{
		}

		// Token: 0x04023B8D RID: 146317
		[Token(Token = "0x4023B8D")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public GachaResult[] gachaResult;

		// Token: 0x04023B8E RID: 146318
		[Token(Token = "0x4023B8E")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public GachaController.Output gachaOutput;

		// Token: 0x04023B8F RID: 146319
		[Token(Token = "0x4023B8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
