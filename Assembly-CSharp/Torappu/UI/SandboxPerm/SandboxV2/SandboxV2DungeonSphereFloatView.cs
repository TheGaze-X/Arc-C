using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004216 RID: 16918
	[Token(Token = "0x2004216")]
	public class SandboxV2DungeonSphereFloatView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A193 RID: 106899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A193")]
		[Address(RVA = "0x1301FB0", Offset = "0x1300BB0", VA = "0x181301FB0")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A194 RID: 106900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A194")]
		[Address(RVA = "0x1302100", Offset = "0x1300D00", VA = "0x181302100")]
		public void TutorialOnly_TryRaiseAVGSignal()
		{
		}

		// Token: 0x0601A195 RID: 106901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A195")]
		[Address(RVA = "0x13022B0", Offset = "0x1300EB0", VA = "0x1813022B0")]
		public SandboxV2DungeonSphereFloatView()
		{
		}

		// Token: 0x04020E9B RID: 134811
		[Token(Token = "0x4020E9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04020E9C RID: 134812
		[Token(Token = "0x4020E9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2DungeonSphereNormalView _normalView;

		// Token: 0x04020E9D RID: 134813
		[Token(Token = "0x4020E9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelRift;

		// Token: 0x04020E9E RID: 134814
		[Token(Token = "0x4020E9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2DungeonSphereRiftView _riftView;

		// Token: 0x04020E9F RID: 134815
		[Token(Token = "0x4020E9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelChallenge;

		// Token: 0x04020EA0 RID: 134816
		[Token(Token = "0x4020EA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2DungeonSphereChallengeView _challengeView;

		// Token: 0x04020EA1 RID: 134817
		[Token(Token = "0x4020EA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020EA2 RID: 134818
		[Token(Token = "0x4020EA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x04020EA3 RID: 134819
		[Token(Token = "0x4020EA3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
