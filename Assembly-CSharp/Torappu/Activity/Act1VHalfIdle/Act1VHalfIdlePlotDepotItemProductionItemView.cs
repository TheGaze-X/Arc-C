using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200775C RID: 30556
	[Token(Token = "0x200775C")]
	public class Act1VHalfIdlePlotDepotItemProductionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AEB3 RID: 175795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEB3")]
		[Address(RVA = "0x26B2E60", Offset = "0x26B1A60", VA = "0x1826B2E60")]
		public void Render(Act1VHalfIdlePlotData.ItemDropData itemDropData)
		{
		}

		// Token: 0x0602AEB4 RID: 175796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEB4")]
		[Address(RVA = "0x26B2DE0", Offset = "0x26B19E0", VA = "0x1826B2DE0")]
		public void OnItemClicked()
		{
		}

		// Token: 0x0602AEB5 RID: 175797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEB5")]
		[Address(RVA = "0x26B3010", Offset = "0x26B1C10", VA = "0x1826B3010")]
		public Act1VHalfIdlePlotDepotItemProductionItemView()
		{
		}

		// Token: 0x0403DE80 RID: 253568
		[Token(Token = "0x403DE80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _matIcon;

		// Token: 0x0403DE81 RID: 253569
		[Token(Token = "0x403DE81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _matDesc;

		// Token: 0x0403DE82 RID: 253570
		[Token(Token = "0x403DE82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlItemIcon;

		// Token: 0x0403DE83 RID: 253571
		[Token(Token = "0x403DE83")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedItemId;

		// Token: 0x0403DE84 RID: 253572
		[Token(Token = "0x403DE84")]
		[FieldOffset(Offset = "0x38")]
		private UICompDialogFinder m_compDialogFinder;

		// Token: 0x0403DE85 RID: 253573
		[Token(Token = "0x403DE85")]
		[FieldOffset(Offset = "0x48")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403DE86 RID: 253574
		[Token(Token = "0x403DE86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DE87 RID: 253575
		[Token(Token = "0x403DE87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnItemClicked;

		// Token: 0x0403DE88 RID: 253576
		[Token(Token = "0x403DE88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
