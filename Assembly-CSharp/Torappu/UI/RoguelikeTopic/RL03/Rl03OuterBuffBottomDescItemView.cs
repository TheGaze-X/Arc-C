using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045C2 RID: 17858
	[Token(Token = "0x20045C2")]
	public class Rl03OuterBuffBottomDescItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B2C6 RID: 111302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2C6")]
		[Address(RVA = "0x14545B0", Offset = "0x14531B0", VA = "0x1814545B0")]
		public void Render(string desc)
		{
		}

		// Token: 0x0601B2C7 RID: 111303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2C7")]
		[Address(RVA = "0x1454690", Offset = "0x1453290", VA = "0x181454690")]
		public Rl03OuterBuffBottomDescItemView()
		{
		}

		// Token: 0x04022FFC RID: 143356
		[Token(Token = "0x4022FFC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04022FFD RID: 143357
		[Token(Token = "0x4022FFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022FFE RID: 143358
		[Token(Token = "0x4022FFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
