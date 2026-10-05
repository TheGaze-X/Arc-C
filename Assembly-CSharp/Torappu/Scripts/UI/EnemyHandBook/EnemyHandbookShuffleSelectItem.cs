using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Scripts.UI.EnemyHandBook
{
	// Token: 0x020017A2 RID: 6050
	[Token(Token = "0x20017A2")]
	public class EnemyHandbookShuffleSelectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060098EB RID: 39147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EB")]
		[Address(RVA = "0x3142DA0", Offset = "0x31419A0", VA = "0x183142DA0")]
		public void Render(int index, string text, bool isSelected)
		{
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EC")]
		[Address(RVA = "0x3142D20", Offset = "0x3141920", VA = "0x183142D20")]
		public void OnClick()
		{
		}

		// Token: 0x060098ED RID: 39149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098ED")]
		[Address(RVA = "0x3142EC0", Offset = "0x3141AC0", VA = "0x183142EC0")]
		public EnemyHandbookShuffleSelectItem()
		{
		}

		// Token: 0x04008EF3 RID: 36595
		[Token(Token = "0x4008EF3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04008EF4 RID: 36596
		[Token(Token = "0x4008EF4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _detailText2;

		// Token: 0x04008EF5 RID: 36597
		[Token(Token = "0x4008EF5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04008EF6 RID: 36598
		[Token(Token = "0x4008EF6")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public UIIntEvent onClick;

		// Token: 0x04008EF7 RID: 36599
		[Token(Token = "0x4008EF7")]
		[FieldOffset(Offset = "0x38")]
		private int m_index;

		// Token: 0x04008EF8 RID: 36600
		[Token(Token = "0x4008EF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04008EF9 RID: 36601
		[Token(Token = "0x4008EF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04008EFA RID: 36602
		[Token(Token = "0x4008EFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
