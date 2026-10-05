using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004724 RID: 18212
	[Token(Token = "0x2004724")]
	public class RecruitBuildSlotGroupView : DataBinder<BuildSlotGroupViewProperty>
	{
		// Token: 0x0601B9A2 RID: 113058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9A2")]
		[Address(RVA = "0x14DFB30", Offset = "0x14DE730", VA = "0x1814DFB30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B9A3 RID: 113059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9A3")]
		[Address(RVA = "0x14DF990", Offset = "0x14DE590", VA = "0x1814DF990", Slot = "7")]
		public override void OnValueChanged(BuildSlotGroupViewProperty property)
		{
		}

		// Token: 0x0601B9A4 RID: 113060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9A4")]
		[Address(RVA = "0x14DFC30", Offset = "0x14DE830", VA = "0x1814DFC30")]
		public RecruitBuildSlotGroupView()
		{
		}

		// Token: 0x04023C53 RID: 146515
		[Token(Token = "0x4023C53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _slotsLayout;

		// Token: 0x04023C54 RID: 146516
		[Token(Token = "0x4023C54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntEvent _fastFinishEvent;

		// Token: 0x04023C55 RID: 146517
		[Token(Token = "0x4023C55")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIIntEvent _stopRecruitEvent;

		// Token: 0x04023C56 RID: 146518
		[Token(Token = "0x4023C56")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIIntEvent _startRecruitEvent;

		// Token: 0x04023C57 RID: 146519
		[Token(Token = "0x4023C57")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIIntEvent _buildTimeUpEvent;

		// Token: 0x04023C58 RID: 146520
		[Token(Token = "0x4023C58")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIIntEvent _finishBuildEvent;

		// Token: 0x04023C59 RID: 146521
		[Token(Token = "0x4023C59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIIntEvent _buyBuildEvent;

		// Token: 0x04023C5A RID: 146522
		[Token(Token = "0x4023C5A")]
		[FieldOffset(Offset = "0x58")]
		private List<BuildSlotViewModel> m_slotModelsCache;

		// Token: 0x04023C5B RID: 146523
		[Token(Token = "0x4023C5B")]
		[FieldOffset(Offset = "0x60")]
		private RecruitBuildSlotGroupView.SlotsAdapter m_slotsAdapter;

		// Token: 0x04023C5C RID: 146524
		[Token(Token = "0x4023C5C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04023C5D RID: 146525
		[Token(Token = "0x4023C5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023C5E RID: 146526
		[Token(Token = "0x4023C5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023C5F RID: 146527
		[Token(Token = "0x4023C5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004725 RID: 18213
		[Token(Token = "0x2004725")]
		private class SlotsAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B9A5 RID: 113061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9A5")]
			[Address(RVA = "0x14EFC40", Offset = "0x14EE840", VA = "0x1814EFC40")]
			public SlotsAdapter(RecruitBuildSlotGroupView closure)
			{
			}

			// Token: 0x170041AD RID: 16813
			// (get) Token: 0x0601B9A6 RID: 113062 RVA: 0x000A5A68 File Offset: 0x000A3C68
			[Token(Token = "0x170041AD")]
			public override int count
			{
				[Token(Token = "0x601B9A6")]
				[Address(RVA = "0x14EFCC0", Offset = "0x14EE8C0", VA = "0x1814EFCC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B9A7 RID: 113063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B9A7")]
			[Address(RVA = "0x14EF960", Offset = "0x14EE560", VA = "0x1814EF960", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B9A8 RID: 113064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9A8")]
			[Address(RVA = "0x14EF900", Offset = "0x14EE500", VA = "0x1814EF900", Slot = "8")]
			public override void NotifyDataSetChanged()
			{
			}

			// Token: 0x0601B9A9 RID: 113065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9A9")]
			[Address(RVA = "0xDEAD20", Offset = "0xDE9920", VA = "0x180DEAD20")]
			private void <>xLuaBaseProxy_NotifyDataSetChanged()
			{
			}

			// Token: 0x04023C60 RID: 146528
			[Token(Token = "0x4023C60")]
			[FieldOffset(Offset = "0x20")]
			private RecruitBuildSlotGroupView m_closure;

			// Token: 0x04023C61 RID: 146529
			[Token(Token = "0x4023C61")]
			[FieldOffset(Offset = "0x28")]
			private bool m_AVGIsEmptySlotRegistered;

			// Token: 0x04023C62 RID: 146530
			[Token(Token = "0x4023C62")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023C63 RID: 146531
			[Token(Token = "0x4023C63")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023C64 RID: 146532
			[Token(Token = "0x4023C64")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04023C65 RID: 146533
			[Token(Token = "0x4023C65")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyDataSetChanged;
		}
	}
}
