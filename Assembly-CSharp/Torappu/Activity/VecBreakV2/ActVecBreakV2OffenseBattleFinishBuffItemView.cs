using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DEA RID: 28138
	[Token(Token = "0x2006DEA")]
	public class ActVecBreakV2OffenseBattleFinishBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028113 RID: 164115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028113")]
		[Address(RVA = "0x23511C0", Offset = "0x234FDC0", VA = "0x1823511C0")]
		public void Render(ActVecBreakV2OffenseBattleFinishBuffItemModel buffItemModel)
		{
		}

		// Token: 0x06028114 RID: 164116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028114")]
		[Address(RVA = "0x23512F0", Offset = "0x234FEF0", VA = "0x1823512F0")]
		public ActVecBreakV2OffenseBattleFinishBuffItemView()
		{
		}

		// Token: 0x04038D5C RID: 232796
		[Token(Token = "0x4038D5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04038D5D RID: 232797
		[Token(Token = "0x4038D5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04038D5E RID: 232798
		[Token(Token = "0x4038D5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconImg;

		// Token: 0x04038D5F RID: 232799
		[Token(Token = "0x4038D5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038D60 RID: 232800
		[Token(Token = "0x4038D60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
