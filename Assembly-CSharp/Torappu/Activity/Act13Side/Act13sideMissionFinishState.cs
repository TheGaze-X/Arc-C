using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F5 RID: 31221
	[Token(Token = "0x20079F5")]
	public class Act13sideMissionFinishState : PopupFloatState
	{
		// Token: 0x0602BC40 RID: 179264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC40")]
		[Address(RVA = "0x27B7290", Offset = "0x27B5E90", VA = "0x1827B7290")]
		private void _InitPromoteView()
		{
		}

		// Token: 0x0602BC41 RID: 179265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC41")]
		[Address(RVA = "0x27B6CC0", Offset = "0x27B58C0", VA = "0x1827B6CC0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BC42 RID: 179266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC42")]
		[Address(RVA = "0x27B6D20", Offset = "0x27B5920", VA = "0x1827B6D20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BC43 RID: 179267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC43")]
		[Address(RVA = "0x27B7160", Offset = "0x27B5D60", VA = "0x1827B7160")]
		public void ToNextOrDismiss()
		{
		}

		// Token: 0x0602BC44 RID: 179268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC44")]
		[Address(RVA = "0x27B7390", Offset = "0x27B5F90", VA = "0x1827B7390")]
		private void _RenderCurrent()
		{
		}

		// Token: 0x0602BC45 RID: 179269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC45")]
		[Address(RVA = "0x27B7520", Offset = "0x27B6120", VA = "0x1827B7520")]
		public Act13sideMissionFinishState()
		{
		}

		// Token: 0x0602BC47 RID: 179271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC47")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403F512 RID: 259346
		[Token(Token = "0x403F512")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act13sideFinishMissionView _missionView;

		// Token: 0x0403F513 RID: 259347
		[Token(Token = "0x403F513")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act13sidePrestigePromoteView _promoteView;

		// Token: 0x0403F514 RID: 259348
		[Token(Token = "0x403F514")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403F515 RID: 259349
		[Token(Token = "0x403F515")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<string, Act13SideData.LongTermMissionData> m_missionDataGroup;

		// Token: 0x0403F516 RID: 259350
		[Token(Token = "0x403F516")]
		[FieldOffset(Offset = "0x90")]
		private Act13sideMissionFinishViewModel m_cacheModel;

		// Token: 0x0403F517 RID: 259351
		[Token(Token = "0x403F517")]
		[FieldOffset(Offset = "0x98")]
		private int m_cacheIndex;

		// Token: 0x0403F518 RID: 259352
		[Token(Token = "0x403F518")]
		[FieldOffset(Offset = "0x9C")]
		private int m_currentPer;

		// Token: 0x0403F519 RID: 259353
		[Token(Token = "0x403F519")]
		[FieldOffset(Offset = "0xA0")]
		private int m_finishPer;

		// Token: 0x0403F51A RID: 259354
		[Token(Token = "0x403F51A")]
		[FieldOffset(Offset = "0xA8")]
		private Act13sidePrestigePromoteView m_promoteView;

		// Token: 0x0403F51B RID: 259355
		[Token(Token = "0x403F51B")]
		[FieldOffset(Offset = "0xB0")]
		private string m_actId;

		// Token: 0x0403F51C RID: 259356
		[Token(Token = "0x403F51C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitPromoteView;

		// Token: 0x0403F51D RID: 259357
		[Token(Token = "0x403F51D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F51E RID: 259358
		[Token(Token = "0x403F51E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F51F RID: 259359
		[Token(Token = "0x403F51F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToNextOrDismiss;

		// Token: 0x0403F520 RID: 259360
		[Token(Token = "0x403F520")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCurrent;

		// Token: 0x0403F521 RID: 259361
		[Token(Token = "0x403F521")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
