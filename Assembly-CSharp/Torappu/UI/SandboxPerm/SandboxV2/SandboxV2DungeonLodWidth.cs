using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004167 RID: 16743
	[Token(Token = "0x2004167")]
	public class SandboxV2DungeonLodWidth : SandboxV2DungeonLodElement
	{
		// Token: 0x06019D74 RID: 105844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D74")]
		[Address(RVA = "0x12C6C90", Offset = "0x12C5890", VA = "0x1812C6C90", Slot = "5")]
		public override void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank, bool fastMode = false)
		{
		}

		// Token: 0x06019D75 RID: 105845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D75")]
		[Address(RVA = "0x12C6DD0", Offset = "0x12C59D0", VA = "0x1812C6DD0")]
		public SandboxV2DungeonLodWidth()
		{
		}

		// Token: 0x04020751 RID: 132945
		[Token(Token = "0x4020751")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minWidth;

		// Token: 0x04020752 RID: 132946
		[Token(Token = "0x4020752")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxWidth;

		// Token: 0x04020753 RID: 132947
		[Token(Token = "0x4020753")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLod;

		// Token: 0x04020754 RID: 132948
		[Token(Token = "0x4020754")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
