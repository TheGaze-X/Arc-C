using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.StagePlugin
{
	// Token: 0x02006A45 RID: 27205
	[Token(Token = "0x2006A45")]
	public class StageZoneMapPositionAnimPlugin : StageMainZoneMapPlugin
	{
		// Token: 0x06026E30 RID: 159280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E30")]
		[Address(RVA = "0x21FD7D0", Offset = "0x21FC3D0", VA = "0x1821FD7D0", Slot = "4")]
		public override void OnMapInitiated(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x06026E31 RID: 159281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E31")]
		[Address(RVA = "0x21FDB60", Offset = "0x21FC760", VA = "0x1821FDB60")]
		private void _UpdateAnim(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x06026E32 RID: 159282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E32")]
		[Address(RVA = "0x21FDC80", Offset = "0x21FC880", VA = "0x1821FDC80")]
		private void _UpdateImagePosition(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x06026E33 RID: 159283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E33")]
		[Address(RVA = "0x21FDA00", Offset = "0x21FC600", VA = "0x1821FDA00", Slot = "5")]
		public override void OnMapPositionChanged(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x06026E34 RID: 159284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E34")]
		[Address(RVA = "0x21FDD40", Offset = "0x21FC940", VA = "0x1821FDD40")]
		public StageZoneMapPositionAnimPlugin()
		{
		}

		// Token: 0x06026E35 RID: 159285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E35")]
		[Address(RVA = "0x21FD750", Offset = "0x21FC350", VA = "0x1821FD750")]
		private void <>xLuaBaseProxy_OnMapInitiated(StageMainZoneMapPlugin.MapPosInfo P0)
		{
		}

		// Token: 0x06026E36 RID: 159286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E36")]
		[Address(RVA = "0x21FDB40", Offset = "0x21FC740", VA = "0x1821FDB40")]
		private void <>xLuaBaseProxy_OnMapPositionChanged(StageMainZoneMapPlugin.MapPosInfo P0)
		{
		}

		// Token: 0x04036FCD RID: 225229
		[Token(Token = "0x4036FCD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _anim;

		// Token: 0x04036FCE RID: 225230
		[Token(Token = "0x4036FCE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Options")]
		private bool _fixOnBackground;

		// Token: 0x04036FCF RID: 225231
		[Token(Token = "0x4036FCF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Image Group, can be none if not fixed on background")]
		private GameObject _imageGroup;

		// Token: 0x04036FD0 RID: 225232
		[Token(Token = "0x4036FD0")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_rectTrans;

		// Token: 0x04036FD1 RID: 225233
		[Token(Token = "0x4036FD1")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 m_startPos;

		// Token: 0x04036FD2 RID: 225234
		[Token(Token = "0x4036FD2")]
		[FieldOffset(Offset = "0x48")]
		private AnimationWrapper m_animWrapper;

		// Token: 0x04036FD3 RID: 225235
		[Token(Token = "0x4036FD3")]
		[FieldOffset(Offset = "0x50")]
		private string m_animName;

		// Token: 0x04036FD4 RID: 225236
		[Token(Token = "0x4036FD4")]
		[FieldOffset(Offset = "0x58")]
		private float m_animLength;

		// Token: 0x04036FD5 RID: 225237
		[Token(Token = "0x4036FD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMapInitiated;

		// Token: 0x04036FD6 RID: 225238
		[Token(Token = "0x4036FD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateAnim;

		// Token: 0x04036FD7 RID: 225239
		[Token(Token = "0x4036FD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateImagePosition;

		// Token: 0x04036FD8 RID: 225240
		[Token(Token = "0x4036FD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMapPositionChanged;

		// Token: 0x04036FD9 RID: 225241
		[Token(Token = "0x4036FD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
