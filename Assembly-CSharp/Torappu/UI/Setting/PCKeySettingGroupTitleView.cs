using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FD6 RID: 16342
	[Token(Token = "0x2003FD6")]
	public class PCKeySettingGroupTitleView : UISimpleRecycleLayoutItemView<PCKeySettingTitleItemModel>, IHotfixable
	{
		// Token: 0x0601953F RID: 103743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601953F")]
		[Address(RVA = "0x11FAD00", Offset = "0x11F9900", VA = "0x1811FAD00", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06019540 RID: 103744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019540")]
		[Address(RVA = "0x11FAD70", Offset = "0x11F9970", VA = "0x1811FAD70", Slot = "6")]
		protected override void OnRender(PCKeySettingTitleItemModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06019541 RID: 103745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019541")]
		[Address(RVA = "0x11FAE70", Offset = "0x11F9A70", VA = "0x1811FAE70")]
		public PCKeySettingGroupTitleView()
		{
		}

		// Token: 0x0401F7BA RID: 128954
		[Token(Token = "0x401F7BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0401F7BB RID: 128955
		[Token(Token = "0x401F7BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F7BC RID: 128956
		[Token(Token = "0x401F7BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401F7BD RID: 128957
		[Token(Token = "0x401F7BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
