using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D14 RID: 23828
	[Token(Token = "0x2005D14")]
	public class ClimbTowerEndingState : PopupFadeState, IHotfixable
	{
		// Token: 0x06022819 RID: 141337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022819")]
		[Address(RVA = "0x1CFE780", Offset = "0x1CFD380", VA = "0x181CFE780", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602281A RID: 141338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602281A")]
		[Address(RVA = "0x1CFF090", Offset = "0x1CFDC90", VA = "0x181CFF090", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602281B RID: 141339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602281B")]
		[Address(RVA = "0x1CFE9E0", Offset = "0x1CFD5E0", VA = "0x181CFE9E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602281C RID: 141340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602281C")]
		[Address(RVA = "0x1CFECE0", Offset = "0x1CFD8E0", VA = "0x181CFECE0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602281D RID: 141341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602281D")]
		[Address(RVA = "0x1CFF1F0", Offset = "0x1CFDDF0", VA = "0x181CFF1F0")]
		private void _OnJumpToTopState(IStateBean stateBean)
		{
		}

		// Token: 0x0602281E RID: 141342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602281E")]
		[Address(RVA = "0x1CFE7E0", Offset = "0x1CFD3E0", VA = "0x181CFE7E0")]
		public void OnClick()
		{
		}

		// Token: 0x0602281F RID: 141343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602281F")]
		[Address(RVA = "0x1CFF3C0", Offset = "0x1CFDFC0", VA = "0x181CFF3C0")]
		private IEnumerator _ShowTopState()
		{
			return null;
		}

		// Token: 0x06022820 RID: 141344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022820")]
		[Address(RVA = "0x1CFF470", Offset = "0x1CFE070", VA = "0x181CFF470")]
		public ClimbTowerEndingState()
		{
		}

		// Token: 0x06022821 RID: 141345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022821")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022822 RID: 141346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022822")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022823 RID: 141347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022823")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402F6C9 RID: 194249
		[Token(Token = "0x402F6C9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerEndingView _endingView;

		// Token: 0x0402F6CA RID: 194250
		[Token(Token = "0x402F6CA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402F6CB RID: 194251
		[Token(Token = "0x402F6CB")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerEndingStateBean m_stateBean;

		// Token: 0x0402F6CC RID: 194252
		[Token(Token = "0x402F6CC")]
		[FieldOffset(Offset = "0x88")]
		private string m_currentTowerId;

		// Token: 0x0402F6CD RID: 194253
		[Token(Token = "0x402F6CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F6CE RID: 194254
		[Token(Token = "0x402F6CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F6CF RID: 194255
		[Token(Token = "0x402F6CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F6D0 RID: 194256
		[Token(Token = "0x402F6D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F6D1 RID: 194257
		[Token(Token = "0x402F6D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToTopState;

		// Token: 0x0402F6D2 RID: 194258
		[Token(Token = "0x402F6D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402F6D3 RID: 194259
		[Token(Token = "0x402F6D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowTopState;

		// Token: 0x0402F6D4 RID: 194260
		[Token(Token = "0x402F6D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
