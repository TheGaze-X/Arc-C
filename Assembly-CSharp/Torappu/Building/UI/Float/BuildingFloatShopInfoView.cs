using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF7 RID: 7671
	[Token(Token = "0x2001DF7")]
	public class BuildingFloatShopInfoView : DataBinder<FloatShopInfoViewProperty>
	{
		// Token: 0x0600BD75 RID: 48501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD75")]
		[Address(RVA = "0x33A1B70", Offset = "0x33A0770", VA = "0x1833A1B70")]
		private void Start()
		{
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD76")]
		[Address(RVA = "0x33A1BF0", Offset = "0x33A07F0", VA = "0x1833A1BF0")]
		private void Update()
		{
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD77")]
		[Address(RVA = "0x33A1A00", Offset = "0x33A0600", VA = "0x1833A1A00", Slot = "7")]
		public override void OnValueChanged(FloatShopInfoViewProperty property)
		{
		}

		// Token: 0x0600BD78 RID: 48504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD78")]
		[Address(RVA = "0x33A1CC0", Offset = "0x33A08C0", VA = "0x1833A1CC0")]
		private void _UpdateContent()
		{
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD79")]
		[Address(RVA = "0x33A20F0", Offset = "0x33A0CF0", VA = "0x1833A20F0")]
		public BuildingFloatShopInfoView()
		{
		}

		// Token: 0x0400BDDD RID: 48605
		[Token(Token = "0x400BDDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingFloatShopInfoStockView[] _stockViews;

		// Token: 0x0400BDDE RID: 48606
		[Token(Token = "0x400BDDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textOutput;

		// Token: 0x0400BDDF RID: 48607
		[Token(Token = "0x400BDDF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textOutputLimit;

		// Token: 0x0400BDE0 RID: 48608
		[Token(Token = "0x400BDE0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FillProgressBar _progress;

		// Token: 0x0400BDE1 RID: 48609
		[Token(Token = "0x400BDE1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _outputLine;

		// Token: 0x0400BDE2 RID: 48610
		[Token(Token = "0x400BDE2")]
		[FieldOffset(Offset = "0x48")]
		private CountDownTask[] m_countDowns;

		// Token: 0x0400BDE3 RID: 48611
		[Token(Token = "0x400BDE3")]
		[FieldOffset(Offset = "0x50")]
		private ShopInfoViewModel m_viewModel;

		// Token: 0x0400BDE4 RID: 48612
		[Token(Token = "0x400BDE4")]
		[FieldOffset(Offset = "0x58")]
		private ShopStockSnapshot[] m_snapshots;

		// Token: 0x0400BDE5 RID: 48613
		[Token(Token = "0x400BDE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400BDE6 RID: 48614
		[Token(Token = "0x400BDE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400BDE7 RID: 48615
		[Token(Token = "0x400BDE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BDE8 RID: 48616
		[Token(Token = "0x400BDE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400BDE9 RID: 48617
		[Token(Token = "0x400BDE9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
