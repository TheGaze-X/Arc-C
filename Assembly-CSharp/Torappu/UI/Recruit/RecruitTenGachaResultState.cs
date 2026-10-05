using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046F5 RID: 18165
	[Token(Token = "0x20046F5")]
	public class RecruitTenGachaResultState : PopupFadeState
	{
		// Token: 0x0601B8D5 RID: 112853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B8D5")]
		[Address(RVA = "0x14EC510", Offset = "0x14EB110", VA = "0x1814EC510", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B8D6 RID: 112854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B8D6")]
		[Address(RVA = "0x14ECA60", Offset = "0x14EB660", VA = "0x1814ECA60", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601B8D7 RID: 112855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8D7")]
		[Address(RVA = "0x14EC980", Offset = "0x14EB580", VA = "0x1814EC980")]
		public void ParseDismiss()
		{
		}

		// Token: 0x0601B8D8 RID: 112856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8D8")]
		[Address(RVA = "0x14EC370", Offset = "0x14EAF70", VA = "0x1814EC370")]
		public void DismissOrRemoveTo()
		{
		}

		// Token: 0x0601B8D9 RID: 112857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8D9")]
		[Address(RVA = "0x14EC570", Offset = "0x14EB170", VA = "0x1814EC570", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601B8DA RID: 112858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8DA")]
		[Address(RVA = "0x14EC7F0", Offset = "0x14EB3F0", VA = "0x1814EC7F0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601B8DB RID: 112859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8DB")]
		[Address(RVA = "0x14ECBA0", Offset = "0x14EB7A0", VA = "0x1814ECBA0")]
		private void _PlayTenGachaPanelShownSE()
		{
		}

		// Token: 0x0601B8DC RID: 112860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8DC")]
		[Address(RVA = "0x14ECC30", Offset = "0x14EB830", VA = "0x1814ECC30")]
		public RecruitTenGachaResultState()
		{
		}

		// Token: 0x0601B8DD RID: 112861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B8DD")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601B8DE RID: 112862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8DE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601B8DF RID: 112863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8DF")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04023AFE RID: 146174
		[Token(Token = "0x4023AFE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RecruitTenGachaResultStateBean _stateBean;

		// Token: 0x04023AFF RID: 146175
		[Token(Token = "0x4023AFF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RecruitTenObject _object;

		// Token: 0x04023B00 RID: 146176
		[Token(Token = "0x4023B00")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023B01 RID: 146177
		[Token(Token = "0x4023B01")]
		[FieldOffset(Offset = "0x88")]
		private List<RecruitTenObject> m_objectList;

		// Token: 0x04023B02 RID: 146178
		[Token(Token = "0x4023B02")]
		private const float TIMEPARSE = 2500f;

		// Token: 0x04023B03 RID: 146179
		[Token(Token = "0x4023B03")]
		[FieldOffset(Offset = "0x90")]
		private DateTime m_timeParse;

		// Token: 0x04023B04 RID: 146180
		[Token(Token = "0x4023B04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04023B05 RID: 146181
		[Token(Token = "0x4023B05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04023B06 RID: 146182
		[Token(Token = "0x4023B06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseDismiss;

		// Token: 0x04023B07 RID: 146183
		[Token(Token = "0x4023B07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DismissOrRemoveTo;

		// Token: 0x04023B08 RID: 146184
		[Token(Token = "0x4023B08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023B09 RID: 146185
		[Token(Token = "0x4023B09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04023B0A RID: 146186
		[Token(Token = "0x4023B0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayTenGachaPanelShownSE;

		// Token: 0x04023B0B RID: 146187
		[Token(Token = "0x4023B0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
