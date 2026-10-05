using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040A9 RID: 16553
	[Token(Token = "0x20040A9")]
	public class SandboxV2AdminMainInventoryItemView : DataBinder<SandboxV2AdminMainInventoryPanelModelProperty>
	{
		// Token: 0x060199C1 RID: 104897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199C1")]
		[Address(RVA = "0x124B340", Offset = "0x1249F40", VA = "0x18124B340", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainInventoryPanelModelProperty property)
		{
		}

		// Token: 0x060199C2 RID: 104898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199C2")]
		[Address(RVA = "0x124B530", Offset = "0x124A130", VA = "0x18124B530")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060199C3 RID: 104899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199C3")]
		[Address(RVA = "0x124B620", Offset = "0x124A220", VA = "0x18124B620")]
		public SandboxV2AdminMainInventoryItemView()
		{
		}

		// Token: 0x0401FFE0 RID: 131040
		[Token(Token = "0x401FFE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401FFE1 RID: 131041
		[Token(Token = "0x401FFE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2AdminMainInventoryItemListAdapter _itemListAdapter;

		// Token: 0x0401FFE2 RID: 131042
		[Token(Token = "0x401FFE2")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x0401FFE3 RID: 131043
		[Token(Token = "0x401FFE3")]
		[FieldOffset(Offset = "0x38")]
		public Action<int> onItemClick;

		// Token: 0x0401FFE4 RID: 131044
		[Token(Token = "0x401FFE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FFE5 RID: 131045
		[Token(Token = "0x401FFE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FFE6 RID: 131046
		[Token(Token = "0x401FFE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
