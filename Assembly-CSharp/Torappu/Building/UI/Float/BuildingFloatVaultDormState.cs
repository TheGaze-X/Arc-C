using System;
using Il2CppDummyDll;
using Torappu.Building.DIY.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DE5 RID: 7653
	[Token(Token = "0x2001DE5")]
	public class BuildingFloatVaultDormState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x0600BCDF RID: 48351 RVA: 0x00046380 File Offset: 0x00044580
		[Token(Token = "0x170016DA")]
		public bool DIYShopShown
		{
			[Token(Token = "0x600BCDF")]
			[Address(RVA = "0x33AA130", Offset = "0x33A8D30", VA = "0x1833AA130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x0600BCE0 RID: 48352 RVA: 0x00046398 File Offset: 0x00044598
		[Token(Token = "0x170016DB")]
		protected override FloatState state
		{
			[Token(Token = "0x600BCE0")]
			[Address(RVA = "0x33AA1F0", Offset = "0x33A8DF0", VA = "0x1833AA1F0", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE1")]
		[Address(RVA = "0x33A9740", Offset = "0x33A8340", VA = "0x1833A9740", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE2")]
		[Address(RVA = "0x33A9320", Offset = "0x33A7F20", VA = "0x1833A9320", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE3")]
		[Address(RVA = "0x33A9680", Offset = "0x33A8280", VA = "0x1833A9680", Slot = "7")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE4")]
		[Address(RVA = "0x33A9940", Offset = "0x33A8540", VA = "0x1833A9940", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BCE5 RID: 48357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE5")]
		[Address(RVA = "0x33A8FC0", Offset = "0x33A7BC0", VA = "0x1833A8FC0")]
		public void EventOnDIYClick()
		{
		}

		// Token: 0x0600BCE6 RID: 48358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE6")]
		[Address(RVA = "0x33A90E0", Offset = "0x33A7CE0", VA = "0x1833A90E0")]
		public void EventOnDIYShopClick()
		{
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE7")]
		[Address(RVA = "0x33AA0B0", Offset = "0x33A8CB0", VA = "0x1833AA0B0")]
		public BuildingFloatVaultDormState()
		{
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE9")]
		[Address(RVA = "0x3389D30", Offset = "0x3388930", VA = "0x183389D30")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEA")]
		[Address(RVA = "0x3389D20", Offset = "0x3388920", VA = "0x183389D20")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEB")]
		[Address(RVA = "0x33AA0A0", Offset = "0x33A8CA0", VA = "0x1833AA0A0")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEC")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BD0D RID: 48397
		[Token(Token = "0x400BD0D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _comfortText;

		// Token: 0x0400BD0E RID: 48398
		[Token(Token = "0x400BD0E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _manpowerRecoverText;

		// Token: 0x0400BD0F RID: 48399
		[Token(Token = "0x400BD0F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _shopPanelHolder;

		// Token: 0x0400BD10 RID: 48400
		[Token(Token = "0x400BD10")]
		[FieldOffset(Offset = "0xB8")]
		private DIYShopPanel m_diyShopPanel;

		// Token: 0x0400BD11 RID: 48401
		[Token(Token = "0x400BD11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_DIYShopShown;

		// Token: 0x0400BD12 RID: 48402
		[Token(Token = "0x400BD12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BD13 RID: 48403
		[Token(Token = "0x400BD13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BD14 RID: 48404
		[Token(Token = "0x400BD14")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BD15 RID: 48405
		[Token(Token = "0x400BD15")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400BD16 RID: 48406
		[Token(Token = "0x400BD16")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BD17 RID: 48407
		[Token(Token = "0x400BD17")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnDIYClick;

		// Token: 0x0400BD18 RID: 48408
		[Token(Token = "0x400BD18")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnDIYShopClick;

		// Token: 0x0400BD19 RID: 48409
		[Token(Token = "0x400BD19")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
