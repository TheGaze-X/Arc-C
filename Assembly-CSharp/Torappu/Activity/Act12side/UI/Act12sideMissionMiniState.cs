using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A98 RID: 31384
	[Token(Token = "0x2007A98")]
	public class Act12sideMissionMiniState : PopupFloatState
	{
		// Token: 0x1700670C RID: 26380
		// (get) Token: 0x0602BF7E RID: 180094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700670C")]
		protected string activityId
		{
			[Token(Token = "0x602BF7E")]
			[Address(RVA = "0x27E0880", Offset = "0x27DF480", VA = "0x1827E0880")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700670D RID: 26381
		// (get) Token: 0x0602BF7F RID: 180095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700670D")]
		protected Act12sideStageController actController
		{
			[Token(Token = "0x602BF7F")]
			[Address(RVA = "0x27E07D0", Offset = "0x27DF3D0", VA = "0x1827E07D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BF80 RID: 180096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF80")]
		[Address(RVA = "0x27E01F0", Offset = "0x27DEDF0", VA = "0x1827E01F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF81 RID: 180097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF81")]
		[Address(RVA = "0x27E0190", Offset = "0x27DED90", VA = "0x1827E0190", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF82 RID: 180098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF82")]
		[Address(RVA = "0x27E0640", Offset = "0x27DF240", VA = "0x1827E0640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BF83 RID: 180099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF83")]
		[Address(RVA = "0x27E04E0", Offset = "0x27DF0E0", VA = "0x1827E04E0")]
		private void _FetchStageController()
		{
		}

		// Token: 0x0602BF84 RID: 180100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF84")]
		[Address(RVA = "0x27E0770", Offset = "0x27DF370", VA = "0x1827E0770")]
		public Act12sideMissionMiniState()
		{
		}

		// Token: 0x0602BF85 RID: 180101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF85")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403FAF9 RID: 260857
		[Token(Token = "0x403FAF9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act12sideMissionMiniView _view;

		// Token: 0x0403FAFA RID: 260858
		[Token(Token = "0x403FAFA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x0403FAFB RID: 260859
		[Token(Token = "0x403FAFB")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403FAFC RID: 260860
		[Token(Token = "0x403FAFC")]
		[FieldOffset(Offset = "0x88")]
		private Act12sideStageController m_stageController;

		// Token: 0x0403FAFD RID: 260861
		[Token(Token = "0x403FAFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403FAFE RID: 260862
		[Token(Token = "0x403FAFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403FAFF RID: 260863
		[Token(Token = "0x403FAFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FB00 RID: 260864
		[Token(Token = "0x403FB00")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FB01 RID: 260865
		[Token(Token = "0x403FB01")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FB02 RID: 260866
		[Token(Token = "0x403FB02")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FetchStageController;

		// Token: 0x0403FB03 RID: 260867
		[Token(Token = "0x403FB03")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
