using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BC3 RID: 27587
	[Token(Token = "0x2006BC3")]
	public class ArchiveNewsDetailObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027665 RID: 161381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027665")]
		[Address(RVA = "0x22951D0", Offset = "0x2293DD0", VA = "0x1822951D0")]
		public void RenderTitlePart(NewsItemModel model, ArchiveNewsModel newsModel)
		{
		}

		// Token: 0x06027666 RID: 161382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027666")]
		[Address(RVA = "0x22950F0", Offset = "0x2293CF0", VA = "0x1822950F0")]
		public void RenderTextPart(string textContent)
		{
		}

		// Token: 0x06027667 RID: 161383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027667")]
		[Address(RVA = "0x2295030", Offset = "0x2293C30", VA = "0x182295030")]
		public void RenderImgPart(Sprite newsPic)
		{
		}

		// Token: 0x06027668 RID: 161384 RVA: 0x000CE4F0 File Offset: 0x000CC6F0
		[Token(Token = "0x6027668")]
		[Address(RVA = "0x22954F0", Offset = "0x22940F0", VA = "0x1822954F0")]
		private int _CalReadCount(NewsItemModel model, ArchiveNewsModel newsModel)
		{
			return 0;
		}

		// Token: 0x06027669 RID: 161385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027669")]
		[Address(RVA = "0x2295960", Offset = "0x2294560", VA = "0x182295960")]
		private string _FormatReadCount(int readCount)
		{
			return null;
		}

		// Token: 0x0602766A RID: 161386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602766A")]
		[Address(RVA = "0x2295AD0", Offset = "0x22946D0", VA = "0x182295AD0")]
		public ArchiveNewsDetailObjView()
		{
		}

		// Token: 0x04037D0E RID: 228622
		[Token(Token = "0x4037D0E")]
		private const int BOUND1 = 10000;

		// Token: 0x04037D0F RID: 228623
		[Token(Token = "0x4037D0F")]
		private const int BOUND2 = 200000;

		// Token: 0x04037D10 RID: 228624
		[Token(Token = "0x4037D10")]
		private const int DIVIDER1 = 10000;

		// Token: 0x04037D11 RID: 228625
		[Token(Token = "0x4037D11")]
		private const int DIVIDER2 = 1000;

		// Token: 0x04037D12 RID: 228626
		[Token(Token = "0x4037D12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _titlePart;

		// Token: 0x04037D13 RID: 228627
		[Token(Token = "0x4037D13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _imgPart;

		// Token: 0x04037D14 RID: 228628
		[Token(Token = "0x4037D14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _textPart;

		// Token: 0x04037D15 RID: 228629
		[Token(Token = "0x4037D15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04037D16 RID: 228630
		[Token(Token = "0x4037D16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _titleAuthor;

		// Token: 0x04037D17 RID: 228631
		[Token(Token = "0x4037D17")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _readCount;

		// Token: 0x04037D18 RID: 228632
		[Token(Token = "0x4037D18")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgPartImg;

		// Token: 0x04037D19 RID: 228633
		[Token(Token = "0x4037D19")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textPartText;

		// Token: 0x04037D1A RID: 228634
		[Token(Token = "0x4037D1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderTitlePart;

		// Token: 0x04037D1B RID: 228635
		[Token(Token = "0x4037D1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderTextPart;

		// Token: 0x04037D1C RID: 228636
		[Token(Token = "0x4037D1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderImgPart;

		// Token: 0x04037D1D RID: 228637
		[Token(Token = "0x4037D1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalReadCount;

		// Token: 0x04037D1E RID: 228638
		[Token(Token = "0x4037D1E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FormatReadCount;

		// Token: 0x04037D1F RID: 228639
		[Token(Token = "0x4037D1F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
