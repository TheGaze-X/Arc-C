using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200717A RID: 29050
	[Token(Token = "0x200717A")]
	public class Act9D0NewsView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060293D3 RID: 168915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293D3")]
		[Address(RVA = "0x24A11E0", Offset = "0x249FDE0", VA = "0x1824A11E0")]
		public void Render(Act9D0NewsStateBean stateBean, string chosenId)
		{
		}

		// Token: 0x060293D4 RID: 168916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293D4")]
		[Address(RVA = "0x24A0CF0", Offset = "0x249F8F0", VA = "0x1824A0CF0")]
		public void RenderDetail(Act9D0NewsViewModel viewModel)
		{
		}

		// Token: 0x060293D5 RID: 168917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293D5")]
		[Address(RVA = "0x24A15B0", Offset = "0x24A01B0", VA = "0x1824A15B0")]
		private void _ClearContent()
		{
		}

		// Token: 0x060293D6 RID: 168918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293D6")]
		[Address(RVA = "0x24A1300", Offset = "0x249FF00", VA = "0x1824A1300")]
		public void ScrollToGroupPos(int index = 0)
		{
		}

		// Token: 0x060293D7 RID: 168919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293D7")]
		[Address(RVA = "0x24A16B0", Offset = "0x24A02B0", VA = "0x1824A16B0")]
		public Act9D0NewsView()
		{
		}

		// Token: 0x0403AE4F RID: 241231
		[Token(Token = "0x403AE4F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act9D0NewsGroupAdapter _newsAdapter;

		// Token: 0x0403AE50 RID: 241232
		[Token(Token = "0x403AE50")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _detailContent;

		// Token: 0x0403AE51 RID: 241233
		[Token(Token = "0x403AE51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act9D0NewsDetailObjView _titleObj;

		// Token: 0x0403AE52 RID: 241234
		[Token(Token = "0x403AE52")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act9D0NewsDetailObjView _textObj;

		// Token: 0x0403AE53 RID: 241235
		[Token(Token = "0x403AE53")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act9D0NewsDetailObjView _imgObj;

		// Token: 0x0403AE54 RID: 241236
		[Token(Token = "0x403AE54")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _detailMainLogo;

		// Token: 0x0403AE55 RID: 241237
		[Token(Token = "0x403AE55")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LoopScrollRect _scrollRect;

		// Token: 0x0403AE56 RID: 241238
		[Token(Token = "0x403AE56")]
		[FieldOffset(Offset = "0x50")]
		private string cachedActId;

		// Token: 0x0403AE57 RID: 241239
		[Token(Token = "0x403AE57")]
		[FieldOffset(Offset = "0x58")]
		private Act9D0NewsStateBean cachedBean;

		// Token: 0x0403AE58 RID: 241240
		[Token(Token = "0x403AE58")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_cacheTween;

		// Token: 0x0403AE59 RID: 241241
		[Token(Token = "0x403AE59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AE5A RID: 241242
		[Token(Token = "0x403AE5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderDetail;

		// Token: 0x0403AE5B RID: 241243
		[Token(Token = "0x403AE5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearContent;

		// Token: 0x0403AE5C RID: 241244
		[Token(Token = "0x403AE5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ScrollToGroupPos;

		// Token: 0x0403AE5D RID: 241245
		[Token(Token = "0x403AE5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
