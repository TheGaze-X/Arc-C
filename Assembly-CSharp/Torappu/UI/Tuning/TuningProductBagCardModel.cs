using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D01 RID: 15617
	[Token(Token = "0x2003D01")]
	public class TuningProductBagCardModel : IHotfixable
	{
		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x060185AD RID: 99757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A32")]
		public TuningCommonCardModel cardModel
		{
			[Token(Token = "0x60185AD")]
			[Address(RVA = "0x10D9D80", Offset = "0x10D8980", VA = "0x1810D9D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x060185AE RID: 99758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A33")]
		public string productId
		{
			[Token(Token = "0x60185AE")]
			[Address(RVA = "0x10D9F60", Offset = "0x10D8B60", VA = "0x1810D9F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x060185AF RID: 99759 RVA: 0x0009A260 File Offset: 0x00098460
		[Token(Token = "0x17003A34")]
		public int productNum
		{
			[Token(Token = "0x60185AF")]
			[Address(RVA = "0x10D9FC0", Offset = "0x10D8BC0", VA = "0x1810D9FC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x060185B0 RID: 99760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A35")]
		public string productTypeId
		{
			[Token(Token = "0x60185B0")]
			[Address(RVA = "0x10DA020", Offset = "0x10D8C20", VA = "0x1810DA020")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x060185B1 RID: 99761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A36")]
		public string displayName
		{
			[Token(Token = "0x60185B1")]
			[Address(RVA = "0x10D9DE0", Offset = "0x10D89E0", VA = "0x1810D9DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x060185B2 RID: 99762 RVA: 0x0009A278 File Offset: 0x00098478
		[Token(Token = "0x17003A37")]
		public bool isSelect
		{
			[Token(Token = "0x60185B2")]
			[Address(RVA = "0x10D9F00", Offset = "0x10D8B00", VA = "0x1810D9F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x060185B3 RID: 99763 RVA: 0x0009A290 File Offset: 0x00098490
		[Token(Token = "0x17003A38")]
		public bool isAnswer
		{
			[Token(Token = "0x60185B3")]
			[Address(RVA = "0x10D9E40", Offset = "0x10D8A40", VA = "0x1810D9E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x060185B4 RID: 99764 RVA: 0x0009A2A8 File Offset: 0x000984A8
		[Token(Token = "0x17003A39")]
		public bool isCardInteractable
		{
			[Token(Token = "0x60185B4")]
			[Address(RVA = "0x10D9EA0", Offset = "0x10D8AA0", VA = "0x1810D9EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x060185B5 RID: 99765 RVA: 0x0009A2C0 File Offset: 0x000984C0
		[Token(Token = "0x17003A3A")]
		public int sortId
		{
			[Token(Token = "0x60185B5")]
			[Address(RVA = "0x10DA080", Offset = "0x10D8C80", VA = "0x1810DA080")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060185B6 RID: 99766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185B6")]
		[Address(RVA = "0x10D97F0", Offset = "0x10D83F0", VA = "0x1810D97F0")]
		public void InitData(string actId, Act29SideData actData, Act29SideData.Act29SideProductData productData, int iProductNum, bool iIsCardInteractable, bool isHidden)
		{
		}

		// Token: 0x060185B7 RID: 99767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185B7")]
		[Address(RVA = "0x10D9BE0", Offset = "0x10D87E0", VA = "0x1810D9BE0")]
		private void _LoadNormalCardData(string orcheId, Act29SideData actData)
		{
		}

		// Token: 0x060185B8 RID: 99768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185B8")]
		[Address(RVA = "0x10D9B50", Offset = "0x10D8750", VA = "0x1810D9B50")]
		private void _LoadHiddenCardData(Act29SideData actData)
		{
		}

		// Token: 0x060185B9 RID: 99769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185B9")]
		[Address(RVA = "0x10D9AE0", Offset = "0x10D86E0", VA = "0x1810D9AE0")]
		public void SetSelect(bool iIsSelect)
		{
		}

		// Token: 0x060185BA RID: 99770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185BA")]
		[Address(RVA = "0x10D9A70", Offset = "0x10D8670", VA = "0x1810D9A70")]
		public void SetAnswer(bool iIsAnswer)
		{
		}

		// Token: 0x060185BB RID: 99771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185BB")]
		[Address(RVA = "0x10D9CE0", Offset = "0x10D88E0", VA = "0x1810D9CE0")]
		public TuningProductBagCardModel()
		{
		}

		// Token: 0x0401DC55 RID: 121941
		[Token(Token = "0x401DC55")]
		[FieldOffset(Offset = "0x10")]
		private TuningCommonCardModel m_cardModel;

		// Token: 0x0401DC56 RID: 121942
		[Token(Token = "0x401DC56")]
		[FieldOffset(Offset = "0x18")]
		private int m_productNum;

		// Token: 0x0401DC57 RID: 121943
		[Token(Token = "0x401DC57")]
		[FieldOffset(Offset = "0x20")]
		private string m_productId;

		// Token: 0x0401DC58 RID: 121944
		[Token(Token = "0x401DC58")]
		[FieldOffset(Offset = "0x28")]
		private string m_productTypeId;

		// Token: 0x0401DC59 RID: 121945
		[Token(Token = "0x401DC59")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isCardInteractable;

		// Token: 0x0401DC5A RID: 121946
		[Token(Token = "0x401DC5A")]
		[FieldOffset(Offset = "0x38")]
		private string m_displayName;

		// Token: 0x0401DC5B RID: 121947
		[Token(Token = "0x401DC5B")]
		[FieldOffset(Offset = "0x40")]
		private int m_sortId;

		// Token: 0x0401DC5C RID: 121948
		[Token(Token = "0x401DC5C")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isSelect;

		// Token: 0x0401DC5D RID: 121949
		[Token(Token = "0x401DC5D")]
		[FieldOffset(Offset = "0x45")]
		private bool m_isAnswer;

		// Token: 0x0401DC5E RID: 121950
		[Token(Token = "0x401DC5E")]
		[FieldOffset(Offset = "0x46")]
		private bool m_isHidden;

		// Token: 0x0401DC5F RID: 121951
		[Token(Token = "0x401DC5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardModel;

		// Token: 0x0401DC60 RID: 121952
		[Token(Token = "0x401DC60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_productId;

		// Token: 0x0401DC61 RID: 121953
		[Token(Token = "0x401DC61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_productNum;

		// Token: 0x0401DC62 RID: 121954
		[Token(Token = "0x401DC62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_productTypeId;

		// Token: 0x0401DC63 RID: 121955
		[Token(Token = "0x401DC63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_displayName;

		// Token: 0x0401DC64 RID: 121956
		[Token(Token = "0x401DC64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isSelect;

		// Token: 0x0401DC65 RID: 121957
		[Token(Token = "0x401DC65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isAnswer;

		// Token: 0x0401DC66 RID: 121958
		[Token(Token = "0x401DC66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isCardInteractable;

		// Token: 0x0401DC67 RID: 121959
		[Token(Token = "0x401DC67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401DC68 RID: 121960
		[Token(Token = "0x401DC68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DC69 RID: 121961
		[Token(Token = "0x401DC69")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadNormalCardData;

		// Token: 0x0401DC6A RID: 121962
		[Token(Token = "0x401DC6A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadHiddenCardData;

		// Token: 0x0401DC6B RID: 121963
		[Token(Token = "0x401DC6B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x0401DC6C RID: 121964
		[Token(Token = "0x401DC6C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetAnswer;

		// Token: 0x0401DC6D RID: 121965
		[Token(Token = "0x401DC6D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
