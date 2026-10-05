using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DD0 RID: 28112
	[Token(Token = "0x2006DD0")]
	public class ActVecBreakV2AchvTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028077 RID: 163959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028077")]
		[Address(RVA = "0x234B1F0", Offset = "0x2349DF0", VA = "0x18234B1F0")]
		public void Render(bool isSelect)
		{
		}

		// Token: 0x06028078 RID: 163960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028078")]
		[Address(RVA = "0x234B280", Offset = "0x2349E80", VA = "0x18234B280")]
		public ActVecBreakV2AchvTabItemView()
		{
		}

		// Token: 0x04038C1D RID: 232477
		[Token(Token = "0x4038C1D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectPartGO;

		// Token: 0x04038C1E RID: 232478
		[Token(Token = "0x4038C1E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unselectPartGO;

		// Token: 0x04038C1F RID: 232479
		[Token(Token = "0x4038C1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038C20 RID: 232480
		[Token(Token = "0x4038C20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
