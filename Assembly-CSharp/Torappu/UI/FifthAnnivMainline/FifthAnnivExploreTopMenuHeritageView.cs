using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F1E RID: 20254
	[Token(Token = "0x2004F1E")]
	public class FifthAnnivExploreTopMenuHeritageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x0601E2E3 RID: 123619 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E2E2 RID: 123618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046BF")]
		public Action onBtnClick
		{
			[Token(Token = "0x601E2E3")]
			[Address(RVA = "0x17F3490", Offset = "0x17F2090", VA = "0x1817F3490")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E2E2")]
			[Address(RVA = "0x17F34F0", Offset = "0x17F20F0", VA = "0x1817F34F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E2E4 RID: 123620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2E4")]
		[Address(RVA = "0x17F3210", Offset = "0x17F1E10", VA = "0x1817F3210")]
		public void Render(FifthAnnivExploreGroupHeritageViewModel viewModel)
		{
		}

		// Token: 0x0601E2E5 RID: 123621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2E5")]
		[Address(RVA = "0x17F3100", Offset = "0x17F1D00", VA = "0x1817F3100")]
		public void OnBtnClick()
		{
		}

		// Token: 0x0601E2E6 RID: 123622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2E6")]
		[Address(RVA = "0x17F3430", Offset = "0x17F2030", VA = "0x1817F3430")]
		public FifthAnnivExploreTopMenuHeritageView()
		{
		}

		// Token: 0x04028321 RID: 164641
		[Token(Token = "0x4028321")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _emptyHeritageToogle;

		// Token: 0x04028322 RID: 164642
		[Token(Token = "0x4028322")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _groupIconImg;

		// Token: 0x04028323 RID: 164643
		[Token(Token = "0x4028323")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _groupIconAtlas;

		// Token: 0x04028324 RID: 164644
		[Token(Token = "0x4028324")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _groupNameText;

		// Token: 0x04028325 RID: 164645
		[Token(Token = "0x4028325")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _heritageSelectObj;

		// Token: 0x04028327 RID: 164647
		[Token(Token = "0x4028327")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onBtnClick;

		// Token: 0x04028328 RID: 164648
		[Token(Token = "0x4028328")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onBtnClick;

		// Token: 0x04028329 RID: 164649
		[Token(Token = "0x4028329")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402832A RID: 164650
		[Token(Token = "0x402832A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnClick;

		// Token: 0x0402832B RID: 164651
		[Token(Token = "0x402832B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
