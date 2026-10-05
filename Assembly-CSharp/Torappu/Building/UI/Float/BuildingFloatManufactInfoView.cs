using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF3 RID: 7667
	[Token(Token = "0x2001DF3")]
	public class BuildingFloatManufactInfoView : DataBinder<FloatManufactViewProperty>
	{
		// Token: 0x0600BD5D RID: 48477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5D")]
		[Address(RVA = "0x339F4F0", Offset = "0x339E0F0", VA = "0x18339F4F0", Slot = "7")]
		public override void OnValueChanged(FloatManufactViewProperty property)
		{
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5E")]
		[Address(RVA = "0x339FB60", Offset = "0x339E760", VA = "0x18339FB60")]
		private void _Init()
		{
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5F")]
		[Address(RVA = "0x339FE70", Offset = "0x339EA70", VA = "0x18339FE70")]
		private void _UpdateActiveContent()
		{
		}

		// Token: 0x0600BD60 RID: 48480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD60")]
		[Address(RVA = "0x339FFA0", Offset = "0x339EBA0", VA = "0x18339FFA0")]
		private void _UpdateAutoLayouts()
		{
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD61")]
		[Address(RVA = "0x339FCE0", Offset = "0x339E8E0", VA = "0x18339FCE0")]
		private void _OnTimeTick(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD62")]
		[Address(RVA = "0x33A0090", Offset = "0x339EC90", VA = "0x1833A0090")]
		private void _UpdateManufactInfo()
		{
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD63")]
		[Address(RVA = "0x339F880", Offset = "0x339E480", VA = "0x18339F880")]
		private void Start()
		{
		}

		// Token: 0x0600BD64 RID: 48484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD64")]
		[Address(RVA = "0x339FAE0", Offset = "0x339E6E0", VA = "0x18339FAE0")]
		private void Update()
		{
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD65")]
		[Address(RVA = "0x33A0640", Offset = "0x339F240", VA = "0x1833A0640")]
		public BuildingFloatManufactInfoView()
		{
		}

		// Token: 0x0400BDA1 RID: 48545
		[Token(Token = "0x400BDA1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelItems;

		// Token: 0x0400BDA2 RID: 48546
		[Token(Token = "0x400BDA2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400BDA3 RID: 48547
		[Token(Token = "0x400BDA3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400BDA4 RID: 48548
		[Token(Token = "0x400BDA4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLimit;

		// Token: 0x0400BDA5 RID: 48549
		[Token(Token = "0x400BDA5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textManufState;

		// Token: 0x0400BDA6 RID: 48550
		[Token(Token = "0x400BDA6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x0400BDA7 RID: 48551
		[Token(Token = "0x400BDA7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x0400BDA8 RID: 48552
		[Token(Token = "0x400BDA8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0400BDA9 RID: 48553
		[Token(Token = "0x400BDA9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x0400BDAA RID: 48554
		[Token(Token = "0x400BDAA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FillProgressBar _progress;

		// Token: 0x0400BDAB RID: 48555
		[Token(Token = "0x400BDAB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0400BDAC RID: 48556
		[Token(Token = "0x400BDAC")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0400BDAD RID: 48557
		[Token(Token = "0x400BDAD")]
		[FieldOffset(Offset = "0x80")]
		private UIItemCard m_itemCard;

		// Token: 0x0400BDAE RID: 48558
		[Token(Token = "0x400BDAE")]
		[FieldOffset(Offset = "0x88")]
		private CountDownTask m_outputCountDown;

		// Token: 0x0400BDAF RID: 48559
		[Token(Token = "0x400BDAF")]
		[FieldOffset(Offset = "0x90")]
		private CountDownTask m_totalRemainCountDown;

		// Token: 0x0400BDB0 RID: 48560
		[Token(Token = "0x400BDB0")]
		[FieldOffset(Offset = "0x98")]
		private ManufactInfoViewModel m_manufactInfo;

		// Token: 0x0400BDB1 RID: 48561
		[Token(Token = "0x400BDB1")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0400BDB2 RID: 48562
		[Token(Token = "0x400BDB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BDB3 RID: 48563
		[Token(Token = "0x400BDB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400BDB4 RID: 48564
		[Token(Token = "0x400BDB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateActiveContent;

		// Token: 0x0400BDB5 RID: 48565
		[Token(Token = "0x400BDB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayouts;

		// Token: 0x0400BDB6 RID: 48566
		[Token(Token = "0x400BDB6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTimeTick;

		// Token: 0x0400BDB7 RID: 48567
		[Token(Token = "0x400BDB7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateManufactInfo;

		// Token: 0x0400BDB8 RID: 48568
		[Token(Token = "0x400BDB8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400BDB9 RID: 48569
		[Token(Token = "0x400BDB9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400BDBA RID: 48570
		[Token(Token = "0x400BDBA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
