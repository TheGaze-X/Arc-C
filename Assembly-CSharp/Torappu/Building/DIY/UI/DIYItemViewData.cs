using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001996 RID: 6550
	[Token(Token = "0x2001996")]
	public class DIYItemViewData : IHotfixable
	{
		// Token: 0x0600A442 RID: 42050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A442")]
		[Address(RVA = "0x31DF7C0", Offset = "0x31DE3C0", VA = "0x1831DF7C0", Slot = "4")]
		public virtual Sprite GetBigSprite()
		{
			return null;
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A443")]
		[Address(RVA = "0x31E0AA0", Offset = "0x31DF6A0", VA = "0x1831E0AA0", Slot = "5")]
		public virtual Sprite GetSmallSprite()
		{
			return null;
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x0003F978 File Offset: 0x0003DB78
		[Token(Token = "0x600A444")]
		[Address(RVA = "0x31E0D50", Offset = "0x31DF950", VA = "0x1831E0D50")]
		public int SetCount(int count)
		{
			return 0;
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x0003F990 File Offset: 0x0003DB90
		[Token(Token = "0x600A445")]
		[Address(RVA = "0x31E0860", Offset = "0x31DF460", VA = "0x1831E0860")]
		public int GetCount()
		{
			return 0;
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x0003F9A8 File Offset: 0x0003DBA8
		[Token(Token = "0x600A446")]
		[Address(RVA = "0x31E0FF0", Offset = "0x31DFBF0", VA = "0x1831E0FF0")]
		public int SetTotalCount(int totalCount)
		{
			return 0;
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x0003F9C0 File Offset: 0x0003DBC0
		[Token(Token = "0x600A447")]
		[Address(RVA = "0x31E0B60", Offset = "0x31DF760", VA = "0x1831E0B60")]
		public int GetTotalCount()
		{
			return 0;
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x0003F9D8 File Offset: 0x0003DBD8
		[Token(Token = "0x600A448")]
		[Address(RVA = "0x31E0E30", Offset = "0x31DFA30", VA = "0x1831E0E30")]
		public int SetInUseCount(int inUseCount)
		{
			return 0;
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x0003F9F0 File Offset: 0x0003DBF0
		[Token(Token = "0x600A449")]
		[Address(RVA = "0x31E0920", Offset = "0x31DF520", VA = "0x1831E0920")]
		public int GetInUseCount()
		{
			return 0;
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x0003FA08 File Offset: 0x0003DC08
		[Token(Token = "0x600A44A")]
		[Address(RVA = "0x31E0B00", Offset = "0x31DF700", VA = "0x1831E0B00")]
		public int GetSubTypeLimitCount()
		{
			return 0;
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x0003FA20 File Offset: 0x0003DC20
		[Token(Token = "0x600A44B")]
		[Address(RVA = "0x31E0DC0", Offset = "0x31DF9C0", VA = "0x1831E0DC0")]
		public int SetFuncTypePlacedCount(int count)
		{
			return 0;
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x0003FA38 File Offset: 0x0003DC38
		[Token(Token = "0x600A44C")]
		[Address(RVA = "0x31E08C0", Offset = "0x31DF4C0", VA = "0x1831E08C0")]
		public int GetFuncTypePlacedCount()
		{
			return 0;
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A44D")]
		[Address(RVA = "0x31E0CE0", Offset = "0x31DF8E0", VA = "0x1831E0CE0")]
		public void SetCountStatus(DIYItemViewData.CountStatus status)
		{
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x0003FA50 File Offset: 0x0003DC50
		[Token(Token = "0x600A44E")]
		[Address(RVA = "0x31E0800", Offset = "0x31DF400", VA = "0x1831E0800")]
		public DIYItemViewData.CountStatus GetCountStatus()
		{
			return (DIYItemViewData.CountStatus)0;
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x0600A44F RID: 42063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012FD")]
		public virtual IDIYItem diyItem
		{
			[Token(Token = "0x600A44F")]
			[Address(RVA = "0x31DFAD0", Offset = "0x31DE6D0", VA = "0x1831DFAD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600A450 RID: 42064 RVA: 0x0003FA68 File Offset: 0x0003DC68
		[Token(Token = "0x170012FE")]
		public virtual int enableRoomType
		{
			[Token(Token = "0x600A450")]
			[Address(RVA = "0x31DFB30", Offset = "0x31DE730", VA = "0x1831DFB30", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x0600A451 RID: 42065 RVA: 0x0003FA80 File Offset: 0x0003DC80
		[Token(Token = "0x170012FF")]
		public virtual BuildingData.FurnitureType furnitureType
		{
			[Token(Token = "0x600A451")]
			[Address(RVA = "0x31DFB90", Offset = "0x31DE790", VA = "0x1831DFB90", Slot = "8")]
			get
			{
				return BuildingData.FurnitureType.FLOOR;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x0600A452 RID: 42066 RVA: 0x0003FA98 File Offset: 0x0003DC98
		[Token(Token = "0x17001300")]
		public virtual BuildingData.FurnitureSubType subType
		{
			[Token(Token = "0x600A452")]
			[Address(RVA = "0x31DFBF0", Offset = "0x31DE7F0", VA = "0x1831DFBF0", Slot = "9")]
			get
			{
				return BuildingData.FurnitureSubType.NONE;
			}
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x0003FAB0 File Offset: 0x0003DCB0
		[Token(Token = "0x600A453")]
		[Address(RVA = "0x31E1060", Offset = "0x31DFC60", VA = "0x1831E1060", Slot = "10")]
		public virtual bool ShowCount()
		{
			return default(bool);
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x0003FAC8 File Offset: 0x0003DCC8
		[Token(Token = "0x600A454")]
		[Address(RVA = "0x31E10C0", Offset = "0x31DFCC0", VA = "0x1831E10C0", Slot = "11")]
		public virtual bool ShowCurrentCount()
		{
			return default(bool);
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x0003FAE0 File Offset: 0x0003DCE0
		[Token(Token = "0x600A455")]
		[Address(RVA = "0x31DFA70", Offset = "0x31DE670", VA = "0x1831DFA70", Slot = "12")]
		public virtual bool ShowTotalCount()
		{
			return default(bool);
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		[Token(Token = "0x600A456")]
		[Address(RVA = "0x31E1180", Offset = "0x31DFD80", VA = "0x1831E1180", Slot = "13")]
		public virtual bool ShowSubButton()
		{
			return default(bool);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A457")]
		[Address(RVA = "0x31DF950", Offset = "0x31DE550", VA = "0x1831DF950", Slot = "14")]
		public virtual void SetShowTotalCount(bool showTotalCount)
		{
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x0003FB10 File Offset: 0x0003DD10
		[Token(Token = "0x600A458")]
		[Address(RVA = "0x31E1120", Offset = "0x31DFD20", VA = "0x1831E1120", Slot = "15")]
		public virtual bool ShowRenameButton()
		{
			return default(bool);
		}

		// Token: 0x0600A459 RID: 42073 RVA: 0x0003FB28 File Offset: 0x0003DD28
		[Token(Token = "0x600A459")]
		[Address(RVA = "0x31E0BC0", Offset = "0x31DF7C0", VA = "0x1831E0BC0", Slot = "16")]
		public virtual bool IsCountLabelAtCorner()
		{
			return default(bool);
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x0003FB40 File Offset: 0x0003DD40
		[Token(Token = "0x600A45A")]
		[Address(RVA = "0x31DF9B0", Offset = "0x31DE5B0", VA = "0x1831DF9B0", Slot = "17")]
		public virtual bool ShowComfort()
		{
			return default(bool);
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x0003FB58 File Offset: 0x0003DD58
		[Token(Token = "0x600A45B")]
		[Address(RVA = "0x31DF820", Offset = "0x31DE420", VA = "0x1831DF820", Slot = "18")]
		public virtual int GetComfort()
		{
			return 0;
		}

		// Token: 0x0600A45C RID: 42076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A45C")]
		[Address(RVA = "0x31E0C80", Offset = "0x31DF880", VA = "0x1831E0C80", Slot = "19")]
		public virtual void SetComfort(int comfort)
		{
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A45D")]
		[Address(RVA = "0x31E0F90", Offset = "0x31DFB90", VA = "0x1831E0F90", Slot = "20")]
		public virtual void SetShowComfort(bool showComfort)
		{
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x0003FB70 File Offset: 0x0003DD70
		[Token(Token = "0x600A45E")]
		[Address(RVA = "0x31DF760", Offset = "0x31DE360", VA = "0x1831DF760", Slot = "21")]
		public virtual bool ButtonValid()
		{
			return default(bool);
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A45F")]
		[Address(RVA = "0x31DF880", Offset = "0x31DE480", VA = "0x1831DF880", Slot = "22")]
		public virtual string GetDisplayName()
		{
			return null;
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x0003FB88 File Offset: 0x0003DD88
		[Token(Token = "0x600A460")]
		[Address(RVA = "0x31E0A40", Offset = "0x31DF640", VA = "0x1831E0A40", Slot = "23")]
		public virtual int GetRarity()
		{
			return 0;
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A461")]
		[Address(RVA = "0x31DF8F0", Offset = "0x31DE4F0", VA = "0x1831DF8F0", Slot = "24")]
		public virtual object GetTarget()
		{
			return null;
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A462")]
		[Address(RVA = "0x31E1240", Offset = "0x31DFE40", VA = "0x1831E1240", Slot = "25")]
		public virtual void Uninitialize()
		{
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x0003FBA0 File Offset: 0x0003DDA0
		[Token(Token = "0x600A463")]
		[Address(RVA = "0x31E0C20", Offset = "0x31DF820", VA = "0x1831E0C20", Slot = "26")]
		public virtual bool Selected()
		{
			return default(bool);
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x0003FBB8 File Offset: 0x0003DDB8
		[Token(Token = "0x600A464")]
		[Address(RVA = "0x31E11E0", Offset = "0x31DFDE0", VA = "0x1831E11E0", Slot = "27")]
		public virtual bool ShowUpperInfoButton()
		{
			return default(bool);
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x0003FBD0 File Offset: 0x0003DDD0
		[Token(Token = "0x600A465")]
		[Address(RVA = "0x31DFA10", Offset = "0x31DE610", VA = "0x1831DFA10", Slot = "28")]
		public virtual bool ShowLowerInfoButton()
		{
			return default(bool);
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x0003FBE8 File Offset: 0x0003DDE8
		[Token(Token = "0x600A466")]
		[Address(RVA = "0x31E09E0", Offset = "0x31DF5E0", VA = "0x1831E09E0", Slot = "29")]
		public virtual bool GetIsNew()
		{
			return default(bool);
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A467")]
		[Address(RVA = "0x31E0F20", Offset = "0x31DFB20", VA = "0x1831E0F20", Slot = "30")]
		public virtual void SetIsNew(bool isNew)
		{
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A468")]
		[Address(RVA = "0x31E0980", Offset = "0x31DF580", VA = "0x1831E0980", Slot = "31")]
		public virtual string GetInvalidText()
		{
			return null;
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A469")]
		[Address(RVA = "0x31E0EA0", Offset = "0x31DFAA0", VA = "0x1831E0EA0", Slot = "32")]
		public virtual void SetInvalidText(string invalidText)
		{
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A46A")]
		[Address(RVA = "0x31E12A0", Offset = "0x31DFEA0", VA = "0x1831E12A0")]
		private void _OnInit()
		{
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A46B")]
		[Address(RVA = "0x31E0530", Offset = "0x31DF130", VA = "0x1831E0530")]
		public static DIYItemViewData Create(object target)
		{
			return null;
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A46C")]
		[Address(RVA = "0x31E1360", Offset = "0x31DFF60", VA = "0x1831E1360")]
		public DIYItemViewData()
		{
		}

		// Token: 0x04009B77 RID: 39799
		[Token(Token = "0x4009B77")]
		[FieldOffset(Offset = "0x10")]
		private int m_count;

		// Token: 0x04009B78 RID: 39800
		[Token(Token = "0x4009B78")]
		[FieldOffset(Offset = "0x14")]
		private int m_totalCount;

		// Token: 0x04009B79 RID: 39801
		[Token(Token = "0x4009B79")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isNew;

		// Token: 0x04009B7A RID: 39802
		[Token(Token = "0x4009B7A")]
		[FieldOffset(Offset = "0x20")]
		private string m_invalidText;

		// Token: 0x04009B7B RID: 39803
		[Token(Token = "0x4009B7B")]
		[FieldOffset(Offset = "0x28")]
		private int m_funcTypePlacedCount;

		// Token: 0x04009B7C RID: 39804
		[Token(Token = "0x4009B7C")]
		[FieldOffset(Offset = "0x2C")]
		private int m_inUseCount;

		// Token: 0x04009B7D RID: 39805
		[Token(Token = "0x4009B7D")]
		[FieldOffset(Offset = "0x30")]
		private int m_limitCount;

		// Token: 0x04009B7E RID: 39806
		[Token(Token = "0x4009B7E")]
		[FieldOffset(Offset = "0x34")]
		private DIYItemViewData.CountStatus m_countStatus;

		// Token: 0x04009B7F RID: 39807
		[Token(Token = "0x4009B7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBigSprite;

		// Token: 0x04009B80 RID: 39808
		[Token(Token = "0x4009B80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSmallSprite;

		// Token: 0x04009B81 RID: 39809
		[Token(Token = "0x4009B81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCount;

		// Token: 0x04009B82 RID: 39810
		[Token(Token = "0x4009B82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCount;

		// Token: 0x04009B83 RID: 39811
		[Token(Token = "0x4009B83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetTotalCount;

		// Token: 0x04009B84 RID: 39812
		[Token(Token = "0x4009B84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetTotalCount;

		// Token: 0x04009B85 RID: 39813
		[Token(Token = "0x4009B85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetInUseCount;

		// Token: 0x04009B86 RID: 39814
		[Token(Token = "0x4009B86")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetInUseCount;

		// Token: 0x04009B87 RID: 39815
		[Token(Token = "0x4009B87")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetSubTypeLimitCount;

		// Token: 0x04009B88 RID: 39816
		[Token(Token = "0x4009B88")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetFuncTypePlacedCount;

		// Token: 0x04009B89 RID: 39817
		[Token(Token = "0x4009B89")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetFuncTypePlacedCount;

		// Token: 0x04009B8A RID: 39818
		[Token(Token = "0x4009B8A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetCountStatus;

		// Token: 0x04009B8B RID: 39819
		[Token(Token = "0x4009B8B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCountStatus;

		// Token: 0x04009B8C RID: 39820
		[Token(Token = "0x4009B8C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_diyItem;

		// Token: 0x04009B8D RID: 39821
		[Token(Token = "0x4009B8D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_enableRoomType;

		// Token: 0x04009B8E RID: 39822
		[Token(Token = "0x4009B8E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_furnitureType;

		// Token: 0x04009B8F RID: 39823
		[Token(Token = "0x4009B8F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_subType;

		// Token: 0x04009B90 RID: 39824
		[Token(Token = "0x4009B90")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ShowCount;

		// Token: 0x04009B91 RID: 39825
		[Token(Token = "0x4009B91")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ShowCurrentCount;

		// Token: 0x04009B92 RID: 39826
		[Token(Token = "0x4009B92")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ShowTotalCount;

		// Token: 0x04009B93 RID: 39827
		[Token(Token = "0x4009B93")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ShowSubButton;

		// Token: 0x04009B94 RID: 39828
		[Token(Token = "0x4009B94")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetShowTotalCount;

		// Token: 0x04009B95 RID: 39829
		[Token(Token = "0x4009B95")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ShowRenameButton;

		// Token: 0x04009B96 RID: 39830
		[Token(Token = "0x4009B96")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IsCountLabelAtCorner;

		// Token: 0x04009B97 RID: 39831
		[Token(Token = "0x4009B97")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ShowComfort;

		// Token: 0x04009B98 RID: 39832
		[Token(Token = "0x4009B98")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetComfort;

		// Token: 0x04009B99 RID: 39833
		[Token(Token = "0x4009B99")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SetComfort;

		// Token: 0x04009B9A RID: 39834
		[Token(Token = "0x4009B9A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SetShowComfort;

		// Token: 0x04009B9B RID: 39835
		[Token(Token = "0x4009B9B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ButtonValid;

		// Token: 0x04009B9C RID: 39836
		[Token(Token = "0x4009B9C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetDisplayName;

		// Token: 0x04009B9D RID: 39837
		[Token(Token = "0x4009B9D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetRarity;

		// Token: 0x04009B9E RID: 39838
		[Token(Token = "0x4009B9E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetTarget;

		// Token: 0x04009B9F RID: 39839
		[Token(Token = "0x4009B9F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_Uninitialize;

		// Token: 0x04009BA0 RID: 39840
		[Token(Token = "0x4009BA0")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Selected;

		// Token: 0x04009BA1 RID: 39841
		[Token(Token = "0x4009BA1")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_ShowUpperInfoButton;

		// Token: 0x04009BA2 RID: 39842
		[Token(Token = "0x4009BA2")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ShowLowerInfoButton;

		// Token: 0x04009BA3 RID: 39843
		[Token(Token = "0x4009BA3")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetIsNew;

		// Token: 0x04009BA4 RID: 39844
		[Token(Token = "0x4009BA4")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_SetIsNew;

		// Token: 0x04009BA5 RID: 39845
		[Token(Token = "0x4009BA5")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GetInvalidText;

		// Token: 0x04009BA6 RID: 39846
		[Token(Token = "0x4009BA6")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_SetInvalidText;

		// Token: 0x04009BA7 RID: 39847
		[Token(Token = "0x4009BA7")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnInit;

		// Token: 0x04009BA8 RID: 39848
		[Token(Token = "0x4009BA8")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04009BA9 RID: 39849
		[Token(Token = "0x4009BA9")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001997 RID: 6551
		[Token(Token = "0x2001997")]
		public enum CountStatus
		{
			// Token: 0x04009BAB RID: 39851
			[Token(Token = "0x4009BAB")]
			AVAILABLE = 1,
			// Token: 0x04009BAC RID: 39852
			[Token(Token = "0x4009BAC")]
			ADDED,
			// Token: 0x04009BAD RID: 39853
			[Token(Token = "0x4009BAD")]
			OCCUPIED,
			// Token: 0x04009BAE RID: 39854
			[Token(Token = "0x4009BAE")]
			NO_STORAGE
		}

		// Token: 0x02001998 RID: 6552
		[Token(Token = "0x2001998")]
		private class DIYItemViewDataFurniture : DIYItemViewData
		{
			// Token: 0x0600A46D RID: 42093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A46D")]
			[Address(RVA = "0x31DFC50", Offset = "0x31DE850", VA = "0x1831DFC50")]
			public DIYItemViewDataFurniture(IFurnitureData target)
			{
			}

			// Token: 0x0600A46E RID: 42094 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A46E")]
			[Address(RVA = "0x31DF3F0", Offset = "0x31DDFF0", VA = "0x1831DF3F0", Slot = "4")]
			public override Sprite GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A46F RID: 42095 RVA: 0x0003FC00 File Offset: 0x0003DE00
			[Token(Token = "0x600A46F")]
			[Address(RVA = "0x31DF380", Offset = "0x31DDF80", VA = "0x1831DF380", Slot = "21")]
			public override bool ButtonValid()
			{
				return default(bool);
			}

			// Token: 0x0600A470 RID: 42096 RVA: 0x0003FC18 File Offset: 0x0003DE18
			[Token(Token = "0x600A470")]
			[Address(RVA = "0x31DF640", Offset = "0x31DE240", VA = "0x1831DF640", Slot = "17")]
			public override bool ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600A471 RID: 42097 RVA: 0x0003FC30 File Offset: 0x0003DE30
			[Token(Token = "0x600A471")]
			[Address(RVA = "0x31DF470", Offset = "0x31DE070", VA = "0x1831DF470", Slot = "18")]
			public override int GetComfort()
			{
				return 0;
			}

			// Token: 0x0600A472 RID: 42098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A472")]
			[Address(RVA = "0x31DF4F0", Offset = "0x31DE0F0", VA = "0x1831DF4F0", Slot = "22")]
			public override string GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A473 RID: 42099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A473")]
			[Address(RVA = "0x31DF570", Offset = "0x31DE170", VA = "0x1831DF570", Slot = "24")]
			public override object GetTarget()
			{
				return null;
			}

			// Token: 0x17001301 RID: 4865
			// (get) Token: 0x0600A474 RID: 42100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001301")]
			public override IDIYItem diyItem
			{
				[Token(Token = "0x600A474")]
				[Address(RVA = "0x31DFCD0", Offset = "0x31DE8D0", VA = "0x1831DFCD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001302 RID: 4866
			// (get) Token: 0x0600A475 RID: 42101 RVA: 0x0003FC48 File Offset: 0x0003DE48
			[Token(Token = "0x17001302")]
			public override int enableRoomType
			{
				[Token(Token = "0x600A475")]
				[Address(RVA = "0x31DFD30", Offset = "0x31DE930", VA = "0x1831DFD30", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001303 RID: 4867
			// (get) Token: 0x0600A476 RID: 42102 RVA: 0x0003FC60 File Offset: 0x0003DE60
			[Token(Token = "0x17001303")]
			public override BuildingData.FurnitureType furnitureType
			{
				[Token(Token = "0x600A476")]
				[Address(RVA = "0x31DFDB0", Offset = "0x31DE9B0", VA = "0x1831DFDB0", Slot = "8")]
				get
				{
					return BuildingData.FurnitureType.FLOOR;
				}
			}

			// Token: 0x17001304 RID: 4868
			// (get) Token: 0x0600A477 RID: 42103 RVA: 0x0003FC78 File Offset: 0x0003DE78
			[Token(Token = "0x17001304")]
			public override BuildingData.FurnitureSubType subType
			{
				[Token(Token = "0x600A477")]
				[Address(RVA = "0x31DFE30", Offset = "0x31DEA30", VA = "0x1831DFE30", Slot = "9")]
				get
				{
					return BuildingData.FurnitureSubType.NONE;
				}
			}

			// Token: 0x0600A478 RID: 42104 RVA: 0x0003FC90 File Offset: 0x0003DE90
			[Token(Token = "0x600A478")]
			[Address(RVA = "0x31DF6A0", Offset = "0x31DE2A0", VA = "0x1831DF6A0", Slot = "28")]
			public override bool ShowLowerInfoButton()
			{
				return default(bool);
			}

			// Token: 0x0600A479 RID: 42105 RVA: 0x0003FCA8 File Offset: 0x0003DEA8
			[Token(Token = "0x600A479")]
			[Address(RVA = "0x31DF700", Offset = "0x31DE300", VA = "0x1831DF700", Slot = "12")]
			public override bool ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600A47A RID: 42106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A47A")]
			[Address(RVA = "0x31DF5D0", Offset = "0x31DE1D0", VA = "0x1831DF5D0", Slot = "14")]
			public override void SetShowTotalCount(bool showTotalCount)
			{
			}

			// Token: 0x0600A47B RID: 42107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A47B")]
			[Address(RVA = "0x31DF7C0", Offset = "0x31DE3C0", VA = "0x1831DF7C0")]
			private Sprite <>xLuaBaseProxy_GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A47C RID: 42108 RVA: 0x0003FCC0 File Offset: 0x0003DEC0
			[Token(Token = "0x600A47C")]
			[Address(RVA = "0x31DF760", Offset = "0x31DE360", VA = "0x1831DF760")]
			private bool <>xLuaBaseProxy_ButtonValid()
			{
				return default(bool);
			}

			// Token: 0x0600A47D RID: 42109 RVA: 0x0003FCD8 File Offset: 0x0003DED8
			[Token(Token = "0x600A47D")]
			[Address(RVA = "0x31DF9B0", Offset = "0x31DE5B0", VA = "0x1831DF9B0")]
			private bool <>xLuaBaseProxy_ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600A47E RID: 42110 RVA: 0x0003FCF0 File Offset: 0x0003DEF0
			[Token(Token = "0x600A47E")]
			[Address(RVA = "0x31DF820", Offset = "0x31DE420", VA = "0x1831DF820")]
			private int <>xLuaBaseProxy_GetComfort()
			{
				return 0;
			}

			// Token: 0x0600A47F RID: 42111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A47F")]
			[Address(RVA = "0x31DF880", Offset = "0x31DE480", VA = "0x1831DF880")]
			private string <>xLuaBaseProxy_GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A480 RID: 42112 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A480")]
			[Address(RVA = "0x31DF8F0", Offset = "0x31DE4F0", VA = "0x1831DF8F0")]
			private object <>xLuaBaseProxy_GetTarget()
			{
				return null;
			}

			// Token: 0x0600A481 RID: 42113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A481")]
			[Address(RVA = "0x31DFAD0", Offset = "0x31DE6D0", VA = "0x1831DFAD0")]
			private IDIYItem <>xLuaBaseProxy_get_diyItem()
			{
				return null;
			}

			// Token: 0x0600A482 RID: 42114 RVA: 0x0003FD08 File Offset: 0x0003DF08
			[Token(Token = "0x600A482")]
			[Address(RVA = "0x31DFB30", Offset = "0x31DE730", VA = "0x1831DFB30")]
			private int <>xLuaBaseProxy_get_enableRoomType()
			{
				return 0;
			}

			// Token: 0x0600A483 RID: 42115 RVA: 0x0003FD20 File Offset: 0x0003DF20
			[Token(Token = "0x600A483")]
			[Address(RVA = "0x31DFB90", Offset = "0x31DE790", VA = "0x1831DFB90")]
			private BuildingData.FurnitureType <>xLuaBaseProxy_get_furnitureType()
			{
				return BuildingData.FurnitureType.FLOOR;
			}

			// Token: 0x0600A484 RID: 42116 RVA: 0x0003FD38 File Offset: 0x0003DF38
			[Token(Token = "0x600A484")]
			[Address(RVA = "0x31DFBF0", Offset = "0x31DE7F0", VA = "0x1831DFBF0")]
			private BuildingData.FurnitureSubType <>xLuaBaseProxy_get_subType()
			{
				return BuildingData.FurnitureSubType.NONE;
			}

			// Token: 0x0600A485 RID: 42117 RVA: 0x0003FD50 File Offset: 0x0003DF50
			[Token(Token = "0x600A485")]
			[Address(RVA = "0x31DFA10", Offset = "0x31DE610", VA = "0x1831DFA10")]
			private bool <>xLuaBaseProxy_ShowLowerInfoButton()
			{
				return default(bool);
			}

			// Token: 0x0600A486 RID: 42118 RVA: 0x0003FD68 File Offset: 0x0003DF68
			[Token(Token = "0x600A486")]
			[Address(RVA = "0x31DFA70", Offset = "0x31DE670", VA = "0x1831DFA70")]
			private bool <>xLuaBaseProxy_ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600A487 RID: 42119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A487")]
			[Address(RVA = "0x31DF950", Offset = "0x31DE550", VA = "0x1831DF950")]
			private void <>xLuaBaseProxy_SetShowTotalCount(bool P0)
			{
			}

			// Token: 0x04009BAF RID: 39855
			[Token(Token = "0x4009BAF")]
			[FieldOffset(Offset = "0x38")]
			private IFurnitureData m_furnitureData;

			// Token: 0x04009BB0 RID: 39856
			[Token(Token = "0x4009BB0")]
			[FieldOffset(Offset = "0x40")]
			private bool m_showTotalCount;

			// Token: 0x04009BB1 RID: 39857
			[Token(Token = "0x4009BB1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009BB2 RID: 39858
			[Token(Token = "0x4009BB2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetBigSprite;

			// Token: 0x04009BB3 RID: 39859
			[Token(Token = "0x4009BB3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ButtonValid;

			// Token: 0x04009BB4 RID: 39860
			[Token(Token = "0x4009BB4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ShowComfort;

			// Token: 0x04009BB5 RID: 39861
			[Token(Token = "0x4009BB5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetComfort;

			// Token: 0x04009BB6 RID: 39862
			[Token(Token = "0x4009BB6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetDisplayName;

			// Token: 0x04009BB7 RID: 39863
			[Token(Token = "0x4009BB7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetTarget;

			// Token: 0x04009BB8 RID: 39864
			[Token(Token = "0x4009BB8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_diyItem;

			// Token: 0x04009BB9 RID: 39865
			[Token(Token = "0x4009BB9")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_enableRoomType;

			// Token: 0x04009BBA RID: 39866
			[Token(Token = "0x4009BBA")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_furnitureType;

			// Token: 0x04009BBB RID: 39867
			[Token(Token = "0x4009BBB")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_subType;

			// Token: 0x04009BBC RID: 39868
			[Token(Token = "0x4009BBC")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_ShowLowerInfoButton;

			// Token: 0x04009BBD RID: 39869
			[Token(Token = "0x4009BBD")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_ShowTotalCount;

			// Token: 0x04009BBE RID: 39870
			[Token(Token = "0x4009BBE")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_SetShowTotalCount;
		}

		// Token: 0x02001999 RID: 6553
		[Token(Token = "0x2001999")]
		private class DIYItemViewDataModifier : DIYItemViewData
		{
			// Token: 0x0600A488 RID: 42120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A488")]
			[Address(RVA = "0x31E02D0", Offset = "0x31DEED0", VA = "0x1831E02D0")]
			public DIYItemViewDataModifier(IDIYRoomModifierData target)
			{
			}

			// Token: 0x0600A489 RID: 42121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A489")]
			[Address(RVA = "0x31DFF60", Offset = "0x31DEB60", VA = "0x1831DFF60", Slot = "4")]
			public override Sprite GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A48A RID: 42122 RVA: 0x0003FD80 File Offset: 0x0003DF80
			[Token(Token = "0x600A48A")]
			[Address(RVA = "0x31DFEB0", Offset = "0x31DEAB0", VA = "0x1831DFEB0", Slot = "21")]
			public override bool ButtonValid()
			{
				return default(bool);
			}

			// Token: 0x0600A48B RID: 42123 RVA: 0x0003FD98 File Offset: 0x0003DF98
			[Token(Token = "0x600A48B")]
			[Address(RVA = "0x31E01B0", Offset = "0x31DEDB0", VA = "0x1831E01B0", Slot = "17")]
			public override bool ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600A48C RID: 42124 RVA: 0x0003FDB0 File Offset: 0x0003DFB0
			[Token(Token = "0x600A48C")]
			[Address(RVA = "0x31DFFE0", Offset = "0x31DEBE0", VA = "0x1831DFFE0", Slot = "18")]
			public override int GetComfort()
			{
				return 0;
			}

			// Token: 0x0600A48D RID: 42125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A48D")]
			[Address(RVA = "0x31E0060", Offset = "0x31DEC60", VA = "0x1831E0060", Slot = "22")]
			public override string GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A48E RID: 42126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A48E")]
			[Address(RVA = "0x31E00E0", Offset = "0x31DECE0", VA = "0x1831E00E0", Slot = "24")]
			public override object GetTarget()
			{
				return null;
			}

			// Token: 0x17001305 RID: 4869
			// (get) Token: 0x0600A48F RID: 42127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001305")]
			public override IDIYItem diyItem
			{
				[Token(Token = "0x600A48F")]
				[Address(RVA = "0x31E0350", Offset = "0x31DEF50", VA = "0x1831E0350", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001306 RID: 4870
			// (get) Token: 0x0600A490 RID: 42128 RVA: 0x0003FDC8 File Offset: 0x0003DFC8
			[Token(Token = "0x17001306")]
			public override int enableRoomType
			{
				[Token(Token = "0x600A490")]
				[Address(RVA = "0x31E03B0", Offset = "0x31DEFB0", VA = "0x1831E03B0", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001307 RID: 4871
			// (get) Token: 0x0600A491 RID: 42129 RVA: 0x0003FDE0 File Offset: 0x0003DFE0
			[Token(Token = "0x17001307")]
			public override BuildingData.FurnitureType furnitureType
			{
				[Token(Token = "0x600A491")]
				[Address(RVA = "0x31E0430", Offset = "0x31DF030", VA = "0x1831E0430", Slot = "8")]
				get
				{
					return BuildingData.FurnitureType.FLOOR;
				}
			}

			// Token: 0x17001308 RID: 4872
			// (get) Token: 0x0600A492 RID: 42130 RVA: 0x0003FDF8 File Offset: 0x0003DFF8
			[Token(Token = "0x17001308")]
			public override BuildingData.FurnitureSubType subType
			{
				[Token(Token = "0x600A492")]
				[Address(RVA = "0x31E04B0", Offset = "0x31DF0B0", VA = "0x1831E04B0", Slot = "9")]
				get
				{
					return BuildingData.FurnitureSubType.NONE;
				}
			}

			// Token: 0x0600A493 RID: 42131 RVA: 0x0003FE10 File Offset: 0x0003E010
			[Token(Token = "0x600A493")]
			[Address(RVA = "0x31E0210", Offset = "0x31DEE10", VA = "0x1831E0210", Slot = "28")]
			public override bool ShowLowerInfoButton()
			{
				return default(bool);
			}

			// Token: 0x0600A494 RID: 42132 RVA: 0x0003FE28 File Offset: 0x0003E028
			[Token(Token = "0x600A494")]
			[Address(RVA = "0x31E0270", Offset = "0x31DEE70", VA = "0x1831E0270", Slot = "12")]
			public override bool ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600A495 RID: 42133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A495")]
			[Address(RVA = "0x31E0140", Offset = "0x31DED40", VA = "0x1831E0140", Slot = "14")]
			public override void SetShowTotalCount(bool showTotalCount)
			{
			}

			// Token: 0x0600A496 RID: 42134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A496")]
			[Address(RVA = "0x31DF7C0", Offset = "0x31DE3C0", VA = "0x1831DF7C0")]
			private Sprite <>xLuaBaseProxy_GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A497 RID: 42135 RVA: 0x0003FE40 File Offset: 0x0003E040
			[Token(Token = "0x600A497")]
			[Address(RVA = "0x31DF760", Offset = "0x31DE360", VA = "0x1831DF760")]
			private bool <>xLuaBaseProxy_ButtonValid()
			{
				return default(bool);
			}

			// Token: 0x0600A498 RID: 42136 RVA: 0x0003FE58 File Offset: 0x0003E058
			[Token(Token = "0x600A498")]
			[Address(RVA = "0x31DF9B0", Offset = "0x31DE5B0", VA = "0x1831DF9B0")]
			private bool <>xLuaBaseProxy_ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600A499 RID: 42137 RVA: 0x0003FE70 File Offset: 0x0003E070
			[Token(Token = "0x600A499")]
			[Address(RVA = "0x31DF820", Offset = "0x31DE420", VA = "0x1831DF820")]
			private int <>xLuaBaseProxy_GetComfort()
			{
				return 0;
			}

			// Token: 0x0600A49A RID: 42138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A49A")]
			[Address(RVA = "0x31DF880", Offset = "0x31DE480", VA = "0x1831DF880")]
			private string <>xLuaBaseProxy_GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A49B RID: 42139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A49B")]
			[Address(RVA = "0x31DF8F0", Offset = "0x31DE4F0", VA = "0x1831DF8F0")]
			private object <>xLuaBaseProxy_GetTarget()
			{
				return null;
			}

			// Token: 0x0600A49C RID: 42140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A49C")]
			[Address(RVA = "0x31DFAD0", Offset = "0x31DE6D0", VA = "0x1831DFAD0")]
			private IDIYItem <>xLuaBaseProxy_get_diyItem()
			{
				return null;
			}

			// Token: 0x0600A49D RID: 42141 RVA: 0x0003FE88 File Offset: 0x0003E088
			[Token(Token = "0x600A49D")]
			[Address(RVA = "0x31DFB30", Offset = "0x31DE730", VA = "0x1831DFB30")]
			private int <>xLuaBaseProxy_get_enableRoomType()
			{
				return 0;
			}

			// Token: 0x0600A49E RID: 42142 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
			[Token(Token = "0x600A49E")]
			[Address(RVA = "0x31DFB90", Offset = "0x31DE790", VA = "0x1831DFB90")]
			private BuildingData.FurnitureType <>xLuaBaseProxy_get_furnitureType()
			{
				return BuildingData.FurnitureType.FLOOR;
			}

			// Token: 0x0600A49F RID: 42143 RVA: 0x0003FEB8 File Offset: 0x0003E0B8
			[Token(Token = "0x600A49F")]
			[Address(RVA = "0x31DFBF0", Offset = "0x31DE7F0", VA = "0x1831DFBF0")]
			private BuildingData.FurnitureSubType <>xLuaBaseProxy_get_subType()
			{
				return BuildingData.FurnitureSubType.NONE;
			}

			// Token: 0x0600A4A0 RID: 42144 RVA: 0x0003FED0 File Offset: 0x0003E0D0
			[Token(Token = "0x600A4A0")]
			[Address(RVA = "0x31DFA10", Offset = "0x31DE610", VA = "0x1831DFA10")]
			private bool <>xLuaBaseProxy_ShowLowerInfoButton()
			{
				return default(bool);
			}

			// Token: 0x0600A4A1 RID: 42145 RVA: 0x0003FEE8 File Offset: 0x0003E0E8
			[Token(Token = "0x600A4A1")]
			[Address(RVA = "0x31DFA70", Offset = "0x31DE670", VA = "0x1831DFA70")]
			private bool <>xLuaBaseProxy_ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600A4A2 RID: 42146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4A2")]
			[Address(RVA = "0x31DF950", Offset = "0x31DE550", VA = "0x1831DF950")]
			private void <>xLuaBaseProxy_SetShowTotalCount(bool P0)
			{
			}

			// Token: 0x04009BBF RID: 39871
			[Token(Token = "0x4009BBF")]
			[FieldOffset(Offset = "0x38")]
			private IDIYRoomModifierData m_modifierData;

			// Token: 0x04009BC0 RID: 39872
			[Token(Token = "0x4009BC0")]
			[FieldOffset(Offset = "0x40")]
			private bool m_showTotalCount;

			// Token: 0x04009BC1 RID: 39873
			[Token(Token = "0x4009BC1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009BC2 RID: 39874
			[Token(Token = "0x4009BC2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetBigSprite;

			// Token: 0x04009BC3 RID: 39875
			[Token(Token = "0x4009BC3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ButtonValid;

			// Token: 0x04009BC4 RID: 39876
			[Token(Token = "0x4009BC4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ShowComfort;

			// Token: 0x04009BC5 RID: 39877
			[Token(Token = "0x4009BC5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetComfort;

			// Token: 0x04009BC6 RID: 39878
			[Token(Token = "0x4009BC6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetDisplayName;

			// Token: 0x04009BC7 RID: 39879
			[Token(Token = "0x4009BC7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetTarget;

			// Token: 0x04009BC8 RID: 39880
			[Token(Token = "0x4009BC8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_diyItem;

			// Token: 0x04009BC9 RID: 39881
			[Token(Token = "0x4009BC9")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_enableRoomType;

			// Token: 0x04009BCA RID: 39882
			[Token(Token = "0x4009BCA")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_furnitureType;

			// Token: 0x04009BCB RID: 39883
			[Token(Token = "0x4009BCB")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_subType;

			// Token: 0x04009BCC RID: 39884
			[Token(Token = "0x4009BCC")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_ShowLowerInfoButton;

			// Token: 0x04009BCD RID: 39885
			[Token(Token = "0x4009BCD")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_ShowTotalCount;

			// Token: 0x04009BCE RID: 39886
			[Token(Token = "0x4009BCE")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_SetShowTotalCount;
		}
	}
}
