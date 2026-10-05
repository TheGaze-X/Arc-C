using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act33Sign
{
	// Token: 0x02007480 RID: 29824
	[Token(Token = "0x2007480")]
	public class Act33SignRedpackItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A10D RID: 172301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A10D")]
		[Address(RVA = "0x25C0890", Offset = "0x25BF490", VA = "0x1825C0890")]
		public void Render(Act33SignRedpackItemViewModel viewModel)
		{
		}

		// Token: 0x0602A10E RID: 172302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A10E")]
		[Address(RVA = "0x25C0C40", Offset = "0x25BF840", VA = "0x1825C0C40")]
		private void _RenderRewards(ItemBundle item)
		{
		}

		// Token: 0x0602A10F RID: 172303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A10F")]
		[Address(RVA = "0x25C0D90", Offset = "0x25BF990", VA = "0x1825C0D90")]
		public Act33SignRedpackItemView()
		{
		}

		// Token: 0x0403C5D7 RID: 247255
		[Token(Token = "0x403C5D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTips;

		// Token: 0x0403C5D8 RID: 247256
		[Token(Token = "0x403C5D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgNumber;

		// Token: 0x0403C5D9 RID: 247257
		[Token(Token = "0x403C5D9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0403C5DA RID: 247258
		[Token(Token = "0x403C5DA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgDesc;

		// Token: 0x0403C5DB RID: 247259
		[Token(Token = "0x403C5DB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelGot;

		// Token: 0x0403C5DC RID: 247260
		[Token(Token = "0x403C5DC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _redpackBtn;

		// Token: 0x0403C5DD RID: 247261
		[Token(Token = "0x403C5DD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _itemPanel;

		// Token: 0x0403C5DE RID: 247262
		[Token(Token = "0x403C5DE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0403C5DF RID: 247263
		[Token(Token = "0x403C5DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C5E0 RID: 247264
		[Token(Token = "0x403C5E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderRewards;

		// Token: 0x0403C5E1 RID: 247265
		[Token(Token = "0x403C5E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
