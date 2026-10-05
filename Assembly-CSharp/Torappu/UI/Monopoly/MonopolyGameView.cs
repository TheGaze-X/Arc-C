using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004814 RID: 18452
	[Token(Token = "0x2004814")]
	public class MonopolyGameView : DataBinder<MonopolyGameProperty>
	{
		// Token: 0x0601BE75 RID: 114293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE75")]
		[Address(RVA = "0x153E420", Offset = "0x153D020", VA = "0x18153E420", Slot = "7")]
		public override void OnValueChanged(MonopolyGameProperty property)
		{
		}

		// Token: 0x0601BE76 RID: 114294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE76")]
		[Address(RVA = "0x153E660", Offset = "0x153D260", VA = "0x18153E660")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BE77 RID: 114295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE77")]
		[Address(RVA = "0x153E7D0", Offset = "0x153D3D0", VA = "0x18153E7D0")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x0601BE78 RID: 114296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE78")]
		[Address(RVA = "0x153EAF0", Offset = "0x153D6F0", VA = "0x18153EAF0")]
		public MonopolyGameView()
		{
		}

		// Token: 0x040245E6 RID: 148966
		[Token(Token = "0x40245E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MonopolyCardPanelView _cardPanelPrefab;

		// Token: 0x040245E7 RID: 148967
		[Token(Token = "0x40245E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _cardPanelContainer;

		// Token: 0x040245E8 RID: 148968
		[Token(Token = "0x40245E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MonopolyTopBuffBar _topBuffBarPrefab;

		// Token: 0x040245E9 RID: 148969
		[Token(Token = "0x40245E9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _topBuffBarContainer;

		// Token: 0x040245EA RID: 148970
		[Token(Token = "0x40245EA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MonopolyMapView _mapViewPrefab;

		// Token: 0x040245EB RID: 148971
		[Token(Token = "0x40245EB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _mapViewContainer;

		// Token: 0x040245EC RID: 148972
		[Token(Token = "0x40245EC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MonopolyMissionView _missionViewPrefab;

		// Token: 0x040245ED RID: 148973
		[Token(Token = "0x40245ED")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _missionViewContainer;

		// Token: 0x040245EE RID: 148974
		[Token(Token = "0x40245EE")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x040245EF RID: 148975
		[Token(Token = "0x40245EF")]
		[FieldOffset(Offset = "0x68")]
		private MonopolyCardPanelView m_cardPanelView;

		// Token: 0x040245F0 RID: 148976
		[Token(Token = "0x40245F0")]
		[FieldOffset(Offset = "0x70")]
		private MonopolyTopBuffBar m_topBuffBarView;

		// Token: 0x040245F1 RID: 148977
		[Token(Token = "0x40245F1")]
		[FieldOffset(Offset = "0x78")]
		private MonopolyMapView m_mapView;

		// Token: 0x040245F2 RID: 148978
		[Token(Token = "0x40245F2")]
		[FieldOffset(Offset = "0x80")]
		private MonopolyMissionView m_missionView;

		// Token: 0x040245F3 RID: 148979
		[Token(Token = "0x40245F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040245F4 RID: 148980
		[Token(Token = "0x40245F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040245F5 RID: 148981
		[Token(Token = "0x40245F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x040245F6 RID: 148982
		[Token(Token = "0x40245F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
