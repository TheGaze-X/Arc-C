using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CAA RID: 23722
	[Token(Token = "0x2005CAA")]
	public class ClimbTowerRewardView : DataBinder<ClimbTowerProperty>
	{
		// Token: 0x06022561 RID: 140641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022561")]
		[Address(RVA = "0x1CC28B0", Offset = "0x1CC14B0", VA = "0x181CC28B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022562 RID: 140642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022562")]
		[Address(RVA = "0x1CC2690", Offset = "0x1CC1290", VA = "0x181CC2690", Slot = "7")]
		public override void OnValueChanged(ClimbTowerProperty property)
		{
		}

		// Token: 0x06022563 RID: 140643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022563")]
		[Address(RVA = "0x1CC2600", Offset = "0x1CC1200", VA = "0x181CC2600")]
		public void OnBtnReceiveAllClicked()
		{
		}

		// Token: 0x06022564 RID: 140644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022564")]
		[Address(RVA = "0x1CC29D0", Offset = "0x1CC15D0", VA = "0x181CC29D0")]
		private void _OnBtnReceiveRewardClicked(int layerNum)
		{
		}

		// Token: 0x06022565 RID: 140645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022565")]
		[Address(RVA = "0x1CC2B30", Offset = "0x1CC1730", VA = "0x181CC2B30")]
		public ClimbTowerRewardView()
		{
		}

		// Token: 0x0402F2A2 RID: 193186
		[Token(Token = "0x402F2A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelReceiveAll;

		// Token: 0x0402F2A3 RID: 193187
		[Token(Token = "0x402F2A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _rewardContainer;

		// Token: 0x0402F2A4 RID: 193188
		[Token(Token = "0x402F2A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClimbTowerRewardView.ClimbTowerRewardConfirmdEvent _onRewardConfirmedEvent;

		// Token: 0x0402F2A5 RID: 193189
		[Token(Token = "0x402F2A5")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0402F2A6 RID: 193190
		[Token(Token = "0x402F2A6")]
		[FieldOffset(Offset = "0x40")]
		private ClimbTowerViewModel m_cachedModel;

		// Token: 0x0402F2A7 RID: 193191
		[Token(Token = "0x402F2A7")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerRewardView.Adapter m_adapter;

		// Token: 0x0402F2A8 RID: 193192
		[Token(Token = "0x402F2A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F2A9 RID: 193193
		[Token(Token = "0x402F2A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F2AA RID: 193194
		[Token(Token = "0x402F2AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnReceiveAllClicked;

		// Token: 0x0402F2AB RID: 193195
		[Token(Token = "0x402F2AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBtnReceiveRewardClicked;

		// Token: 0x0402F2AC RID: 193196
		[Token(Token = "0x402F2AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CAB RID: 23723
		[Token(Token = "0x2005CAB")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170050AA RID: 20650
			// (get) Token: 0x06022566 RID: 140646 RVA: 0x000BD108 File Offset: 0x000BB308
			[Token(Token = "0x170050AA")]
			public override int count
			{
				[Token(Token = "0x6022566")]
				[Address(RVA = "0x1CB8570", Offset = "0x1CB7170", VA = "0x181CB8570", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022567 RID: 140647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022567")]
			[Address(RVA = "0x1CB8340", Offset = "0x1CB6F40", VA = "0x181CB8340")]
			public Adapter(ClimbTowerRewardView closure)
			{
			}

			// Token: 0x06022568 RID: 140648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022568")]
			[Address(RVA = "0x1CB7560", Offset = "0x1CB6160", VA = "0x181CB7560", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F2AD RID: 193197
			[Token(Token = "0x402F2AD")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerRewardView m_closure;

			// Token: 0x0402F2AE RID: 193198
			[Token(Token = "0x402F2AE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F2AF RID: 193199
			[Token(Token = "0x402F2AF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F2B0 RID: 193200
			[Token(Token = "0x402F2B0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005CAC RID: 23724
		[Token(Token = "0x2005CAC")]
		[Serializable]
		private class ClimbTowerRewardConfirmdEvent : UnityEvent<string, List<int>>
		{
			// Token: 0x06022569 RID: 140649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022569")]
			[Address(RVA = "0x1CC1160", Offset = "0x1CBFD60", VA = "0x181CC1160")]
			public ClimbTowerRewardConfirmdEvent()
			{
			}
		}
	}
}
