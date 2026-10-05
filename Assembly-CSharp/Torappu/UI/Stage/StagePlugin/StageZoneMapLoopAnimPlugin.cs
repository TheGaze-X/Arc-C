using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.StagePlugin
{
	// Token: 0x02006A44 RID: 27204
	[Token(Token = "0x2006A44")]
	public class StageZoneMapLoopAnimPlugin : StageMainZoneMapPlugin, IHotfixable
	{
		// Token: 0x06026E2D RID: 159277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E2D")]
		[Address(RVA = "0x21FD560", Offset = "0x21FC160", VA = "0x1821FD560", Slot = "4")]
		public override void OnMapInitiated(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x06026E2E RID: 159278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E2E")]
		[Address(RVA = "0x21FD770", Offset = "0x21FC370", VA = "0x1821FD770")]
		public StageZoneMapLoopAnimPlugin()
		{
		}

		// Token: 0x06026E2F RID: 159279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E2F")]
		[Address(RVA = "0x21FD750", Offset = "0x21FC350", VA = "0x1821FD750")]
		private void <>xLuaBaseProxy_OnMapInitiated(StageMainZoneMapPlugin.MapPosInfo P0)
		{
		}

		// Token: 0x04036FCA RID: 225226
		[Token(Token = "0x4036FCA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation[] _animLocations;

		// Token: 0x04036FCB RID: 225227
		[Token(Token = "0x4036FCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMapInitiated;

		// Token: 0x04036FCC RID: 225228
		[Token(Token = "0x4036FCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
