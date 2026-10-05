using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200414A RID: 16714
	[Token(Token = "0x200414A")]
	public class SandboxV2BasementMonthEntryBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D0E RID: 105742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D0E")]
		[Address(RVA = "0x12A0D40", Offset = "0x129F940", VA = "0x1812A0D40")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x06019D0F RID: 105743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D0F")]
		[Address(RVA = "0x12A1040", Offset = "0x129FC40", VA = "0x1812A1040")]
		public SandboxV2BasementMonthEntryBtnView()
		{
		}

		// Token: 0x04020668 RID: 132712
		[Token(Token = "0x4020668")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelTimeUndone;

		// Token: 0x04020669 RID: 132713
		[Token(Token = "0x4020669")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelTimeDone;

		// Token: 0x0402066A RID: 132714
		[Token(Token = "0x402066A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNormalBg;

		// Token: 0x0402066B RID: 132715
		[Token(Token = "0x402066B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelDisableBg;

		// Token: 0x0402066C RID: 132716
		[Token(Token = "0x402066C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtTimeUndone;

		// Token: 0x0402066D RID: 132717
		[Token(Token = "0x402066D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtTimeDone;

		// Token: 0x0402066E RID: 132718
		[Token(Token = "0x402066E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _hotspot;

		// Token: 0x0402066F RID: 132719
		[Token(Token = "0x402066F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020670 RID: 132720
		[Token(Token = "0x4020670")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
