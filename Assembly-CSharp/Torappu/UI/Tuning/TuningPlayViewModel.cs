using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CCD RID: 15565
	[Token(Token = "0x2003CCD")]
	public class TuningPlayViewModel : IHotfixable
	{
		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x06018448 RID: 99400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039DB")]
		public ListDict<string, TuningOrcheModel> orcheModelListDict
		{
			[Token(Token = "0x6018448")]
			[Address(RVA = "0x10C7A00", Offset = "0x10C6600", VA = "0x1810C7A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x06018449 RID: 99401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039DC")]
		public string selectOrcheId
		{
			[Token(Token = "0x6018449")]
			[Address(RVA = "0x10C7A60", Offset = "0x10C6660", VA = "0x1810C7A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0601844A RID: 99402 RVA: 0x00099C60 File Offset: 0x00097E60
		[Token(Token = "0x170039DD")]
		public Act29SideData.Act29SideOrcheType selectOrcheType
		{
			[Token(Token = "0x601844A")]
			[Address(RVA = "0x10C7B20", Offset = "0x10C6720", VA = "0x1810C7B20")]
			get
			{
				return Act29SideData.Act29SideOrcheType.ORCHE_1;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0601844B RID: 99403 RVA: 0x00099C78 File Offset: 0x00097E78
		[Token(Token = "0x170039DE")]
		public TuningPlayViewModel.SelectOrcheStatus selectOrcheStatus
		{
			[Token(Token = "0x601844B")]
			[Address(RVA = "0x10C7AC0", Offset = "0x10C66C0", VA = "0x1810C7AC0")]
			get
			{
				return TuningPlayViewModel.SelectOrcheStatus.CAN_NOT_SELECT_ORCHE;
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0601844C RID: 99404 RVA: 0x00099C90 File Offset: 0x00097E90
		[Token(Token = "0x170039DF")]
		public bool hasNewProductType
		{
			[Token(Token = "0x601844C")]
			[Address(RVA = "0x10C79A0", Offset = "0x10C65A0", VA = "0x1810C79A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0601844D RID: 99405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039E0")]
		public string selectProductTypeId
		{
			[Token(Token = "0x601844D")]
			[Address(RVA = "0x10C7B80", Offset = "0x10C6780", VA = "0x1810C7B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0601844E RID: 99406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039E1")]
		public string selectProductTypeTintColor
		{
			[Token(Token = "0x601844E")]
			[Address(RVA = "0x10C7C40", Offset = "0x10C6840", VA = "0x1810C7C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0601844F RID: 99407 RVA: 0x00099CA8 File Offset: 0x00097EA8
		[Token(Token = "0x170039E2")]
		public Act29SideData.Act29SideProductType selectProductType
		{
			[Token(Token = "0x601844F")]
			[Address(RVA = "0x10C7CA0", Offset = "0x10C68A0", VA = "0x1810C7CA0")]
			get
			{
				return Act29SideData.Act29SideProductType.PRODUCT_TYPE_1;
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x06018450 RID: 99408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039E3")]
		public string selectProductTypeName
		{
			[Token(Token = "0x6018450")]
			[Address(RVA = "0x10C7BE0", Offset = "0x10C67E0", VA = "0x1810C7BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x06018451 RID: 99409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039E4")]
		public string formSegmentId
		{
			[Token(Token = "0x6018451")]
			[Address(RVA = "0x10C78E0", Offset = "0x10C64E0", VA = "0x1810C78E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x06018452 RID: 99410 RVA: 0x00099CC0 File Offset: 0x00097EC0
		[Token(Token = "0x170039E5")]
		public int formSegmentNum
		{
			[Token(Token = "0x6018452")]
			[Address(RVA = "0x10C7940", Offset = "0x10C6540", VA = "0x1810C7940")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x06018453 RID: 99411 RVA: 0x00099CD8 File Offset: 0x00097ED8
		[Token(Token = "0x170039E6")]
		public float formRotateSecond
		{
			[Token(Token = "0x6018453")]
			[Address(RVA = "0x10C7880", Offset = "0x10C6480", VA = "0x1810C7880")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x06018454 RID: 99412 RVA: 0x00099CF0 File Offset: 0x00097EF0
		[Token(Token = "0x170039E7")]
		public int enterSequenceNum
		{
			[Token(Token = "0x6018454")]
			[Address(RVA = "0x10C77C0", Offset = "0x10C63C0", VA = "0x1810C77C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x06018455 RID: 99413 RVA: 0x00099D08 File Offset: 0x00097F08
		[Token(Token = "0x170039E8")]
		public int eyeShowSequenceNum
		{
			[Token(Token = "0x6018455")]
			[Address(RVA = "0x10C7820", Offset = "0x10C6420", VA = "0x1810C7820")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x06018456 RID: 99414 RVA: 0x00099D20 File Offset: 0x00097F20
		[Token(Token = "0x170039E9")]
		public int cardChangeSequenceNum
		{
			[Token(Token = "0x6018456")]
			[Address(RVA = "0x10C7640", Offset = "0x10C6240", VA = "0x1810C7640")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x06018457 RID: 99415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039EA")]
		public string curMainMusicId
		{
			[Token(Token = "0x6018457")]
			[Address(RVA = "0x10C7700", Offset = "0x10C6300", VA = "0x1810C7700")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x06018458 RID: 99416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039EB")]
		public string curOrcheMusicId
		{
			[Token(Token = "0x6018458")]
			[Address(RVA = "0x10C7760", Offset = "0x10C6360", VA = "0x1810C7760")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x06018459 RID: 99417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039EC")]
		public TuningCommonCardModel cardModel
		{
			[Token(Token = "0x6018459")]
			[Address(RVA = "0x10C76A0", Offset = "0x10C62A0", VA = "0x1810C76A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601845A RID: 99418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601845A")]
		[Address(RVA = "0x10C6350", Offset = "0x10C4F50", VA = "0x1810C6350")]
		public void InitData(string actId, int iEnterSequenceNum, int iEyeShowSequenceNum)
		{
		}

		// Token: 0x0601845B RID: 99419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601845B")]
		[Address(RVA = "0x10C68E0", Offset = "0x10C54E0", VA = "0x1810C68E0")]
		public void UpdateData(string inputProductTypeId, int iEyeShowSequenceNum, int iCardChangeSequenceNum)
		{
		}

		// Token: 0x0601845C RID: 99420 RVA: 0x00099D38 File Offset: 0x00097F38
		[Token(Token = "0x601845C")]
		[Address(RVA = "0x10C6830", Offset = "0x10C5430", VA = "0x1810C6830")]
		public bool TrySelectOrche(string iSelectOrcheId)
		{
			return default(bool);
		}

		// Token: 0x0601845D RID: 99421 RVA: 0x00099D50 File Offset: 0x00097F50
		[Token(Token = "0x601845D")]
		[Address(RVA = "0x10C66A0", Offset = "0x10C52A0", VA = "0x1810C66A0")]
		public bool TryCloseOrche()
		{
			return default(bool);
		}

		// Token: 0x0601845E RID: 99422 RVA: 0x00099D68 File Offset: 0x00097F68
		[Token(Token = "0x601845E")]
		[Address(RVA = "0x10C6710", Offset = "0x10C5310", VA = "0x1810C6710")]
		public bool TryOpenOrche()
		{
			return default(bool);
		}

		// Token: 0x0601845F RID: 99423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601845F")]
		[Address(RVA = "0x10C6540", Offset = "0x10C5140", VA = "0x1810C6540")]
		public void SyncCurMusicId()
		{
		}

		// Token: 0x06018460 RID: 99424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018460")]
		[Address(RVA = "0x10C72E0", Offset = "0x10C5EE0", VA = "0x1810C72E0")]
		private void _UpdateModel()
		{
		}

		// Token: 0x06018461 RID: 99425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018461")]
		[Address(RVA = "0x10C6DB0", Offset = "0x10C59B0", VA = "0x1810C6DB0")]
		private void _LoadOrcheData()
		{
		}

		// Token: 0x06018462 RID: 99426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018462")]
		[Address(RVA = "0x10C69C0", Offset = "0x10C55C0", VA = "0x1810C69C0")]
		private void _CheckOutDefaultProductType(Dictionary<string, int> melodyNax)
		{
		}

		// Token: 0x06018463 RID: 99427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018463")]
		[Address(RVA = "0x10C7160", Offset = "0x10C5D60", VA = "0x1810C7160")]
		private void _SetProductDisplayProperty()
		{
		}

		// Token: 0x06018464 RID: 99428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018464")]
		[Address(RVA = "0x10C70B0", Offset = "0x10C5CB0", VA = "0x1810C70B0")]
		private void _SetOrcheType()
		{
		}

		// Token: 0x06018465 RID: 99429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018465")]
		[Address(RVA = "0x10C7530", Offset = "0x10C6130", VA = "0x1810C7530")]
		public TuningPlayViewModel()
		{
		}

		// Token: 0x0401D9C5 RID: 121285
		[Token(Token = "0x401D9C5")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, TuningOrcheModel> m_orcheModelListDict;

		// Token: 0x0401D9C6 RID: 121286
		[Token(Token = "0x401D9C6")]
		[FieldOffset(Offset = "0x18")]
		private string m_selectOrcheId;

		// Token: 0x0401D9C7 RID: 121287
		[Token(Token = "0x401D9C7")]
		[FieldOffset(Offset = "0x20")]
		private Act29SideData.Act29SideOrcheType m_selectOrcheType;

		// Token: 0x0401D9C8 RID: 121288
		[Token(Token = "0x401D9C8")]
		[FieldOffset(Offset = "0x24")]
		private TuningPlayViewModel.SelectOrcheStatus m_selectOrcheStatus;

		// Token: 0x0401D9C9 RID: 121289
		[Token(Token = "0x401D9C9")]
		[FieldOffset(Offset = "0x28")]
		private string m_selectProductTypeId;

		// Token: 0x0401D9CA RID: 121290
		[Token(Token = "0x401D9CA")]
		[FieldOffset(Offset = "0x30")]
		private string m_selectProductTypeTintColor;

		// Token: 0x0401D9CB RID: 121291
		[Token(Token = "0x401D9CB")]
		[FieldOffset(Offset = "0x38")]
		private Act29SideData.Act29SideProductType m_selectProductType;

		// Token: 0x0401D9CC RID: 121292
		[Token(Token = "0x401D9CC")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_hasNewProductType;

		// Token: 0x0401D9CD RID: 121293
		[Token(Token = "0x401D9CD")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectProductTypeName;

		// Token: 0x0401D9CE RID: 121294
		[Token(Token = "0x401D9CE")]
		[FieldOffset(Offset = "0x48")]
		private string m_formSegmentId;

		// Token: 0x0401D9CF RID: 121295
		[Token(Token = "0x401D9CF")]
		[FieldOffset(Offset = "0x50")]
		private int m_formSegmentNum;

		// Token: 0x0401D9D0 RID: 121296
		[Token(Token = "0x401D9D0")]
		[FieldOffset(Offset = "0x54")]
		private float m_formRotateSecond;

		// Token: 0x0401D9D1 RID: 121297
		[Token(Token = "0x401D9D1")]
		[FieldOffset(Offset = "0x58")]
		private string m_curMainMusicId;

		// Token: 0x0401D9D2 RID: 121298
		[Token(Token = "0x401D9D2")]
		[FieldOffset(Offset = "0x60")]
		private string m_curOrcheMusicId;

		// Token: 0x0401D9D3 RID: 121299
		[Token(Token = "0x401D9D3")]
		[FieldOffset(Offset = "0x68")]
		private Act29SideData m_actData;

		// Token: 0x0401D9D4 RID: 121300
		[Token(Token = "0x401D9D4")]
		[FieldOffset(Offset = "0x70")]
		private string m_actId;

		// Token: 0x0401D9D5 RID: 121301
		[Token(Token = "0x401D9D5")]
		[FieldOffset(Offset = "0x78")]
		private int m_enterSequenceNum;

		// Token: 0x0401D9D6 RID: 121302
		[Token(Token = "0x401D9D6")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cardChangeSequenceNum;

		// Token: 0x0401D9D7 RID: 121303
		[Token(Token = "0x401D9D7")]
		[FieldOffset(Offset = "0x80")]
		private int m_eyeShowSequenceNum;

		// Token: 0x0401D9D8 RID: 121304
		[Token(Token = "0x401D9D8")]
		[FieldOffset(Offset = "0x88")]
		private TuningCommonCardModel m_cardModel;

		// Token: 0x0401D9D9 RID: 121305
		[Token(Token = "0x401D9D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_orcheModelListDict;

		// Token: 0x0401D9DA RID: 121306
		[Token(Token = "0x401D9DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectOrcheId;

		// Token: 0x0401D9DB RID: 121307
		[Token(Token = "0x401D9DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectOrcheType;

		// Token: 0x0401D9DC RID: 121308
		[Token(Token = "0x401D9DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectOrcheStatus;

		// Token: 0x0401D9DD RID: 121309
		[Token(Token = "0x401D9DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hasNewProductType;

		// Token: 0x0401D9DE RID: 121310
		[Token(Token = "0x401D9DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectProductTypeId;

		// Token: 0x0401D9DF RID: 121311
		[Token(Token = "0x401D9DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectProductTypeTintColor;

		// Token: 0x0401D9E0 RID: 121312
		[Token(Token = "0x401D9E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectProductType;

		// Token: 0x0401D9E1 RID: 121313
		[Token(Token = "0x401D9E1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectProductTypeName;

		// Token: 0x0401D9E2 RID: 121314
		[Token(Token = "0x401D9E2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_formSegmentId;

		// Token: 0x0401D9E3 RID: 121315
		[Token(Token = "0x401D9E3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_formSegmentNum;

		// Token: 0x0401D9E4 RID: 121316
		[Token(Token = "0x401D9E4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_formRotateSecond;

		// Token: 0x0401D9E5 RID: 121317
		[Token(Token = "0x401D9E5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_enterSequenceNum;

		// Token: 0x0401D9E6 RID: 121318
		[Token(Token = "0x401D9E6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_eyeShowSequenceNum;

		// Token: 0x0401D9E7 RID: 121319
		[Token(Token = "0x401D9E7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_cardChangeSequenceNum;

		// Token: 0x0401D9E8 RID: 121320
		[Token(Token = "0x401D9E8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_curMainMusicId;

		// Token: 0x0401D9E9 RID: 121321
		[Token(Token = "0x401D9E9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_curOrcheMusicId;

		// Token: 0x0401D9EA RID: 121322
		[Token(Token = "0x401D9EA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_cardModel;

		// Token: 0x0401D9EB RID: 121323
		[Token(Token = "0x401D9EB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401D9EC RID: 121324
		[Token(Token = "0x401D9EC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401D9ED RID: 121325
		[Token(Token = "0x401D9ED")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TrySelectOrche;

		// Token: 0x0401D9EE RID: 121326
		[Token(Token = "0x401D9EE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryCloseOrche;

		// Token: 0x0401D9EF RID: 121327
		[Token(Token = "0x401D9EF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryOpenOrche;

		// Token: 0x0401D9F0 RID: 121328
		[Token(Token = "0x401D9F0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SyncCurMusicId;

		// Token: 0x0401D9F1 RID: 121329
		[Token(Token = "0x401D9F1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateModel;

		// Token: 0x0401D9F2 RID: 121330
		[Token(Token = "0x401D9F2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__LoadOrcheData;

		// Token: 0x0401D9F3 RID: 121331
		[Token(Token = "0x401D9F3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckOutDefaultProductType;

		// Token: 0x0401D9F4 RID: 121332
		[Token(Token = "0x401D9F4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SetProductDisplayProperty;

		// Token: 0x0401D9F5 RID: 121333
		[Token(Token = "0x401D9F5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SetOrcheType;

		// Token: 0x0401D9F6 RID: 121334
		[Token(Token = "0x401D9F6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CCE RID: 15566
		[Token(Token = "0x2003CCE")]
		public enum SelectOrcheStatus
		{
			// Token: 0x0401D9F8 RID: 121336
			[Token(Token = "0x401D9F8")]
			CAN_NOT_SELECT_ORCHE,
			// Token: 0x0401D9F9 RID: 121337
			[Token(Token = "0x401D9F9")]
			CAN_SELECT_ORCHE,
			// Token: 0x0401D9FA RID: 121338
			[Token(Token = "0x401D9FA")]
			IS_HIDDEN_ORCHE,
			// Token: 0x0401D9FB RID: 121339
			[Token(Token = "0x401D9FB")]
			ENUM
		}
	}
}
