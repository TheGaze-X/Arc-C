using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072DF RID: 29407
	[Token(Token = "0x20072DF")]
	public class Act45SideMailPointView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060299D8 RID: 170456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299D8")]
		[Address(RVA = "0x24FA610", Offset = "0x24F9210", VA = "0x1824FA610")]
		public void Render(bool isUnlocked, bool isSelected)
		{
		}

		// Token: 0x060299D9 RID: 170457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299D9")]
		[Address(RVA = "0x24FA6C0", Offset = "0x24F92C0", VA = "0x1824FA6C0")]
		public Act45SideMailPointView()
		{
		}

		// Token: 0x0403B84B RID: 243787
		[Token(Token = "0x403B84B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0403B84C RID: 243788
		[Token(Token = "0x403B84C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggleUnlock;

		// Token: 0x0403B84D RID: 243789
		[Token(Token = "0x403B84D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B84E RID: 243790
		[Token(Token = "0x403B84E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
