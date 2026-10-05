using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056D0 RID: 22224
	[Token(Token = "0x20056D0")]
	public class RL04FragmentGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x06020987 RID: 133511 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020988 RID: 133512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C5D")]
		public ILoadAsset loader
		{
			[Token(Token = "0x6020987")]
			[Address(RVA = "0x1ABCC30", Offset = "0x1ABB830", VA = "0x181ABCC30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020988")]
			[Address(RVA = "0x1ABCCF0", Offset = "0x1ABB8F0", VA = "0x181ABCCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x06020989 RID: 133513 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602098A RID: 133514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C5E")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x6020989")]
			[Address(RVA = "0x1ABCC90", Offset = "0x1ABB890", VA = "0x181ABCC90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602098A")]
			[Address(RVA = "0x1ABCD70", Offset = "0x1ABB970", VA = "0x181ABCD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602098B RID: 133515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602098B")]
		[Address(RVA = "0x1ABC7C0", Offset = "0x1ABB3C0", VA = "0x181ABC7C0")]
		public void Render(RL04FragmentItemGroupViewModel viewModel, RoguelikeFragmentDialogListType fragmentListType)
		{
		}

		// Token: 0x0602098C RID: 133516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602098C")]
		[Address(RVA = "0x1ABCAA0", Offset = "0x1ABB6A0", VA = "0x181ABCAA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602098D RID: 133517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602098D")]
		[Address(RVA = "0x1ABCBD0", Offset = "0x1ABB7D0", VA = "0x181ABCBD0")]
		public RL04FragmentGroupView()
		{
		}

		// Token: 0x0402C2E7 RID: 180967
		[Token(Token = "0x402C2E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelTitle;

		// Token: 0x0402C2E8 RID: 180968
		[Token(Token = "0x402C2E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelFragment;

		// Token: 0x0402C2E9 RID: 180969
		[Token(Token = "0x402C2E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelFragmentDetail;

		// Token: 0x0402C2EA RID: 180970
		[Token(Token = "0x402C2EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelFragmentSummary;

		// Token: 0x0402C2EB RID: 180971
		[Token(Token = "0x402C2EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RL04FragmentGroupView.TitleConfig[] _titleConfigList;

		// Token: 0x0402C2EC RID: 180972
		[Token(Token = "0x402C2EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelFoodUsed;

		// Token: 0x0402C2ED RID: 180973
		[Token(Token = "0x402C2ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelFoodUnused;

		// Token: 0x0402C2EE RID: 180974
		[Token(Token = "0x402C2EE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _summaryContent;

		// Token: 0x0402C2EF RID: 180975
		[Token(Token = "0x402C2EF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _detailContent;

		// Token: 0x0402C2F2 RID: 180978
		[Token(Token = "0x402C2F2")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0402C2F3 RID: 180979
		[Token(Token = "0x402C2F3")]
		[FieldOffset(Offset = "0x78")]
		private RL04FragmentGroupView.Adapter m_detailAdapter;

		// Token: 0x0402C2F4 RID: 180980
		[Token(Token = "0x402C2F4")]
		[FieldOffset(Offset = "0x80")]
		private RL04FragmentGroupView.Adapter m_summaryAdapter;

		// Token: 0x0402C2F5 RID: 180981
		[Token(Token = "0x402C2F5")]
		[FieldOffset(Offset = "0x88")]
		private List<RL04FragmentItemViewModel> m_cachedFragmentList;

		// Token: 0x0402C2F6 RID: 180982
		[Token(Token = "0x402C2F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402C2F7 RID: 180983
		[Token(Token = "0x402C2F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402C2F8 RID: 180984
		[Token(Token = "0x402C2F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0402C2F9 RID: 180985
		[Token(Token = "0x402C2F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0402C2FA RID: 180986
		[Token(Token = "0x402C2FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C2FB RID: 180987
		[Token(Token = "0x402C2FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C2FC RID: 180988
		[Token(Token = "0x402C2FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056D1 RID: 22225
		[Token(Token = "0x20056D1")]
		[Serializable]
		private struct TitleConfig
		{
			// Token: 0x0402C2FD RID: 180989
			[Token(Token = "0x402C2FD")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeFragmentType type;

			// Token: 0x0402C2FE RID: 180990
			[Token(Token = "0x402C2FE")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelTitle;
		}

		// Token: 0x020056D2 RID: 22226
		[Token(Token = "0x20056D2")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602098E RID: 133518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602098E")]
			[Address(RVA = "0x1ABA380", Offset = "0x1AB8F80", VA = "0x181ABA380")]
			public Adapter(RL04FragmentGroupView closure)
			{
			}

			// Token: 0x17004C5F RID: 19551
			// (get) Token: 0x0602098F RID: 133519 RVA: 0x000B6730 File Offset: 0x000B4930
			[Token(Token = "0x17004C5F")]
			public override int count
			{
				[Token(Token = "0x602098F")]
				[Address(RVA = "0x1ABA480", Offset = "0x1AB9080", VA = "0x181ABA480", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020990 RID: 133520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020990")]
			[Address(RVA = "0x1ABA100", Offset = "0x1AB8D00", VA = "0x181ABA100", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C2FF RID: 180991
			[Token(Token = "0x402C2FF")]
			[FieldOffset(Offset = "0x20")]
			private RL04FragmentGroupView m_closure;

			// Token: 0x0402C300 RID: 180992
			[Token(Token = "0x402C300")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C301 RID: 180993
			[Token(Token = "0x402C301")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C302 RID: 180994
			[Token(Token = "0x402C302")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
