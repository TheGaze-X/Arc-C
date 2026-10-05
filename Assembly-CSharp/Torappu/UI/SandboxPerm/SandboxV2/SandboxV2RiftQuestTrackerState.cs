using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200421D RID: 16925
	[Token(Token = "0x200421D")]
	public class SandboxV2RiftQuestTrackerState : SandboxV2TrackerState
	{
		// Token: 0x0601A1C0 RID: 106944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C0")]
		[Address(RVA = "0x130F500", Offset = "0x130E100", VA = "0x18130F500", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A1C1 RID: 106945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A1C1")]
		[Address(RVA = "0x130F4A0", Offset = "0x130E0A0", VA = "0x18130F4A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A1C2 RID: 106946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C2")]
		[Address(RVA = "0x130F850", Offset = "0x130E450", VA = "0x18130F850")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1C3 RID: 106947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C3")]
		[Address(RVA = "0x130F8F0", Offset = "0x130E4F0", VA = "0x18130F8F0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601A1C4 RID: 106948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C4")]
		[Address(RVA = "0x130F9F0", Offset = "0x130E5F0", VA = "0x18130F9F0")]
		private void _UpdateData()
		{
		}

		// Token: 0x0601A1C5 RID: 106949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C5")]
		[Address(RVA = "0x130FB90", Offset = "0x130E790", VA = "0x18130FB90")]
		public SandboxV2RiftQuestTrackerState()
		{
		}

		// Token: 0x0601A1C6 RID: 106950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C6")]
		[Address(RVA = "0x1304000", Offset = "0x1302C00", VA = "0x181304000")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04020EFD RID: 134909
		[Token(Token = "0x4020EFD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04020EFE RID: 134910
		[Token(Token = "0x4020EFE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SandboxV2RiftQuestTrackerView _view;

		// Token: 0x04020EFF RID: 134911
		[Token(Token = "0x4020EFF")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04020F00 RID: 134912
		[Token(Token = "0x4020F00")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_enterTween;

		// Token: 0x04020F01 RID: 134913
		[Token(Token = "0x4020F01")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2RiftQuestTrackerProperty m_property;

		// Token: 0x04020F02 RID: 134914
		[Token(Token = "0x4020F02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020F03 RID: 134915
		[Token(Token = "0x4020F03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020F04 RID: 134916
		[Token(Token = "0x4020F04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F05 RID: 134917
		[Token(Token = "0x4020F05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04020F06 RID: 134918
		[Token(Token = "0x4020F06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04020F07 RID: 134919
		[Token(Token = "0x4020F07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
