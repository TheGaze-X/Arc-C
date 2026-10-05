using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040B6 RID: 16566
	[Token(Token = "0x20040B6")]
	public class SandboxV2AdminMainTopView : SandboxV2AdminMainViewBase
	{
		// Token: 0x06019A0C RID: 104972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A0C")]
		[Address(RVA = "0x1289910", Offset = "0x1288510", VA = "0x181289910", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainModelProperty property)
		{
		}

		// Token: 0x06019A0D RID: 104973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A0D")]
		[Address(RVA = "0x1289B70", Offset = "0x1288770", VA = "0x181289B70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019A0E RID: 104974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A0E")]
		[Address(RVA = "0x12897F0", Offset = "0x12883F0", VA = "0x1812897F0")]
		public void EventBackBtnClick()
		{
		}

		// Token: 0x06019A0F RID: 104975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A0F")]
		[Address(RVA = "0x1289C80", Offset = "0x1288880", VA = "0x181289C80")]
		public SandboxV2AdminMainTopView()
		{
		}

		// Token: 0x0402004B RID: 131147
		[Token(Token = "0x402004B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402004C RID: 131148
		[Token(Token = "0x402004C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402004D RID: 131149
		[Token(Token = "0x402004D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _title;

		// Token: 0x0402004E RID: 131150
		[Token(Token = "0x402004E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0402004F RID: 131151
		[Token(Token = "0x402004F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020050 RID: 131152
		[Token(Token = "0x4020050")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020051 RID: 131153
		[Token(Token = "0x4020051")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventBackBtnClick;

		// Token: 0x04020052 RID: 131154
		[Token(Token = "0x4020052")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
