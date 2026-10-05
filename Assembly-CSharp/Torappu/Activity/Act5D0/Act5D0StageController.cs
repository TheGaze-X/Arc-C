using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071DA RID: 29146
	[Token(Token = "0x20071DA")]
	public class Act5D0StageController : ActivityStageController
	{
		// Token: 0x060295A3 RID: 169379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295A3")]
		[Address(RVA = "0x24AC570", Offset = "0x24AB170", VA = "0x1824AC570", Slot = "9")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x170061FB RID: 25083
		// (get) Token: 0x060295A4 RID: 169380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061FB")]
		public static string staticActivityId
		{
			[Token(Token = "0x60295A4")]
			[Address(RVA = "0x24ACBA0", Offset = "0x24AB7A0", VA = "0x1824ACBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060295A5 RID: 169381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295A5")]
		[Address(RVA = "0x24AC620", Offset = "0x24AB220", VA = "0x1824AC620", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x060295A6 RID: 169382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295A6")]
		[Address(RVA = "0x24AC860", Offset = "0x24AB460", VA = "0x1824AC860", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x060295A7 RID: 169383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295A7")]
		[Address(RVA = "0x24AC2D0", Offset = "0x24AAED0", VA = "0x1824AC2D0", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x060295A8 RID: 169384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295A8")]
		[Address(RVA = "0x24ACA50", Offset = "0x24AB650", VA = "0x1824ACA50")]
		private IEnumerator _TrySyncMissionStatus()
		{
			return null;
		}

		// Token: 0x060295A9 RID: 169385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295A9")]
		[Address(RVA = "0x24AC430", Offset = "0x24AB030", VA = "0x1824AC430")]
		public static PlayerActivity.PlayerAct5D0Activity GetAct5D0PlayerInfo(string actId)
		{
			return null;
		}

		// Token: 0x060295AA RID: 169386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295AA")]
		[Address(RVA = "0x24AC370", Offset = "0x24AAF70", VA = "0x1824AC370")]
		public static PlayerActivity.PlayerAct5D0Activity GetAct5D0PlayerInfoFromPlayerData(string actId, PlayerDataModel playerModel)
		{
			return null;
		}

		// Token: 0x060295AB RID: 169387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295AB")]
		[Address(RVA = "0x24ACB00", Offset = "0x24AB700", VA = "0x1824ACB00")]
		public Act5D0StageController()
		{
		}

		// Token: 0x060295AD RID: 169389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295AD")]
		[Address(RVA = "0x246D290", Offset = "0x246BE90", VA = "0x18246D290")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x060295AE RID: 169390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295AE")]
		[Address(RVA = "0x22DB660", Offset = "0x22DA260", VA = "0x1822DB660")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x060295AF RID: 169391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295AF")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0403B0F8 RID: 241912
		[Token(Token = "0x403B0F8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act5D0EntryZoneGroupBinder _entryZoneBinder;

		// Token: 0x0403B0F9 RID: 241913
		[Token(Token = "0x403B0F9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act5D0MapZoneGroupBinder _mapZoneBinder;

		// Token: 0x0403B0FA RID: 241914
		[Token(Token = "0x403B0FA")]
		[FieldOffset(Offset = "0x70")]
		private Act5D0ZoneDescGroupViewProperty m_zoneDescGroupProperty;

		// Token: 0x0403B0FB RID: 241915
		[Token(Token = "0x403B0FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x0403B0FC RID: 241916
		[Token(Token = "0x403B0FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_staticActivityId;

		// Token: 0x0403B0FD RID: 241917
		[Token(Token = "0x403B0FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403B0FE RID: 241918
		[Token(Token = "0x403B0FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403B0FF RID: 241919
		[Token(Token = "0x403B0FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403B100 RID: 241920
		[Token(Token = "0x403B100")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TrySyncMissionStatus;

		// Token: 0x0403B101 RID: 241921
		[Token(Token = "0x403B101")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetAct5D0PlayerInfo;

		// Token: 0x0403B102 RID: 241922
		[Token(Token = "0x403B102")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetAct5D0PlayerInfoFromPlayerData;

		// Token: 0x0403B103 RID: 241923
		[Token(Token = "0x403B103")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020071DB RID: 29147
		[Token(Token = "0x20071DB")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x060295B0 RID: 169392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60295B0")]
			[Address(RVA = "0x24BE8D0", Offset = "0x24BD4D0", VA = "0x1824BE8D0")]
			public Bridge(Act5D0StageController controller)
			{
			}

			// Token: 0x060295B1 RID: 169393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60295B1")]
			[Address(RVA = "0x24BE830", Offset = "0x24BD430", VA = "0x1824BE830", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x0403B104 RID: 241924
			[Token(Token = "0x403B104")]
			[FieldOffset(Offset = "0x18")]
			private Act5D0StageController m_controller;
		}
	}
}
