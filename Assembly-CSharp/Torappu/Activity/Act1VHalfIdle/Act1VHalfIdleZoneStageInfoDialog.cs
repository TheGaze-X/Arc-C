using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007820 RID: 30752
	[Token(Token = "0x2007820")]
	public class Act1VHalfIdleZoneStageInfoDialog : UICompDialog<Act1VHalfIdleZoneStageInfoDialog.Option>
	{
		// Token: 0x0602B232 RID: 176690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B232")]
		[Address(RVA = "0x27039B0", Offset = "0x27025B0", VA = "0x1827039B0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602B233 RID: 176691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B233")]
		[Address(RVA = "0x2703AB0", Offset = "0x27026B0", VA = "0x182703AB0", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleZoneStageInfoDialog.Option input)
		{
		}

		// Token: 0x0602B234 RID: 176692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B234")]
		[Address(RVA = "0x2703950", Offset = "0x2702550", VA = "0x182703950", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602B235 RID: 176693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B235")]
		[Address(RVA = "0x2703890", Offset = "0x2702490", VA = "0x182703890")]
		public void EventOnClickClose()
		{
		}

		// Token: 0x0602B236 RID: 176694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B236")]
		[Address(RVA = "0x2703C70", Offset = "0x2702870", VA = "0x182703C70")]
		public Act1VHalfIdleZoneStageInfoDialog()
		{
		}

		// Token: 0x0602B237 RID: 176695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B237")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0602B238 RID: 176696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B238")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403E5A4 RID: 255396
		[Token(Token = "0x403E5A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _stageNameText;

		// Token: 0x0403E5A5 RID: 255397
		[Token(Token = "0x403E5A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _stageCodeText;

		// Token: 0x0403E5A6 RID: 255398
		[Token(Token = "0x403E5A6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _stageDescText;

		// Token: 0x0403E5A7 RID: 255399
		[Token(Token = "0x403E5A7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x0403E5A8 RID: 255400
		[Token(Token = "0x403E5A8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403E5A9 RID: 255401
		[Token(Token = "0x403E5A9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _stagePreviewImg;

		// Token: 0x0403E5AA RID: 255402
		[Token(Token = "0x403E5AA")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E5AB RID: 255403
		[Token(Token = "0x403E5AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403E5AC RID: 255404
		[Token(Token = "0x403E5AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E5AD RID: 255405
		[Token(Token = "0x403E5AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403E5AE RID: 255406
		[Token(Token = "0x403E5AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClickClose;

		// Token: 0x0403E5AF RID: 255407
		[Token(Token = "0x403E5AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007821 RID: 30753
		[Token(Token = "0x2007821")]
		public class Option
		{
			// Token: 0x0602B239 RID: 176697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B239")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403E5B0 RID: 255408
			[Token(Token = "0x403E5B0")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;
		}
	}
}
