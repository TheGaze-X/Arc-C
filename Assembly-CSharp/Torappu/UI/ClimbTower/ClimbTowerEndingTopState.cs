using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D1E RID: 23838
	[Token(Token = "0x2005D1E")]
	public class ClimbTowerEndingTopState : PopupFloatState, IHotfixable
	{
		// Token: 0x1700512F RID: 20783
		// (get) Token: 0x0602283C RID: 141372 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602283D RID: 141373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700512F")]
		public List<Coroutine> cachedCoroutine
		{
			[Token(Token = "0x602283C")]
			[Address(RVA = "0x1D00370", Offset = "0x1CFEF70", VA = "0x181D00370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602283D")]
			[Address(RVA = "0x1D003D0", Offset = "0x1CFEFD0", VA = "0x181D003D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602283E RID: 141374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602283E")]
		[Address(RVA = "0x1CFF8A0", Offset = "0x1CFE4A0", VA = "0x181CFF8A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602283F RID: 141375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602283F")]
		[Address(RVA = "0x1CFFA20", Offset = "0x1CFE620", VA = "0x181CFFA20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022840 RID: 141376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022840")]
		[Address(RVA = "0x1D00020", Offset = "0x1CFEC20", VA = "0x181D00020", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022841 RID: 141377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022841")]
		[Address(RVA = "0x1CFFE60", Offset = "0x1CFEA60", VA = "0x181CFFE60", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06022842 RID: 141378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022842")]
		[Address(RVA = "0x1CFF900", Offset = "0x1CFE500", VA = "0x181CFF900")]
		public void OnClick()
		{
		}

		// Token: 0x06022843 RID: 141379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022843")]
		[Address(RVA = "0x1D00200", Offset = "0x1CFEE00", VA = "0x181D00200")]
		public ClimbTowerEndingTopState()
		{
		}

		// Token: 0x06022844 RID: 141380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022844")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022845 RID: 141381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022845")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06022846 RID: 141382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022846")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0402F707 RID: 194311
		[Token(Token = "0x402F707")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerEndingTopView _endingTopView;

		// Token: 0x0402F708 RID: 194312
		[Token(Token = "0x402F708")]
		[FieldOffset(Offset = "0x78")]
		private ClimbTowerEndingTopStateBean m_stateBean;

		// Token: 0x0402F70A RID: 194314
		[Token(Token = "0x402F70A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachedCoroutine;

		// Token: 0x0402F70B RID: 194315
		[Token(Token = "0x402F70B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cachedCoroutine;

		// Token: 0x0402F70C RID: 194316
		[Token(Token = "0x402F70C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F70D RID: 194317
		[Token(Token = "0x402F70D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F70E RID: 194318
		[Token(Token = "0x402F70E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F70F RID: 194319
		[Token(Token = "0x402F70F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402F710 RID: 194320
		[Token(Token = "0x402F710")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402F711 RID: 194321
		[Token(Token = "0x402F711")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
