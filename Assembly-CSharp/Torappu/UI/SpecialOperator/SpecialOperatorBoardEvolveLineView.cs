using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E89 RID: 16009
	[Token(Token = "0x2003E89")]
	public class SpecialOperatorBoardEvolveLineView : SpecialOperatorBoardEvolveItemView
	{
		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x06018DE9 RID: 101865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B5A")]
		public RectTransform progressAnchor
		{
			[Token(Token = "0x6018DE9")]
			[Address(RVA = "0x1186430", Offset = "0x1185030", VA = "0x181186430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018DEA RID: 101866 RVA: 0x0009C3D8 File Offset: 0x0009A5D8
		[Token(Token = "0x6018DEA")]
		[Address(RVA = "0x11860D0", Offset = "0x1184CD0", VA = "0x1811860D0", Slot = "4")]
		public override SpecialOperatorBoardEvolveItemType GetItemType()
		{
			return SpecialOperatorBoardEvolveItemType.LINE;
		}

		// Token: 0x06018DEB RID: 101867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DEB")]
		[Address(RVA = "0x1186130", Offset = "0x1184D30", VA = "0x181186130", Slot = "5")]
		public override void Render(ISpecialOperatorBoardEvolveItemViewModel viewModel, SpecialOperatorBoardEvolveItemView.Param param)
		{
		}

		// Token: 0x06018DEC RID: 101868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DEC")]
		[Address(RVA = "0x1186390", Offset = "0x1184F90", VA = "0x181186390")]
		public SpecialOperatorBoardEvolveLineView()
		{
		}

		// Token: 0x0401EA0D RID: 125453
		[Token(Token = "0x401EA0D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _LevelMax;

		// Token: 0x0401EA0E RID: 125454
		[Token(Token = "0x401EA0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _pixelPerLevel;

		// Token: 0x0401EA0F RID: 125455
		[Token(Token = "0x401EA0F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _progress;

		// Token: 0x0401EA10 RID: 125456
		[Token(Token = "0x401EA10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0401EA11 RID: 125457
		[Token(Token = "0x401EA11")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _progressAnchor;

		// Token: 0x0401EA12 RID: 125458
		[Token(Token = "0x401EA12")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelFill;

		// Token: 0x0401EA13 RID: 125459
		[Token(Token = "0x401EA13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_progressAnchor;

		// Token: 0x0401EA14 RID: 125460
		[Token(Token = "0x401EA14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetItemType;

		// Token: 0x0401EA15 RID: 125461
		[Token(Token = "0x401EA15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EA16 RID: 125462
		[Token(Token = "0x401EA16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
