using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Notification
{
	// Token: 0x020047E0 RID: 18400
	[Token(Token = "0x20047E0")]
	public class UITextNotifyView : UINotifyView<TextNotifyViewParam>
	{
		// Token: 0x0601BD6C RID: 114028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD6C")]
		[Address(RVA = "0x1536B70", Offset = "0x1535770", VA = "0x181536B70", Slot = "9")]
		protected override void Render(TextNotifyViewParam textParam)
		{
		}

		// Token: 0x0601BD6D RID: 114029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD6D")]
		[Address(RVA = "0x1536D50", Offset = "0x1535950", VA = "0x181536D50")]
		public UITextNotifyView()
		{
		}

		// Token: 0x0402439A RID: 148378
		[Token(Token = "0x402439A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _text;

		// Token: 0x0402439B RID: 148379
		[Token(Token = "0x402439B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _maxTextHeight;

		// Token: 0x0402439C RID: 148380
		[Token(Token = "0x402439C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402439D RID: 148381
		[Token(Token = "0x402439D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
