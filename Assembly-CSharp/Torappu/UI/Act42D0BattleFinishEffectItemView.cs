using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200345B RID: 13403
	[Token(Token = "0x200345B")]
	public class Act42D0BattleFinishEffectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015687 RID: 87687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015687")]
		[Address(RVA = "0xDDDB10", Offset = "0xDDC710", VA = "0x180DDDB10")]
		public void Render(string actId, Act42D0Data.Act42D0EffectInfoData effectInfoData, bool isFirstInRow)
		{
		}

		// Token: 0x06015688 RID: 87688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015688")]
		[Address(RVA = "0xDDDC50", Offset = "0xDDC850", VA = "0x180DDDC50")]
		public Act42D0BattleFinishEffectItemView()
		{
		}

		// Token: 0x04019A0E RID: 104974
		[Token(Token = "0x4019A0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPanelGo;

		// Token: 0x04019A0F RID: 104975
		[Token(Token = "0x4019A0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _effectPanelGo;

		// Token: 0x04019A10 RID: 104976
		[Token(Token = "0x4019A10")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _shadowGo;

		// Token: 0x04019A11 RID: 104977
		[Token(Token = "0x4019A11")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgEffect;

		// Token: 0x04019A12 RID: 104978
		[Token(Token = "0x4019A12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x04019A13 RID: 104979
		[Token(Token = "0x4019A13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04019A14 RID: 104980
		[Token(Token = "0x4019A14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
