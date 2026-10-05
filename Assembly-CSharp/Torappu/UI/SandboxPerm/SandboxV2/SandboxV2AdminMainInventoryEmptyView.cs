using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040A6 RID: 16550
	[Token(Token = "0x20040A6")]
	public class SandboxV2AdminMainInventoryEmptyView : DataBinder<SandboxV2AdminMainInventoryPanelModelProperty>
	{
		// Token: 0x060199BA RID: 104890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199BA")]
		[Address(RVA = "0x1249010", Offset = "0x1247C10", VA = "0x181249010", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainInventoryPanelModelProperty property)
		{
		}

		// Token: 0x060199BB RID: 104891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199BB")]
		[Address(RVA = "0x12491A0", Offset = "0x1247DA0", VA = "0x1812491A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060199BC RID: 104892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199BC")]
		[Address(RVA = "0x1249270", Offset = "0x1247E70", VA = "0x181249270")]
		public SandboxV2AdminMainInventoryEmptyView()
		{
		}

		// Token: 0x0401FFD5 RID: 131029
		[Token(Token = "0x401FFD5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401FFD6 RID: 131030
		[Token(Token = "0x401FFD6")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x0401FFD7 RID: 131031
		[Token(Token = "0x401FFD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FFD8 RID: 131032
		[Token(Token = "0x401FFD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FFD9 RID: 131033
		[Token(Token = "0x401FFD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
