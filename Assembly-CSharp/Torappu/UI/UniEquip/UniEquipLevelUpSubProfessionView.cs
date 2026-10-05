using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C28 RID: 15400
	[Token(Token = "0x2003C28")]
	public class UniEquipLevelUpSubProfessionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018163 RID: 98659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018163")]
		[Address(RVA = "0x1093520", Offset = "0x1092120", VA = "0x181093520")]
		public void Render(UniEquipSubProfessionViewModel model)
		{
		}

		// Token: 0x06018164 RID: 98660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018164")]
		[Address(RVA = "0x10937B0", Offset = "0x10923B0", VA = "0x1810937B0")]
		public UniEquipLevelUpSubProfessionView()
		{
		}

		// Token: 0x0401D39C RID: 119708
		[Token(Token = "0x401D39C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _subProfessionTitle;

		// Token: 0x0401D39D RID: 119709
		[Token(Token = "0x401D39D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _subProfessionContent;

		// Token: 0x0401D39E RID: 119710
		[Token(Token = "0x401D39E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterAttackRangeDeltaWidget _deltaWidget;

		// Token: 0x0401D39F RID: 119711
		[Token(Token = "0x401D39F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0401D3A0 RID: 119712
		[Token(Token = "0x401D3A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D3A1 RID: 119713
		[Token(Token = "0x401D3A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
