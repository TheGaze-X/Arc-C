using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200732A RID: 29482
	[Token(Token = "0x200732A")]
	public class Act42SideGunTaskDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029B0A RID: 170762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B0A")]
		[Address(RVA = "0x250C730", Offset = "0x250B330", VA = "0x18250C730")]
		public void Render(Act42SideDetailViewModel model, bool isActEnd)
		{
		}

		// Token: 0x06029B0B RID: 170763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B0B")]
		[Address(RVA = "0x250C460", Offset = "0x250B060", VA = "0x18250C460")]
		public void OnAcceptTaskClicked()
		{
		}

		// Token: 0x06029B0C RID: 170764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B0C")]
		[Address(RVA = "0x250C640", Offset = "0x250B240", VA = "0x18250C640")]
		public void OnSubmitTaskClicked()
		{
		}

		// Token: 0x06029B0D RID: 170765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B0D")]
		[Address(RVA = "0x250C550", Offset = "0x250B150", VA = "0x18250C550")]
		public void OnGoToStageClicked()
		{
		}

		// Token: 0x06029B0E RID: 170766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B0E")]
		[Address(RVA = "0x250D190", Offset = "0x250BD90", VA = "0x18250D190")]
		private void _PlayAnim()
		{
		}

		// Token: 0x06029B0F RID: 170767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B0F")]
		[Address(RVA = "0x250D2A0", Offset = "0x250BEA0", VA = "0x18250D2A0")]
		private void _RenderActEndPart(GameObject[] _hideList, bool isActEnd)
		{
		}

		// Token: 0x06029B10 RID: 170768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B10")]
		[Address(RVA = "0x250CD60", Offset = "0x250B960", VA = "0x18250CD60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029B11 RID: 170769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B11")]
		[Address(RVA = "0x250CFD0", Offset = "0x250BBD0", VA = "0x18250CFD0")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x06029B12 RID: 170770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B12")]
		[Address(RVA = "0x250D3B0", Offset = "0x250BFB0", VA = "0x18250D3B0")]
		public Act42SideGunTaskDetailView()
		{
		}

		// Token: 0x0403BA90 RID: 244368
		[Token(Token = "0x403BA90")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Title")]
		private Text _titleSmall;

		// Token: 0x0403BA91 RID: 244369
		[Token(Token = "0x403BA91")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Title")]
		private Text _title;

		// Token: 0x0403BA92 RID: 244370
		[Token(Token = "0x403BA92")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Title")]
		private Image _iconWhite;

		// Token: 0x0403BA93 RID: 244371
		[Token(Token = "0x403BA93")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Title")]
		private Image _iconColor;

		// Token: 0x0403BA94 RID: 244372
		[Token(Token = "0x403BA94")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Detail")]
		private TwoStateToggle _toggleComplete;

		// Token: 0x0403BA95 RID: 244373
		[Token(Token = "0x403BA95")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Detail")]
		private ThreeStateToggle _toggleNotComplete;

		// Token: 0x0403BA96 RID: 244374
		[Token(Token = "0x403BA96")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Detail")]
		private Text[] _content;

		// Token: 0x0403BA97 RID: 244375
		[Token(Token = "0x403BA97")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Detail")]
		private Text[] _taskDesc;

		// Token: 0x0403BA98 RID: 244376
		[Token(Token = "0x403BA98")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Detail")]
		private Text _contentAfterTask;

		// Token: 0x0403BA99 RID: 244377
		[Token(Token = "0x403BA99")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Detail")]
		private Transform[] _rewardHolder;

		// Token: 0x0403BA9A RID: 244378
		[Token(Token = "0x403BA9A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Detail")]
		private float _itemScale;

		// Token: 0x0403BA9B RID: 244379
		[Token(Token = "0x403BA9B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Act End")]
		private GameObject[] _hideWhenActEndUnlock;

		// Token: 0x0403BA9C RID: 244380
		[Token(Token = "0x403BA9C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Act End")]
		private GameObject[] _hideWhenActEndAccepted;

		// Token: 0x0403BA9D RID: 244381
		[Token(Token = "0x403BA9D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Act End")]
		private GameObject _panelActEnd;

		// Token: 0x0403BA9E RID: 244382
		[Token(Token = "0x403BA9E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _anim;

		// Token: 0x0403BA9F RID: 244383
		[Token(Token = "0x403BA9F")]
		[FieldOffset(Offset = "0x98")]
		private List<UIItemCard> m_itemCards;

		// Token: 0x0403BAA0 RID: 244384
		[Token(Token = "0x403BAA0")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIItemViewModel> m_itemModels;

		// Token: 0x0403BAA1 RID: 244385
		[Token(Token = "0x403BAA1")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BAA2 RID: 244386
		[Token(Token = "0x403BAA2")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BAA3 RID: 244387
		[Token(Token = "0x403BAA3")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_tween;

		// Token: 0x0403BAA4 RID: 244388
		[Token(Token = "0x403BAA4")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x0403BAA5 RID: 244389
		[Token(Token = "0x403BAA5")]
		[FieldOffset(Offset = "0xD8")]
		private string m_cachedId;

		// Token: 0x0403BAA6 RID: 244390
		[Token(Token = "0x403BAA6")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cachedStageId;

		// Token: 0x0403BAA7 RID: 244391
		[Token(Token = "0x403BAA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BAA8 RID: 244392
		[Token(Token = "0x403BAA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAcceptTaskClicked;

		// Token: 0x0403BAA9 RID: 244393
		[Token(Token = "0x403BAA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSubmitTaskClicked;

		// Token: 0x0403BAAA RID: 244394
		[Token(Token = "0x403BAAA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGoToStageClicked;

		// Token: 0x0403BAAB RID: 244395
		[Token(Token = "0x403BAAB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403BAAC RID: 244396
		[Token(Token = "0x403BAAC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderActEndPart;

		// Token: 0x0403BAAD RID: 244397
		[Token(Token = "0x403BAAD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BAAE RID: 244398
		[Token(Token = "0x403BAAE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0403BAAF RID: 244399
		[Token(Token = "0x403BAAF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
