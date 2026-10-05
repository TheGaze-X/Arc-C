using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200415E RID: 16734
	[Token(Token = "0x200415E")]
	public class SandboxV2DungeonLodAlpha : SandboxV2DungeonLodElement
	{
		// Token: 0x06019D5C RID: 105820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D5C")]
		[Address(RVA = "0x12B2670", Offset = "0x12B1270", VA = "0x1812B2670", Slot = "5")]
		public override void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank, bool fastMode = false)
		{
		}

		// Token: 0x06019D5D RID: 105821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D5D")]
		[Address(RVA = "0x12B2740", Offset = "0x12B1340", VA = "0x1812B2740")]
		public SandboxV2DungeonLodAlpha()
		{
		}

		// Token: 0x04020721 RID: 132897
		[Token(Token = "0x4020721")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04020722 RID: 132898
		[Token(Token = "0x4020722")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _alphaMin;

		// Token: 0x04020723 RID: 132899
		[Token(Token = "0x4020723")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _alphaMax;

		// Token: 0x04020724 RID: 132900
		[Token(Token = "0x4020724")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLod;

		// Token: 0x04020725 RID: 132901
		[Token(Token = "0x4020725")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
