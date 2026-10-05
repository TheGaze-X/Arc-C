using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200656A RID: 25962
	[Token(Token = "0x200656A")]
	public class ArtMagazineDiyHomeView : DataBinder<ArtMagazineDiyHomeProperty>
	{
		// Token: 0x0602554C RID: 152908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602554C")]
		[Address(RVA = "0x204A090", Offset = "0x2048C90", VA = "0x18204A090", Slot = "7")]
		public override void OnValueChanged(ArtMagazineDiyHomeProperty property)
		{
		}

		// Token: 0x0602554D RID: 152909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602554D")]
		[Address(RVA = "0x204A330", Offset = "0x2048F30", VA = "0x18204A330")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602554E RID: 152910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602554E")]
		[Address(RVA = "0x2049E60", Offset = "0x2048A60", VA = "0x182049E60")]
		public void EventOnSaveBtnClick()
		{
		}

		// Token: 0x0602554F RID: 152911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602554F")]
		[Address(RVA = "0x2049D40", Offset = "0x2048940", VA = "0x182049D40")]
		public void EventOnClearAllBtnClick()
		{
		}

		// Token: 0x06025550 RID: 152912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025550")]
		[Address(RVA = "0x204A010", Offset = "0x2048C10", VA = "0x18204A010")]
		public void EventOnTemplateBtnClick()
		{
		}

		// Token: 0x06025551 RID: 152913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025551")]
		[Address(RVA = "0x2049F80", Offset = "0x2048B80", VA = "0x182049F80")]
		public void EventOnSkinSelectBtnClick()
		{
		}

		// Token: 0x06025552 RID: 152914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025552")]
		[Address(RVA = "0x2049EF0", Offset = "0x2048AF0", VA = "0x182049EF0")]
		public void EventOnSkinEditBtnClick()
		{
		}

		// Token: 0x06025553 RID: 152915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025553")]
		[Address(RVA = "0x2049DD0", Offset = "0x20489D0", VA = "0x182049DD0")]
		public void EventOnDecorBtnClick()
		{
		}

		// Token: 0x06025554 RID: 152916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025554")]
		[Address(RVA = "0x204A3C0", Offset = "0x2048FC0", VA = "0x18204A3C0")]
		public ArtMagazineDiyHomeView()
		{
		}

		// Token: 0x0403460F RID: 214543
		[Token(Token = "0x403460F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _skinSelectToggle;

		// Token: 0x04034610 RID: 214544
		[Token(Token = "0x4034610")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _presetBtnGo;

		// Token: 0x04034611 RID: 214545
		[Token(Token = "0x4034611")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _stickerTypeTrackPoint;

		// Token: 0x04034612 RID: 214546
		[Token(Token = "0x4034612")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034613 RID: 214547
		[Token(Token = "0x4034613")]
		[FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_stickerTypeTrackPoint;

		// Token: 0x04034614 RID: 214548
		[Token(Token = "0x4034614")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04034615 RID: 214549
		[Token(Token = "0x4034615")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034616 RID: 214550
		[Token(Token = "0x4034616")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034617 RID: 214551
		[Token(Token = "0x4034617")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnSaveBtnClick;

		// Token: 0x04034618 RID: 214552
		[Token(Token = "0x4034618")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClearAllBtnClick;

		// Token: 0x04034619 RID: 214553
		[Token(Token = "0x4034619")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnTemplateBtnClick;

		// Token: 0x0403461A RID: 214554
		[Token(Token = "0x403461A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSkinSelectBtnClick;

		// Token: 0x0403461B RID: 214555
		[Token(Token = "0x403461B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnSkinEditBtnClick;

		// Token: 0x0403461C RID: 214556
		[Token(Token = "0x403461C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnDecorBtnClick;

		// Token: 0x0403461D RID: 214557
		[Token(Token = "0x403461D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200656B RID: 25963
		[Token(Token = "0x200656B")]
		private class StickerTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700581D RID: 22557
			// (get) Token: 0x06025555 RID: 152917 RVA: 0x000C7770 File Offset: 0x000C5970
			[Token(Token = "0x1700581D")]
			public bool isShow
			{
				[Token(Token = "0x6025555")]
				[Address(RVA = "0x2055E20", Offset = "0x2054A20", VA = "0x182055E20", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06025556 RID: 152918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025556")]
			[Address(RVA = "0x2055C20", Offset = "0x2054820", VA = "0x182055C20", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x06025557 RID: 152919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025557")]
			[Address(RVA = "0x2055D60", Offset = "0x2054960", VA = "0x182055D60")]
			public StickerTrackPointModel()
			{
			}

			// Token: 0x0403461E RID: 214558
			[Token(Token = "0x403461E")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403461F RID: 214559
			[Token(Token = "0x403461F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04034620 RID: 214560
			[Token(Token = "0x4034620")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04034621 RID: 214561
			[Token(Token = "0x4034621")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
