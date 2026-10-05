using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053C4 RID: 21444
	[Token(Token = "0x20053C4")]
	public class RoguelikeRewardCapsuleState : PopupFloatState
	{
		// Token: 0x0601F8EE RID: 129262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8EE")]
		[Address(RVA = "0x1938330", Offset = "0x1936F30", VA = "0x181938330", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F8EF RID: 129263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8EF")]
		[Address(RVA = "0x1938410", Offset = "0x1937010", VA = "0x181938410", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F8F0 RID: 129264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8F0")]
		[Address(RVA = "0x1938390", Offset = "0x1936F90", VA = "0x181938390")]
		public void OnClick()
		{
		}

		// Token: 0x0601F8F1 RID: 129265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8F1")]
		[Address(RVA = "0x19385E0", Offset = "0x19371E0", VA = "0x1819385E0")]
		public RoguelikeRewardCapsuleState()
		{
		}

		// Token: 0x0601F8F2 RID: 129266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8F2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402A7D1 RID: 174033
		[Token(Token = "0x402A7D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeRewardCapsuleShowView _view;

		// Token: 0x0402A7D2 RID: 174034
		[Token(Token = "0x402A7D2")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeMenuAdapter m_menuAdapter;

		// Token: 0x0402A7D3 RID: 174035
		[Token(Token = "0x402A7D3")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeRewardCapsuleStateBean m_stateBean;

		// Token: 0x0402A7D4 RID: 174036
		[Token(Token = "0x402A7D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A7D5 RID: 174037
		[Token(Token = "0x402A7D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A7D6 RID: 174038
		[Token(Token = "0x402A7D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A7D7 RID: 174039
		[Token(Token = "0x402A7D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
