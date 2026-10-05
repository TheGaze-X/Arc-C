using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061AF RID: 25007
	[Token(Token = "0x20061AF")]
	public class BossRushStageChooseState : PopupFadeState
	{
		// Token: 0x06024162 RID: 147810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024162")]
		[Address(RVA = "0x1EC3D60", Offset = "0x1EC2960", VA = "0x181EC3D60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024163 RID: 147811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024163")]
		[Address(RVA = "0x1EC3DC0", Offset = "0x1EC29C0", VA = "0x181EC3DC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06024164 RID: 147812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024164")]
		[Address(RVA = "0x1EC3E40", Offset = "0x1EC2A40", VA = "0x181EC3E40", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06024165 RID: 147813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024165")]
		[Address(RVA = "0x1EC3EC0", Offset = "0x1EC2AC0", VA = "0x181EC3EC0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06024166 RID: 147814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024166")]
		[Address(RVA = "0x1EC4290", Offset = "0x1EC2E90", VA = "0x181EC4290")]
		private void _OnJumpToStageDetail(IStateBean stateBean)
		{
		}

		// Token: 0x06024167 RID: 147815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024167")]
		[Address(RVA = "0x1EC43B0", Offset = "0x1EC2FB0", VA = "0x181EC43B0")]
		private void _OnStageGroupClicked(string stageGroupId)
		{
		}

		// Token: 0x06024168 RID: 147816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024168")]
		[Address(RVA = "0x1EC40A0", Offset = "0x1EC2CA0", VA = "0x181EC40A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024169 RID: 147817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024169")]
		[Address(RVA = "0x1EC4580", Offset = "0x1EC3180", VA = "0x181EC4580")]
		private void _RefreshView(bool showEnterAnim = false)
		{
		}

		// Token: 0x0602416A RID: 147818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602416A")]
		[Address(RVA = "0x1EC4780", Offset = "0x1EC3380", VA = "0x181EC4780")]
		public BossRushStageChooseState()
		{
		}

		// Token: 0x0602416C RID: 147820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602416C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602416D RID: 147821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602416D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602416E RID: 147822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602416E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04032267 RID: 205415
		[Token(Token = "0x4032267")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BossRushStageChooseButtonGroupView _btnGroupView;

		// Token: 0x04032268 RID: 205416
		[Token(Token = "0x4032268")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BossRushStageChooseProgressView _progressView;

		// Token: 0x04032269 RID: 205417
		[Token(Token = "0x4032269")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topContainer;

		// Token: 0x0403226A RID: 205418
		[Token(Token = "0x403226A")]
		[FieldOffset(Offset = "0x88")]
		private BossRushStageChooseStateBean m_stateBean;

		// Token: 0x0403226B RID: 205419
		[Token(Token = "0x403226B")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0403226C RID: 205420
		[Token(Token = "0x403226C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403226D RID: 205421
		[Token(Token = "0x403226D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403226E RID: 205422
		[Token(Token = "0x403226E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403226F RID: 205423
		[Token(Token = "0x403226F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04032270 RID: 205424
		[Token(Token = "0x4032270")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToStageDetail;

		// Token: 0x04032271 RID: 205425
		[Token(Token = "0x4032271")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStageGroupClicked;

		// Token: 0x04032272 RID: 205426
		[Token(Token = "0x4032272")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032273 RID: 205427
		[Token(Token = "0x4032273")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x04032274 RID: 205428
		[Token(Token = "0x4032274")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
