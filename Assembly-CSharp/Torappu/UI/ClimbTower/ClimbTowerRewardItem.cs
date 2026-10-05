using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CA6 RID: 23718
	[Token(Token = "0x2005CA6")]
	public class ClimbTowerRewardItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170050A7 RID: 20647
		// (set) Token: 0x06022551 RID: 140625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050A7")]
		public Action<int> onReceiveRewardClicked
		{
			[Token(Token = "0x6022551")]
			[Address(RVA = "0x1CC1FC0", Offset = "0x1CC0BC0", VA = "0x181CC1FC0")]
			set
			{
			}
		}

		// Token: 0x06022552 RID: 140626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022552")]
		[Address(RVA = "0x1CC1DA0", Offset = "0x1CC09A0", VA = "0x181CC1DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022553 RID: 140627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022553")]
		[Address(RVA = "0x1CC18B0", Offset = "0x1CC04B0", VA = "0x181CC18B0")]
		public void Render(ClimbTowerRewardModel model, ClimbTowerViewModel towerModel)
		{
		}

		// Token: 0x06022554 RID: 140628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022554")]
		[Address(RVA = "0x1CC1820", Offset = "0x1CC0420", VA = "0x181CC1820")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x06022555 RID: 140629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022555")]
		[Address(RVA = "0x1CC1F40", Offset = "0x1CC0B40", VA = "0x181CC1F40")]
		public ClimbTowerRewardItem()
		{
		}

		// Token: 0x0402F279 RID: 193145
		[Token(Token = "0x402F279")]
		private const string MAX_LAYER_FORMAT = "/{0}";

		// Token: 0x0402F27A RID: 193146
		[Token(Token = "0x402F27A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_AVAILABLE;

		// Token: 0x0402F27B RID: 193147
		[Token(Token = "0x402F27B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x0402F27C RID: 193148
		[Token(Token = "0x402F27C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402F27D RID: 193149
		[Token(Token = "0x402F27D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurr;

		// Token: 0x0402F27E RID: 193150
		[Token(Token = "0x402F27E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotal;

		// Token: 0x0402F27F RID: 193151
		[Token(Token = "0x402F27F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F280 RID: 193152
		[Token(Token = "0x402F280")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0402F281 RID: 193153
		[Token(Token = "0x402F281")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelAvailable;

		// Token: 0x0402F282 RID: 193154
		[Token(Token = "0x402F282")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _rewardContainer;

		// Token: 0x0402F283 RID: 193155
		[Token(Token = "0x402F283")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textState;

		// Token: 0x0402F284 RID: 193156
		[Token(Token = "0x402F284")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelCompleted;

		// Token: 0x0402F285 RID: 193157
		[Token(Token = "0x402F285")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0402F286 RID: 193158
		[Token(Token = "0x402F286")]
		[FieldOffset(Offset = "0x68")]
		private List<ItemBundle> m_cachedRewardList;

		// Token: 0x0402F287 RID: 193159
		[Token(Token = "0x402F287")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedLayerNum;

		// Token: 0x0402F288 RID: 193160
		[Token(Token = "0x402F288")]
		[FieldOffset(Offset = "0x78")]
		private ClimbTowerRewardItem.Adapter m_adapter;

		// Token: 0x0402F289 RID: 193161
		[Token(Token = "0x402F289")]
		[FieldOffset(Offset = "0x80")]
		private Action<int> m_onReceiveRewardClicked;

		// Token: 0x0402F28A RID: 193162
		[Token(Token = "0x402F28A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onReceiveRewardClicked;

		// Token: 0x0402F28B RID: 193163
		[Token(Token = "0x402F28B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F28C RID: 193164
		[Token(Token = "0x402F28C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F28D RID: 193165
		[Token(Token = "0x402F28D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402F28E RID: 193166
		[Token(Token = "0x402F28E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CA7 RID: 23719
		[Token(Token = "0x2005CA7")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170050A8 RID: 20648
			// (get) Token: 0x06022557 RID: 140631 RVA: 0x000BD0F0 File Offset: 0x000BB2F0
			[Token(Token = "0x170050A8")]
			public override int count
			{
				[Token(Token = "0x6022557")]
				[Address(RVA = "0x1CB8600", Offset = "0x1CB7200", VA = "0x181CB8600", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022558 RID: 140632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022558")]
			[Address(RVA = "0x1CB8130", Offset = "0x1CB6D30", VA = "0x181CB8130")]
			public Adapter(ClimbTowerRewardItem closure)
			{
			}

			// Token: 0x06022559 RID: 140633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022559")]
			[Address(RVA = "0x1CB7B70", Offset = "0x1CB6770", VA = "0x181CB7B70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F28F RID: 193167
			[Token(Token = "0x402F28F")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerRewardItem m_closure;

			// Token: 0x0402F290 RID: 193168
			[Token(Token = "0x402F290")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F291 RID: 193169
			[Token(Token = "0x402F291")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F292 RID: 193170
			[Token(Token = "0x402F292")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
