using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200338D RID: 13197
	[Token(Token = "0x200338D")]
	[RequireComponent(typeof(Text))]
	public class UIMessageText : UIPopup
	{
		// Token: 0x060150AA RID: 86186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150AA")]
		[Address(RVA = "0xD79440", Offset = "0xD78040", VA = "0x180D79440")]
		public void Init(string message, Transform spawnPoint)
		{
		}

		// Token: 0x060150AB RID: 86187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150AB")]
		[Address(RVA = "0xD792F0", Offset = "0xD77EF0", VA = "0x180D792F0")]
		public void Init(string message, Transform spawnPoint, Color color)
		{
		}

		// Token: 0x060150AC RID: 86188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150AC")]
		[Address(RVA = "0xD79590", Offset = "0xD78190", VA = "0x180D79590", Slot = "9")]
		protected override void SetTweens(float duration)
		{
		}

		// Token: 0x060150AD RID: 86189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150AD")]
		[Address(RVA = "0xD79270", Offset = "0xD77E70", VA = "0x180D79270")]
		private void Awake()
		{
		}

		// Token: 0x060150AE RID: 86190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150AE")]
		[Address(RVA = "0xD79780", Offset = "0xD78380", VA = "0x180D79780")]
		public UIMessageText()
		{
		}

		// Token: 0x040190BA RID: 102586
		[Token(Token = "0x40190BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _floatOffset;

		// Token: 0x040190BB RID: 102587
		[Token(Token = "0x40190BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _color;

		// Token: 0x040190BC RID: 102588
		[Token(Token = "0x40190BC")]
		[FieldOffset(Offset = "0x48")]
		private Text m_label;

		// Token: 0x040190BD RID: 102589
		[Token(Token = "0x40190BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040190BE RID: 102590
		[Token(Token = "0x40190BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x040190BF RID: 102591
		[Token(Token = "0x40190BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetTweens;

		// Token: 0x040190C0 RID: 102592
		[Token(Token = "0x40190C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040190C1 RID: 102593
		[Token(Token = "0x40190C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
