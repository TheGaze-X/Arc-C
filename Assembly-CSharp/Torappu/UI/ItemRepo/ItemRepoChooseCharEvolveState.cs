using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E52 RID: 24146
	[Token(Token = "0x2005E52")]
	public class ItemRepoChooseCharEvolveState : PopupFloatState
	{
		// Token: 0x06022FB8 RID: 143288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FB8")]
		[Address(RVA = "0x1D80B90", Offset = "0x1D7F790", VA = "0x181D80B90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022FB9 RID: 143289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FB9")]
		[Address(RVA = "0x1D81520", Offset = "0x1D80120", VA = "0x181D81520", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022FBA RID: 143290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FBA")]
		[Address(RVA = "0x1D80BF0", Offset = "0x1D7F7F0", VA = "0x181D80BF0")]
		public void OnCharClick(CharacterCardViewModel charViewModel)
		{
		}

		// Token: 0x06022FBB RID: 143291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FBB")]
		[Address(RVA = "0x1D81040", Offset = "0x1D7FC40", VA = "0x181D81040", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022FBC RID: 143292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FBC")]
		[Address(RVA = "0x1D81850", Offset = "0x1D80450", VA = "0x181D81850")]
		private List<CharacterCardViewModel> _GeneDataList()
		{
			return null;
		}

		// Token: 0x06022FBD RID: 143293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FBD")]
		[Address(RVA = "0x1D81C20", Offset = "0x1D80820", VA = "0x181D81C20")]
		private void _InitListData(List<CharacterCardViewModel> itemList, bool clickable, CharCardType cardType)
		{
		}

		// Token: 0x06022FBE RID: 143294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FBE")]
		[Address(RVA = "0x1D80F80", Offset = "0x1D7FB80", VA = "0x181D80F80")]
		private void OnEnable()
		{
		}

		// Token: 0x06022FBF RID: 143295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FBF")]
		[Address(RVA = "0x1D81DB0", Offset = "0x1D809B0", VA = "0x181D81DB0")]
		public ItemRepoChooseCharEvolveState()
		{
		}

		// Token: 0x06022FC2 RID: 143298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FC2")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022FC3 RID: 143299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FC3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403030B RID: 197387
		[Token(Token = "0x403030B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x0403030C RID: 197388
		[Token(Token = "0x403030C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharClickEvent _itemEvent;

		// Token: 0x0403030D RID: 197389
		[Token(Token = "0x403030D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CancelDragIfFits _cancelDragIfFits;

		// Token: 0x0403030E RID: 197390
		[Token(Token = "0x403030E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0403030F RID: 197391
		[Token(Token = "0x403030F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x04030310 RID: 197392
		[Token(Token = "0x4030310")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _emptyText;

		// Token: 0x04030311 RID: 197393
		[Token(Token = "0x4030311")]
		[FieldOffset(Offset = "0xA0")]
		private ItemRepoChooseCharEvolveAdapter m_adapter;

		// Token: 0x04030312 RID: 197394
		[Token(Token = "0x4030312")]
		[FieldOffset(Offset = "0xA8")]
		private ItemRepoChooseCharEvolveStateBean m_stateBean;

		// Token: 0x04030313 RID: 197395
		[Token(Token = "0x4030313")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030314 RID: 197396
		[Token(Token = "0x4030314")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04030315 RID: 197397
		[Token(Token = "0x4030315")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCharClick;

		// Token: 0x04030316 RID: 197398
		[Token(Token = "0x4030316")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030317 RID: 197399
		[Token(Token = "0x4030317")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GeneDataList;

		// Token: 0x04030318 RID: 197400
		[Token(Token = "0x4030318")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitListData;

		// Token: 0x04030319 RID: 197401
		[Token(Token = "0x4030319")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403031A RID: 197402
		[Token(Token = "0x403031A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
