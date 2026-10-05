using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006918 RID: 26904
	[Token(Token = "0x2006918")]
	public class StageZoneMapPlayOnceAnimPlugin : StageMainZoneMapPlugin
	{
		// Token: 0x060268AB RID: 157867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268AB")]
		[Address(RVA = "0x21A45F0", Offset = "0x21A31F0", VA = "0x1821A45F0", Slot = "4")]
		public override void OnMapInitiated(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x060268AC RID: 157868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268AC")]
		[Address(RVA = "0x21A4790", Offset = "0x21A3390", VA = "0x1821A4790")]
		public StageZoneMapPlayOnceAnimPlugin()
		{
		}

		// Token: 0x060268AD RID: 157869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268AD")]
		[Address(RVA = "0x219AC00", Offset = "0x2199800", VA = "0x18219AC00")]
		private void <>xLuaBaseProxy_OnMapInitiated(StageMainZoneMapPlugin.MapPosInfo P0)
		{
		}

		// Token: 0x0403659F RID: 222623
		[Token(Token = "0x403659F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x040365A0 RID: 222624
		[Token(Token = "0x40365A0")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_tween;

		// Token: 0x040365A1 RID: 222625
		[Token(Token = "0x40365A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMapInitiated;

		// Token: 0x040365A2 RID: 222626
		[Token(Token = "0x40365A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
