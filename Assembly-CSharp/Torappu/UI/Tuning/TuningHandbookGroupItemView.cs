using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C8D RID: 15501
	[Token(Token = "0x2003C8D")]
	public class TuningHandbookGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018354 RID: 99156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018354")]
		[Address(RVA = "0x10B43F0", Offset = "0x10B2FF0", VA = "0x1810B43F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018355 RID: 99157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018355")]
		[Address(RVA = "0x10B4090", Offset = "0x10B2C90", VA = "0x1810B4090")]
		public void Render(TuningHandbookGroupViewModel viewModel)
		{
		}

		// Token: 0x06018356 RID: 99158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018356")]
		[Address(RVA = "0x10B3EC0", Offset = "0x10B2AC0", VA = "0x1810B3EC0")]
		public void EventOnEmotionClick()
		{
		}

		// Token: 0x06018357 RID: 99159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018357")]
		[Address(RVA = "0x10B3FA0", Offset = "0x10B2BA0", VA = "0x1810B3FA0")]
		public void EventOnLockEmotionClick()
		{
		}

		// Token: 0x06018358 RID: 99160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018358")]
		[Address(RVA = "0x10B4590", Offset = "0x10B3190", VA = "0x1810B4590")]
		public TuningHandbookGroupItemView()
		{
		}

		// Token: 0x0401D7B6 RID: 120758
		[Token(Token = "0x401D7B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objNormalItem;

		// Token: 0x0401D7B7 RID: 120759
		[Token(Token = "0x401D7B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objLockItem;

		// Token: 0x0401D7B8 RID: 120760
		[Token(Token = "0x401D7B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objSelectItem;

		// Token: 0x0401D7B9 RID: 120761
		[Token(Token = "0x401D7B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNameNormal;

		// Token: 0x0401D7BA RID: 120762
		[Token(Token = "0x401D7BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtNameSelect;

		// Token: 0x0401D7BB RID: 120763
		[Token(Token = "0x401D7BB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgEmotion;

		// Token: 0x0401D7BC RID: 120764
		[Token(Token = "0x401D7BC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0401D7BD RID: 120765
		[Token(Token = "0x401D7BD")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D7BE RID: 120766
		[Token(Token = "0x401D7BE")]
		[FieldOffset(Offset = "0x60")]
		private TuningHandbookGroupViewModel m_viewModel;

		// Token: 0x0401D7BF RID: 120767
		[Token(Token = "0x401D7BF")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0401D7C0 RID: 120768
		[Token(Token = "0x401D7C0")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D7C1 RID: 120769
		[Token(Token = "0x401D7C1")]
		[FieldOffset(Offset = "0x80")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0401D7C2 RID: 120770
		[Token(Token = "0x401D7C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D7C3 RID: 120771
		[Token(Token = "0x401D7C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D7C4 RID: 120772
		[Token(Token = "0x401D7C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnEmotionClick;

		// Token: 0x0401D7C5 RID: 120773
		[Token(Token = "0x401D7C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnLockEmotionClick;

		// Token: 0x0401D7C6 RID: 120774
		[Token(Token = "0x401D7C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C8E RID: 15502
		[Token(Token = "0x2003C8E")]
		private class TuningHandbookTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x06018359 RID: 99161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018359")]
			[Address(RVA = "0x10B6160", Offset = "0x10B4D60", VA = "0x1810B6160", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x170039CE RID: 14798
			// (get) Token: 0x0601835A RID: 99162 RVA: 0x00099AF8 File Offset: 0x00097CF8
			[Token(Token = "0x170039CE")]
			public bool isShow
			{
				[Token(Token = "0x601835A")]
				[Address(RVA = "0x10B62E0", Offset = "0x10B4EE0", VA = "0x1810B62E0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601835B RID: 99163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601835B")]
			[Address(RVA = "0x10B6280", Offset = "0x10B4E80", VA = "0x1810B6280")]
			public TuningHandbookTrackPointModel()
			{
			}

			// Token: 0x0401D7C7 RID: 120775
			[Token(Token = "0x401D7C7")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0401D7C8 RID: 120776
			[Token(Token = "0x401D7C8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0401D7C9 RID: 120777
			[Token(Token = "0x401D7C9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0401D7CA RID: 120778
			[Token(Token = "0x401D7CA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02003C8F RID: 15503
			[Token(Token = "0x2003C8F")]
			public class Input
			{
				// Token: 0x0601835C RID: 99164 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601835C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Input()
				{
				}

				// Token: 0x0401D7CB RID: 120779
				[Token(Token = "0x401D7CB")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0401D7CC RID: 120780
				[Token(Token = "0x401D7CC")]
				[FieldOffset(Offset = "0x18")]
				public string groupId;
			}
		}
	}
}
