using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E1F RID: 19999
	[Token(Token = "0x2004E1F")]
	public class FireworkAnimalNotify : UINotifyView<FireworkAnimalNotify.Param>, IHotfixable
	{
		// Token: 0x0601DE1A RID: 122394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE1A")]
		[Address(RVA = "0x1769220", Offset = "0x1767E20", VA = "0x181769220", Slot = "9")]
		protected override void Render(FireworkAnimalNotify.Param param)
		{
		}

		// Token: 0x0601DE1B RID: 122395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE1B")]
		[Address(RVA = "0x1769320", Offset = "0x1767F20", VA = "0x181769320")]
		public FireworkAnimalNotify()
		{
		}

		// Token: 0x040279FA RID: 162298
		[Token(Token = "0x40279FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x040279FB RID: 162299
		[Token(Token = "0x40279FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textToast;

		// Token: 0x040279FC RID: 162300
		[Token(Token = "0x40279FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040279FD RID: 162301
		[Token(Token = "0x40279FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E20 RID: 20000
		[Token(Token = "0x2004E20")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0601DE1C RID: 122396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE1C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x040279FE RID: 162302
			[Token(Token = "0x40279FE")]
			[FieldOffset(Offset = "0x10")]
			public string toastInfo;

			// Token: 0x040279FF RID: 162303
			[Token(Token = "0x40279FF")]
			[FieldOffset(Offset = "0x18")]
			public string iconId;
		}
	}
}
