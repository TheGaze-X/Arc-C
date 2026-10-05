using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x0200206B RID: 8299
	[Token(Token = "0x200206B")]
	public class SceneUIVignette : BaseSceneEffect
	{
		// Token: 0x0600CC70 RID: 52336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC70")]
		[Address(RVA = "0x34E4CF0", Offset = "0x34E38F0", VA = "0x1834E4CF0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CC71 RID: 52337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC71")]
		[Address(RVA = "0x34E4BF0", Offset = "0x34E37F0", VA = "0x1834E4BF0", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CC72 RID: 52338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC72")]
		[Address(RVA = "0x34E4E90", Offset = "0x34E3A90", VA = "0x1834E4E90")]
		public SceneUIVignette()
		{
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC73")]
		[Address(RVA = "0x34D08D0", Offset = "0x34CF4D0", VA = "0x1834D08D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CC74 RID: 52340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC74")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400D718 RID: 55064
		[Token(Token = "0x400D718")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _vignetteMaskColor;

		// Token: 0x0400D719 RID: 55065
		[Token(Token = "0x400D719")]
		[FieldOffset(Offset = "0x30")]
		private Image m_vignetteImage;

		// Token: 0x0400D71A RID: 55066
		[Token(Token = "0x400D71A")]
		[FieldOffset(Offset = "0x38")]
		private Color m_vignetteImageOriginalColor;

		// Token: 0x0400D71B RID: 55067
		[Token(Token = "0x400D71B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D71C RID: 55068
		[Token(Token = "0x400D71C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D71D RID: 55069
		[Token(Token = "0x400D71D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
