using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200415B RID: 16731
	[Token(Token = "0x200415B")]
	public class SandboxV2DungeonCullController : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D52 RID: 105810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D52")]
		[Address(RVA = "0x12B1FE0", Offset = "0x12B0BE0", VA = "0x1812B1FE0")]
		public void Watch(ISandboxV2DungeonCullElement element)
		{
		}

		// Token: 0x06019D53 RID: 105811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D53")]
		[Address(RVA = "0x12B1F60", Offset = "0x12B0B60", VA = "0x1812B1F60")]
		public void Unwatch(ISandboxV2DungeonCullElement element)
		{
		}

		// Token: 0x06019D54 RID: 105812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D54")]
		[Address(RVA = "0x12B2060", Offset = "0x12B0C60", VA = "0x1812B2060")]
		public SandboxV2DungeonCullController()
		{
		}

		// Token: 0x04020713 RID: 132883
		[Token(Token = "0x4020713")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2DungeonCameraController _cameraController;

		// Token: 0x04020714 RID: 132884
		[Token(Token = "0x4020714")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Watch;

		// Token: 0x04020715 RID: 132885
		[Token(Token = "0x4020715")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Unwatch;

		// Token: 0x04020716 RID: 132886
		[Token(Token = "0x4020716")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
