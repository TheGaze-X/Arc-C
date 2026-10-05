using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004163 RID: 16739
	[Token(Token = "0x2004163")]
	public abstract class SandboxV2DungeonLodElement : MonoBehaviour, ISandboxV2DungeonLodElement, IHotfixable
	{
		// Token: 0x06019D6A RID: 105834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D6A")]
		[Address(RVA = "0x12B3430", Offset = "0x12B2030", VA = "0x1812B3430")]
		private void OnEnable()
		{
		}

		// Token: 0x06019D6B RID: 105835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D6B")]
		[Address(RVA = "0x12B32E0", Offset = "0x12B1EE0", VA = "0x1812B32E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06019D6C RID: 105836
		[Token(Token = "0x6019D6C")]
		public abstract void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank, bool fastMode = false);

		// Token: 0x06019D6D RID: 105837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D6D")]
		[Address(RVA = "0x12B3610", Offset = "0x12B2210", VA = "0x1812B3610")]
		protected SandboxV2DungeonLodElement()
		{
		}

		// Token: 0x04020741 RID: 132929
		[Token(Token = "0x4020741")]
		[FieldOffset(Offset = "0x18")]
		private SandboxV2DungeonLodController m_lodController;

		// Token: 0x04020742 RID: 132930
		[Token(Token = "0x4020742")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04020743 RID: 132931
		[Token(Token = "0x4020743")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04020744 RID: 132932
		[Token(Token = "0x4020744")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
