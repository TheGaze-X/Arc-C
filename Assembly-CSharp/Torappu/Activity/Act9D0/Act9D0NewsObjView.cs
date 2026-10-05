using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007177 RID: 29047
	[Token(Token = "0x2007177")]
	public class Act9D0NewsObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006198 RID: 24984
		// (get) Token: 0x060293BB RID: 168891 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060293BC RID: 168892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006198")]
		public UIStringEvent onClicked
		{
			[Token(Token = "0x60293BB")]
			[Address(RVA = "0x249E690", Offset = "0x249D290", VA = "0x18249E690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60293BC")]
			[Address(RVA = "0x249E6F0", Offset = "0x249D2F0", VA = "0x18249E6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060293BD RID: 168893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293BD")]
		[Address(RVA = "0x249E360", Offset = "0x249CF60", VA = "0x18249E360")]
		public void Render(Act9D0NewsViewModel model, string chosenId, string actId)
		{
		}

		// Token: 0x060293BE RID: 168894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293BE")]
		[Address(RVA = "0x249E240", Offset = "0x249CE40", VA = "0x18249E240")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060293BF RID: 168895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293BF")]
		[Address(RVA = "0x249E610", Offset = "0x249D210", VA = "0x18249E610")]
		public Act9D0NewsObjView()
		{
		}

		// Token: 0x0403AE29 RID: 241193
		[Token(Token = "0x403AE29")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _newsLogo;

		// Token: 0x0403AE2A RID: 241194
		[Token(Token = "0x403AE2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _newsImg;

		// Token: 0x0403AE2B RID: 241195
		[Token(Token = "0x403AE2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unread;

		// Token: 0x0403AE2C RID: 241196
		[Token(Token = "0x403AE2C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _newsTitle;

		// Token: 0x0403AE2D RID: 241197
		[Token(Token = "0x403AE2D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _newsContent;

		// Token: 0x0403AE2E RID: 241198
		[Token(Token = "0x403AE2E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _constText;

		// Token: 0x0403AE2F RID: 241199
		[Token(Token = "0x403AE2F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _chosenObj;

		// Token: 0x0403AE30 RID: 241200
		[Token(Token = "0x403AE30")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _lightColor;

		// Token: 0x0403AE31 RID: 241201
		[Token(Token = "0x403AE31")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _darkColor;

		// Token: 0x0403AE32 RID: 241202
		[Token(Token = "0x403AE32")]
		[FieldOffset(Offset = "0x70")]
		private string m_newsId;

		// Token: 0x0403AE34 RID: 241204
		[Token(Token = "0x403AE34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0403AE35 RID: 241205
		[Token(Token = "0x403AE35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0403AE36 RID: 241206
		[Token(Token = "0x403AE36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AE37 RID: 241207
		[Token(Token = "0x403AE37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403AE38 RID: 241208
		[Token(Token = "0x403AE38")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
