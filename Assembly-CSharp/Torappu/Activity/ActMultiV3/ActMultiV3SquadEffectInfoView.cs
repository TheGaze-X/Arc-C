using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EFF RID: 28415
	[Token(Token = "0x2006EFF")]
	public class ActMultiV3SquadEffectInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060285E4 RID: 165348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E4")]
		[Address(RVA = "0x23BC5D0", Offset = "0x23BB1D0", VA = "0x1823BC5D0")]
		public void Render(ActMultiV3SquadEffectModel effectModel)
		{
		}

		// Token: 0x060285E5 RID: 165349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E5")]
		[Address(RVA = "0x23BC8F0", Offset = "0x23BB4F0", VA = "0x1823BC8F0")]
		public ActMultiV3SquadEffectInfoView()
		{
		}

		// Token: 0x04039658 RID: 235096
		[Token(Token = "0x4039658")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgEffectTheme;

		// Token: 0x04039659 RID: 235097
		[Token(Token = "0x4039659")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textEffectName;

		// Token: 0x0403965A RID: 235098
		[Token(Token = "0x403965A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textBuffDesc;

		// Token: 0x0403965B RID: 235099
		[Token(Token = "0x403965B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDebuffDesc;

		// Token: 0x0403965C RID: 235100
		[Token(Token = "0x403965C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _tokenInfoGO;

		// Token: 0x0403965D RID: 235101
		[Token(Token = "0x403965D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTokenName;

		// Token: 0x0403965E RID: 235102
		[Token(Token = "0x403965E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTokenDesc;

		// Token: 0x0403965F RID: 235103
		[Token(Token = "0x403965F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgTokenIcon;

		// Token: 0x04039660 RID: 235104
		[Token(Token = "0x4039660")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039661 RID: 235105
		[Token(Token = "0x4039661")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039662 RID: 235106
		[Token(Token = "0x4039662")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
