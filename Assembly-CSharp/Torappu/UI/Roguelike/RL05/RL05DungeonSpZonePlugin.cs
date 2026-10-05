using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200561F RID: 22047
	[Token(Token = "0x200561F")]
	public class RL05DungeonSpZonePlugin : RoguelikeDungeonSpZonePluginBase
	{
		// Token: 0x060205AE RID: 132526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205AE")]
		[Address(RVA = "0x1A78820", Offset = "0x1A77420", VA = "0x181A78820", Slot = "4")]
		public override RoguelikeDungeonGeneSpZonePluginBase GetGeneSpZonePlugin()
		{
			return null;
		}

		// Token: 0x060205AF RID: 132527 RVA: 0x000B5848 File Offset: 0x000B3A48
		[Token(Token = "0x60205AF")]
		[Address(RVA = "0x1A78700", Offset = "0x1A77300", VA = "0x181A78700", Slot = "5")]
		public override bool CheckIfNeedLockCamera(RoguelikeDungeonZone dungeonZone)
		{
			return default(bool);
		}

		// Token: 0x060205B0 RID: 132528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205B0")]
		[Address(RVA = "0x1A788F0", Offset = "0x1A774F0", VA = "0x181A788F0", Slot = "6")]
		public override RoguelikeCameraController.RoguelikeCameraConfig GetOverrideCameraConfig(RoguelikeDungeonZone dungeonZone)
		{
			return null;
		}

		// Token: 0x060205B1 RID: 132529 RVA: 0x000B5860 File Offset: 0x000B3A60
		[Token(Token = "0x60205B1")]
		[Address(RVA = "0x1A78A30", Offset = "0x1A77630", VA = "0x181A78A30")]
		private bool _CheckIsSpZone(RoguelikeDungeonZone dungeonZone)
		{
			return default(bool);
		}

		// Token: 0x060205B2 RID: 132530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205B2")]
		[Address(RVA = "0x1A787C0", Offset = "0x1A773C0", VA = "0x181A787C0", Slot = "7")]
		public override GameObject GetFocusNodePluginGO()
		{
			return null;
		}

		// Token: 0x060205B3 RID: 132531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205B3")]
		[Address(RVA = "0x1A78AB0", Offset = "0x1A776B0", VA = "0x181A78AB0")]
		public RL05DungeonSpZonePlugin()
		{
		}

		// Token: 0x060205B4 RID: 132532 RVA: 0x000B5878 File Offset: 0x000B3A78
		[Token(Token = "0x60205B4")]
		[Address(RVA = "0x1A78A00", Offset = "0x1A77600", VA = "0x181A78A00")]
		private bool <>xLuaBaseProxy_CheckIfNeedLockCamera(RoguelikeDungeonZone P0)
		{
			return default(bool);
		}

		// Token: 0x060205B5 RID: 132533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205B5")]
		[Address(RVA = "0x1A78A20", Offset = "0x1A77620", VA = "0x181A78A20")]
		private RoguelikeCameraController.RoguelikeCameraConfig <>xLuaBaseProxy_GetOverrideCameraConfig(RoguelikeDungeonZone P0)
		{
			return null;
		}

		// Token: 0x060205B6 RID: 132534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205B6")]
		[Address(RVA = "0x1A78A10", Offset = "0x1A77610", VA = "0x181A78A10")]
		private GameObject <>xLuaBaseProxy_GetFocusNodePluginGO()
		{
			return null;
		}

		// Token: 0x0402BCAC RID: 179372
		[Token(Token = "0x402BCAC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("camera config")]
		private float _cameraBoundMargin;

		// Token: 0x0402BCAD RID: 179373
		[Token(Token = "0x402BCAD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Group("camera config")]
		private float _cameraFocusBoundLeft;

		// Token: 0x0402BCAE RID: 179374
		[Token(Token = "0x402BCAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("camera config")]
		private float _cameraFocusBoundRight;

		// Token: 0x0402BCAF RID: 179375
		[Token(Token = "0x402BCAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _forcusNodePluginGO;

		// Token: 0x0402BCB0 RID: 179376
		[Token(Token = "0x402BCB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGeneSpZonePlugin;

		// Token: 0x0402BCB1 RID: 179377
		[Token(Token = "0x402BCB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfNeedLockCamera;

		// Token: 0x0402BCB2 RID: 179378
		[Token(Token = "0x402BCB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetOverrideCameraConfig;

		// Token: 0x0402BCB3 RID: 179379
		[Token(Token = "0x402BCB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIsSpZone;

		// Token: 0x0402BCB4 RID: 179380
		[Token(Token = "0x402BCB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetFocusNodePluginGO;

		// Token: 0x0402BCB5 RID: 179381
		[Token(Token = "0x402BCB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
