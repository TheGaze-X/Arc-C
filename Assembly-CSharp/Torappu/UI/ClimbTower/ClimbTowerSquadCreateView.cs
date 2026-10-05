using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D61 RID: 23905
	[Token(Token = "0x2005D61")]
	public class ClimbTowerSquadCreateView : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x1700519B RID: 20891
		// (get) Token: 0x06022A15 RID: 141845 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A16 RID: 141846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700519B")]
		public Action<int> onSlotClick
		{
			[Token(Token = "0x6022A15")]
			[Address(RVA = "0x1D261C0", Offset = "0x1D24DC0", VA = "0x181D261C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022A16")]
			[Address(RVA = "0x1D26320", Offset = "0x1D24F20", VA = "0x181D26320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700519C RID: 20892
		// (get) Token: 0x06022A17 RID: 141847 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A18 RID: 141848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700519C")]
		public Action<int> onClearAssistClick
		{
			[Token(Token = "0x6022A17")]
			[Address(RVA = "0x1D26100", Offset = "0x1D24D00", VA = "0x181D26100")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022A18")]
			[Address(RVA = "0x1D26220", Offset = "0x1D24E20", VA = "0x181D26220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700519D RID: 20893
		// (get) Token: 0x06022A19 RID: 141849 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A1A RID: 141850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700519D")]
		public Action<int> onGetAssistClick
		{
			[Token(Token = "0x6022A19")]
			[Address(RVA = "0x1D26160", Offset = "0x1D24D60", VA = "0x181D26160")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022A1A")]
			[Address(RVA = "0x1D262A0", Offset = "0x1D24EA0", VA = "0x181D262A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022A1B RID: 141851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A1B")]
		[Address(RVA = "0x1D25850", Offset = "0x1D24450", VA = "0x181D25850", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x06022A1C RID: 141852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A1C")]
		[Address(RVA = "0x1D257E0", Offset = "0x1D243E0", VA = "0x181D257E0")]
		public void FocusToEnd()
		{
		}

		// Token: 0x06022A1D RID: 141853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A1D")]
		[Address(RVA = "0x1D25E70", Offset = "0x1D24A70", VA = "0x181D25E70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022A1E RID: 141854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A1E")]
		[Address(RVA = "0x1D25D60", Offset = "0x1D24960", VA = "0x181D25D60")]
		private void _CalcDisplayCount()
		{
		}

		// Token: 0x06022A1F RID: 141855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A1F")]
		[Address(RVA = "0x1D26080", Offset = "0x1D24C80", VA = "0x181D26080")]
		public ClimbTowerSquadCreateView()
		{
		}

		// Token: 0x0402F977 RID: 194935
		[Token(Token = "0x402F977")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _squadList;

		// Token: 0x0402F978 RID: 194936
		[Token(Token = "0x402F978")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _squadGridLayout;

		// Token: 0x0402F979 RID: 194937
		[Token(Token = "0x402F979")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCaption;

		// Token: 0x0402F97A RID: 194938
		[Token(Token = "0x402F97A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCurrentCount;

		// Token: 0x0402F97B RID: 194939
		[Token(Token = "0x402F97B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTotalCount;

		// Token: 0x0402F97C RID: 194940
		[Token(Token = "0x402F97C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _squadScrollRect;

		// Token: 0x0402F97D RID: 194941
		[Token(Token = "0x402F97D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _scrollDuration;

		// Token: 0x0402F97E RID: 194942
		[Token(Token = "0x402F97E")]
		[FieldOffset(Offset = "0x54")]
		private bool m_hasInited;

		// Token: 0x0402F97F RID: 194943
		[Token(Token = "0x402F97F")]
		[FieldOffset(Offset = "0x58")]
		private int m_displaySlotCount;

		// Token: 0x0402F980 RID: 194944
		[Token(Token = "0x402F980")]
		[FieldOffset(Offset = "0x60")]
		private ClimbTowerSquadCreateView.SquadListAdapter m_adapter;

		// Token: 0x0402F984 RID: 194948
		[Token(Token = "0x402F984")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSlotClick;

		// Token: 0x0402F985 RID: 194949
		[Token(Token = "0x402F985")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSlotClick;

		// Token: 0x0402F986 RID: 194950
		[Token(Token = "0x402F986")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClearAssistClick;

		// Token: 0x0402F987 RID: 194951
		[Token(Token = "0x402F987")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClearAssistClick;

		// Token: 0x0402F988 RID: 194952
		[Token(Token = "0x402F988")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onGetAssistClick;

		// Token: 0x0402F989 RID: 194953
		[Token(Token = "0x402F989")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onGetAssistClick;

		// Token: 0x0402F98A RID: 194954
		[Token(Token = "0x402F98A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F98B RID: 194955
		[Token(Token = "0x402F98B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FocusToEnd;

		// Token: 0x0402F98C RID: 194956
		[Token(Token = "0x402F98C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F98D RID: 194957
		[Token(Token = "0x402F98D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalcDisplayCount;

		// Token: 0x0402F98E RID: 194958
		[Token(Token = "0x402F98E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D62 RID: 23906
		[Token(Token = "0x2005D62")]
		private class SquadListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700519E RID: 20894
			// (get) Token: 0x06022A20 RID: 141856 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06022A21 RID: 141857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700519E")]
			public Action<int> onSlotClick
			{
				[Token(Token = "0x6022A20")]
				[Address(RVA = "0x1D2FAC0", Offset = "0x1D2E6C0", VA = "0x181D2FAC0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6022A21")]
				[Address(RVA = "0x1D2FC20", Offset = "0x1D2E820", VA = "0x181D2FC20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700519F RID: 20895
			// (get) Token: 0x06022A22 RID: 141858 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06022A23 RID: 141859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700519F")]
			public Action<int> onGetAssistClick
			{
				[Token(Token = "0x6022A22")]
				[Address(RVA = "0x1D2FA60", Offset = "0x1D2E660", VA = "0x181D2FA60")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6022A23")]
				[Address(RVA = "0x1D2FBA0", Offset = "0x1D2E7A0", VA = "0x181D2FBA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170051A0 RID: 20896
			// (get) Token: 0x06022A24 RID: 141860 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06022A25 RID: 141861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170051A0")]
			public Action<int> onClearAssistClick
			{
				[Token(Token = "0x6022A24")]
				[Address(RVA = "0x1D2FA00", Offset = "0x1D2E600", VA = "0x181D2FA00")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6022A25")]
				[Address(RVA = "0x1D2FB20", Offset = "0x1D2E720", VA = "0x181D2FB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06022A26 RID: 141862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022A26")]
			[Address(RVA = "0x1D2F870", Offset = "0x1D2E470", VA = "0x181D2F870")]
			public void SetData(ClimbTowerSquadGroupViewModel squadViewModel, int displayCount)
			{
			}

			// Token: 0x170051A1 RID: 20897
			// (get) Token: 0x06022A27 RID: 141863 RVA: 0x000BE320 File Offset: 0x000BC520
			[Token(Token = "0x170051A1")]
			public override int count
			{
				[Token(Token = "0x6022A27")]
				[Address(RVA = "0x1D2F970", Offset = "0x1D2E570", VA = "0x181D2F970", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022A28 RID: 141864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022A28")]
			[Address(RVA = "0x1D2F320", Offset = "0x1D2DF20", VA = "0x181D2F320", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022A29 RID: 141865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022A29")]
			[Address(RVA = "0x1D2F910", Offset = "0x1D2E510", VA = "0x181D2F910")]
			public SquadListAdapter()
			{
			}

			// Token: 0x0402F98F RID: 194959
			[Token(Token = "0x402F98F")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadGroupViewModel m_squadViewModel;

			// Token: 0x0402F990 RID: 194960
			[Token(Token = "0x402F990")]
			[FieldOffset(Offset = "0x28")]
			private int m_displayCount;

			// Token: 0x0402F994 RID: 194964
			[Token(Token = "0x402F994")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_onSlotClick;

			// Token: 0x0402F995 RID: 194965
			[Token(Token = "0x402F995")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_onSlotClick;

			// Token: 0x0402F996 RID: 194966
			[Token(Token = "0x402F996")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_onGetAssistClick;

			// Token: 0x0402F997 RID: 194967
			[Token(Token = "0x402F997")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_onGetAssistClick;

			// Token: 0x0402F998 RID: 194968
			[Token(Token = "0x402F998")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_onClearAssistClick;

			// Token: 0x0402F999 RID: 194969
			[Token(Token = "0x402F999")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_onClearAssistClick;

			// Token: 0x0402F99A RID: 194970
			[Token(Token = "0x402F99A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x0402F99B RID: 194971
			[Token(Token = "0x402F99B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F99C RID: 194972
			[Token(Token = "0x402F99C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402F99D RID: 194973
			[Token(Token = "0x402F99D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
