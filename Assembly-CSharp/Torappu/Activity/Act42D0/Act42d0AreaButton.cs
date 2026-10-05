using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200738E RID: 29582
	[Token(Token = "0x200738E")]
	public class Act42d0AreaButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x170062C7 RID: 25287
		// (get) Token: 0x06029D1A RID: 171290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062C7")]
		public GameObject btnGo
		{
			[Token(Token = "0x6029D1A")]
			[Address(RVA = "0x2577870", Offset = "0x2576470", VA = "0x182577870")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029D1B RID: 171291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D1B")]
		[Address(RVA = "0x25776F0", Offset = "0x25762F0", VA = "0x1825776F0")]
		private void _PlayAnimIfNecessary(bool showStatusChanged)
		{
		}

		// Token: 0x06029D1C RID: 171292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D1C")]
		[Address(RVA = "0x2577380", Offset = "0x2575F80", VA = "0x182577380")]
		public void RenderBtn(Act42d0AreaViewModel viewModel, bool isSelected, NewestProgress progressInfo, bool showStatusChanged)
		{
		}

		// Token: 0x06029D1D RID: 171293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D1D")]
		[Address(RVA = "0x25772A0", Offset = "0x2575EA0", VA = "0x1825772A0")]
		public void EventOnAreaClick()
		{
		}

		// Token: 0x06029D1E RID: 171294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D1E")]
		[Address(RVA = "0x2577810", Offset = "0x2576410", VA = "0x182577810")]
		public Act42d0AreaButton()
		{
		}

		// Token: 0x0403BE2D RID: 245293
		[Token(Token = "0x403BE2D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _areaCodeIcon;

		// Token: 0x0403BE2E RID: 245294
		[Token(Token = "0x403BE2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _iconAtlas;

		// Token: 0x0403BE2F RID: 245295
		[Token(Token = "0x403BE2F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectMaskGo;

		// Token: 0x0403BE30 RID: 245296
		[Token(Token = "0x403BE30")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0403BE31 RID: 245297
		[Token(Token = "0x403BE31")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403BE32 RID: 245298
		[Token(Token = "0x403BE32")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lastProgress;

		// Token: 0x0403BE33 RID: 245299
		[Token(Token = "0x403BE33")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _isNew;

		// Token: 0x0403BE34 RID: 245300
		[Token(Token = "0x403BE34")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgRateIcon;

		// Token: 0x0403BE35 RID: 245301
		[Token(Token = "0x403BE35")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _lastStageName;

		// Token: 0x0403BE36 RID: 245302
		[Token(Token = "0x403BE36")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnGo;

		// Token: 0x0403BE37 RID: 245303
		[Token(Token = "0x403BE37")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _progressAnim;

		// Token: 0x0403BE38 RID: 245304
		[Token(Token = "0x403BE38")]
		[FieldOffset(Offset = "0x78")]
		private string m_areaId;

		// Token: 0x0403BE39 RID: 245305
		[Token(Token = "0x403BE39")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BE3A RID: 245306
		[Token(Token = "0x403BE3A")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_progressTween;

		// Token: 0x0403BE3B RID: 245307
		[Token(Token = "0x403BE3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_btnGo;

		// Token: 0x0403BE3C RID: 245308
		[Token(Token = "0x403BE3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnimIfNecessary;

		// Token: 0x0403BE3D RID: 245309
		[Token(Token = "0x403BE3D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderBtn;

		// Token: 0x0403BE3E RID: 245310
		[Token(Token = "0x403BE3E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnAreaClick;

		// Token: 0x0403BE3F RID: 245311
		[Token(Token = "0x403BE3F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
