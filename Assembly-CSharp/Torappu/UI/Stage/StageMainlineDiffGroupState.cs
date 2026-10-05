using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200687F RID: 26751
	[Token(Token = "0x200687F")]
	public class StageMainlineDiffGroupState : PopupFloatState
	{
		// Token: 0x06026504 RID: 156932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026504")]
		[Address(RVA = "0x2161D70", Offset = "0x2160970", VA = "0x182161D70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026505 RID: 156933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026505")]
		[Address(RVA = "0x2161DD0", Offset = "0x21609D0", VA = "0x182161DD0")]
		public void OnDiffClick(StageDiffGroup diffGroup)
		{
		}

		// Token: 0x06026506 RID: 156934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026506")]
		[Address(RVA = "0x21622B0", Offset = "0x2160EB0", VA = "0x1821622B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026507 RID: 156935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026507")]
		[Address(RVA = "0x2161E70", Offset = "0x2160A70", VA = "0x182161E70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026508 RID: 156936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026508")]
		[Address(RVA = "0x2162050", Offset = "0x2160C50", VA = "0x182162050", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06026509 RID: 156937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026509")]
		[Address(RVA = "0x2162110", Offset = "0x2160D10", VA = "0x182162110", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602650A RID: 156938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602650A")]
		[Address(RVA = "0x21623E0", Offset = "0x2160FE0", VA = "0x1821623E0")]
		public StageMainlineDiffGroupState()
		{
		}

		// Token: 0x0602650C RID: 156940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602650C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602650D RID: 156941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602650D")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0602650E RID: 156942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602650E")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04035F85 RID: 221061
		[Token(Token = "0x4035F85")]
		[FieldOffset(Offset = "0x70")]
		private StageMainlineDiffGroupStateBean m_stateBean;

		// Token: 0x04035F86 RID: 221062
		[Token(Token = "0x4035F86")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DynamicPrefabInstHolder _viewInstHolder;

		// Token: 0x04035F87 RID: 221063
		[Token(Token = "0x4035F87")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _backBtn;

		// Token: 0x04035F88 RID: 221064
		[Token(Token = "0x4035F88")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04035F89 RID: 221065
		[Token(Token = "0x4035F89")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("Block the events when state changes")]
		protected GameObject _globalEventMask;

		// Token: 0x04035F8A RID: 221066
		[Token(Token = "0x4035F8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035F8B RID: 221067
		[Token(Token = "0x4035F8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDiffClick;

		// Token: 0x04035F8C RID: 221068
		[Token(Token = "0x4035F8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035F8D RID: 221069
		[Token(Token = "0x4035F8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035F8E RID: 221070
		[Token(Token = "0x4035F8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04035F8F RID: 221071
		[Token(Token = "0x4035F8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035F90 RID: 221072
		[Token(Token = "0x4035F90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
