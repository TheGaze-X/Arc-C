using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C6 RID: 14790
	[Token(Token = "0x20039C6")]
	public class TwoStateActiveSwitcher : TwoStateSwitcher, IHotfixable
	{
		// Token: 0x060175D4 RID: 95700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175D4")]
		[Address(RVA = "0xFB91B0", Offset = "0xFB7DB0", VA = "0x180FB91B0", Slot = "11")]
		protected override void OnChangeState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175D5 RID: 95701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175D5")]
		[Address(RVA = "0xFB9230", Offset = "0xFB7E30", VA = "0x180FB9230", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060175D6 RID: 95702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175D6")]
		[Address(RVA = "0xFB9300", Offset = "0xFB7F00", VA = "0x180FB9300", Slot = "10")]
		protected override void OnResetState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175D7 RID: 95703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175D7")]
		[Address(RVA = "0xFB9380", Offset = "0xFB7F80", VA = "0x180FB9380")]
		public TwoStateActiveSwitcher()
		{
		}

		// Token: 0x0401C372 RID: 115570
		[Token(Token = "0x401C372")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _activeNode;

		// Token: 0x0401C373 RID: 115571
		[Token(Token = "0x401C373")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_targetNode;

		// Token: 0x0401C374 RID: 115572
		[Token(Token = "0x401C374")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnChangeState;

		// Token: 0x0401C375 RID: 115573
		[Token(Token = "0x401C375")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C376 RID: 115574
		[Token(Token = "0x401C376")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResetState;

		// Token: 0x0401C377 RID: 115575
		[Token(Token = "0x401C377")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
