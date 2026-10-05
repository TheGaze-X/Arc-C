using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200418D RID: 16781
	[Token(Token = "0x200418D")]
	public class SandboxV2DungeonCrossDayExpeditionSquadItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019E31 RID: 106033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E31")]
		[Address(RVA = "0x12C2230", Offset = "0x12C0E30", VA = "0x1812C2230")]
		public void Render(Sprite img)
		{
		}

		// Token: 0x06019E32 RID: 106034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E32")]
		[Address(RVA = "0x12C22B0", Offset = "0x12C0EB0", VA = "0x1812C22B0")]
		public SandboxV2DungeonCrossDayExpeditionSquadItemView()
		{
		}

		// Token: 0x040208E3 RID: 133347
		[Token(Token = "0x40208E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCharIcon;

		// Token: 0x040208E4 RID: 133348
		[Token(Token = "0x40208E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040208E5 RID: 133349
		[Token(Token = "0x40208E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
