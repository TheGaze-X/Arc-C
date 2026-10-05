using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006945 RID: 26949
	[Token(Token = "0x2006945")]
	public class StageZoneVecBreakV2View : StageZoneSeasonEntryItem<VecBreakV2ZoneEntryModel>
	{
		// Token: 0x06026958 RID: 158040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026958")]
		[Address(RVA = "0x21B9880", Offset = "0x21B8480", VA = "0x1821B9880", Slot = "4")]
		public override void Render(VecBreakV2ZoneEntryModel entryModel)
		{
		}

		// Token: 0x06026959 RID: 158041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026959")]
		[Address(RVA = "0x21B9670", Offset = "0x21B8270", VA = "0x1821B9670")]
		public void EventOnOpenVecBreakAchvPage()
		{
		}

		// Token: 0x0602695A RID: 158042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602695A")]
		[Address(RVA = "0x21B96D0", Offset = "0x21B82D0", VA = "0x1821B96D0")]
		public void EventOpenVecBreakEntryPage()
		{
		}

		// Token: 0x0602695B RID: 158043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602695B")]
		[Address(RVA = "0x21B9D00", Offset = "0x21B8900", VA = "0x1821B9D00")]
		public StageZoneVecBreakV2View()
		{
		}

		// Token: 0x040366EC RID: 222956
		[Token(Token = "0x40366EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _incomingPartGO;

		// Token: 0x040366ED RID: 222957
		[Token(Token = "0x40366ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _commonPartGO;

		// Token: 0x040366EE RID: 222958
		[Token(Token = "0x40366EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _closePartGO;

		// Token: 0x040366EF RID: 222959
		[Token(Token = "0x40366EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _openPartGO;

		// Token: 0x040366F0 RID: 222960
		[Token(Token = "0x40366F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textActName;

		// Token: 0x040366F1 RID: 222961
		[Token(Token = "0x40366F1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textFinishTime;

		// Token: 0x040366F2 RID: 222962
		[Token(Token = "0x40366F2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x040366F3 RID: 222963
		[Token(Token = "0x40366F3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgAchvEntry;

		// Token: 0x040366F4 RID: 222964
		[Token(Token = "0x40366F4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgActEntry;

		// Token: 0x040366F5 RID: 222965
		[Token(Token = "0x40366F5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgMedalIcon;

		// Token: 0x040366F6 RID: 222966
		[Token(Token = "0x40366F6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _scheduleList;

		// Token: 0x040366F7 RID: 222967
		[Token(Token = "0x40366F7")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040366F8 RID: 222968
		[Token(Token = "0x40366F8")]
		[FieldOffset(Offset = "0x80")]
		private VecBreakV2ZoneEntryModel m_entryModel;

		// Token: 0x040366F9 RID: 222969
		[Token(Token = "0x40366F9")]
		[FieldOffset(Offset = "0x88")]
		private Color m_colorActiveText;

		// Token: 0x040366FA RID: 222970
		[Token(Token = "0x40366FA")]
		[FieldOffset(Offset = "0x98")]
		private Color m_colorActiveBg;

		// Token: 0x040366FB RID: 222971
		[Token(Token = "0x40366FB")]
		[FieldOffset(Offset = "0xA8")]
		private StageZoneVecBreakV2View.Adapter m_adapter;

		// Token: 0x040366FC RID: 222972
		[Token(Token = "0x40366FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040366FD RID: 222973
		[Token(Token = "0x40366FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnOpenVecBreakAchvPage;

		// Token: 0x040366FE RID: 222974
		[Token(Token = "0x40366FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOpenVecBreakEntryPage;

		// Token: 0x040366FF RID: 222975
		[Token(Token = "0x40366FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006946 RID: 26950
		[Token(Token = "0x2006946")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602695C RID: 158044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602695C")]
			[Address(RVA = "0x21A5D90", Offset = "0x21A4990", VA = "0x1821A5D90")]
			public Adapter(StageZoneVecBreakV2View closure)
			{
			}

			// Token: 0x17005B19 RID: 23321
			// (get) Token: 0x0602695D RID: 158045 RVA: 0x000CBC10 File Offset: 0x000C9E10
			[Token(Token = "0x17005B19")]
			public override int count
			{
				[Token(Token = "0x602695D")]
				[Address(RVA = "0x21A5EE0", Offset = "0x21A4AE0", VA = "0x1821A5EE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602695E RID: 158046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602695E")]
			[Address(RVA = "0x21A5B30", Offset = "0x21A4730", VA = "0x1821A5B30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04036700 RID: 222976
			[Token(Token = "0x4036700")]
			[FieldOffset(Offset = "0x20")]
			public StageZoneVecBreakV2View m_closure;

			// Token: 0x04036701 RID: 222977
			[Token(Token = "0x4036701")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04036702 RID: 222978
			[Token(Token = "0x4036702")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036703 RID: 222979
			[Token(Token = "0x4036703")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
