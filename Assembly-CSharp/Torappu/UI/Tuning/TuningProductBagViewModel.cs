using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CFA RID: 15610
	[Token(Token = "0x2003CFA")]
	public class TuningProductBagViewModel : IHotfixable
	{
		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0601856F RID: 99695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A1B")]
		public ListDict<string, TuningProductBagProductGroupModel> productGroupListDict
		{
			[Token(Token = "0x601856F")]
			[Address(RVA = "0x10DEF60", Offset = "0x10DDB60", VA = "0x1810DEF60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x06018570 RID: 99696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A1C")]
		public string selectProductType
		{
			[Token(Token = "0x6018570")]
			[Address(RVA = "0x10DF020", Offset = "0x10DDC20", VA = "0x1810DF020")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x06018571 RID: 99697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A1D")]
		public TuningProductBagProductGroupModel selectGroupModel
		{
			[Token(Token = "0x6018571")]
			[Address(RVA = "0x10DEFC0", Offset = "0x10DDBC0", VA = "0x1810DEFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x06018572 RID: 99698 RVA: 0x0009A0C8 File Offset: 0x000982C8
		[Token(Token = "0x17003A1E")]
		public bool isSelectGroupEmpty
		{
			[Token(Token = "0x6018572")]
			[Address(RVA = "0x10DEF00", Offset = "0x10DDB00", VA = "0x1810DEF00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x06018573 RID: 99699 RVA: 0x0009A0E0 File Offset: 0x000982E0
		[Token(Token = "0x17003A1F")]
		public bool isChatState
		{
			[Token(Token = "0x6018573")]
			[Address(RVA = "0x10DEE40", Offset = "0x10DDA40", VA = "0x1810DEE40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x06018574 RID: 99700 RVA: 0x0009A0F8 File Offset: 0x000982F8
		[Token(Token = "0x17003A20")]
		public bool isPanelShow
		{
			[Token(Token = "0x6018574")]
			[Address(RVA = "0x10DEEA0", Offset = "0x10DDAA0", VA = "0x1810DEEA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x06018575 RID: 99701 RVA: 0x0009A110 File Offset: 0x00098310
		[Token(Token = "0x17003A21")]
		public bool hasAnswer
		{
			[Token(Token = "0x6018575")]
			[Address(RVA = "0x10DED80", Offset = "0x10DD980", VA = "0x1810DED80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x06018576 RID: 99702 RVA: 0x0009A128 File Offset: 0x00098328
		[Token(Token = "0x17003A22")]
		public bool hasSetAnswer
		{
			[Token(Token = "0x6018576")]
			[Address(RVA = "0x10DEDE0", Offset = "0x10DD9E0", VA = "0x1810DEDE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x06018577 RID: 99703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A23")]
		public string themeColor
		{
			[Token(Token = "0x6018577")]
			[Address(RVA = "0x10DF080", Offset = "0x10DDC80", VA = "0x1810DF080")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018578 RID: 99704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018578")]
		[Address(RVA = "0x10DCFE0", Offset = "0x10DBBE0", VA = "0x1810DCFE0")]
		public void InitData(string actId, bool iIsChatState)
		{
		}

		// Token: 0x06018579 RID: 99705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018579")]
		[Address(RVA = "0x10DD550", Offset = "0x10DC150", VA = "0x1810DD550")]
		public void UpdateData()
		{
		}

		// Token: 0x0601857A RID: 99706 RVA: 0x0009A140 File Offset: 0x00098340
		[Token(Token = "0x601857A")]
		[Address(RVA = "0x10DD3B0", Offset = "0x10DBFB0", VA = "0x1810DD3B0")]
		public bool TrySelectProductGroup(string productTypeId)
		{
			return default(bool);
		}

		// Token: 0x0601857B RID: 99707 RVA: 0x0009A158 File Offset: 0x00098358
		[Token(Token = "0x601857B")]
		[Address(RVA = "0x10DD2E0", Offset = "0x10DBEE0", VA = "0x1810DD2E0")]
		public bool TrySelectCard(string productId)
		{
			return default(bool);
		}

		// Token: 0x0601857C RID: 99708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601857C")]
		[Address(RVA = "0x10DD120", Offset = "0x10DBD20", VA = "0x1810DD120")]
		public void SetAnswer(TuningProductBagViewModel.AnswerParam answerParam)
		{
		}

		// Token: 0x0601857D RID: 99709 RVA: 0x0009A170 File Offset: 0x00098370
		[Token(Token = "0x601857D")]
		[Address(RVA = "0x10DD4D0", Offset = "0x10DC0D0", VA = "0x1810DD4D0")]
		public bool TrySetShow(bool isShow)
		{
			return default(bool);
		}

		// Token: 0x0601857E RID: 99710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601857E")]
		[Address(RVA = "0x10DCF80", Offset = "0x10DBB80", VA = "0x1810DCF80")]
		public TuningProductBagCardModel GetSelectCardModel()
		{
			return null;
		}

		// Token: 0x0601857F RID: 99711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601857F")]
		[Address(RVA = "0x10DDF40", Offset = "0x10DCB40", VA = "0x1810DDF40")]
		private void _InitProductGroupDict()
		{
		}

		// Token: 0x06018580 RID: 99712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018580")]
		[Address(RVA = "0x10DE930", Offset = "0x10DD530", VA = "0x1810DE930")]
		private void _UpdateProductGroupDict(PlayerActivity.PlayerAct29SideActivity playerActData)
		{
		}

		// Token: 0x06018581 RID: 99713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018581")]
		[Address(RVA = "0x10DD740", Offset = "0x10DC340", VA = "0x1810DD740")]
		private void _CheckProductGroupDictLock(PlayerActivity.PlayerAct29SideActivity playerActData)
		{
		}

		// Token: 0x06018582 RID: 99714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018582")]
		[Address(RVA = "0x10DE6B0", Offset = "0x10DD2B0", VA = "0x1810DE6B0")]
		private void _SetDefaultProductType()
		{
		}

		// Token: 0x06018583 RID: 99715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018583")]
		[Address(RVA = "0x10DDD80", Offset = "0x10DC980", VA = "0x1810DDD80")]
		private TuningProductBagCardModel _GetCardModelByProductId(string productId)
		{
			return null;
		}

		// Token: 0x06018584 RID: 99716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018584")]
		[Address(RVA = "0x10DE830", Offset = "0x10DD430", VA = "0x1810DE830")]
		private void _SetProductIsSelect(string productId, bool isSelect)
		{
		}

		// Token: 0x06018585 RID: 99717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018585")]
		[Address(RVA = "0x10DDA40", Offset = "0x10DC640", VA = "0x1810DDA40")]
		private void _CheckSelectProductTypeEmpty()
		{
		}

		// Token: 0x06018586 RID: 99718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018586")]
		[Address(RVA = "0x10DDBE0", Offset = "0x10DC7E0", VA = "0x1810DDBE0")]
		private void _ClearProductGroupData()
		{
		}

		// Token: 0x06018587 RID: 99719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018587")]
		[Address(RVA = "0x10DE290", Offset = "0x10DCE90", VA = "0x1810DE290")]
		private void _SetAnswerByProductId(TuningProductBagViewModel.AnswerParam answerParam)
		{
		}

		// Token: 0x06018588 RID: 99720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018588")]
		[Address(RVA = "0x10DE3C0", Offset = "0x10DCFC0", VA = "0x1810DE3C0")]
		private void _SetAnswerByProductTypeAndOrche(TuningProductBagViewModel.AnswerParam answerParam)
		{
		}

		// Token: 0x06018589 RID: 99721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018589")]
		[Address(RVA = "0x10DECC0", Offset = "0x10DD8C0", VA = "0x1810DECC0")]
		public TuningProductBagViewModel()
		{
		}

		// Token: 0x0401DBFB RID: 121851
		[Token(Token = "0x401DBFB")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, TuningProductBagProductGroupModel> m_productGroupListDict;

		// Token: 0x0401DBFC RID: 121852
		[Token(Token = "0x401DBFC")]
		[FieldOffset(Offset = "0x18")]
		private string m_selectProductType;

		// Token: 0x0401DBFD RID: 121853
		[Token(Token = "0x401DBFD")]
		[FieldOffset(Offset = "0x20")]
		private TuningProductBagProductGroupModel m_selectGroupModel;

		// Token: 0x0401DBFE RID: 121854
		[Token(Token = "0x401DBFE")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isSelectGroupEmpty;

		// Token: 0x0401DBFF RID: 121855
		[Token(Token = "0x401DBFF")]
		[FieldOffset(Offset = "0x30")]
		private string m_selectProductId;

		// Token: 0x0401DC00 RID: 121856
		[Token(Token = "0x401DC00")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isChatState;

		// Token: 0x0401DC01 RID: 121857
		[Token(Token = "0x401DC01")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isPanelShow;

		// Token: 0x0401DC02 RID: 121858
		[Token(Token = "0x401DC02")]
		[FieldOffset(Offset = "0x3A")]
		private bool m_hasAnswer;

		// Token: 0x0401DC03 RID: 121859
		[Token(Token = "0x401DC03")]
		[FieldOffset(Offset = "0x3B")]
		private bool m_hasSetAnswer;

		// Token: 0x0401DC04 RID: 121860
		[Token(Token = "0x401DC04")]
		[FieldOffset(Offset = "0x40")]
		private string m_themeColor;

		// Token: 0x0401DC05 RID: 121861
		[Token(Token = "0x401DC05")]
		[FieldOffset(Offset = "0x48")]
		private string m_actId;

		// Token: 0x0401DC06 RID: 121862
		[Token(Token = "0x401DC06")]
		[FieldOffset(Offset = "0x50")]
		private Act29SideData m_actData;

		// Token: 0x0401DC07 RID: 121863
		[Token(Token = "0x401DC07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_productGroupListDict;

		// Token: 0x0401DC08 RID: 121864
		[Token(Token = "0x401DC08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectProductType;

		// Token: 0x0401DC09 RID: 121865
		[Token(Token = "0x401DC09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectGroupModel;

		// Token: 0x0401DC0A RID: 121866
		[Token(Token = "0x401DC0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isSelectGroupEmpty;

		// Token: 0x0401DC0B RID: 121867
		[Token(Token = "0x401DC0B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isChatState;

		// Token: 0x0401DC0C RID: 121868
		[Token(Token = "0x401DC0C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isPanelShow;

		// Token: 0x0401DC0D RID: 121869
		[Token(Token = "0x401DC0D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasAnswer;

		// Token: 0x0401DC0E RID: 121870
		[Token(Token = "0x401DC0E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hasSetAnswer;

		// Token: 0x0401DC0F RID: 121871
		[Token(Token = "0x401DC0F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x0401DC10 RID: 121872
		[Token(Token = "0x401DC10")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DC11 RID: 121873
		[Token(Token = "0x401DC11")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401DC12 RID: 121874
		[Token(Token = "0x401DC12")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TrySelectProductGroup;

		// Token: 0x0401DC13 RID: 121875
		[Token(Token = "0x401DC13")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TrySelectCard;

		// Token: 0x0401DC14 RID: 121876
		[Token(Token = "0x401DC14")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetAnswer;

		// Token: 0x0401DC15 RID: 121877
		[Token(Token = "0x401DC15")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TrySetShow;

		// Token: 0x0401DC16 RID: 121878
		[Token(Token = "0x401DC16")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetSelectCardModel;

		// Token: 0x0401DC17 RID: 121879
		[Token(Token = "0x401DC17")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitProductGroupDict;

		// Token: 0x0401DC18 RID: 121880
		[Token(Token = "0x401DC18")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateProductGroupDict;

		// Token: 0x0401DC19 RID: 121881
		[Token(Token = "0x401DC19")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckProductGroupDictLock;

		// Token: 0x0401DC1A RID: 121882
		[Token(Token = "0x401DC1A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetDefaultProductType;

		// Token: 0x0401DC1B RID: 121883
		[Token(Token = "0x401DC1B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetCardModelByProductId;

		// Token: 0x0401DC1C RID: 121884
		[Token(Token = "0x401DC1C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SetProductIsSelect;

		// Token: 0x0401DC1D RID: 121885
		[Token(Token = "0x401DC1D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckSelectProductTypeEmpty;

		// Token: 0x0401DC1E RID: 121886
		[Token(Token = "0x401DC1E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearProductGroupData;

		// Token: 0x0401DC1F RID: 121887
		[Token(Token = "0x401DC1F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__SetAnswerByProductId;

		// Token: 0x0401DC20 RID: 121888
		[Token(Token = "0x401DC20")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SetAnswerByProductTypeAndOrche;

		// Token: 0x0401DC21 RID: 121889
		[Token(Token = "0x401DC21")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CFB RID: 15611
		[Token(Token = "0x2003CFB")]
		public struct AnswerParam
		{
			// Token: 0x0401DC22 RID: 121890
			[Token(Token = "0x401DC22")]
			[FieldOffset(Offset = "0x0")]
			public string productTypeId;

			// Token: 0x0401DC23 RID: 121891
			[Token(Token = "0x401DC23")]
			[FieldOffset(Offset = "0x8")]
			public string orcheId;

			// Token: 0x0401DC24 RID: 121892
			[Token(Token = "0x401DC24")]
			[FieldOffset(Offset = "0x10")]
			public string productId;
		}
	}
}
