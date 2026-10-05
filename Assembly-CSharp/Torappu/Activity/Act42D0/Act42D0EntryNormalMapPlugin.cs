using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200738D RID: 29581
	[Token(Token = "0x200738D")]
	public class Act42D0EntryNormalMapPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06029D17 RID: 171287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D17")]
		[Address(RVA = "0x256F9E0", Offset = "0x256E5E0", VA = "0x18256F9E0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029D18 RID: 171288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D18")]
		[Address(RVA = "0x256F7F0", Offset = "0x256E3F0", VA = "0x18256F7F0")]
		public void OnNormalMapClick()
		{
		}

		// Token: 0x06029D19 RID: 171289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D19")]
		[Address(RVA = "0x256FC70", Offset = "0x256E870", VA = "0x18256FC70")]
		public Act42D0EntryNormalMapPlugin()
		{
		}

		// Token: 0x0403BE21 RID: 245281
		[Token(Token = "0x403BE21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textAreaCode;

		// Token: 0x0403BE22 RID: 245282
		[Token(Token = "0x403BE22")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x0403BE23 RID: 245283
		[Token(Token = "0x403BE23")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgRating;

		// Token: 0x0403BE24 RID: 245284
		[Token(Token = "0x403BE24")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objAllClear;

		// Token: 0x0403BE25 RID: 245285
		[Token(Token = "0x403BE25")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objHasProgress;

		// Token: 0x0403BE26 RID: 245286
		[Token(Token = "0x403BE26")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objNoProgress;

		// Token: 0x0403BE27 RID: 245287
		[Token(Token = "0x403BE27")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objClosed;

		// Token: 0x0403BE28 RID: 245288
		[Token(Token = "0x403BE28")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0403BE29 RID: 245289
		[Token(Token = "0x403BE29")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BE2A RID: 245290
		[Token(Token = "0x403BE2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403BE2B RID: 245291
		[Token(Token = "0x403BE2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnNormalMapClick;

		// Token: 0x0403BE2C RID: 245292
		[Token(Token = "0x403BE2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
