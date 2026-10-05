using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007443 RID: 29763
	[Token(Token = "0x2007443")]
	public class Act36sideEntryFoodHandbookPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x0602A019 RID: 172057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A019")]
		[Address(RVA = "0x259A540", Offset = "0x2599140", VA = "0x18259A540", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A01A RID: 172058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A01A")]
		[Address(RVA = "0x259A8D0", Offset = "0x25994D0", VA = "0x18259A8D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A01B RID: 172059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A01B")]
		[Address(RVA = "0x259A6C0", Offset = "0x25992C0", VA = "0x18259A6C0")]
		public void OpenFoodHandbookPage()
		{
		}

		// Token: 0x0602A01C RID: 172060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A01C")]
		[Address(RVA = "0x259A960", Offset = "0x2599560", VA = "0x18259A960")]
		public Act36sideEntryFoodHandbookPlugin()
		{
		}

		// Token: 0x0403C3D1 RID: 246737
		[Token(Token = "0x403C3D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hasRewardGo;

		// Token: 0x0403C3D2 RID: 246738
		[Token(Token = "0x403C3D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _newTrackPoint;

		// Token: 0x0403C3D3 RID: 246739
		[Token(Token = "0x403C3D3")]
		[FieldOffset(Offset = "0x38")]
		private TrackPointViewProperty m_trackPointProp;

		// Token: 0x0403C3D4 RID: 246740
		[Token(Token = "0x403C3D4")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403C3D5 RID: 246741
		[Token(Token = "0x403C3D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C3D6 RID: 246742
		[Token(Token = "0x403C3D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C3D7 RID: 246743
		[Token(Token = "0x403C3D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenFoodHandbookPage;

		// Token: 0x0403C3D8 RID: 246744
		[Token(Token = "0x403C3D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007444 RID: 29764
		[Token(Token = "0x2007444")]
		public class FoodHandbookTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700631D RID: 25373
			// (get) Token: 0x0602A01D RID: 172061 RVA: 0x000D7388 File Offset: 0x000D5588
			[Token(Token = "0x1700631D")]
			public bool isShow
			{
				[Token(Token = "0x602A01D")]
				[Address(RVA = "0x25ABE80", Offset = "0x25AAA80", VA = "0x1825ABE80", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602A01E RID: 172062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A01E")]
			[Address(RVA = "0x25ABD50", Offset = "0x25AA950", VA = "0x1825ABD50", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602A01F RID: 172063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A01F")]
			[Address(RVA = "0x25ABE20", Offset = "0x25AAA20", VA = "0x1825ABE20")]
			public FoodHandbookTrackPointModel()
			{
			}

			// Token: 0x0403C3D9 RID: 246745
			[Token(Token = "0x403C3D9")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403C3DA RID: 246746
			[Token(Token = "0x403C3DA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403C3DB RID: 246747
			[Token(Token = "0x403C3DB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403C3DC RID: 246748
			[Token(Token = "0x403C3DC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
