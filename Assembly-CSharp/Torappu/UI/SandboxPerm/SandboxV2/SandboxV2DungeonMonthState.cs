using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041CA RID: 16842
	[Token(Token = "0x20041CA")]
	public class SandboxV2DungeonMonthState : PopupFadeState
	{
		// Token: 0x06019F58 RID: 106328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F58")]
		[Address(RVA = "0x12DBD50", Offset = "0x12DA950", VA = "0x1812DBD50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019F59 RID: 106329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F59")]
		[Address(RVA = "0x12DBDF0", Offset = "0x12DA9F0", VA = "0x1812DBDF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06019F5A RID: 106330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F5A")]
		[Address(RVA = "0x12DBE60", Offset = "0x12DAA60", VA = "0x1812DBE60", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x06019F5B RID: 106331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DD9")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x6019F5B")]
			[Address(RVA = "0x12DD1E0", Offset = "0x12DBDE0", VA = "0x1812DD1E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019F5C RID: 106332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F5C")]
		[Address(RVA = "0x12DCEE0", Offset = "0x12DBAE0", VA = "0x1812DCEE0")]
		private void _Refresh()
		{
		}

		// Token: 0x06019F5D RID: 106333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F5D")]
		[Address(RVA = "0x12DC560", Offset = "0x12DB160", VA = "0x1812DC560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019F5E RID: 106334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F5E")]
		[Address(RVA = "0x12DC870", Offset = "0x12DB470", VA = "0x1812DC870")]
		private void _LoadFromRuntime(SandboxV2DungeonMonthState.StateRuntime runtime)
		{
		}

		// Token: 0x06019F5F RID: 106335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F5F")]
		[Address(RVA = "0x12DCD50", Offset = "0x12DB950", VA = "0x1812DCD50")]
		private void _OnJumpToNodeStagePreview(IStateBean stateBean)
		{
		}

		// Token: 0x06019F60 RID: 106336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F60")]
		[Address(RVA = "0x12DCAE0", Offset = "0x12DB6E0", VA = "0x1812DCAE0")]
		private void _OnJumpToDungeonSquad(IStateBean stateBean)
		{
		}

		// Token: 0x06019F61 RID: 106337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F61")]
		[Address(RVA = "0x12DC420", Offset = "0x12DB020", VA = "0x1812DC420")]
		private SandboxV2DungeonNodeViewModel _GetCurrentNodeViewModel(SandboxV2DungeonController controller)
		{
			return null;
		}

		// Token: 0x06019F62 RID: 106338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F62")]
		[Address(RVA = "0x12DC040", Offset = "0x12DAC40", VA = "0x1812DC040")]
		private void _EventOnOpenEnemy()
		{
		}

		// Token: 0x06019F63 RID: 106339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F63")]
		[Address(RVA = "0x12DC1C0", Offset = "0x12DADC0", VA = "0x1812DC1C0")]
		private void _EventOnOpenMap()
		{
		}

		// Token: 0x06019F64 RID: 106340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F64")]
		[Address(RVA = "0x12DC2F0", Offset = "0x12DAEF0", VA = "0x1812DC2F0")]
		private void _EventOnStartBattle()
		{
		}

		// Token: 0x06019F65 RID: 106341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F65")]
		[Address(RVA = "0x12DBCF0", Offset = "0x12DA8F0", VA = "0x1812DBCF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019F66 RID: 106342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F66")]
		[Address(RVA = "0x12DD180", Offset = "0x12DBD80", VA = "0x1812DD180")]
		public SandboxV2DungeonMonthState()
		{
		}

		// Token: 0x06019F67 RID: 106343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F67")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019F68 RID: 106344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F68")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06019F69 RID: 106345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F69")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019F6A RID: 106346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F6A")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x04020B2B RID: 133931
		[Token(Token = "0x4020B2B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2DungeonMonthView _view;

		// Token: 0x04020B2C RID: 133932
		[Token(Token = "0x4020B2C")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonMonthModelProperty m_prop;

		// Token: 0x04020B2D RID: 133933
		[Token(Token = "0x4020B2D")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020B2E RID: 133934
		[Token(Token = "0x4020B2E")]
		[FieldOffset(Offset = "0x90")]
		private StateCacheHandler<SandboxV2DungeonMonthState.StateRuntime> m_runtimeHandler;

		// Token: 0x04020B2F RID: 133935
		[Token(Token = "0x4020B2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020B30 RID: 133936
		[Token(Token = "0x4020B30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020B31 RID: 133937
		[Token(Token = "0x4020B31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04020B32 RID: 133938
		[Token(Token = "0x4020B32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04020B33 RID: 133939
		[Token(Token = "0x4020B33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x04020B34 RID: 133940
		[Token(Token = "0x4020B34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020B35 RID: 133941
		[Token(Token = "0x4020B35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadFromRuntime;

		// Token: 0x04020B36 RID: 133942
		[Token(Token = "0x4020B36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToNodeStagePreview;

		// Token: 0x04020B37 RID: 133943
		[Token(Token = "0x4020B37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToDungeonSquad;

		// Token: 0x04020B38 RID: 133944
		[Token(Token = "0x4020B38")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetCurrentNodeViewModel;

		// Token: 0x04020B39 RID: 133945
		[Token(Token = "0x4020B39")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnOpenEnemy;

		// Token: 0x04020B3A RID: 133946
		[Token(Token = "0x4020B3A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnOpenMap;

		// Token: 0x04020B3B RID: 133947
		[Token(Token = "0x4020B3B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnStartBattle;

		// Token: 0x04020B3C RID: 133948
		[Token(Token = "0x4020B3C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020B3D RID: 133949
		[Token(Token = "0x4020B3D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041CB RID: 16843
		[Token(Token = "0x20041CB")]
		public class StateRuntime
		{
			// Token: 0x06019F6B RID: 106347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019F6B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateRuntime()
			{
			}

			// Token: 0x04020B3E RID: 133950
			[Token(Token = "0x4020B3E")]
			[FieldOffset(Offset = "0x10")]
			public string monthlyRushId;
		}
	}
}
