using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004164 RID: 16740
	[Token(Token = "0x2004164")]
	public class SandboxV2DungeonLodRaycast : SandboxV2DungeonLodElement
	{
		// Token: 0x06019D6E RID: 105838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D6E")]
		[Address(RVA = "0x12C6800", Offset = "0x12C5400", VA = "0x1812C6800", Slot = "5")]
		public override void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank, bool fastMode = false)
		{
		}

		// Token: 0x06019D6F RID: 105839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D6F")]
		[Address(RVA = "0x12C68F0", Offset = "0x12C54F0", VA = "0x1812C68F0")]
		public SandboxV2DungeonLodRaycast()
		{
		}

		// Token: 0x04020745 RID: 132933
		[Token(Token = "0x4020745")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool[] _enabled;

		// Token: 0x04020746 RID: 132934
		[Token(Token = "0x4020746")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _raycastHandler;

		// Token: 0x04020747 RID: 132935
		[Token(Token = "0x4020747")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLod;

		// Token: 0x04020748 RID: 132936
		[Token(Token = "0x4020748")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
