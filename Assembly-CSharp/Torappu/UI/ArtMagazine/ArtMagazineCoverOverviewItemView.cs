using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200653A RID: 25914
	[Token(Token = "0x200653A")]
	public class ArtMagazineCoverOverviewItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060253E9 RID: 152553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253E9")]
		[Address(RVA = "0x2033B30", Offset = "0x2032730", VA = "0x182033B30")]
		public void Render(ArtMagazineCoverOverviewItemViewModel itemViewModel)
		{
		}

		// Token: 0x060253EA RID: 152554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253EA")]
		[Address(RVA = "0x20340D0", Offset = "0x2032CD0", VA = "0x1820340D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060253EB RID: 152555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253EB")]
		[Address(RVA = "0x2033A10", Offset = "0x2032610", VA = "0x182033A10")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x060253EC RID: 152556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253EC")]
		[Address(RVA = "0x2034210", Offset = "0x2032E10", VA = "0x182034210")]
		public ArtMagazineCoverOverviewItemView()
		{
		}

		// Token: 0x04034407 RID: 214023
		[Token(Token = "0x4034407")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AsyncImageRenderer _asyncImageRenderer;

		// Token: 0x04034408 RID: 214024
		[Token(Token = "0x4034408")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _loadAnim;

		// Token: 0x04034409 RID: 214025
		[Token(Token = "0x4034409")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objSerialPart;

		// Token: 0x0403440A RID: 214026
		[Token(Token = "0x403440A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtSerialNum;

		// Token: 0x0403440B RID: 214027
		[Token(Token = "0x403440B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtLeafName;

		// Token: 0x0403440C RID: 214028
		[Token(Token = "0x403440C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtLeafEngName;

		// Token: 0x0403440D RID: 214029
		[Token(Token = "0x403440D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objLine;

		// Token: 0x0403440E RID: 214030
		[Token(Token = "0x403440E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textNickname;

		// Token: 0x0403440F RID: 214031
		[Token(Token = "0x403440F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _leafItemTrackpoint;

		// Token: 0x04034410 RID: 214032
		[Token(Token = "0x4034410")]
		[FieldOffset(Offset = "0x68")]
		private string m_leafId;

		// Token: 0x04034411 RID: 214033
		[Token(Token = "0x4034411")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x04034412 RID: 214034
		[Token(Token = "0x4034412")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034413 RID: 214035
		[Token(Token = "0x4034413")]
		[FieldOffset(Offset = "0x88")]
		private TrackPointViewProperty m_itemNewTrackpoint;

		// Token: 0x04034414 RID: 214036
		[Token(Token = "0x4034414")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034415 RID: 214037
		[Token(Token = "0x4034415")]
		[FieldOffset(Offset = "0xA0")]
		private UISwitchTween m_loadTween;

		// Token: 0x04034416 RID: 214038
		[Token(Token = "0x4034416")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cacheThumbnailKey;

		// Token: 0x04034417 RID: 214039
		[Token(Token = "0x4034417")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034418 RID: 214040
		[Token(Token = "0x4034418")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034419 RID: 214041
		[Token(Token = "0x4034419")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0403441A RID: 214042
		[Token(Token = "0x403441A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200653B RID: 25915
		[Token(Token = "0x200653B")]
		private class LeafItemTrackpointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x170057EC RID: 22508
			// (get) Token: 0x060253EE RID: 152558 RVA: 0x000C7278 File Offset: 0x000C5478
			[Token(Token = "0x170057EC")]
			public bool isShow
			{
				[Token(Token = "0x60253EE")]
				[Address(RVA = "0x2040840", Offset = "0x203F440", VA = "0x182040840", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060253EF RID: 152559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60253EF")]
			[Address(RVA = "0x2040670", Offset = "0x203F270", VA = "0x182040670", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x060253F0 RID: 152560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60253F0")]
			[Address(RVA = "0x20407E0", Offset = "0x203F3E0", VA = "0x1820407E0")]
			public LeafItemTrackpointModel()
			{
			}

			// Token: 0x0403441B RID: 214043
			[Token(Token = "0x403441B")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403441C RID: 214044
			[Token(Token = "0x403441C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403441D RID: 214045
			[Token(Token = "0x403441D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403441E RID: 214046
			[Token(Token = "0x403441E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200653C RID: 25916
			[Token(Token = "0x200653C")]
			public class Param
			{
				// Token: 0x060253F1 RID: 152561 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60253F1")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403441F RID: 214047
				[Token(Token = "0x403441F")]
				[FieldOffset(Offset = "0x10")]
				public string leafId;
			}
		}
	}
}
