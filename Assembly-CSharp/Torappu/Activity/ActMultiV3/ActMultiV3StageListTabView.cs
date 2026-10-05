using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007004 RID: 28676
	[Token(Token = "0x2007004")]
	public class ActMultiV3StageListTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028B5F RID: 166751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B5F")]
		[Address(RVA = "0x2413030", Offset = "0x2411C30", VA = "0x182413030")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B60 RID: 166752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B60")]
		[Address(RVA = "0x2412D20", Offset = "0x2411920", VA = "0x182412D20")]
		public void Render(ActMultiV3StageListViewModel model)
		{
		}

		// Token: 0x06028B61 RID: 166753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B61")]
		[Address(RVA = "0x2412C30", Offset = "0x2411830", VA = "0x182412C30")]
		public void OnClicked()
		{
		}

		// Token: 0x06028B62 RID: 166754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B62")]
		[Address(RVA = "0x2413110", Offset = "0x2411D10", VA = "0x182413110")]
		public ActMultiV3StageListTabView()
		{
		}

		// Token: 0x0403A073 RID: 237683
		[Token(Token = "0x403A073")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _pnlSelected;

		// Token: 0x0403A074 RID: 237684
		[Token(Token = "0x403A074")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDiffName;

		// Token: 0x0403A075 RID: 237685
		[Token(Token = "0x403A075")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3MapDiffType _diffType;

		// Token: 0x0403A076 RID: 237686
		[Token(Token = "0x403A076")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasRaycast;

		// Token: 0x0403A077 RID: 237687
		[Token(Token = "0x403A077")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A078 RID: 237688
		[Token(Token = "0x403A078")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_tabSelectSwitchTween;

		// Token: 0x0403A079 RID: 237689
		[Token(Token = "0x403A079")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0403A07A RID: 237690
		[Token(Token = "0x403A07A")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedLoadDataSeqNum;

		// Token: 0x0403A07B RID: 237691
		[Token(Token = "0x403A07B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A07C RID: 237692
		[Token(Token = "0x403A07C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A07D RID: 237693
		[Token(Token = "0x403A07D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403A07E RID: 237694
		[Token(Token = "0x403A07E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
