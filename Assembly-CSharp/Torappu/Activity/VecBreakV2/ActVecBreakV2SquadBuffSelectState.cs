using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E6E RID: 28270
	[Token(Token = "0x2006E6E")]
	public class ActVecBreakV2SquadBuffSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060283A4 RID: 164772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283A4")]
		[Address(RVA = "0x2383690", Offset = "0x2382290", VA = "0x182383690", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060283A5 RID: 164773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283A5")]
		[Address(RVA = "0x23836F0", Offset = "0x23822F0", VA = "0x1823836F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060283A6 RID: 164774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283A6")]
		[Address(RVA = "0x2383E20", Offset = "0x2382A20", VA = "0x182383E20", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060283A7 RID: 164775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283A7")]
		[Address(RVA = "0x2384550", Offset = "0x2383150", VA = "0x182384550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060283A8 RID: 164776 RVA: 0x000D0F20 File Offset: 0x000CF120
		[Token(Token = "0x60283A8")]
		[Address(RVA = "0x23846A0", Offset = "0x23832A0", VA = "0x1823846A0")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x060283A9 RID: 164777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283A9")]
		[Address(RVA = "0x2383AF0", Offset = "0x23826F0", VA = "0x182383AF0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060283AA RID: 164778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283AA")]
		[Address(RVA = "0x23842B0", Offset = "0x2382EB0", VA = "0x1823842B0")]
		private void _ClosePage()
		{
		}

		// Token: 0x060283AB RID: 164779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283AB")]
		[Address(RVA = "0x2384CB0", Offset = "0x23838B0", VA = "0x182384CB0")]
		private void _UnselectSingleBuff(string buffId)
		{
		}

		// Token: 0x060283AC RID: 164780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283AC")]
		[Address(RVA = "0x2384B20", Offset = "0x2383720", VA = "0x182384B20")]
		private void _UnselectAll()
		{
		}

		// Token: 0x060283AD RID: 164781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283AD")]
		[Address(RVA = "0x2383F90", Offset = "0x2382B90", VA = "0x182383F90")]
		private void _BuffItemClick(string stageId)
		{
		}

		// Token: 0x060283AE RID: 164782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283AE")]
		[Address(RVA = "0x2384800", Offset = "0x2383400", VA = "0x182384800")]
		private void _SaveBuff()
		{
		}

		// Token: 0x060283AF RID: 164783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283AF")]
		[Address(RVA = "0x2384760", Offset = "0x2383360", VA = "0x182384760")]
		private void _JumpToDefense()
		{
		}

		// Token: 0x060283B0 RID: 164784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283B0")]
		[Address(RVA = "0x2384E50", Offset = "0x2383A50", VA = "0x182384E50")]
		public ActVecBreakV2SquadBuffSelectState()
		{
		}

		// Token: 0x060283B1 RID: 164785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283B1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060283B2 RID: 164786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283B2")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040392BF RID: 234175
		[Token(Token = "0x40392BF")]
		[NonSerialized]
		public const int CLOSE_BTN_CLICK = 0;

		// Token: 0x040392C0 RID: 234176
		[Token(Token = "0x40392C0")]
		[NonSerialized]
		public const int UNSELECT_SINGLE_BUFF = 1;

		// Token: 0x040392C1 RID: 234177
		[Token(Token = "0x40392C1")]
		[NonSerialized]
		public const int UNSELECT_ALL_BUFF = 2;

		// Token: 0x040392C2 RID: 234178
		[Token(Token = "0x40392C2")]
		[NonSerialized]
		public const int BUFF_ITEM_CLICK = 3;

		// Token: 0x040392C3 RID: 234179
		[Token(Token = "0x40392C3")]
		[NonSerialized]
		public const int SAVE_BUFF = 4;

		// Token: 0x040392C4 RID: 234180
		[Token(Token = "0x40392C4")]
		[NonSerialized]
		public const int JUMP_TO_DEFENSE = 5;

		// Token: 0x040392C5 RID: 234181
		[Token(Token = "0x40392C5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActVecBreakV2SquadBuffSelectView _view;

		// Token: 0x040392C6 RID: 234182
		[Token(Token = "0x40392C6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backPressArea;

		// Token: 0x040392C7 RID: 234183
		[Token(Token = "0x40392C7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _squadBuffEditAreaGO;

		// Token: 0x040392C8 RID: 234184
		[Token(Token = "0x40392C8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _squadBuffEquipAreaGO;

		// Token: 0x040392C9 RID: 234185
		[Token(Token = "0x40392C9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _btnNavGO;

		// Token: 0x040392CA RID: 234186
		[Token(Token = "0x40392CA")]
		[FieldOffset(Offset = "0x98")]
		private ActVecBreakV2SquadBuffSelectStateBean m_stateBean;

		// Token: 0x040392CB RID: 234187
		[Token(Token = "0x40392CB")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x040392CC RID: 234188
		[Token(Token = "0x40392CC")]
		[FieldOffset(Offset = "0xA8")]
		private string m_actId;

		// Token: 0x040392CD RID: 234189
		[Token(Token = "0x40392CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040392CE RID: 234190
		[Token(Token = "0x40392CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040392CF RID: 234191
		[Token(Token = "0x40392CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040392D0 RID: 234192
		[Token(Token = "0x40392D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040392D1 RID: 234193
		[Token(Token = "0x40392D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x040392D2 RID: 234194
		[Token(Token = "0x40392D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040392D3 RID: 234195
		[Token(Token = "0x40392D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClosePage;

		// Token: 0x040392D4 RID: 234196
		[Token(Token = "0x40392D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UnselectSingleBuff;

		// Token: 0x040392D5 RID: 234197
		[Token(Token = "0x40392D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UnselectAll;

		// Token: 0x040392D6 RID: 234198
		[Token(Token = "0x40392D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BuffItemClick;

		// Token: 0x040392D7 RID: 234199
		[Token(Token = "0x40392D7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SaveBuff;

		// Token: 0x040392D8 RID: 234200
		[Token(Token = "0x40392D8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__JumpToDefense;

		// Token: 0x040392D9 RID: 234201
		[Token(Token = "0x40392D9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
