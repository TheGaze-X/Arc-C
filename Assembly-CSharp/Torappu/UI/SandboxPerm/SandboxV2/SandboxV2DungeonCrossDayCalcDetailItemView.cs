using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200418B RID: 16779
	[Token(Token = "0x200418B")]
	public class SandboxV2DungeonCrossDayCalcDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019E2D RID: 106029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E2D")]
		[Address(RVA = "0x12C0CE0", Offset = "0x12BF8E0", VA = "0x1812C0CE0")]
		public void Render(SandboxV2DungeonCrossDayCalcDetailItemModel model)
		{
		}

		// Token: 0x06019E2E RID: 106030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E2E")]
		[Address(RVA = "0x12C0E00", Offset = "0x12BFA00", VA = "0x1812C0E00")]
		public SandboxV2DungeonCrossDayCalcDetailItemView()
		{
		}

		// Token: 0x040208DC RID: 133340
		[Token(Token = "0x40208DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x040208DD RID: 133341
		[Token(Token = "0x40208DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtScore;

		// Token: 0x040208DE RID: 133342
		[Token(Token = "0x40208DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objIsMax;

		// Token: 0x040208DF RID: 133343
		[Token(Token = "0x40208DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040208E0 RID: 133344
		[Token(Token = "0x40208E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
