using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200667B RID: 26235
	[Token(Token = "0x200667B")]
	public class HandBookInfoStageDetailState : UIPopupState
	{
		// Token: 0x06025A99 RID: 154265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A99")]
		[Address(RVA = "0x2092C90", Offset = "0x2091890", VA = "0x182092C90")]
		public void OnStartBattleClick()
		{
		}

		// Token: 0x06025A9A RID: 154266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A9A")]
		[Address(RVA = "0x2092BA0", Offset = "0x20917A0", VA = "0x182092BA0")]
		public void OnOpenEnemy()
		{
		}

		// Token: 0x06025A9B RID: 154267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A9B")]
		[Address(RVA = "0x2092EB0", Offset = "0x2091AB0", VA = "0x182092EB0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025A9C RID: 154268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A9C")]
		[Address(RVA = "0x2092740", Offset = "0x2091340", VA = "0x182092740", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025A9D RID: 154269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A9D")]
		[Address(RVA = "0x20929D0", Offset = "0x20915D0", VA = "0x1820929D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025A9E RID: 154270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A9E")]
		[Address(RVA = "0x2093010", Offset = "0x2091C10", VA = "0x182093010", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06025A9F RID: 154271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A9F")]
		[Address(RVA = "0x2093150", Offset = "0x2091D50", VA = "0x182093150", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06025AA0 RID: 154272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AA0")]
		[Address(RVA = "0x20927A0", Offset = "0x20913A0", VA = "0x1820927A0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06025AA1 RID: 154273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AA1")]
		[Address(RVA = "0x20928E0", Offset = "0x20914E0", VA = "0x1820928E0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06025AA2 RID: 154274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AA2")]
		[Address(RVA = "0x2093620", Offset = "0x2092220", VA = "0x182093620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025AA3 RID: 154275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AA3")]
		[Address(RVA = "0x20937B0", Offset = "0x20923B0", VA = "0x1820937B0")]
		public HandBookInfoStageDetailState()
		{
		}

		// Token: 0x06025AA7 RID: 154279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AA7")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025AA8 RID: 154280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AA8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04034EBA RID: 216762
		[Token(Token = "0x4034EBA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HandBookInfoStageDetailView _view;

		// Token: 0x04034EBB RID: 216763
		[Token(Token = "0x4034EBB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04034EBC RID: 216764
		[Token(Token = "0x4034EBC")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04034EBD RID: 216765
		[Token(Token = "0x4034EBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStartBattleClick;

		// Token: 0x04034EBE RID: 216766
		[Token(Token = "0x4034EBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnOpenEnemy;

		// Token: 0x04034EBF RID: 216767
		[Token(Token = "0x4034EBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04034EC0 RID: 216768
		[Token(Token = "0x4034EC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034EC1 RID: 216769
		[Token(Token = "0x4034EC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034EC2 RID: 216770
		[Token(Token = "0x4034EC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04034EC3 RID: 216771
		[Token(Token = "0x4034EC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04034EC4 RID: 216772
		[Token(Token = "0x4034EC4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04034EC5 RID: 216773
		[Token(Token = "0x4034EC5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04034EC6 RID: 216774
		[Token(Token = "0x4034EC6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034EC7 RID: 216775
		[Token(Token = "0x4034EC7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
