using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007174 RID: 29044
	[Token(Token = "0x2007174")]
	public class Act9D0NewsDetailObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060293B2 RID: 168882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293B2")]
		[Address(RVA = "0x249D7A0", Offset = "0x249C3A0", VA = "0x18249D7A0")]
		public void RenderTitlePart(Act9D0NewsViewModel viewModel, int unlockCount, Dictionary<string, string> miscHub)
		{
		}

		// Token: 0x060293B3 RID: 168883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293B3")]
		[Address(RVA = "0x249D6C0", Offset = "0x249C2C0", VA = "0x18249D6C0")]
		public void RenderTextPart(string textContent)
		{
		}

		// Token: 0x060293B4 RID: 168884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293B4")]
		[Address(RVA = "0x249D600", Offset = "0x249C200", VA = "0x18249D600")]
		public void RenderImgPart(Sprite newsPic)
		{
		}

		// Token: 0x060293B5 RID: 168885 RVA: 0x000D4CB8 File Offset: 0x000D2EB8
		[Token(Token = "0x60293B5")]
		[Address(RVA = "0x249DBB0", Offset = "0x249C7B0", VA = "0x18249DBB0")]
		private int _CalReadCount(Act9D0NewsViewModel viewModel, int unlockMission)
		{
			return 0;
		}

		// Token: 0x060293B6 RID: 168886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293B6")]
		[Address(RVA = "0x249DF20", Offset = "0x249CB20", VA = "0x18249DF20")]
		public Act9D0NewsDetailObjView()
		{
		}

		// Token: 0x0403AE14 RID: 241172
		[Token(Token = "0x403AE14")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _titlePart;

		// Token: 0x0403AE15 RID: 241173
		[Token(Token = "0x403AE15")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _imgPart;

		// Token: 0x0403AE16 RID: 241174
		[Token(Token = "0x403AE16")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _textPart;

		// Token: 0x0403AE17 RID: 241175
		[Token(Token = "0x403AE17")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0403AE18 RID: 241176
		[Token(Token = "0x403AE18")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _titleAuthor;

		// Token: 0x0403AE19 RID: 241177
		[Token(Token = "0x403AE19")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _readCount;

		// Token: 0x0403AE1A RID: 241178
		[Token(Token = "0x403AE1A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgPartImg;

		// Token: 0x0403AE1B RID: 241179
		[Token(Token = "0x403AE1B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textPartText;

		// Token: 0x0403AE1C RID: 241180
		[Token(Token = "0x403AE1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderTitlePart;

		// Token: 0x0403AE1D RID: 241181
		[Token(Token = "0x403AE1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderTextPart;

		// Token: 0x0403AE1E RID: 241182
		[Token(Token = "0x403AE1E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderImgPart;

		// Token: 0x0403AE1F RID: 241183
		[Token(Token = "0x403AE1F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalReadCount;

		// Token: 0x0403AE20 RID: 241184
		[Token(Token = "0x403AE20")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
