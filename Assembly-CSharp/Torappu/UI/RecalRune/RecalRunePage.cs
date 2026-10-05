using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x02004781 RID: 18305
	[Token(Token = "0x2004781")]
	public class RecalRunePage : StateEnginePage
	{
		// Token: 0x0601BB44 RID: 113476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB44")]
		[Address(RVA = "0x1507F90", Offset = "0x1506B90", VA = "0x181507F90")]
		public static DataBundle CreateRecoverDataBundleForBattle(string seasonId, string stageId)
		{
			return null;
		}

		// Token: 0x0601BB45 RID: 113477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB45")]
		[Address(RVA = "0x1508310", Offset = "0x1506F10", VA = "0x181508310")]
		public static UIPageControllerParam SceneParamToStageRune(DataBundle bundle)
		{
			return null;
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x0601BB46 RID: 113478 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BB47 RID: 113479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041C9")]
		public string seasonId
		{
			[Token(Token = "0x601BB46")]
			[Address(RVA = "0x1508DC0", Offset = "0x15079C0", VA = "0x181508DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601BB47")]
			[Address(RVA = "0x1508E80", Offset = "0x1507A80", VA = "0x181508E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x0601BB48 RID: 113480 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BB49 RID: 113481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041CA")]
		public string stageId
		{
			[Token(Token = "0x601BB48")]
			[Address(RVA = "0x1508E20", Offset = "0x1507A20", VA = "0x181508E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601BB49")]
			[Address(RVA = "0x1508F00", Offset = "0x1507B00", VA = "0x181508F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601BB4A RID: 113482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB4A")]
		[Address(RVA = "0x15086F0", Offset = "0x15072F0", VA = "0x1815086F0")]
		public void SetSeasonId(string str)
		{
		}

		// Token: 0x0601BB4B RID: 113483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB4B")]
		[Address(RVA = "0x1508780", Offset = "0x1507380", VA = "0x181508780")]
		public void SetStageId(string str)
		{
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x0601BB4C RID: 113484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041CB")]
		public override string musicSubSignal
		{
			[Token(Token = "0x601BB4C")]
			[Address(RVA = "0x1508D60", Offset = "0x1507960", VA = "0x181508D60", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BB4D RID: 113485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB4D")]
		[Address(RVA = "0x1508130", Offset = "0x1506D30", VA = "0x181508130", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601BB4E RID: 113486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB4E")]
		[Address(RVA = "0x1508080", Offset = "0x1506C80", VA = "0x181508080", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601BB4F RID: 113487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB4F")]
		[Address(RVA = "0x1508AF0", Offset = "0x15076F0", VA = "0x181508AF0")]
		private IEnumerator _RouteToProperState()
		{
			return null;
		}

		// Token: 0x0601BB50 RID: 113488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB50")]
		[Address(RVA = "0x1508C50", Offset = "0x1507850", VA = "0x181508C50")]
		private IEnumerator _RouteToSeasonSelect()
		{
			return null;
		}

		// Token: 0x0601BB51 RID: 113489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB51")]
		[Address(RVA = "0x1508BA0", Offset = "0x15077A0", VA = "0x181508BA0")]
		private IEnumerator _RouteToSeasonEntry()
		{
			return null;
		}

		// Token: 0x0601BB52 RID: 113490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB52")]
		[Address(RVA = "0x1508A40", Offset = "0x1507640", VA = "0x181508A40")]
		private IEnumerator _RogueToStageRune()
		{
			return null;
		}

		// Token: 0x0601BB53 RID: 113491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB53")]
		[Address(RVA = "0x1508810", Offset = "0x1507410", VA = "0x181508810")]
		private void _OnBackClick()
		{
		}

		// Token: 0x0601BB54 RID: 113492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB54")]
		[Address(RVA = "0x1508910", Offset = "0x1507510", VA = "0x181508910")]
		private void _OnTopMenuRouted(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x0601BB55 RID: 113493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB55")]
		[Address(RVA = "0x1508D00", Offset = "0x1507900", VA = "0x181508D00")]
		public RecalRunePage()
		{
		}

		// Token: 0x0601BB57 RID: 113495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB57")]
		[Address(RVA = "0x1508800", Offset = "0x1507400", VA = "0x181508800")]
		private string <>xLuaBaseProxy_get_musicSubSignal()
		{
			return null;
		}

		// Token: 0x0601BB58 RID: 113496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB58")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601BB59 RID: 113497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB59")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04024036 RID: 147510
		[Token(Token = "0x4024036")]
		private const string BUNDLE_KEY_SEASON_ID = "key_recal_rune_season_id";

		// Token: 0x04024037 RID: 147511
		[Token(Token = "0x4024037")]
		private const string BUNDLE_KEY_STAGE_ID = "key_recal_rune_stage_id";

		// Token: 0x04024038 RID: 147512
		[Token(Token = "0x4024038")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform _topMenuHolder;

		// Token: 0x04024039 RID: 147513
		[Token(Token = "0x4024039")]
		[FieldOffset(Offset = "0xF8")]
		private CommonTopMenu m_topMenuInstance;

		// Token: 0x0402403C RID: 147516
		[Token(Token = "0x402403C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateRecoverDataBundleForBattle;

		// Token: 0x0402403D RID: 147517
		[Token(Token = "0x402403D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SceneParamToStageRune;

		// Token: 0x0402403E RID: 147518
		[Token(Token = "0x402403E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_seasonId;

		// Token: 0x0402403F RID: 147519
		[Token(Token = "0x402403F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_seasonId;

		// Token: 0x04024040 RID: 147520
		[Token(Token = "0x4024040")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x04024041 RID: 147521
		[Token(Token = "0x4024041")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_stageId;

		// Token: 0x04024042 RID: 147522
		[Token(Token = "0x4024042")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetSeasonId;

		// Token: 0x04024043 RID: 147523
		[Token(Token = "0x4024043")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetStageId;

		// Token: 0x04024044 RID: 147524
		[Token(Token = "0x4024044")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_musicSubSignal;

		// Token: 0x04024045 RID: 147525
		[Token(Token = "0x4024045")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04024046 RID: 147526
		[Token(Token = "0x4024046")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04024047 RID: 147527
		[Token(Token = "0x4024047")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x04024048 RID: 147528
		[Token(Token = "0x4024048")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RouteToSeasonSelect;

		// Token: 0x04024049 RID: 147529
		[Token(Token = "0x4024049")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RouteToSeasonEntry;

		// Token: 0x0402404A RID: 147530
		[Token(Token = "0x402404A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RogueToStageRune;

		// Token: 0x0402404B RID: 147531
		[Token(Token = "0x402404B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x0402404C RID: 147532
		[Token(Token = "0x402404C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnTopMenuRouted;

		// Token: 0x0402404D RID: 147533
		[Token(Token = "0x402404D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004782 RID: 18306
		[Token(Token = "0x2004782")]
		public class Param
		{
			// Token: 0x0601BB5A RID: 113498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB5A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0402404E RID: 147534
			[Token(Token = "0x402404E")]
			[FieldOffset(Offset = "0x10")]
			public string seasonId;

			// Token: 0x0402404F RID: 147535
			[Token(Token = "0x402404F")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;
		}
	}
}
