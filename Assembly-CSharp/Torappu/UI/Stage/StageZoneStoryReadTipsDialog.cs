using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068A1 RID: 26785
	[Token(Token = "0x20068A1")]
	public class StageZoneStoryReadTipsDialog : UISimpleCompDialog
	{
		// Token: 0x0602663C RID: 157244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602663C")]
		[Address(RVA = "0x2173F60", Offset = "0x2172B60", VA = "0x182173F60", Slot = "18")]
		protected override void OnRender(object input)
		{
		}

		// Token: 0x0602663D RID: 157245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602663D")]
		[Address(RVA = "0x2173F00", Offset = "0x2172B00", VA = "0x182173F00", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602663E RID: 157246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602663E")]
		[Address(RVA = "0x2173E40", Offset = "0x2172A40", VA = "0x182173E40")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x0602663F RID: 157247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602663F")]
		[Address(RVA = "0x21741A0", Offset = "0x2172DA0", VA = "0x1821741A0")]
		public StageZoneStoryReadTipsDialog()
		{
		}

		// Token: 0x06026640 RID: 157248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026640")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x040360F7 RID: 221431
		[Token(Token = "0x40360F7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x040360F8 RID: 221432
		[Token(Token = "0x40360F8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgPic;

		// Token: 0x040360F9 RID: 221433
		[Token(Token = "0x40360F9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtTips;

		// Token: 0x040360FA RID: 221434
		[Token(Token = "0x40360FA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _txtConfirmBtn;

		// Token: 0x040360FB RID: 221435
		[Token(Token = "0x40360FB")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040360FC RID: 221436
		[Token(Token = "0x40360FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040360FD RID: 221437
		[Token(Token = "0x40360FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040360FE RID: 221438
		[Token(Token = "0x40360FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x040360FF RID: 221439
		[Token(Token = "0x40360FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068A2 RID: 26786
		[Token(Token = "0x20068A2")]
		public class Option
		{
			// Token: 0x06026641 RID: 157249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026641")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04036100 RID: 221440
			[Token(Token = "0x4036100")]
			[FieldOffset(Offset = "0x10")]
			public StoryReadTipsData storyTipsData;
		}
	}
}
