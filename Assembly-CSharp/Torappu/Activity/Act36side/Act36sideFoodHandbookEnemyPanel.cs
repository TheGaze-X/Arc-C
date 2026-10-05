using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007459 RID: 29785
	[Token(Token = "0x2007459")]
	public class Act36sideFoodHandbookEnemyPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A05A RID: 172122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A05A")]
		[Address(RVA = "0x259C1C0", Offset = "0x259ADC0", VA = "0x18259C1C0")]
		public void Render(Act36sideFoodHandbookViewModel model)
		{
		}

		// Token: 0x0602A05B RID: 172123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A05B")]
		[Address(RVA = "0x259C340", Offset = "0x259AF40", VA = "0x18259C340")]
		public Act36sideFoodHandbookEnemyPanel()
		{
		}

		// Token: 0x0403C461 RID: 246881
		[Token(Token = "0x403C461")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act36sideFoodHandbookEnemyItemAdapter _adapter;

		// Token: 0x0403C462 RID: 246882
		[Token(Token = "0x403C462")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C463 RID: 246883
		[Token(Token = "0x403C463")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
