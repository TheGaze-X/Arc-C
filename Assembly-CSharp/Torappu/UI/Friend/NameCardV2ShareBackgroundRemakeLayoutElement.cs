using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DCB RID: 19915
	[Token(Token = "0x2004DCB")]
	public class NameCardV2ShareBackgroundRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DC68 RID: 121960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC68")]
		[Address(RVA = "0x1760A20", Offset = "0x175F620", VA = "0x181760A20", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC69 RID: 121961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC69")]
		[Address(RVA = "0x1760C60", Offset = "0x175F860", VA = "0x181760C60")]
		public NameCardV2ShareBackgroundRemakeLayoutElement()
		{
		}

		// Token: 0x04027684 RID: 161412
		[Token(Token = "0x4027684")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04027685 RID: 161413
		[Token(Token = "0x4027685")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgPureColor;

		// Token: 0x04027686 RID: 161414
		[Token(Token = "0x4027686")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _leftBorder;

		// Token: 0x04027687 RID: 161415
		[Token(Token = "0x4027687")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _rightBorder;

		// Token: 0x04027688 RID: 161416
		[Token(Token = "0x4027688")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027689 RID: 161417
		[Token(Token = "0x4027689")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
