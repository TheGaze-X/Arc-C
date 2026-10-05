using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006784 RID: 26500
	[Token(Token = "0x2006784")]
	public class MainlineDiffGroupRewardState : State
	{
		// Token: 0x06026037 RID: 155703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026037")]
		[Address(RVA = "0x20FB750", Offset = "0x20FA350", VA = "0x1820FB750", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026038 RID: 155704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026038")]
		[Address(RVA = "0x20FB7B0", Offset = "0x20FA3B0", VA = "0x1820FB7B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026039 RID: 155705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026039")]
		[Address(RVA = "0x20FC070", Offset = "0x20FAC70", VA = "0x1820FC070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602603A RID: 155706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602603A")]
		[Address(RVA = "0x20FB970", Offset = "0x20FA570", VA = "0x1820FB970")]
		public void OnGoToSquad()
		{
		}

		// Token: 0x0602603B RID: 155707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602603B")]
		[Address(RVA = "0x20FBBC0", Offset = "0x20FA7C0", VA = "0x1820FBBC0")]
		public void OnRewardClick(string stageId)
		{
		}

		// Token: 0x0602603C RID: 155708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602603C")]
		[Address(RVA = "0x20FBD20", Offset = "0x20FA920", VA = "0x1820FBD20", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602603D RID: 155709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602603D")]
		[Address(RVA = "0x20FC190", Offset = "0x20FAD90", VA = "0x1820FC190")]
		public MainlineDiffGroupRewardState()
		{
		}

		// Token: 0x06026040 RID: 155712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026040")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026041 RID: 155713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026041")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403579E RID: 219038
		[Token(Token = "0x403579E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MainlineDiffGroupRewardView _rewardView;

		// Token: 0x0403579F RID: 219039
		[Token(Token = "0x403579F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _backPress;

		// Token: 0x040357A0 RID: 219040
		[Token(Token = "0x40357A0")]
		[FieldOffset(Offset = "0x60")]
		private string m_cacheStageId;

		// Token: 0x040357A1 RID: 219041
		[Token(Token = "0x40357A1")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x040357A2 RID: 219042
		[Token(Token = "0x40357A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040357A3 RID: 219043
		[Token(Token = "0x40357A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040357A4 RID: 219044
		[Token(Token = "0x40357A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040357A5 RID: 219045
		[Token(Token = "0x40357A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGoToSquad;

		// Token: 0x040357A6 RID: 219046
		[Token(Token = "0x40357A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRewardClick;

		// Token: 0x040357A7 RID: 219047
		[Token(Token = "0x40357A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040357A8 RID: 219048
		[Token(Token = "0x40357A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
