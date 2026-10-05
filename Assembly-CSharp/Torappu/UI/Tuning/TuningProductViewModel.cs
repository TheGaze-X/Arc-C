using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CE7 RID: 15591
	[Token(Token = "0x2003CE7")]
	public class TuningProductViewModel : IHotfixable
	{
		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x060184F0 RID: 99568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F2")]
		public ListDict<string, TuningFragModel> fragModelListDict
		{
			[Token(Token = "0x60184F0")]
			[Address(RVA = "0x10E5F30", Offset = "0x10E4B30", VA = "0x1810E5F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x060184F1 RID: 99569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F3")]
		public ListDict<string, TuningOrcheModel> orcheModelListDict
		{
			[Token(Token = "0x60184F1")]
			[Address(RVA = "0x10E60B0", Offset = "0x10E4CB0", VA = "0x1810E60B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x060184F2 RID: 99570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F4")]
		public List<string> selectFragList
		{
			[Token(Token = "0x60184F2")]
			[Address(RVA = "0x10E6290", Offset = "0x10E4E90", VA = "0x1810E6290")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x060184F3 RID: 99571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F5")]
		public string selectOrcheId
		{
			[Token(Token = "0x60184F3")]
			[Address(RVA = "0x10E62F0", Offset = "0x10E4EF0", VA = "0x1810E62F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x060184F4 RID: 99572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F6")]
		public string selectOrcheName
		{
			[Token(Token = "0x60184F4")]
			[Address(RVA = "0x10E6350", Offset = "0x10E4F50", VA = "0x1810E6350")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x060184F5 RID: 99573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F7")]
		public string selectProductTypeId
		{
			[Token(Token = "0x60184F5")]
			[Address(RVA = "0x10E6470", Offset = "0x10E5070", VA = "0x1810E6470")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x060184F6 RID: 99574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F8")]
		public string selectProductTypeName
		{
			[Token(Token = "0x60184F6")]
			[Address(RVA = "0x10E64D0", Offset = "0x10E50D0", VA = "0x1810E64D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x060184F7 RID: 99575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039F9")]
		public string selectProductTypeDescColor
		{
			[Token(Token = "0x60184F7")]
			[Address(RVA = "0x10E6410", Offset = "0x10E5010", VA = "0x1810E6410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x060184F8 RID: 99576 RVA: 0x00099DC8 File Offset: 0x00097FC8
		[Token(Token = "0x170039FA")]
		public Act29SideData.Act29SideProductType selectProductType
		{
			[Token(Token = "0x60184F8")]
			[Address(RVA = "0x10E6530", Offset = "0x10E5130", VA = "0x1810E6530")]
			get
			{
				return Act29SideData.Act29SideProductType.PRODUCT_TYPE_1;
			}
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x060184F9 RID: 99577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039FB")]
		public string selectFormDesc
		{
			[Token(Token = "0x60184F9")]
			[Address(RVA = "0x10E61D0", Offset = "0x10E4DD0", VA = "0x1810E61D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x060184FA RID: 99578 RVA: 0x00099DE0 File Offset: 0x00097FE0
		[Token(Token = "0x170039FC")]
		public bool selectFormHasBeenMade
		{
			[Token(Token = "0x60184FA")]
			[Address(RVA = "0x10E6230", Offset = "0x10E4E30", VA = "0x1810E6230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x060184FB RID: 99579 RVA: 0x00099DF8 File Offset: 0x00097FF8
		[Token(Token = "0x170039FD")]
		public TuningProductViewModel.ProductStatus productStatus
		{
			[Token(Token = "0x60184FB")]
			[Address(RVA = "0x10E6170", Offset = "0x10E4D70", VA = "0x1810E6170")]
			get
			{
				return TuningProductViewModel.ProductStatus.SELECT_FRAG;
			}
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x060184FC RID: 99580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039FE")]
		public string formSegmentId
		{
			[Token(Token = "0x60184FC")]
			[Address(RVA = "0x10E5E10", Offset = "0x10E4A10", VA = "0x1810E5E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x060184FD RID: 99581 RVA: 0x00099E10 File Offset: 0x00098010
		[Token(Token = "0x170039FF")]
		public int formSegmentNum
		{
			[Token(Token = "0x60184FD")]
			[Address(RVA = "0x10E5E70", Offset = "0x10E4A70", VA = "0x1810E5E70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x060184FE RID: 99582 RVA: 0x00099E28 File Offset: 0x00098028
		[Token(Token = "0x17003A00")]
		public float formSegmentRotateSecond
		{
			[Token(Token = "0x60184FE")]
			[Address(RVA = "0x10E5ED0", Offset = "0x10E4AD0", VA = "0x1810E5ED0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x060184FF RID: 99583 RVA: 0x00099E40 File Offset: 0x00098040
		[Token(Token = "0x17003A01")]
		public bool haveNewForm
		{
			[Token(Token = "0x60184FF")]
			[Address(RVA = "0x10E5FF0", Offset = "0x10E4BF0", VA = "0x1810E5FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x06018500 RID: 99584 RVA: 0x00099E58 File Offset: 0x00098058
		[Token(Token = "0x17003A02")]
		public bool haveFormUnlock
		{
			[Token(Token = "0x6018500")]
			[Address(RVA = "0x10E5F90", Offset = "0x10E4B90", VA = "0x1810E5F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x06018501 RID: 99585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A03")]
		public string curMainMusicId
		{
			[Token(Token = "0x6018501")]
			[Address(RVA = "0x10E5CF0", Offset = "0x10E48F0", VA = "0x1810E5CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x06018502 RID: 99586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A04")]
		public string curOrcheMusicId
		{
			[Token(Token = "0x6018502")]
			[Address(RVA = "0x10E5D50", Offset = "0x10E4950", VA = "0x1810E5D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x06018503 RID: 99587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A05")]
		public string orcheIconId
		{
			[Token(Token = "0x6018503")]
			[Address(RVA = "0x10E6050", Offset = "0x10E4C50", VA = "0x1810E6050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x06018504 RID: 99588 RVA: 0x00099E70 File Offset: 0x00098070
		[Token(Token = "0x17003A06")]
		public Act29SideData.Act29SideOrcheType selectOrcheType
		{
			[Token(Token = "0x6018504")]
			[Address(RVA = "0x10E63B0", Offset = "0x10E4FB0", VA = "0x1810E63B0")]
			get
			{
				return Act29SideData.Act29SideOrcheType.ORCHE_1;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x06018505 RID: 99589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A07")]
		public string productEyeIconId
		{
			[Token(Token = "0x6018505")]
			[Address(RVA = "0x10E6110", Offset = "0x10E4D10", VA = "0x1810E6110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x06018506 RID: 99590 RVA: 0x00099E88 File Offset: 0x00098088
		[Token(Token = "0x17003A08")]
		public int enterSequenceNum
		{
			[Token(Token = "0x6018506")]
			[Address(RVA = "0x10E5DB0", Offset = "0x10E49B0", VA = "0x1810E5DB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06018507 RID: 99591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018507")]
		[Address(RVA = "0x10E3CB0", Offset = "0x10E28B0", VA = "0x1810E3CB0")]
		public void InitData(string actId, int enterSequenceNum)
		{
		}

		// Token: 0x06018508 RID: 99592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018508")]
		[Address(RVA = "0x10E4810", Offset = "0x10E3410", VA = "0x1810E4810")]
		public void UpdateData()
		{
		}

		// Token: 0x06018509 RID: 99593 RVA: 0x00099EA0 File Offset: 0x000980A0
		[Token(Token = "0x6018509")]
		[Address(RVA = "0x10E4010", Offset = "0x10E2C10", VA = "0x1810E4010")]
		public bool TrySelectFrag(string selectFragId)
		{
			return default(bool);
		}

		// Token: 0x0601850A RID: 99594 RVA: 0x00099EB8 File Offset: 0x000980B8
		[Token(Token = "0x601850A")]
		[Address(RVA = "0x10E4410", Offset = "0x10E3010", VA = "0x1810E4410")]
		public bool TrySelectOrche(string iSelectOrcheId)
		{
			return default(bool);
		}

		// Token: 0x0601850B RID: 99595 RVA: 0x00099ED0 File Offset: 0x000980D0
		[Token(Token = "0x601850B")]
		[Address(RVA = "0x10E45D0", Offset = "0x10E31D0", VA = "0x1810E45D0")]
		public bool TryTransToSelectOrche()
		{
			return default(bool);
		}

		// Token: 0x0601850C RID: 99596 RVA: 0x00099EE8 File Offset: 0x000980E8
		[Token(Token = "0x601850C")]
		[Address(RVA = "0x10E4560", Offset = "0x10E3160", VA = "0x1810E4560")]
		public bool TryTransToSelectFrag()
		{
			return default(bool);
		}

		// Token: 0x0601850D RID: 99597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601850D")]
		[Address(RVA = "0x10E3970", Offset = "0x10E2570", VA = "0x1810E3970")]
		public void ClearSelectFrag()
		{
		}

		// Token: 0x0601850E RID: 99598 RVA: 0x00099F00 File Offset: 0x00098100
		[Token(Token = "0x601850E")]
		[Address(RVA = "0x10E38F0", Offset = "0x10E24F0", VA = "0x1810E38F0")]
		public bool CheckHasSelectedEnoughFrag()
		{
			return default(bool);
		}

		// Token: 0x0601850F RID: 99599 RVA: 0x00099F18 File Offset: 0x00098118
		[Token(Token = "0x601850F")]
		[Address(RVA = "0x10E37F0", Offset = "0x10E23F0", VA = "0x1810E37F0")]
		public bool CheckHasEnoughFragToProduct()
		{
			return default(bool);
		}

		// Token: 0x06018510 RID: 99600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018510")]
		[Address(RVA = "0x10E3E90", Offset = "0x10E2A90", VA = "0x1810E3E90")]
		public void SyncCurMusicId()
		{
		}

		// Token: 0x06018511 RID: 99601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018511")]
		[Address(RVA = "0x10E3AD0", Offset = "0x10E26D0", VA = "0x1810E3AD0")]
		public string GetFragFormIconId(string fragId)
		{
			return null;
		}

		// Token: 0x06018512 RID: 99602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018512")]
		[Address(RVA = "0x10E3BC0", Offset = "0x10E27C0", VA = "0x1810E3BC0")]
		public string GetFragSmallIconId(string fragId)
		{
			return null;
		}

		// Token: 0x06018513 RID: 99603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018513")]
		[Address(RVA = "0x10E50E0", Offset = "0x10E3CE0", VA = "0x1810E50E0")]
		private void _LoadOrcheData()
		{
		}

		// Token: 0x06018514 RID: 99604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018514")]
		[Address(RVA = "0x10E4DE0", Offset = "0x10E39E0", VA = "0x1810E4DE0")]
		private void _LoadFragData()
		{
		}

		// Token: 0x06018515 RID: 99605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018515")]
		[Address(RVA = "0x10E59E0", Offset = "0x10E45E0", VA = "0x1810E59E0")]
		private void _UpdateFragNum(PlayerActivity.PlayerAct29SideActivity playerData)
		{
		}

		// Token: 0x06018516 RID: 99606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018516")]
		[Address(RVA = "0x10E5730", Offset = "0x10E4330", VA = "0x1810E5730")]
		private void _SetRightForm()
		{
		}

		// Token: 0x06018517 RID: 99607 RVA: 0x00099F30 File Offset: 0x00098130
		[Token(Token = "0x6018517")]
		[Address(RVA = "0x10E4CB0", Offset = "0x10E38B0", VA = "0x1810E4CB0")]
		private bool _CheckIfFragListEqual(List<string> fragIdList)
		{
			return default(bool);
		}

		// Token: 0x06018518 RID: 99608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018518")]
		[Address(RVA = "0x10E58B0", Offset = "0x10E44B0", VA = "0x1810E58B0")]
		private void _SortSelectFragListUsedCheckProduct()
		{
		}

		// Token: 0x06018519 RID: 99609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018519")]
		[Address(RVA = "0x10E53E0", Offset = "0x10E3FE0", VA = "0x1810E53E0")]
		private void _SetFormProperty(Act29SideData.Act29SideFormData formData)
		{
		}

		// Token: 0x0601851A RID: 99610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601851A")]
		[Address(RVA = "0x10E5B50", Offset = "0x10E4750", VA = "0x1810E5B50")]
		public TuningProductViewModel()
		{
		}

		// Token: 0x0401DB16 RID: 121622
		[Token(Token = "0x401DB16")]
		private const int PRODUCT_NEED_FRAG_NUM = 3;

		// Token: 0x0401DB17 RID: 121623
		[Token(Token = "0x401DB17")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, TuningFragModel> m_fragModelListDict;

		// Token: 0x0401DB18 RID: 121624
		[Token(Token = "0x401DB18")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, TuningOrcheModel> m_orcheModelListDict;

		// Token: 0x0401DB19 RID: 121625
		[Token(Token = "0x401DB19")]
		[FieldOffset(Offset = "0x20")]
		private List<string> m_selectFragList;

		// Token: 0x0401DB1A RID: 121626
		[Token(Token = "0x401DB1A")]
		[FieldOffset(Offset = "0x28")]
		private string m_selectOrcheId;

		// Token: 0x0401DB1B RID: 121627
		[Token(Token = "0x401DB1B")]
		[FieldOffset(Offset = "0x30")]
		private string m_selectOrcheName;

		// Token: 0x0401DB1C RID: 121628
		[Token(Token = "0x401DB1C")]
		[FieldOffset(Offset = "0x38")]
		private string m_orcheIconId;

		// Token: 0x0401DB1D RID: 121629
		[Token(Token = "0x401DB1D")]
		[FieldOffset(Offset = "0x40")]
		private Act29SideData.Act29SideOrcheType m_selectOrcheType;

		// Token: 0x0401DB1E RID: 121630
		[Token(Token = "0x401DB1E")]
		[FieldOffset(Offset = "0x44")]
		private Act29SideData.Act29SideProductType m_selectProductType;

		// Token: 0x0401DB1F RID: 121631
		[Token(Token = "0x401DB1F")]
		[FieldOffset(Offset = "0x48")]
		private string m_selectProductTypeId;

		// Token: 0x0401DB20 RID: 121632
		[Token(Token = "0x401DB20")]
		[FieldOffset(Offset = "0x50")]
		private string m_selectProductTypeName;

		// Token: 0x0401DB21 RID: 121633
		[Token(Token = "0x401DB21")]
		[FieldOffset(Offset = "0x58")]
		private string m_selectProductTypeDescColor;

		// Token: 0x0401DB22 RID: 121634
		[Token(Token = "0x401DB22")]
		[FieldOffset(Offset = "0x60")]
		private string m_productEyeIconId;

		// Token: 0x0401DB23 RID: 121635
		[Token(Token = "0x401DB23")]
		[FieldOffset(Offset = "0x68")]
		private string m_selectFormDesc;

		// Token: 0x0401DB24 RID: 121636
		[Token(Token = "0x401DB24")]
		[FieldOffset(Offset = "0x70")]
		private string m_selectFormId;

		// Token: 0x0401DB25 RID: 121637
		[Token(Token = "0x401DB25")]
		[FieldOffset(Offset = "0x78")]
		private bool m_selectFormHasBeenMade;

		// Token: 0x0401DB26 RID: 121638
		[Token(Token = "0x401DB26")]
		[FieldOffset(Offset = "0x80")]
		private Act29SideData m_actData;

		// Token: 0x0401DB27 RID: 121639
		[Token(Token = "0x401DB27")]
		[FieldOffset(Offset = "0x88")]
		private TuningProductViewModel.ProductStatus m_productStatus;

		// Token: 0x0401DB28 RID: 121640
		[Token(Token = "0x401DB28")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_haveNewForm;

		// Token: 0x0401DB29 RID: 121641
		[Token(Token = "0x401DB29")]
		[FieldOffset(Offset = "0x8D")]
		private bool m_haveFormUnlock;

		// Token: 0x0401DB2A RID: 121642
		[Token(Token = "0x401DB2A")]
		[FieldOffset(Offset = "0x90")]
		private int m_enterSequenceNum;

		// Token: 0x0401DB2B RID: 121643
		[Token(Token = "0x401DB2B")]
		[FieldOffset(Offset = "0x98")]
		private string m_formSegmentId;

		// Token: 0x0401DB2C RID: 121644
		[Token(Token = "0x401DB2C")]
		[FieldOffset(Offset = "0xA0")]
		private int m_formSegmentNum;

		// Token: 0x0401DB2D RID: 121645
		[Token(Token = "0x401DB2D")]
		[FieldOffset(Offset = "0xA4")]
		private float m_formSegmentRotateSecond;

		// Token: 0x0401DB2E RID: 121646
		[Token(Token = "0x401DB2E")]
		[FieldOffset(Offset = "0xA8")]
		private string m_curMainMusicId;

		// Token: 0x0401DB2F RID: 121647
		[Token(Token = "0x401DB2F")]
		[FieldOffset(Offset = "0xB0")]
		private string m_curOrcheMusicId;

		// Token: 0x0401DB30 RID: 121648
		[Token(Token = "0x401DB30")]
		[FieldOffset(Offset = "0xB8")]
		private string m_actId;

		// Token: 0x0401DB31 RID: 121649
		[Token(Token = "0x401DB31")]
		[FieldOffset(Offset = "0xC0")]
		private List<string> m_selectFragListUsedCheckProduct;

		// Token: 0x0401DB32 RID: 121650
		[Token(Token = "0x401DB32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fragModelListDict;

		// Token: 0x0401DB33 RID: 121651
		[Token(Token = "0x401DB33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_orcheModelListDict;

		// Token: 0x0401DB34 RID: 121652
		[Token(Token = "0x401DB34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectFragList;

		// Token: 0x0401DB35 RID: 121653
		[Token(Token = "0x401DB35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectOrcheId;

		// Token: 0x0401DB36 RID: 121654
		[Token(Token = "0x401DB36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectOrcheName;

		// Token: 0x0401DB37 RID: 121655
		[Token(Token = "0x401DB37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectProductTypeId;

		// Token: 0x0401DB38 RID: 121656
		[Token(Token = "0x401DB38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectProductTypeName;

		// Token: 0x0401DB39 RID: 121657
		[Token(Token = "0x401DB39")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectProductTypeDescColor;

		// Token: 0x0401DB3A RID: 121658
		[Token(Token = "0x401DB3A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectProductType;

		// Token: 0x0401DB3B RID: 121659
		[Token(Token = "0x401DB3B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_selectFormDesc;

		// Token: 0x0401DB3C RID: 121660
		[Token(Token = "0x401DB3C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_selectFormHasBeenMade;

		// Token: 0x0401DB3D RID: 121661
		[Token(Token = "0x401DB3D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_productStatus;

		// Token: 0x0401DB3E RID: 121662
		[Token(Token = "0x401DB3E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_formSegmentId;

		// Token: 0x0401DB3F RID: 121663
		[Token(Token = "0x401DB3F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_formSegmentNum;

		// Token: 0x0401DB40 RID: 121664
		[Token(Token = "0x401DB40")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_formSegmentRotateSecond;

		// Token: 0x0401DB41 RID: 121665
		[Token(Token = "0x401DB41")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_haveNewForm;

		// Token: 0x0401DB42 RID: 121666
		[Token(Token = "0x401DB42")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_haveFormUnlock;

		// Token: 0x0401DB43 RID: 121667
		[Token(Token = "0x401DB43")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_curMainMusicId;

		// Token: 0x0401DB44 RID: 121668
		[Token(Token = "0x401DB44")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_curOrcheMusicId;

		// Token: 0x0401DB45 RID: 121669
		[Token(Token = "0x401DB45")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_orcheIconId;

		// Token: 0x0401DB46 RID: 121670
		[Token(Token = "0x401DB46")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_selectOrcheType;

		// Token: 0x0401DB47 RID: 121671
		[Token(Token = "0x401DB47")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_productEyeIconId;

		// Token: 0x0401DB48 RID: 121672
		[Token(Token = "0x401DB48")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_enterSequenceNum;

		// Token: 0x0401DB49 RID: 121673
		[Token(Token = "0x401DB49")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DB4A RID: 121674
		[Token(Token = "0x401DB4A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401DB4B RID: 121675
		[Token(Token = "0x401DB4B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TrySelectFrag;

		// Token: 0x0401DB4C RID: 121676
		[Token(Token = "0x401DB4C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TrySelectOrche;

		// Token: 0x0401DB4D RID: 121677
		[Token(Token = "0x401DB4D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_TryTransToSelectOrche;

		// Token: 0x0401DB4E RID: 121678
		[Token(Token = "0x401DB4E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_TryTransToSelectFrag;

		// Token: 0x0401DB4F RID: 121679
		[Token(Token = "0x401DB4F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ClearSelectFrag;

		// Token: 0x0401DB50 RID: 121680
		[Token(Token = "0x401DB50")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckHasSelectedEnoughFrag;

		// Token: 0x0401DB51 RID: 121681
		[Token(Token = "0x401DB51")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckHasEnoughFragToProduct;

		// Token: 0x0401DB52 RID: 121682
		[Token(Token = "0x401DB52")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SyncCurMusicId;

		// Token: 0x0401DB53 RID: 121683
		[Token(Token = "0x401DB53")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetFragFormIconId;

		// Token: 0x0401DB54 RID: 121684
		[Token(Token = "0x401DB54")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetFragSmallIconId;

		// Token: 0x0401DB55 RID: 121685
		[Token(Token = "0x401DB55")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LoadOrcheData;

		// Token: 0x0401DB56 RID: 121686
		[Token(Token = "0x401DB56")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__LoadFragData;

		// Token: 0x0401DB57 RID: 121687
		[Token(Token = "0x401DB57")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__UpdateFragNum;

		// Token: 0x0401DB58 RID: 121688
		[Token(Token = "0x401DB58")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__SetRightForm;

		// Token: 0x0401DB59 RID: 121689
		[Token(Token = "0x401DB59")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__CheckIfFragListEqual;

		// Token: 0x0401DB5A RID: 121690
		[Token(Token = "0x401DB5A")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SortSelectFragListUsedCheckProduct;

		// Token: 0x0401DB5B RID: 121691
		[Token(Token = "0x401DB5B")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__SetFormProperty;

		// Token: 0x0401DB5C RID: 121692
		[Token(Token = "0x401DB5C")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CE8 RID: 15592
		[Token(Token = "0x2003CE8")]
		public enum ProductStatus
		{
			// Token: 0x0401DB5E RID: 121694
			[Token(Token = "0x401DB5E")]
			SELECT_FRAG,
			// Token: 0x0401DB5F RID: 121695
			[Token(Token = "0x401DB5F")]
			SELECT_ORCHE,
			// Token: 0x0401DB60 RID: 121696
			[Token(Token = "0x401DB60")]
			ENUM
		}
	}
}
