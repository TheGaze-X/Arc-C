using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FC4 RID: 20420
	[Token(Token = "0x2004FC4")]
	public class EnemyDuelBetSideView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E53B RID: 124219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E53B")]
		[Address(RVA = "0x17F9DB0", Offset = "0x17F89B0", VA = "0x1817F9DB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E53C RID: 124220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E53C")]
		[Address(RVA = "0x17F98F0", Offset = "0x17F84F0", VA = "0x1817F98F0")]
		public void Render(EnemyDuelBetViewModel model, bool isLeft, bool isInit)
		{
		}

		// Token: 0x0601E53D RID: 124221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E53D")]
		[Address(RVA = "0x17F9850", Offset = "0x17F8450", VA = "0x1817F9850")]
		public void OnEnemyDetailBtnClicked()
		{
		}

		// Token: 0x0601E53E RID: 124222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E53E")]
		[Address(RVA = "0x17F9ED0", Offset = "0x17F8AD0", VA = "0x1817F9ED0")]
		public EnemyDuelBetSideView()
		{
		}

		// Token: 0x0402882B RID: 165931
		[Token(Token = "0x402882B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EnemyDuelBetSideView.PnlBetOperation _pnlBetOperation;

		// Token: 0x0402882C RID: 165932
		[Token(Token = "0x402882C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyDuelBetSideView.PnlBetStand _pnlBetStand;

		// Token: 0x0402882D RID: 165933
		[Token(Token = "0x402882D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textPlayerNumDesc;

		// Token: 0x0402882E RID: 165934
		[Token(Token = "0x402882E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnemyDuelBetSidePlayerListView _playerListView;

		// Token: 0x0402882F RID: 165935
		[Token(Token = "0x402882F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _layoutEnemyList;

		// Token: 0x04028830 RID: 165936
		[Token(Token = "0x4028830")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _enemyDetailBtnColorGraphic;

		// Token: 0x04028831 RID: 165937
		[Token(Token = "0x4028831")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EnemyDuelBetEnemyDetailPanel _enemyDetailPanel;

		// Token: 0x04028832 RID: 165938
		[Token(Token = "0x4028832")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedDefaultEnemyTag;

		// Token: 0x04028833 RID: 165939
		[Token(Token = "0x4028833")]
		[FieldOffset(Offset = "0x58")]
		private List<EnemyDuelBetEnemyViewModel> m_cachedEnemyList;

		// Token: 0x04028834 RID: 165940
		[Token(Token = "0x4028834")]
		[FieldOffset(Offset = "0x60")]
		private bool m_cachedIsLeft;

		// Token: 0x04028835 RID: 165941
		[Token(Token = "0x4028835")]
		[FieldOffset(Offset = "0x68")]
		private EnemyDuelBetSideView.Adapter m_adapter;

		// Token: 0x04028836 RID: 165942
		[Token(Token = "0x4028836")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x04028837 RID: 165943
		[Token(Token = "0x4028837")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028838 RID: 165944
		[Token(Token = "0x4028838")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedRefreshPlayerListSeqNum;

		// Token: 0x04028839 RID: 165945
		[Token(Token = "0x4028839")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402883A RID: 165946
		[Token(Token = "0x402883A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402883B RID: 165947
		[Token(Token = "0x402883B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnemyDetailBtnClicked;

		// Token: 0x0402883C RID: 165948
		[Token(Token = "0x402883C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FC5 RID: 20421
		[Token(Token = "0x2004FC5")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E53F RID: 124223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E53F")]
			[Address(RVA = "0x17F77B0", Offset = "0x17F63B0", VA = "0x1817F77B0")]
			public Adapter(EnemyDuelBetSideView closure)
			{
			}

			// Token: 0x170046F3 RID: 18163
			// (get) Token: 0x0601E540 RID: 124224 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
			[Token(Token = "0x170046F3")]
			public override int count
			{
				[Token(Token = "0x601E540")]
				[Address(RVA = "0x17F79B0", Offset = "0x17F65B0", VA = "0x1817F79B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E541 RID: 124225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E541")]
			[Address(RVA = "0x17F7460", Offset = "0x17F6060", VA = "0x1817F7460", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402883D RID: 165949
			[Token(Token = "0x402883D")]
			private const int ENEMY_ITEM_COUNT = 3;

			// Token: 0x0402883E RID: 165950
			[Token(Token = "0x402883E")]
			[FieldOffset(Offset = "0x20")]
			private EnemyDuelBetSideView m_closure;

			// Token: 0x0402883F RID: 165951
			[Token(Token = "0x402883F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028840 RID: 165952
			[Token(Token = "0x4028840")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04028841 RID: 165953
			[Token(Token = "0x4028841")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004FC6 RID: 20422
		[Token(Token = "0x2004FC6")]
		[Serializable]
		private class PnlBetOperation : IHotfixable
		{
			// Token: 0x0601E542 RID: 124226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E542")]
			[Address(RVA = "0x180C410", Offset = "0x180B010", VA = "0x18180C410")]
			public void Render(EnemyDuelBetViewModel model, bool isInit)
			{
			}

			// Token: 0x0601E543 RID: 124227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E543")]
			[Address(RVA = "0x180C5D0", Offset = "0x180B1D0", VA = "0x18180C5D0")]
			public PnlBetOperation()
			{
			}

			// Token: 0x04028842 RID: 165954
			[Token(Token = "0x4028842")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x04028843 RID: 165955
			[Token(Token = "0x4028843")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlNormalBet;

			// Token: 0x04028844 RID: 165956
			[Token(Token = "0x4028844")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _pnlExBet;

			// Token: 0x04028845 RID: 165957
			[Token(Token = "0x4028845")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textBetAmount;

			// Token: 0x04028846 RID: 165958
			[Token(Token = "0x4028846")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textBetAmountEx;

			// Token: 0x04028847 RID: 165959
			[Token(Token = "0x4028847")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textBetAmountExNotEnough;

			// Token: 0x04028848 RID: 165960
			[Token(Token = "0x4028848")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private GameObject _pnlExBetEnough;

			// Token: 0x04028849 RID: 165961
			[Token(Token = "0x4028849")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private GameObject _pnlExBetNotEnough;

			// Token: 0x0402884A RID: 165962
			[Token(Token = "0x402884A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402884B RID: 165963
			[Token(Token = "0x402884B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004FC7 RID: 20423
		[Token(Token = "0x2004FC7")]
		[Serializable]
		private class PnlBetStand : IHotfixable
		{
			// Token: 0x0601E544 RID: 124228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E544")]
			[Address(RVA = "0x180C630", Offset = "0x180B230", VA = "0x18180C630")]
			public void Render(EnemyDuelBetViewModel model, bool isInit)
			{
			}

			// Token: 0x0601E545 RID: 124229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E545")]
			[Address(RVA = "0x180C6E0", Offset = "0x180B2E0", VA = "0x18180C6E0")]
			public PnlBetStand()
			{
			}

			// Token: 0x0402884C RID: 165964
			[Token(Token = "0x402884C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x0402884D RID: 165965
			[Token(Token = "0x402884D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402884E RID: 165966
			[Token(Token = "0x402884E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
