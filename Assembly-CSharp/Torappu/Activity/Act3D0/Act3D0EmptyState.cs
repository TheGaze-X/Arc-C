using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073EE RID: 29678
	[Token(Token = "0x20073EE")]
	public class Act3D0EmptyState : State
	{
		// Token: 0x06029EB6 RID: 171702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EB6")]
		[Address(RVA = "0x2587590", Offset = "0x2586190", VA = "0x182587590", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029EB7 RID: 171703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EB7")]
		[Address(RVA = "0x25879F0", Offset = "0x25865F0", VA = "0x1825879F0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029EB8 RID: 171704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EB8")]
		[Address(RVA = "0x25875F0", Offset = "0x25861F0", VA = "0x1825875F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029EB9 RID: 171705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EB9")]
		[Address(RVA = "0x25877B0", Offset = "0x25863B0", VA = "0x1825877B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06029EBA RID: 171706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EBA")]
		[Address(RVA = "0x2587BE0", Offset = "0x25867E0", VA = "0x182587BE0")]
		private void _OnCampSelected(object _)
		{
		}

		// Token: 0x06029EBB RID: 171707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EBB")]
		[Address(RVA = "0x2587940", Offset = "0x2586540", VA = "0x182587940", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06029EBC RID: 171708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EBC")]
		[Address(RVA = "0x2587C70", Offset = "0x2586870", VA = "0x182587C70")]
		public Act3D0EmptyState()
		{
		}

		// Token: 0x06029EBD RID: 171709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EBD")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029EBE RID: 171710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EBE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029EBF RID: 171711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EBF")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06029EC0 RID: 171712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EC0")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403C125 RID: 246053
		[Token(Token = "0x403C125")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x0403C126 RID: 246054
		[Token(Token = "0x403C126")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act3D0GachaBoxStateBean _stateBean;

		// Token: 0x0403C127 RID: 246055
		[Token(Token = "0x403C127")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403C128 RID: 246056
		[Token(Token = "0x403C128")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403C129 RID: 246057
		[Token(Token = "0x403C129")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C12A RID: 246058
		[Token(Token = "0x403C12A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403C12B RID: 246059
		[Token(Token = "0x403C12B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCampSelected;

		// Token: 0x0403C12C RID: 246060
		[Token(Token = "0x403C12C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403C12D RID: 246061
		[Token(Token = "0x403C12D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
