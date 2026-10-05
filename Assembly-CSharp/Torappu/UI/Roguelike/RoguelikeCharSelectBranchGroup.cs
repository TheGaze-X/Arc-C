using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200549C RID: 21660
	[Token(Token = "0x200549C")]
	public class RoguelikeCharSelectBranchGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FDFA RID: 130554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDFA")]
		[Address(RVA = "0x19F22B0", Offset = "0x19F0EB0", VA = "0x1819F22B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FDFB RID: 130555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDFB")]
		[Address(RVA = "0x19F1DA0", Offset = "0x19F09A0", VA = "0x1819F1DA0")]
		public void RenderView(RoguelikeCharSelectBranchGroupViewModel branchModel, UIStringEvent branchSelectEvent)
		{
		}

		// Token: 0x0601FDFC RID: 130556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDFC")]
		[Address(RVA = "0x19F23E0", Offset = "0x19F0FE0", VA = "0x1819F23E0")]
		private void _OnBranchSelected(string equipId)
		{
		}

		// Token: 0x0601FDFD RID: 130557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDFD")]
		[Address(RVA = "0x19F2470", Offset = "0x19F1070", VA = "0x1819F2470")]
		public RoguelikeCharSelectBranchGroup()
		{
		}

		// Token: 0x0402AF59 RID: 175961
		[Token(Token = "0x402AF59")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _talentContainer;

		// Token: 0x0402AF5A RID: 175962
		[Token(Token = "0x402AF5A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentItemPrefab;

		// Token: 0x0402AF5B RID: 175963
		[Token(Token = "0x402AF5B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _subProfName;

		// Token: 0x0402AF5C RID: 175964
		[Token(Token = "0x402AF5C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommentedText _subProfDetailBasic;

		// Token: 0x0402AF5D RID: 175965
		[Token(Token = "0x402AF5D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommentedText _subProfDetailAdditive;

		// Token: 0x0402AF5E RID: 175966
		[Token(Token = "0x402AF5E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _subProfImg;

		// Token: 0x0402AF5F RID: 175967
		[Token(Token = "0x402AF5F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelUniequip;

		// Token: 0x0402AF60 RID: 175968
		[Token(Token = "0x402AF60")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0402AF61 RID: 175969
		[Token(Token = "0x402AF61")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _branchLayout;

		// Token: 0x0402AF62 RID: 175970
		[Token(Token = "0x402AF62")]
		[FieldOffset(Offset = "0x60")]
		private UIStringEvent m_onBranchSelected;

		// Token: 0x0402AF63 RID: 175971
		[Token(Token = "0x402AF63")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTalentViewModel[] m_talentsCache;

		// Token: 0x0402AF64 RID: 175972
		[Token(Token = "0x402AF64")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCharSelectBranchGroup.BranchAdapter m_adapter;

		// Token: 0x0402AF65 RID: 175973
		[Token(Token = "0x402AF65")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0402AF66 RID: 175974
		[Token(Token = "0x402AF66")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AF67 RID: 175975
		[Token(Token = "0x402AF67")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402AF68 RID: 175976
		[Token(Token = "0x402AF68")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBranchSelected;

		// Token: 0x0402AF69 RID: 175977
		[Token(Token = "0x402AF69")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200549D RID: 21661
		[Token(Token = "0x200549D")]
		private class BranchAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004AB8 RID: 19128
			// (get) Token: 0x0601FDFE RID: 130558 RVA: 0x000B3A48 File Offset: 0x000B1C48
			[Token(Token = "0x17004AB8")]
			public override int count
			{
				[Token(Token = "0x601FDFE")]
				[Address(RVA = "0x19E6A30", Offset = "0x19E5630", VA = "0x1819E6A30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601FDFF RID: 130559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FDFF")]
			[Address(RVA = "0x19E6730", Offset = "0x19E5330", VA = "0x1819E6730", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601FE00 RID: 130560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE00")]
			[Address(RVA = "0x19E69D0", Offset = "0x19E55D0", VA = "0x1819E69D0")]
			public BranchAdapter()
			{
			}

			// Token: 0x0402AF6A RID: 175978
			[Token(Token = "0x402AF6A")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeCharSelectBranchGroupViewModel viewModel;

			// Token: 0x0402AF6B RID: 175979
			[Token(Token = "0x402AF6B")]
			[FieldOffset(Offset = "0x28")]
			public RoguelikeCharSelectBranchGroup closure;

			// Token: 0x0402AF6C RID: 175980
			[Token(Token = "0x402AF6C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402AF6D RID: 175981
			[Token(Token = "0x402AF6D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402AF6E RID: 175982
			[Token(Token = "0x402AF6E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
