using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF9 RID: 7673
	[Token(Token = "0x2001DF9")]
	public class BuildingFloatTradingView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BD7C RID: 48508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7C")]
		[Address(RVA = "0x33A6E40", Offset = "0x33A5A40", VA = "0x1833A6E40")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BD7D RID: 48509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7D")]
		[Address(RVA = "0x33A6F40", Offset = "0x33A5B40", VA = "0x1833A6F40")]
		public void Render(RoomSlotModel slotModel, TradingInfoViewStruct tradingInfo)
		{
		}

		// Token: 0x0600BD7E RID: 48510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BD7E")]
		[Address(RVA = "0x33A74E0", Offset = "0x33A60E0", VA = "0x1833A74E0")]
		private IEnumerator _UpdateAutoLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7F")]
		[Address(RVA = "0x33A6D30", Offset = "0x33A5930", VA = "0x1833A6D30")]
		public void EventOnOpenPage()
		{
		}

		// Token: 0x0600BD80 RID: 48512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD80")]
		[Address(RVA = "0x33A7590", Offset = "0x33A6190", VA = "0x1833A7590")]
		public BuildingFloatTradingView()
		{
		}

		// Token: 0x0400BDEE RID: 48622
		[Token(Token = "0x400BDEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textGoldName;

		// Token: 0x0400BDEF RID: 48623
		[Token(Token = "0x400BDEF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDiamondName;

		// Token: 0x0400BDF0 RID: 48624
		[Token(Token = "0x400BDF0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCompoundName;

		// Token: 0x0400BDF1 RID: 48625
		[Token(Token = "0x400BDF1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textGoldOrderNum;

		// Token: 0x0400BDF2 RID: 48626
		[Token(Token = "0x400BDF2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDiamondOrderNum;

		// Token: 0x0400BDF3 RID: 48627
		[Token(Token = "0x400BDF3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCompoundOrderNum;

		// Token: 0x0400BDF4 RID: 48628
		[Token(Token = "0x400BDF4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textOrderNum;

		// Token: 0x0400BDF5 RID: 48629
		[Token(Token = "0x400BDF5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textMaxOrderNum;

		// Token: 0x0400BDF6 RID: 48630
		[Token(Token = "0x400BDF6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FillProgressBar _progress;

		// Token: 0x0400BDF7 RID: 48631
		[Token(Token = "0x400BDF7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400BDF8 RID: 48632
		[Token(Token = "0x400BDF8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelNonEmpty;

		// Token: 0x0400BDF9 RID: 48633
		[Token(Token = "0x400BDF9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelAchieving;

		// Token: 0x0400BDFA RID: 48634
		[Token(Token = "0x400BDFA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0400BDFB RID: 48635
		[Token(Token = "0x400BDFB")]
		[FieldOffset(Offset = "0x80")]
		private string m_curSlotId;

		// Token: 0x0400BDFC RID: 48636
		[Token(Token = "0x400BDFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400BDFD RID: 48637
		[Token(Token = "0x400BDFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400BDFE RID: 48638
		[Token(Token = "0x400BDFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayoutCoroutine;

		// Token: 0x0400BDFF RID: 48639
		[Token(Token = "0x400BDFF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnOpenPage;

		// Token: 0x0400BE00 RID: 48640
		[Token(Token = "0x400BE00")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
