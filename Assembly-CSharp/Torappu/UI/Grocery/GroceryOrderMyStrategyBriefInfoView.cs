using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CCC RID: 19660
	[Token(Token = "0x2004CCC")]
	public class GroceryOrderMyStrategyBriefInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D723 RID: 120611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D723")]
		[Address(RVA = "0x16FF280", Offset = "0x16FDE80", VA = "0x1816FF280")]
		public void Render(GroceryOrderGoodMyStrategyBriefViewModel strategyBriefViewModel)
		{
		}

		// Token: 0x0601D724 RID: 120612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D724")]
		[Address(RVA = "0x16FF3B0", Offset = "0x16FDFB0", VA = "0x1816FF3B0")]
		public GroceryOrderMyStrategyBriefInfoView()
		{
		}

		// Token: 0x04026D12 RID: 158994
		[Token(Token = "0x4026D12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtGoodName;

		// Token: 0x04026D13 RID: 158995
		[Token(Token = "0x4026D13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtStrategy;

		// Token: 0x04026D14 RID: 158996
		[Token(Token = "0x4026D14")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedGoodId;

		// Token: 0x04026D15 RID: 158997
		[Token(Token = "0x4026D15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026D16 RID: 158998
		[Token(Token = "0x4026D16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
