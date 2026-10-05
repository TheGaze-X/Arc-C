using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049B4 RID: 18868
	[Token(Token = "0x20049B4")]
	public class LongTermCheckInDetailDialog : UISimpleCompDialog, IHotfixable
	{
		// Token: 0x0601C6D6 RID: 116438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6D6")]
		[Address(RVA = "0x15E30E0", Offset = "0x15E1CE0", VA = "0x1815E30E0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601C6D7 RID: 116439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D7")]
		[Address(RVA = "0x15E3140", Offset = "0x15E1D40", VA = "0x1815E3140", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C6D8 RID: 116440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D8")]
		[Address(RVA = "0x15E3250", Offset = "0x15E1E50", VA = "0x1815E3250", Slot = "18")]
		protected override void OnRender(object input)
		{
		}

		// Token: 0x0601C6D9 RID: 116441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D9")]
		[Address(RVA = "0x15E3020", Offset = "0x15E1C20", VA = "0x1815E3020")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601C6DA RID: 116442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6DA")]
		[Address(RVA = "0x15E3320", Offset = "0x15E1F20", VA = "0x1815E3320")]
		public LongTermCheckInDetailDialog()
		{
		}

		// Token: 0x0601C6DB RID: 116443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6DB")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601C6DC RID: 116444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6DC")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040253DB RID: 152539
		[Token(Token = "0x40253DB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x040253DC RID: 152540
		[Token(Token = "0x40253DC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x040253DD RID: 152541
		[Token(Token = "0x40253DD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x040253DE RID: 152542
		[Token(Token = "0x40253DE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textDetail;

		// Token: 0x040253DF RID: 152543
		[Token(Token = "0x40253DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040253E0 RID: 152544
		[Token(Token = "0x40253E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040253E1 RID: 152545
		[Token(Token = "0x40253E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040253E2 RID: 152546
		[Token(Token = "0x40253E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x040253E3 RID: 152547
		[Token(Token = "0x40253E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
