using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035B9 RID: 13753
	[Token(Token = "0x20035B9")]
	public class CommonSquadCardViewWithPredefine : CommonSquadCardViewBase
	{
		// Token: 0x06015E1D RID: 89629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E1D")]
		[Address(RVA = "0xE620B0", Offset = "0xE60CB0", VA = "0x180E620B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015E1E RID: 89630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E1E")]
		[Address(RVA = "0xE61F20", Offset = "0xE60B20", VA = "0x180E61F20", Slot = "5")]
		protected override void CustomRenderCard(CommonSquadCardViewBase.Options input)
		{
		}

		// Token: 0x06015E1F RID: 89631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E1F")]
		[Address(RVA = "0xE622B0", Offset = "0xE60EB0", VA = "0x180E622B0")]
		public CommonSquadCardViewWithPredefine()
		{
		}

		// Token: 0x0401A50C RID: 107788
		[Token(Token = "0x401A50C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401A50D RID: 107789
		[Token(Token = "0x401A50D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0401A50E RID: 107790
		[Token(Token = "0x401A50E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0401A50F RID: 107791
		[Token(Token = "0x401A50F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelPredefined;

		// Token: 0x0401A510 RID: 107792
		[Token(Token = "0x401A510")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _cardScale;

		// Token: 0x0401A511 RID: 107793
		[Token(Token = "0x401A511")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401A512 RID: 107794
		[Token(Token = "0x401A512")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0401A513 RID: 107795
		[Token(Token = "0x401A513")]
		[FieldOffset(Offset = "0x70")]
		private CommonCharCardView m_cacheCard;

		// Token: 0x0401A514 RID: 107796
		[Token(Token = "0x401A514")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A515 RID: 107797
		[Token(Token = "0x401A515")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CustomRenderCard;

		// Token: 0x0401A516 RID: 107798
		[Token(Token = "0x401A516")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
