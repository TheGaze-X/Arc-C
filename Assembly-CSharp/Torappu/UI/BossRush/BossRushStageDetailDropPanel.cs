using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061B8 RID: 25016
	[Token(Token = "0x20061B8")]
	public class BossRushStageDetailDropPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024191 RID: 147857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024191")]
		[Address(RVA = "0x1EC5F10", Offset = "0x1EC4B10", VA = "0x181EC5F10")]
		public void Render(string actId)
		{
		}

		// Token: 0x06024192 RID: 147858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024192")]
		[Address(RVA = "0x1EC6100", Offset = "0x1EC4D00", VA = "0x181EC6100")]
		public void Show()
		{
		}

		// Token: 0x06024193 RID: 147859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024193")]
		[Address(RVA = "0x1EC5EA0", Offset = "0x1EC4AA0", VA = "0x181EC5EA0")]
		public void Hide()
		{
		}

		// Token: 0x06024194 RID: 147860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024194")]
		[Address(RVA = "0x1EC6170", Offset = "0x1EC4D70", VA = "0x181EC6170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024195 RID: 147861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024195")]
		[Address(RVA = "0x1EC6280", Offset = "0x1EC4E80", VA = "0x181EC6280")]
		public BossRushStageDetailDropPanel()
		{
		}

		// Token: 0x040322B7 RID: 205495
		[Token(Token = "0x40322B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIReentrantFloatPanel _panel;

		// Token: 0x040322B8 RID: 205496
		[Token(Token = "0x40322B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgDropInfo;

		// Token: 0x040322B9 RID: 205497
		[Token(Token = "0x40322B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelBackBtn;

		// Token: 0x040322BA RID: 205498
		[Token(Token = "0x40322BA")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040322BB RID: 205499
		[Token(Token = "0x40322BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040322BC RID: 205500
		[Token(Token = "0x40322BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040322BD RID: 205501
		[Token(Token = "0x40322BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040322BE RID: 205502
		[Token(Token = "0x40322BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040322BF RID: 205503
		[Token(Token = "0x40322BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
