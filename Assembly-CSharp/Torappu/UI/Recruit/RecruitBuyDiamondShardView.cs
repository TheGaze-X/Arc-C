using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200472B RID: 18219
	[Token(Token = "0x200472B")]
	public class RecruitBuyDiamondShardView : PageSingleComponent
	{
		// Token: 0x0601B9CC RID: 113100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9CC")]
		[Address(RVA = "0x14FAB70", Offset = "0x14F9770", VA = "0x1814FAB70")]
		private void _Init()
		{
		}

		// Token: 0x0601B9CD RID: 113101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9CD")]
		[Address(RVA = "0x14FA300", Offset = "0x14F8F00", VA = "0x1814FA300")]
		public static void ApplyDataStatic(int needDS, Action<string> gachaEvent, string inputPoolId)
		{
		}

		// Token: 0x0601B9CE RID: 113102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9CE")]
		[Address(RVA = "0x14FA890", Offset = "0x14F9490", VA = "0x1814FA890")]
		public void SendDiamondExchangeService()
		{
		}

		// Token: 0x0601B9CF RID: 113103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9CF")]
		[Address(RVA = "0x14FAFA0", Offset = "0x14F9BA0", VA = "0x1814FAFA0")]
		private void _OnExchangeResponseSuccess(ExchangeDiamondShardResponse response)
		{
		}

		// Token: 0x0601B9D0 RID: 113104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9D0")]
		[Address(RVA = "0x14FA800", Offset = "0x14F9400", VA = "0x1814FA800")]
		public void Dismiss()
		{
		}

		// Token: 0x0601B9D1 RID: 113105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9D1")]
		[Address(RVA = "0x14FA410", Offset = "0x14F9010", VA = "0x1814FA410")]
		public void ApplyData(int needDS)
		{
		}

		// Token: 0x0601B9D2 RID: 113106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9D2")]
		[Address(RVA = "0x14FB040", Offset = "0x14F9C40", VA = "0x1814FB040")]
		public RecruitBuyDiamondShardView()
		{
		}

		// Token: 0x04023CB1 RID: 146609
		[Token(Token = "0x4023CB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _soldText;

		// Token: 0x04023CB2 RID: 146610
		[Token(Token = "0x4023CB2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x04023CB3 RID: 146611
		[Token(Token = "0x4023CB3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIItemCard _itemPrefab;

		// Token: 0x04023CB4 RID: 146612
		[Token(Token = "0x4023CB4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _itemContainer1;

		// Token: 0x04023CB5 RID: 146613
		[Token(Token = "0x4023CB5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _itemContainer2;

		// Token: 0x04023CB6 RID: 146614
		[Token(Token = "0x4023CB6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04023CB7 RID: 146615
		[Token(Token = "0x4023CB7")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> action;

		// Token: 0x04023CB8 RID: 146616
		[Token(Token = "0x4023CB8")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public string inputPoolId;

		// Token: 0x04023CB9 RID: 146617
		[Token(Token = "0x4023CB9")]
		[FieldOffset(Offset = "0x60")]
		private int m_cacheDiamond;

		// Token: 0x04023CBA RID: 146618
		[Token(Token = "0x4023CBA")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_costItem;

		// Token: 0x04023CBB RID: 146619
		[Token(Token = "0x4023CBB")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_targetItem;

		// Token: 0x04023CBC RID: 146620
		[Token(Token = "0x4023CBC")]
		[FieldOffset(Offset = "0x78")]
		private UIItemViewModel m_costModel;

		// Token: 0x04023CBD RID: 146621
		[Token(Token = "0x4023CBD")]
		[FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_targetModel;

		// Token: 0x04023CBE RID: 146622
		[Token(Token = "0x4023CBE")]
		[FieldOffset(Offset = "0x88")]
		private bool m_initFlag;

		// Token: 0x04023CBF RID: 146623
		[Token(Token = "0x4023CBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04023CC0 RID: 146624
		[Token(Token = "0x4023CC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyDataStatic;

		// Token: 0x04023CC1 RID: 146625
		[Token(Token = "0x4023CC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendDiamondExchangeService;

		// Token: 0x04023CC2 RID: 146626
		[Token(Token = "0x4023CC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnExchangeResponseSuccess;

		// Token: 0x04023CC3 RID: 146627
		[Token(Token = "0x4023CC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x04023CC4 RID: 146628
		[Token(Token = "0x4023CC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04023CC5 RID: 146629
		[Token(Token = "0x4023CC5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
