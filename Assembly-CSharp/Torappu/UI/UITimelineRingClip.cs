using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036D7 RID: 14039
	[Token(Token = "0x20036D7")]
	public class UITimelineRingClip : IHotfixable
	{
		// Token: 0x060164ED RID: 91373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164ED")]
		[Address(RVA = "0xEBEC60", Offset = "0xEBD860", VA = "0x180EBEC60")]
		public UITimelineRingClip(PlayableDirector director)
		{
		}

		// Token: 0x060164EE RID: 91374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164EE")]
		[Address(RVA = "0xEBE4A0", Offset = "0xEBD0A0", VA = "0x180EBE4A0")]
		public void SetAssets(UnityEngine.Object forwardAsset, UnityEngine.Object backwardAsset, string mainId)
		{
		}

		// Token: 0x060164EF RID: 91375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164EF")]
		[Address(RVA = "0xEBDFA0", Offset = "0xEBCBA0", VA = "0x180EBDFA0")]
		public void Clear(bool bClearBindTargets)
		{
		}

		// Token: 0x060164F0 RID: 91376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164F0")]
		[Address(RVA = "0xEBE560", Offset = "0xEBD160", VA = "0x180EBE560")]
		public void SetBinding(string name, UnityEngine.Object target)
		{
		}

		// Token: 0x060164F1 RID: 91377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164F1")]
		[Address(RVA = "0xEBE3F0", Offset = "0xEBCFF0", VA = "0x180EBE3F0")]
		public void ResetToState(string stateId)
		{
		}

		// Token: 0x060164F2 RID: 91378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164F2")]
		[Address(RVA = "0xEBE6B0", Offset = "0xEBD2B0", VA = "0x180EBE6B0")]
		public void TransToState(string stateId, bool isForward)
		{
		}

		// Token: 0x060164F3 RID: 91379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164F3")]
		[Address(RVA = "0xEBE620", Offset = "0xEBD220", VA = "0x180EBE620")]
		public void StopAll()
		{
		}

		// Token: 0x060164F4 RID: 91380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164F4")]
		[Address(RVA = "0xEBE830", Offset = "0xEBD430", VA = "0x180EBE830")]
		private void _SetAssetToStateMachine(string mainId, UnityEngine.Object asset, UITimelineRingStateMachine stateMachine)
		{
		}

		// Token: 0x0401AD49 RID: 109897
		[Token(Token = "0x401AD49")]
		[FieldOffset(Offset = "0x10")]
		private UITimelineRingStateMachine m_forwardStateMachine;

		// Token: 0x0401AD4A RID: 109898
		[Token(Token = "0x401AD4A")]
		[FieldOffset(Offset = "0x18")]
		private UITimelineRingStateMachine m_backwardStateMachine;

		// Token: 0x0401AD4B RID: 109899
		[Token(Token = "0x401AD4B")]
		[FieldOffset(Offset = "0x20")]
		private string m_currStateId;

		// Token: 0x0401AD4C RID: 109900
		[Token(Token = "0x401AD4C")]
		[FieldOffset(Offset = "0x28")]
		private PlayableDirector m_cachedDirector;

		// Token: 0x0401AD4D RID: 109901
		[Token(Token = "0x401AD4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401AD4E RID: 109902
		[Token(Token = "0x401AD4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetAssets;

		// Token: 0x0401AD4F RID: 109903
		[Token(Token = "0x401AD4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0401AD50 RID: 109904
		[Token(Token = "0x401AD50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetBinding;

		// Token: 0x0401AD51 RID: 109905
		[Token(Token = "0x401AD51")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401AD52 RID: 109906
		[Token(Token = "0x401AD52")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TransToState;

		// Token: 0x0401AD53 RID: 109907
		[Token(Token = "0x401AD53")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopAll;

		// Token: 0x0401AD54 RID: 109908
		[Token(Token = "0x401AD54")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetAssetToStateMachine;
	}
}
