using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005220 RID: 21024
	[Token(Token = "0x2005220")]
	public abstract class RoguelikeDungeonSpZonePluginBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F055 RID: 127061
		[Token(Token = "0x601F055")]
		public abstract RoguelikeDungeonGeneSpZonePluginBase GetGeneSpZonePlugin();

		// Token: 0x0601F056 RID: 127062 RVA: 0x000B0880 File Offset: 0x000AEA80
		[Token(Token = "0x601F056")]
		[Address(RVA = "0x18B7BA0", Offset = "0x18B67A0", VA = "0x1818B7BA0", Slot = "5")]
		public virtual bool CheckIfNeedLockCamera(RoguelikeDungeonZone dungeonZone)
		{
			return default(bool);
		}

		// Token: 0x0601F057 RID: 127063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F057")]
		[Address(RVA = "0x18B7C70", Offset = "0x18B6870", VA = "0x1818B7C70", Slot = "6")]
		public virtual RoguelikeCameraController.RoguelikeCameraConfig GetOverrideCameraConfig(RoguelikeDungeonZone dungeonZone)
		{
			return null;
		}

		// Token: 0x0601F058 RID: 127064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F058")]
		[Address(RVA = "0x18B7C10", Offset = "0x18B6810", VA = "0x1818B7C10", Slot = "7")]
		public virtual GameObject GetFocusNodePluginGO()
		{
			return null;
		}

		// Token: 0x0601F059 RID: 127065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F059")]
		[Address(RVA = "0x18B7CE0", Offset = "0x18B68E0", VA = "0x1818B7CE0")]
		protected RoguelikeDungeonSpZonePluginBase()
		{
		}

		// Token: 0x040299CD RID: 170445
		[Token(Token = "0x40299CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfNeedLockCamera;

		// Token: 0x040299CE RID: 170446
		[Token(Token = "0x40299CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetOverrideCameraConfig;

		// Token: 0x040299CF RID: 170447
		[Token(Token = "0x40299CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFocusNodePluginGO;

		// Token: 0x040299D0 RID: 170448
		[Token(Token = "0x40299D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
