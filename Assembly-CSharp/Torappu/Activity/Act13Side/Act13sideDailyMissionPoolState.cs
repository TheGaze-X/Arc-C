using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079ED RID: 31213
	[Token(Token = "0x20079ED")]
	public class Act13sideDailyMissionPoolState : PopupFadeState
	{
		// Token: 0x0602BC05 RID: 179205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC05")]
		[Address(RVA = "0x279A210", Offset = "0x2798E10", VA = "0x18279A210", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BC06 RID: 179206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC06")]
		[Address(RVA = "0x279A720", Offset = "0x2799320", VA = "0x18279A720", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BC07 RID: 179207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC07")]
		[Address(RVA = "0x279A830", Offset = "0x2799430", VA = "0x18279A830", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BC08 RID: 179208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC08")]
		[Address(RVA = "0x279AAD0", Offset = "0x27996D0", VA = "0x18279AAD0")]
		private void _RaiseTutorialSignal()
		{
		}

		// Token: 0x0602BC09 RID: 179209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC09")]
		[Address(RVA = "0x279A900", Offset = "0x2799500", VA = "0x18279A900", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BC0A RID: 179210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC0A")]
		[Address(RVA = "0x279AEB0", Offset = "0x2799AB0", VA = "0x18279AEB0")]
		private void _JumpToSearchState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BC0B RID: 179211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC0B")]
		[Address(RVA = "0x279AD40", Offset = "0x2799940", VA = "0x18279AD40")]
		private void _JumpToReplaceState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BC0C RID: 179212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC0C")]
		[Address(RVA = "0x279B390", Offset = "0x2799F90", VA = "0x18279B390")]
		private void _UpdateMissionProp()
		{
		}

		// Token: 0x0602BC0D RID: 179213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC0D")]
		[Address(RVA = "0x279B0E0", Offset = "0x2799CE0", VA = "0x18279B0E0")]
		private void _PlayRefreshAnimIfNeed()
		{
		}

		// Token: 0x0602BC0E RID: 179214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC0E")]
		[Address(RVA = "0x279AB30", Offset = "0x2799730", VA = "0x18279AB30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17006691 RID: 26257
		// (get) Token: 0x0602BC0F RID: 179215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006691")]
		protected TemplateActivityController actController
		{
			[Token(Token = "0x602BC0F")]
			[Address(RVA = "0x279B5A0", Offset = "0x279A1A0", VA = "0x18279B5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006692 RID: 26258
		// (get) Token: 0x0602BC10 RID: 179216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006692")]
		protected string activityId
		{
			[Token(Token = "0x602BC10")]
			[Address(RVA = "0x279B680", Offset = "0x279A280", VA = "0x18279B680")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BC11 RID: 179217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC11")]
		private T _FetchStageController<T>() where T : ActivityStageController
		{
			return null;
		}

		// Token: 0x0602BC12 RID: 179218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC12")]
		[Address(RVA = "0x279AFD0", Offset = "0x2799BD0", VA = "0x18279AFD0")]
		private void _OnMissonPoolItemSelected(int selectedIdx)
		{
		}

		// Token: 0x0602BC13 RID: 179219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC13")]
		[Address(RVA = "0x279A690", Offset = "0x2799290", VA = "0x18279A690")]
		public void OnBtnSearchClick()
		{
		}

		// Token: 0x0602BC14 RID: 179220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC14")]
		[Address(RVA = "0x279A270", Offset = "0x2798E70", VA = "0x18279A270")]
		public void OnBtnAcceptClick()
		{
		}

		// Token: 0x0602BC15 RID: 179221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC15")]
		[Address(RVA = "0x279A600", Offset = "0x2799200", VA = "0x18279A600")]
		public void OnBtnReplaceClick()
		{
		}

		// Token: 0x0602BC16 RID: 179222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC16")]
		[Address(RVA = "0x279B470", Offset = "0x279A070", VA = "0x18279B470")]
		public Act13sideDailyMissionPoolState()
		{
		}

		// Token: 0x0602BC18 RID: 179224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC18")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BC19 RID: 179225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC19")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602BC1A RID: 179226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC1A")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403F4CA RID: 259274
		[Token(Token = "0x403F4CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0403F4CB RID: 259275
		[Token(Token = "0x403F4CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act13sideDailyMissionPoolView _view;

		// Token: 0x0403F4CC RID: 259276
		[Token(Token = "0x403F4CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animRefresh;

		// Token: 0x0403F4CD RID: 259277
		[Token(Token = "0x403F4CD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0403F4CE RID: 259278
		[Token(Token = "0x403F4CE")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0403F4CF RID: 259279
		[Token(Token = "0x403F4CF")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_missionFlag;

		// Token: 0x0403F4D0 RID: 259280
		[Token(Token = "0x403F4D0")]
		[FieldOffset(Offset = "0xA8")]
		private Act13sideDailyMissionPoolStateBean m_stateBean;

		// Token: 0x0403F4D1 RID: 259281
		[Token(Token = "0x403F4D1")]
		[FieldOffset(Offset = "0xB0")]
		private TemplateActivityController m_stageController;

		// Token: 0x0403F4D2 RID: 259282
		[Token(Token = "0x403F4D2")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isPlayAcceptAnim;

		// Token: 0x0403F4D3 RID: 259283
		[Token(Token = "0x403F4D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F4D4 RID: 259284
		[Token(Token = "0x403F4D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F4D5 RID: 259285
		[Token(Token = "0x403F4D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403F4D6 RID: 259286
		[Token(Token = "0x403F4D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RaiseTutorialSignal;

		// Token: 0x0403F4D7 RID: 259287
		[Token(Token = "0x403F4D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403F4D8 RID: 259288
		[Token(Token = "0x403F4D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__JumpToSearchState;

		// Token: 0x0403F4D9 RID: 259289
		[Token(Token = "0x403F4D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__JumpToReplaceState;

		// Token: 0x0403F4DA RID: 259290
		[Token(Token = "0x403F4DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateMissionProp;

		// Token: 0x0403F4DB RID: 259291
		[Token(Token = "0x403F4DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayRefreshAnimIfNeed;

		// Token: 0x0403F4DC RID: 259292
		[Token(Token = "0x403F4DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F4DD RID: 259293
		[Token(Token = "0x403F4DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403F4DE RID: 259294
		[Token(Token = "0x403F4DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403F4DF RID: 259295
		[Token(Token = "0x403F4DF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FetchStageController;

		// Token: 0x0403F4E0 RID: 259296
		[Token(Token = "0x403F4E0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnMissonPoolItemSelected;

		// Token: 0x0403F4E1 RID: 259297
		[Token(Token = "0x403F4E1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBtnSearchClick;

		// Token: 0x0403F4E2 RID: 259298
		[Token(Token = "0x403F4E2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnBtnAcceptClick;

		// Token: 0x0403F4E3 RID: 259299
		[Token(Token = "0x403F4E3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBtnReplaceClick;

		// Token: 0x0403F4E4 RID: 259300
		[Token(Token = "0x403F4E4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
