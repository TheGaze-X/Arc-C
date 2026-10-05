using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CFF RID: 15615
	[Token(Token = "0x2003CFF")]
	public class TuningProductBagFormModel : IHotfixable
	{
		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x060185A2 RID: 99746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A2E")]
		public string formDesc
		{
			[Token(Token = "0x60185A2")]
			[Address(RVA = "0x10DA710", Offset = "0x10D9310", VA = "0x1810DA710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x060185A3 RID: 99747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A2F")]
		public List<string> fragmentIconList
		{
			[Token(Token = "0x60185A3")]
			[Address(RVA = "0x10DA770", Offset = "0x10D9370", VA = "0x1810DA770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x060185A4 RID: 99748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A30")]
		public ListDict<string, TuningProductBagCardModel> cardListDict
		{
			[Token(Token = "0x60185A4")]
			[Address(RVA = "0x10DA6B0", Offset = "0x10D92B0", VA = "0x1810DA6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x060185A5 RID: 99749 RVA: 0x0009A230 File Offset: 0x00098430
		[Token(Token = "0x17003A31")]
		public int sortId
		{
			[Token(Token = "0x60185A5")]
			[Address(RVA = "0x10DA7D0", Offset = "0x10D93D0", VA = "0x1810DA7D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060185A6 RID: 99750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185A6")]
		[Address(RVA = "0x10DA270", Offset = "0x10D8E70", VA = "0x1810DA270")]
		public void InitData(Act29SideData actData, string formId)
		{
		}

		// Token: 0x060185A7 RID: 99751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185A7")]
		[Address(RVA = "0x10DA0E0", Offset = "0x10D8CE0", VA = "0x1810DA0E0")]
		public void AddProduct(string actId, Act29SideData.Act29SideProductData productData, int productNum, bool isCardInteractable)
		{
		}

		// Token: 0x060185A8 RID: 99752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185A8")]
		[Address(RVA = "0x10DA450", Offset = "0x10D9050", VA = "0x1810DA450")]
		public void SortListDict()
		{
		}

		// Token: 0x060185A9 RID: 99753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185A9")]
		[Address(RVA = "0x10DA5B0", Offset = "0x10D91B0", VA = "0x1810DA5B0")]
		public TuningProductBagFormModel()
		{
		}

		// Token: 0x0401DC46 RID: 121926
		[Token(Token = "0x401DC46")]
		[FieldOffset(Offset = "0x10")]
		private string m_formDesc;

		// Token: 0x0401DC47 RID: 121927
		[Token(Token = "0x401DC47")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_fragmentIconList;

		// Token: 0x0401DC48 RID: 121928
		[Token(Token = "0x401DC48")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, TuningProductBagCardModel> m_cardListDict;

		// Token: 0x0401DC49 RID: 121929
		[Token(Token = "0x401DC49")]
		[FieldOffset(Offset = "0x28")]
		private int m_sortId;

		// Token: 0x0401DC4A RID: 121930
		[Token(Token = "0x401DC4A")]
		[FieldOffset(Offset = "0x30")]
		private Act29SideData m_actData;

		// Token: 0x0401DC4B RID: 121931
		[Token(Token = "0x401DC4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_formDesc;

		// Token: 0x0401DC4C RID: 121932
		[Token(Token = "0x401DC4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fragmentIconList;

		// Token: 0x0401DC4D RID: 121933
		[Token(Token = "0x401DC4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardListDict;

		// Token: 0x0401DC4E RID: 121934
		[Token(Token = "0x401DC4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401DC4F RID: 121935
		[Token(Token = "0x401DC4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DC50 RID: 121936
		[Token(Token = "0x401DC50")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddProduct;

		// Token: 0x0401DC51 RID: 121937
		[Token(Token = "0x401DC51")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SortListDict;

		// Token: 0x0401DC52 RID: 121938
		[Token(Token = "0x401DC52")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
