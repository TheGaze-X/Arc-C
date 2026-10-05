using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CFD RID: 15613
	[Token(Token = "0x2003CFD")]
	public class TuningProductBagProductGroupModel : IHotfixable
	{
		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0601858D RID: 99725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A24")]
		public string productTypeSmallName
		{
			[Token(Token = "0x601858D")]
			[Address(RVA = "0x10DBFE0", Offset = "0x10DABE0", VA = "0x1810DBFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0601858E RID: 99726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A25")]
		public string productTypeId
		{
			[Token(Token = "0x601858E")]
			[Address(RVA = "0x10DBF80", Offset = "0x10DAB80", VA = "0x1810DBF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0601858F RID: 99727 RVA: 0x0009A1A0 File Offset: 0x000983A0
		[Token(Token = "0x17003A26")]
		public bool isSelect
		{
			[Token(Token = "0x601858F")]
			[Address(RVA = "0x10DBF20", Offset = "0x10DAB20", VA = "0x1810DBF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x06018590 RID: 99728 RVA: 0x0009A1B8 File Offset: 0x000983B8
		[Token(Token = "0x17003A27")]
		public bool isLock
		{
			[Token(Token = "0x6018590")]
			[Address(RVA = "0x10DBEC0", Offset = "0x10DAAC0", VA = "0x1810DBEC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x06018591 RID: 99729 RVA: 0x0009A1D0 File Offset: 0x000983D0
		[Token(Token = "0x17003A28")]
		public bool isAnswer
		{
			[Token(Token = "0x6018591")]
			[Address(RVA = "0x10DBE00", Offset = "0x10DAA00", VA = "0x1810DBE00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x06018592 RID: 99730 RVA: 0x0009A1E8 File Offset: 0x000983E8
		[Token(Token = "0x17003A29")]
		public bool isHidden
		{
			[Token(Token = "0x6018592")]
			[Address(RVA = "0x10DBE60", Offset = "0x10DAA60", VA = "0x1810DBE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x06018593 RID: 99731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A2A")]
		public ListDict<string, TuningProductBagFormModel> formListDict
		{
			[Token(Token = "0x6018593")]
			[Address(RVA = "0x10DBD40", Offset = "0x10DA940", VA = "0x1810DBD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x06018594 RID: 99732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A2B")]
		public TuningProductBagCardModel hiddenCardModel
		{
			[Token(Token = "0x6018594")]
			[Address(RVA = "0x10DBDA0", Offset = "0x10DA9A0", VA = "0x1810DBDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x06018595 RID: 99733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A2C")]
		public string themeColor
		{
			[Token(Token = "0x6018595")]
			[Address(RVA = "0x10DC0A0", Offset = "0x10DACA0", VA = "0x1810DC0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x06018596 RID: 99734 RVA: 0x0009A200 File Offset: 0x00098400
		[Token(Token = "0x17003A2D")]
		public int sortId
		{
			[Token(Token = "0x6018596")]
			[Address(RVA = "0x10DC040", Offset = "0x10DAC40", VA = "0x1810DC040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06018597 RID: 99735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018597")]
		[Address(RVA = "0x10DB6F0", Offset = "0x10DA2F0", VA = "0x1810DB6F0")]
		public void InitData(Act29SideData actData, Act29SideData.Act29SideProductGroupData groupData)
		{
		}

		// Token: 0x06018598 RID: 99736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018598")]
		[Address(RVA = "0x10DB230", Offset = "0x10D9E30", VA = "0x1810DB230")]
		public void AddProduct(string actId, Act29SideData.Act29SideProductData productData, int productNum, bool isCardInteractable)
		{
		}

		// Token: 0x06018599 RID: 99737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018599")]
		[Address(RVA = "0x10DB940", Offset = "0x10DA540", VA = "0x1810DB940")]
		public void SortListDict()
		{
		}

		// Token: 0x0601859A RID: 99738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601859A")]
		[Address(RVA = "0x10DB650", Offset = "0x10DA250", VA = "0x1810DB650")]
		public void ClearProduct()
		{
		}

		// Token: 0x0601859B RID: 99739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601859B")]
		[Address(RVA = "0x10DB860", Offset = "0x10DA460", VA = "0x1810DB860")]
		public void SetLock(bool iIsLock)
		{
		}

		// Token: 0x0601859C RID: 99740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601859C")]
		[Address(RVA = "0x10DB8D0", Offset = "0x10DA4D0", VA = "0x1810DB8D0")]
		public void SetSelect(bool iIsSelect)
		{
		}

		// Token: 0x0601859D RID: 99741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601859D")]
		[Address(RVA = "0x10DB7F0", Offset = "0x10DA3F0", VA = "0x1810DB7F0")]
		public void SetAnswer(bool iIsAnswer)
		{
		}

		// Token: 0x0601859E RID: 99742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601859E")]
		[Address(RVA = "0x10DBC80", Offset = "0x10DA880", VA = "0x1810DBC80")]
		public TuningProductBagProductGroupModel()
		{
		}

		// Token: 0x0401DC27 RID: 121895
		[Token(Token = "0x401DC27")]
		[FieldOffset(Offset = "0x10")]
		private string m_productTypeSmallName;

		// Token: 0x0401DC28 RID: 121896
		[Token(Token = "0x401DC28")]
		[FieldOffset(Offset = "0x18")]
		private string m_productTypeId;

		// Token: 0x0401DC29 RID: 121897
		[Token(Token = "0x401DC29")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isSelect;

		// Token: 0x0401DC2A RID: 121898
		[Token(Token = "0x401DC2A")]
		[FieldOffset(Offset = "0x21")]
		private bool m_isLock;

		// Token: 0x0401DC2B RID: 121899
		[Token(Token = "0x401DC2B")]
		[FieldOffset(Offset = "0x22")]
		private bool m_isAnswer;

		// Token: 0x0401DC2C RID: 121900
		[Token(Token = "0x401DC2C")]
		[FieldOffset(Offset = "0x24")]
		private int m_sortId;

		// Token: 0x0401DC2D RID: 121901
		[Token(Token = "0x401DC2D")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isHidden;

		// Token: 0x0401DC2E RID: 121902
		[Token(Token = "0x401DC2E")]
		[FieldOffset(Offset = "0x30")]
		private string m_themeColor;

		// Token: 0x0401DC2F RID: 121903
		[Token(Token = "0x401DC2F")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, TuningProductBagFormModel> m_formListDict;

		// Token: 0x0401DC30 RID: 121904
		[Token(Token = "0x401DC30")]
		[FieldOffset(Offset = "0x40")]
		private TuningProductBagCardModel m_hiddenCardModel;

		// Token: 0x0401DC31 RID: 121905
		[Token(Token = "0x401DC31")]
		[FieldOffset(Offset = "0x48")]
		private Act29SideData m_actData;

		// Token: 0x0401DC32 RID: 121906
		[Token(Token = "0x401DC32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_productTypeSmallName;

		// Token: 0x0401DC33 RID: 121907
		[Token(Token = "0x401DC33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_productTypeId;

		// Token: 0x0401DC34 RID: 121908
		[Token(Token = "0x401DC34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSelect;

		// Token: 0x0401DC35 RID: 121909
		[Token(Token = "0x401DC35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isLock;

		// Token: 0x0401DC36 RID: 121910
		[Token(Token = "0x401DC36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isAnswer;

		// Token: 0x0401DC37 RID: 121911
		[Token(Token = "0x401DC37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x0401DC38 RID: 121912
		[Token(Token = "0x401DC38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_formListDict;

		// Token: 0x0401DC39 RID: 121913
		[Token(Token = "0x401DC39")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hiddenCardModel;

		// Token: 0x0401DC3A RID: 121914
		[Token(Token = "0x401DC3A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x0401DC3B RID: 121915
		[Token(Token = "0x401DC3B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401DC3C RID: 121916
		[Token(Token = "0x401DC3C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DC3D RID: 121917
		[Token(Token = "0x401DC3D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddProduct;

		// Token: 0x0401DC3E RID: 121918
		[Token(Token = "0x401DC3E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SortListDict;

		// Token: 0x0401DC3F RID: 121919
		[Token(Token = "0x401DC3F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ClearProduct;

		// Token: 0x0401DC40 RID: 121920
		[Token(Token = "0x401DC40")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetLock;

		// Token: 0x0401DC41 RID: 121921
		[Token(Token = "0x401DC41")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x0401DC42 RID: 121922
		[Token(Token = "0x401DC42")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetAnswer;

		// Token: 0x0401DC43 RID: 121923
		[Token(Token = "0x401DC43")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
