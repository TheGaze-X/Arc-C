using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DE4 RID: 7652
	[Token(Token = "0x2001DE4")]
	public class BuildingFloatVaultControlState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x0600BCD9 RID: 48345 RVA: 0x00046368 File Offset: 0x00044568
		[Token(Token = "0x170016D9")]
		protected override FloatState state
		{
			[Token(Token = "0x600BCD9")]
			[Address(RVA = "0x33A8F60", Offset = "0x33A7B60", VA = "0x1833A8F60", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDA")]
		[Address(RVA = "0x33A8900", Offset = "0x33A7500", VA = "0x1833A8900", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDB")]
		[Address(RVA = "0x33A8C10", Offset = "0x33A7810", VA = "0x1833A8C10")]
		private void _UpdateMpBuff(long buffVal, SimpleLayoutContent layout, ref BuildingBuffedValueView.ListAdapter refAdapter, Color bkgColor, Color textColor)
		{
		}

		// Token: 0x0600BCDC RID: 48348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDC")]
		[Address(RVA = "0x33A8890", Offset = "0x33A7490", VA = "0x1833A8890")]
		public void EventOnBuildingAssistClicked()
		{
		}

		// Token: 0x0600BCDD RID: 48349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDD")]
		[Address(RVA = "0x33A8E50", Offset = "0x33A7A50", VA = "0x1833A8E50")]
		public BuildingFloatVaultControlState()
		{
		}

		// Token: 0x0600BCDE RID: 48350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDE")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BCFF RID: 48383
		[Token(Token = "0x400BCFF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textMpCost;

		// Token: 0x0400BD00 RID: 48384
		[Token(Token = "0x400BD00")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textMpReduce;

		// Token: 0x0400BD01 RID: 48385
		[Token(Token = "0x400BD01")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SimpleLayoutContent _mpCostLayout;

		// Token: 0x0400BD02 RID: 48386
		[Token(Token = "0x400BD02")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private SimpleLayoutContent _mpReduceLayout;

		// Token: 0x0400BD03 RID: 48387
		[Token(Token = "0x400BD03")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _assistTrackpoint;

		// Token: 0x0400BD04 RID: 48388
		[Token(Token = "0x400BD04")]
		[FieldOffset(Offset = "0xC8")]
		private BuildingBuffedValueView.ListAdapter m_mpCostAdapter;

		// Token: 0x0400BD05 RID: 48389
		[Token(Token = "0x400BD05")]
		[FieldOffset(Offset = "0xD0")]
		private BuildingBuffedValueView.ListAdapter m_mpReduceAdapter;

		// Token: 0x0400BD06 RID: 48390
		[Token(Token = "0x400BD06")]
		[FieldOffset(Offset = "0xD8")]
		private ControlRoomViewModel m_viewModel;

		// Token: 0x0400BD07 RID: 48391
		[Token(Token = "0x400BD07")]
		[FieldOffset(Offset = "0xE0")]
		private string m_colorCode;

		// Token: 0x0400BD08 RID: 48392
		[Token(Token = "0x400BD08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BD09 RID: 48393
		[Token(Token = "0x400BD09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BD0A RID: 48394
		[Token(Token = "0x400BD0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateMpBuff;

		// Token: 0x0400BD0B RID: 48395
		[Token(Token = "0x400BD0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBuildingAssistClicked;

		// Token: 0x0400BD0C RID: 48396
		[Token(Token = "0x400BD0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
