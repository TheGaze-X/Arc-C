using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E8E RID: 20110
	[Token(Token = "0x2004E8E")]
	public class FireworkCraftState : FireworkBaseState
	{
		// Token: 0x0601DFFC RID: 122876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFFC")]
		[Address(RVA = "0x17A04A0", Offset = "0x179F0A0", VA = "0x1817A04A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DFFD RID: 122877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFFD")]
		[Address(RVA = "0x179F0B0", Offset = "0x179DCB0", VA = "0x18179F0B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DFFE RID: 122878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFFE")]
		[Address(RVA = "0x179F110", Offset = "0x179DD10", VA = "0x18179F110", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DFFF RID: 122879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFFF")]
		[Address(RVA = "0x179FD50", Offset = "0x179E950", VA = "0x18179FD50", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601E000 RID: 122880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E000")]
		[Address(RVA = "0x179FE30", Offset = "0x179EA30", VA = "0x18179FE30", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601E001 RID: 122881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E001")]
		[Address(RVA = "0x17A0CF0", Offset = "0x179F8F0", VA = "0x1817A0CF0")]
		private void _OnJumpToAnimalSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601E002 RID: 122882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E002")]
		[Address(RVA = "0x17A0130", Offset = "0x179ED30", VA = "0x1817A0130")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601E003 RID: 122883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E003")]
		[Address(RVA = "0x17A1720", Offset = "0x17A0320", VA = "0x1817A1720")]
		private void _TryTriggerTutorialAVG()
		{
		}

		// Token: 0x0601E004 RID: 122884 RVA: 0x000AD268 File Offset: 0x000AB468
		[Token(Token = "0x601E004")]
		[Address(RVA = "0x179FF90", Offset = "0x179EB90", VA = "0x18179FF90")]
		public bool TutorialOnly_IsStable()
		{
			return default(bool);
		}

		// Token: 0x0601E005 RID: 122885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E005")]
		[Address(RVA = "0x17A0090", Offset = "0x179EC90", VA = "0x1817A0090")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601E006 RID: 122886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E006")]
		[Address(RVA = "0x179F580", Offset = "0x179E180", VA = "0x18179F580", Slot = "32")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E007 RID: 122887 RVA: 0x000AD280 File Offset: 0x000AB480
		[Token(Token = "0x601E007")]
		[Address(RVA = "0x17A05A0", Offset = "0x179F1A0", VA = "0x1817A05A0")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601E008 RID: 122888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E008")]
		[Address(RVA = "0x17A1370", Offset = "0x179FF70", VA = "0x1817A1370")]
		private void _OnViewStateChanged(int status)
		{
		}

		// Token: 0x0601E009 RID: 122889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E009")]
		[Address(RVA = "0x17A1270", Offset = "0x179FE70", VA = "0x1817A1270")]
		private void _OnStageClicked(string stageId)
		{
		}

		// Token: 0x0601E00A RID: 122890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E00A")]
		[Address(RVA = "0x17A1470", Offset = "0x17A0070", VA = "0x1817A1470")]
		private void _OnZoneClicked(string zoneId)
		{
		}

		// Token: 0x0601E00B RID: 122891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E00B")]
		[Address(RVA = "0x17A0F90", Offset = "0x179FB90", VA = "0x1817A0F90")]
		private void _OnPlateListItemClicked(string groupId)
		{
		}

		// Token: 0x0601E00C RID: 122892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E00C")]
		[Address(RVA = "0x17A1090", Offset = "0x179FC90", VA = "0x1817A1090")]
		private void _OnPlateListSubItemClicked(FireworkData.PlateSlotData slotData)
		{
		}

		// Token: 0x0601E00D RID: 122893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E00D")]
		[Address(RVA = "0x17A0E90", Offset = "0x179FA90", VA = "0x1817A0E90")]
		private void _OnPlateListFilledItemClicked(FireworkData.PlateSlotData slotData)
		{
		}

		// Token: 0x0601E00E RID: 122894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E00E")]
		[Address(RVA = "0x17A1190", Offset = "0x179FD90", VA = "0x1817A1190")]
		private void _OnPnlSubListRaycastClicked()
		{
		}

		// Token: 0x0601E00F RID: 122895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E00F")]
		[Address(RVA = "0x17A0C10", Offset = "0x179F810", VA = "0x1817A0C10")]
		private void _OnClearAllBtnClicked()
		{
		}

		// Token: 0x0601E010 RID: 122896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E010")]
		[Address(RVA = "0x17A0660", Offset = "0x179F260", VA = "0x1817A0660")]
		private void _OnAnimalSwitchClicked()
		{
		}

		// Token: 0x0601E011 RID: 122897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E011")]
		[Address(RVA = "0x17A0780", Offset = "0x179F380", VA = "0x1817A0780")]
		private void _OnBtnSaveClicked()
		{
		}

		// Token: 0x0601E012 RID: 122898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E012")]
		[Address(RVA = "0x17A0B00", Offset = "0x179F700", VA = "0x1817A0B00")]
		private void _OnBtnSaveResponse(FireworkSavePlateSlotResponse response)
		{
		}

		// Token: 0x0601E013 RID: 122899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E013")]
		[Address(RVA = "0x17A1690", Offset = "0x17A0290", VA = "0x1817A1690")]
		private void _OpenGuideBook(Story story)
		{
		}

		// Token: 0x0601E014 RID: 122900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E014")]
		[Address(RVA = "0x17A1890", Offset = "0x17A0490", VA = "0x1817A1890")]
		public FireworkCraftState()
		{
		}

		// Token: 0x0601E015 RID: 122901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E015")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E016 RID: 122902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E016")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0601E017 RID: 122903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E017")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04027DBD RID: 163261
		[Token(Token = "0x4027DBD")]
		private const string GUIDE_SUB_SIGNAL = "craft";

		// Token: 0x04027DBE RID: 163262
		[Token(Token = "0x4027DBE")]
		[NonSerialized]
		public const int ON_VIEW_STATE_CHANGED = 0;

		// Token: 0x04027DBF RID: 163263
		[Token(Token = "0x4027DBF")]
		[NonSerialized]
		public const int ON_STAGE_CLICKED = 1;

		// Token: 0x04027DC0 RID: 163264
		[Token(Token = "0x4027DC0")]
		[NonSerialized]
		public const int ON_ZONE_CLICKED = 2;

		// Token: 0x04027DC1 RID: 163265
		[Token(Token = "0x4027DC1")]
		[NonSerialized]
		public const int ON_ANIMAL_SWITCH_CLICKED = 3;

		// Token: 0x04027DC2 RID: 163266
		[Token(Token = "0x4027DC2")]
		[NonSerialized]
		public const int ON_BTN_SAVE_CLICKED = 4;

		// Token: 0x04027DC3 RID: 163267
		[Token(Token = "0x4027DC3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuHolder;

		// Token: 0x04027DC4 RID: 163268
		[Token(Token = "0x4027DC4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private FireworkCraftView _view;

		// Token: 0x04027DC5 RID: 163269
		[Token(Token = "0x4027DC5")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04027DC6 RID: 163270
		[Token(Token = "0x4027DC6")]
		[FieldOffset(Offset = "0x88")]
		private FireworkCraftProperty m_property;

		// Token: 0x04027DC7 RID: 163271
		[Token(Token = "0x4027DC7")]
		[FieldOffset(Offset = "0x90")]
		private List<FireworkData.PlateSlotData> m_cacheSlotList;

		// Token: 0x04027DC8 RID: 163272
		[Token(Token = "0x4027DC8")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedAddPieceSeqNum;

		// Token: 0x04027DC9 RID: 163273
		[Token(Token = "0x4027DC9")]
		[FieldOffset(Offset = "0x9C")]
		private int m_cachedRemovePieceSeqNum;

		// Token: 0x04027DCA RID: 163274
		[Token(Token = "0x4027DCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027DCB RID: 163275
		[Token(Token = "0x4027DCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027DCC RID: 163276
		[Token(Token = "0x4027DCC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027DCD RID: 163277
		[Token(Token = "0x4027DCD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04027DCE RID: 163278
		[Token(Token = "0x4027DCE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04027DCF RID: 163279
		[Token(Token = "0x4027DCF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToAnimalSelectState;

		// Token: 0x04027DD0 RID: 163280
		[Token(Token = "0x4027DD0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x04027DD1 RID: 163281
		[Token(Token = "0x4027DD1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialAVG;

		// Token: 0x04027DD2 RID: 163282
		[Token(Token = "0x4027DD2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TutorialOnly_IsStable;

		// Token: 0x04027DD3 RID: 163283
		[Token(Token = "0x4027DD3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x04027DD4 RID: 163284
		[Token(Token = "0x4027DD4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04027DD5 RID: 163285
		[Token(Token = "0x4027DD5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x04027DD6 RID: 163286
		[Token(Token = "0x4027DD6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnViewStateChanged;

		// Token: 0x04027DD7 RID: 163287
		[Token(Token = "0x4027DD7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStageClicked;

		// Token: 0x04027DD8 RID: 163288
		[Token(Token = "0x4027DD8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnZoneClicked;

		// Token: 0x04027DD9 RID: 163289
		[Token(Token = "0x4027DD9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnPlateListItemClicked;

		// Token: 0x04027DDA RID: 163290
		[Token(Token = "0x4027DDA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnPlateListSubItemClicked;

		// Token: 0x04027DDB RID: 163291
		[Token(Token = "0x4027DDB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnPlateListFilledItemClicked;

		// Token: 0x04027DDC RID: 163292
		[Token(Token = "0x4027DDC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnPnlSubListRaycastClicked;

		// Token: 0x04027DDD RID: 163293
		[Token(Token = "0x4027DDD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnClearAllBtnClicked;

		// Token: 0x04027DDE RID: 163294
		[Token(Token = "0x4027DDE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnAnimalSwitchClicked;

		// Token: 0x04027DDF RID: 163295
		[Token(Token = "0x4027DDF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnBtnSaveClicked;

		// Token: 0x04027DE0 RID: 163296
		[Token(Token = "0x4027DE0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnBtnSaveResponse;

		// Token: 0x04027DE1 RID: 163297
		[Token(Token = "0x4027DE1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OpenGuideBook;

		// Token: 0x04027DE2 RID: 163298
		[Token(Token = "0x4027DE2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
