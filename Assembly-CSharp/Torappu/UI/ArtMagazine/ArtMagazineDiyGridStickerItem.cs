using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065A2 RID: 26018
	[Token(Token = "0x20065A2")]
	public class ArtMagazineDiyGridStickerItem : ArtMagazineDiyGridItemBase
	{
		// Token: 0x06025679 RID: 153209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025679")]
		[Address(RVA = "0x20636B0", Offset = "0x20622B0", VA = "0x1820636B0", Slot = "4")]
		protected override void OnRender(IArtMagazineDiyItemViewModel itemModel, bool isSelected)
		{
		}

		// Token: 0x0602567A RID: 153210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602567A")]
		[Address(RVA = "0x2063900", Offset = "0x2062500", VA = "0x182063900")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602567B RID: 153211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602567B")]
		[Address(RVA = "0x2063640", Offset = "0x2062240", VA = "0x182063640", Slot = "5")]
		public override void EventItemClick()
		{
		}

		// Token: 0x0602567C RID: 153212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602567C")]
		[Address(RVA = "0x2063990", Offset = "0x2062590", VA = "0x182063990")]
		public ArtMagazineDiyGridStickerItem()
		{
		}

		// Token: 0x0602567D RID: 153213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602567D")]
		[Address(RVA = "0x2063590", Offset = "0x2062190", VA = "0x182063590")]
		private void <>xLuaBaseProxy_EventItemClick()
		{
		}

		// Token: 0x040347C8 RID: 214984
		[Token(Token = "0x40347C8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _stickerPic;

		// Token: 0x040347C9 RID: 214985
		[Token(Token = "0x40347C9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x040347CA RID: 214986
		[Token(Token = "0x40347CA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _stickerTypeTrackPoint;

		// Token: 0x040347CB RID: 214987
		[Token(Token = "0x40347CB")]
		[FieldOffset(Offset = "0x50")]
		private string m_cacheStickerId;

		// Token: 0x040347CC RID: 214988
		[Token(Token = "0x40347CC")]
		[FieldOffset(Offset = "0x58")]
		private TrackPointViewProperty m_stickerTypeTrackPoint;

		// Token: 0x040347CD RID: 214989
		[Token(Token = "0x40347CD")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x040347CE RID: 214990
		[Token(Token = "0x40347CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040347CF RID: 214991
		[Token(Token = "0x40347CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040347D0 RID: 214992
		[Token(Token = "0x40347D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventItemClick;

		// Token: 0x040347D1 RID: 214993
		[Token(Token = "0x40347D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065A3 RID: 26019
		[Token(Token = "0x20065A3")]
		private class StickerItemTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700587A RID: 22650
			// (get) Token: 0x0602567E RID: 153214 RVA: 0x000C7D40 File Offset: 0x000C5F40
			[Token(Token = "0x1700587A")]
			public bool isShow
			{
				[Token(Token = "0x602567E")]
				[Address(RVA = "0x206DDC0", Offset = "0x206C9C0", VA = "0x18206DDC0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602567F RID: 153215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602567F")]
			[Address(RVA = "0x206DC80", Offset = "0x206C880", VA = "0x18206DC80", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x06025680 RID: 153216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025680")]
			[Address(RVA = "0x206DD60", Offset = "0x206C960", VA = "0x18206DD60")]
			public StickerItemTrackPointModel()
			{
			}

			// Token: 0x040347D2 RID: 214994
			[Token(Token = "0x40347D2")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x040347D3 RID: 214995
			[Token(Token = "0x40347D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x040347D4 RID: 214996
			[Token(Token = "0x40347D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x040347D5 RID: 214997
			[Token(Token = "0x40347D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020065A4 RID: 26020
			[Token(Token = "0x20065A4")]
			public class Input
			{
				// Token: 0x06025681 RID: 153217 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6025681")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Input()
				{
				}

				// Token: 0x040347D6 RID: 214998
				[Token(Token = "0x40347D6")]
				[FieldOffset(Offset = "0x10")]
				public string stickerId;
			}
		}
	}
}
