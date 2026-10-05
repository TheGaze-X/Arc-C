using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071EC RID: 29164
	[Token(Token = "0x20071EC")]
	public class Act5D0MissionState : PopupFadeState
	{
		// Token: 0x060295F0 RID: 169456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295F0")]
		[Address(RVA = "0x24AA800", Offset = "0x24A9400", VA = "0x1824AA800", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060295F1 RID: 169457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F1")]
		[Address(RVA = "0x24AAA30", Offset = "0x24A9630", VA = "0x1824AAA30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060295F2 RID: 169458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F2")]
		[Address(RVA = "0x24AA860", Offset = "0x24A9460", VA = "0x1824AA860")]
		private void InitTopMenu()
		{
		}

		// Token: 0x060295F3 RID: 169459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F3")]
		[Address(RVA = "0x24AAC90", Offset = "0x24A9890", VA = "0x1824AAC90")]
		public Act5D0MissionState()
		{
		}

		// Token: 0x060295F5 RID: 169461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403B14E RID: 241998
		[Token(Token = "0x403B14E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act5D0MissionStateBean _stateBean;

		// Token: 0x0403B14F RID: 241999
		[Token(Token = "0x403B14F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act5D0MissionView _view;

		// Token: 0x0403B150 RID: 242000
		[Token(Token = "0x403B150")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x0403B151 RID: 242001
		[Token(Token = "0x403B151")]
		[FieldOffset(Offset = "0x88")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403B152 RID: 242002
		[Token(Token = "0x403B152")]
		[FieldOffset(Offset = "0x90")]
		private string m_cacheTransId;

		// Token: 0x0403B153 RID: 242003
		[Token(Token = "0x403B153")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B154 RID: 242004
		[Token(Token = "0x403B154")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B155 RID: 242005
		[Token(Token = "0x403B155")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitTopMenu;

		// Token: 0x0403B156 RID: 242006
		[Token(Token = "0x403B156")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
