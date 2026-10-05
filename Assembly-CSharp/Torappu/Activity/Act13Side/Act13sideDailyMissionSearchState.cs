using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F2 RID: 31218
	[Token(Token = "0x20079F2")]
	public class Act13sideDailyMissionSearchState : PopupFloatState
	{
		// Token: 0x0602BC2B RID: 179243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC2B")]
		[Address(RVA = "0x27B2500", Offset = "0x27B1100", VA = "0x1827B2500", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BC2C RID: 179244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC2C")]
		[Address(RVA = "0x27B2B40", Offset = "0x27B1740", VA = "0x1827B2B40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BC2D RID: 179245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC2D")]
		[Address(RVA = "0x27B2BE0", Offset = "0x27B17E0", VA = "0x1827B2BE0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BC2E RID: 179246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC2E")]
		[Address(RVA = "0x27B3440", Offset = "0x27B2040", VA = "0x1827B3440")]
		private void _RaiseTutorialSignal()
		{
		}

		// Token: 0x0602BC2F RID: 179247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC2F")]
		[Address(RVA = "0x27B2C80", Offset = "0x27B1880", VA = "0x1827B2C80", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BC30 RID: 179248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC30")]
		[Address(RVA = "0x27B30A0", Offset = "0x27B1CA0", VA = "0x1827B30A0")]
		private void _JumpToPoolState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BC31 RID: 179249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC31")]
		[Address(RVA = "0x27B2E20", Offset = "0x27B1A20", VA = "0x1827B2E20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BC32 RID: 179250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC32")]
		[Address(RVA = "0x27B3340", Offset = "0x27B1F40", VA = "0x1827B3340")]
		private void _OnOrgSelected(string orgId)
		{
		}

		// Token: 0x0602BC33 RID: 179251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC33")]
		[Address(RVA = "0x27B3220", Offset = "0x27B1E20", VA = "0x1827B3220")]
		private void _OnMatSelected(ItemBundle itemBundle)
		{
		}

		// Token: 0x0602BC34 RID: 179252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC34")]
		[Address(RVA = "0x27B34A0", Offset = "0x27B20A0", VA = "0x1827B34A0")]
		private void _SendBtnSearchRequest()
		{
		}

		// Token: 0x0602BC35 RID: 179253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC35")]
		[Address(RVA = "0x27B2680", Offset = "0x27B1280", VA = "0x1827B2680")]
		public void OnBtnRandomOrg()
		{
		}

		// Token: 0x0602BC36 RID: 179254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC36")]
		[Address(RVA = "0x27B2560", Offset = "0x27B1160", VA = "0x1827B2560")]
		public void OnBtnRandomMat()
		{
		}

		// Token: 0x0602BC37 RID: 179255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC37")]
		[Address(RVA = "0x27B27E0", Offset = "0x27B13E0", VA = "0x1827B27E0")]
		public void OnBtnSearch()
		{
		}

		// Token: 0x0602BC38 RID: 179256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC38")]
		[Address(RVA = "0x27B37E0", Offset = "0x27B23E0", VA = "0x1827B37E0")]
		public Act13sideDailyMissionSearchState()
		{
		}

		// Token: 0x0602BC3A RID: 179258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC3A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BC3B RID: 179259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC3B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602BC3C RID: 179260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC3C")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403F4FA RID: 259322
		[Token(Token = "0x403F4FA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act13sideDailyMissionSearchView _view;

		// Token: 0x0403F4FB RID: 259323
		[Token(Token = "0x403F4FB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0403F4FC RID: 259324
		[Token(Token = "0x403F4FC")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403F4FD RID: 259325
		[Token(Token = "0x403F4FD")]
		[FieldOffset(Offset = "0x81")]
		private bool m_needShowRefreshAnim;

		// Token: 0x0403F4FE RID: 259326
		[Token(Token = "0x403F4FE")]
		[FieldOffset(Offset = "0x88")]
		private Act13sideDailyMissionSearchStateBean m_stateBean;

		// Token: 0x0403F4FF RID: 259327
		[Token(Token = "0x403F4FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F500 RID: 259328
		[Token(Token = "0x403F500")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F501 RID: 259329
		[Token(Token = "0x403F501")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403F502 RID: 259330
		[Token(Token = "0x403F502")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RaiseTutorialSignal;

		// Token: 0x0403F503 RID: 259331
		[Token(Token = "0x403F503")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403F504 RID: 259332
		[Token(Token = "0x403F504")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__JumpToPoolState;

		// Token: 0x0403F505 RID: 259333
		[Token(Token = "0x403F505")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F506 RID: 259334
		[Token(Token = "0x403F506")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnOrgSelected;

		// Token: 0x0403F507 RID: 259335
		[Token(Token = "0x403F507")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnMatSelected;

		// Token: 0x0403F508 RID: 259336
		[Token(Token = "0x403F508")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendBtnSearchRequest;

		// Token: 0x0403F509 RID: 259337
		[Token(Token = "0x403F509")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnRandomOrg;

		// Token: 0x0403F50A RID: 259338
		[Token(Token = "0x403F50A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnRandomMat;

		// Token: 0x0403F50B RID: 259339
		[Token(Token = "0x403F50B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnSearch;

		// Token: 0x0403F50C RID: 259340
		[Token(Token = "0x403F50C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
