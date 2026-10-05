using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200771A RID: 30490
	[Token(Token = "0x200771A")]
	public class Act1VHalfIdleCharUpgradePage : StateEnginePage, IFadeInPushWithBlurBkg, IHotfixable
	{
		// Token: 0x0602AD67 RID: 175463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AD67")]
		[Address(RVA = "0x269CDF0", Offset = "0x269B9F0", VA = "0x18269CDF0", Slot = "29")]
		public UIRenderTextureImage GetBlurBkg()
		{
			return null;
		}

		// Token: 0x0602AD68 RID: 175464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD68")]
		[Address(RVA = "0x269CE50", Offset = "0x269BA50", VA = "0x18269CE50", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602AD69 RID: 175465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD69")]
		[Address(RVA = "0x269CEF0", Offset = "0x269BAF0", VA = "0x18269CEF0")]
		public Act1VHalfIdleCharUpgradePage()
		{
		}

		// Token: 0x0602AD6A RID: 175466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD6A")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403DBE0 RID: 252896
		[Token(Token = "0x403DBE0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIRenderTextureImage _imageBlurBkg;

		// Token: 0x0403DBE1 RID: 252897
		[Token(Token = "0x403DBE1")]
		[FieldOffset(Offset = "0xF8")]
		private Act1VHalfIdleCharUpgradePage.Param m_param;

		// Token: 0x0403DBE2 RID: 252898
		[Token(Token = "0x403DBE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurBkg;

		// Token: 0x0403DBE3 RID: 252899
		[Token(Token = "0x403DBE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403DBE4 RID: 252900
		[Token(Token = "0x403DBE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200771B RID: 30491
		[Token(Token = "0x200771B")]
		public class Param
		{
			// Token: 0x0602AD6B RID: 175467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD6B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403DBE5 RID: 252901
			[Token(Token = "0x403DBE5")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403DBE6 RID: 252902
			[Token(Token = "0x403DBE6")]
			[FieldOffset(Offset = "0x18")]
			public string charInstId;

			// Token: 0x0403DBE7 RID: 252903
			[Token(Token = "0x403DBE7")]
			[FieldOffset(Offset = "0x20")]
			public List<string> charList;
		}
	}
}
