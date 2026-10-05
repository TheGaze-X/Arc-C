using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x0200204A RID: 8266
	[Token(Token = "0x200204A")]
	[ExecuteInEditMode]
	public class SceneDepth : BaseSceneEffect
	{
		// Token: 0x0600CBB7 RID: 52151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB7")]
		[Address(RVA = "0x34CB790", Offset = "0x34CA390", VA = "0x1834CB790", Slot = "4")]
		public override void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB8")]
		[Address(RVA = "0x34CBB00", Offset = "0x34CA700", VA = "0x1834CBB00")]
		private void _InitCamera(Camera camera)
		{
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB9")]
		[Address(RVA = "0x34CBA30", Offset = "0x34CA630", VA = "0x1834CBA30")]
		private void _ClearCurrentCamera()
		{
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBBA")]
		[Address(RVA = "0x34CB9D0", Offset = "0x34CA5D0", VA = "0x1834CB9D0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBBB")]
		[Address(RVA = "0x34CB970", Offset = "0x34CA570", VA = "0x1834CB970", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBBC")]
		[Address(RVA = "0x34CBBD0", Offset = "0x34CA7D0", VA = "0x1834CBBD0")]
		public SceneDepth()
		{
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBBD")]
		[Address(RVA = "0x34BE650", Offset = "0x34BD250", VA = "0x1834BE650")]
		private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
		{
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBBE")]
		[Address(RVA = "0x34BE730", Offset = "0x34BD330", VA = "0x1834BE730")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CBBF RID: 52159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBBF")]
		[Address(RVA = "0x34BE6D0", Offset = "0x34BD2D0", VA = "0x1834BE6D0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400D621 RID: 54817
		[Token(Token = "0x400D621")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_camera;

		// Token: 0x0400D622 RID: 54818
		[Token(Token = "0x400D622")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x0400D623 RID: 54819
		[Token(Token = "0x400D623")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D624 RID: 54820
		[Token(Token = "0x400D624")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitCamera;

		// Token: 0x0400D625 RID: 54821
		[Token(Token = "0x400D625")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearCurrentCamera;

		// Token: 0x0400D626 RID: 54822
		[Token(Token = "0x400D626")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D627 RID: 54823
		[Token(Token = "0x400D627")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D628 RID: 54824
		[Token(Token = "0x400D628")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
