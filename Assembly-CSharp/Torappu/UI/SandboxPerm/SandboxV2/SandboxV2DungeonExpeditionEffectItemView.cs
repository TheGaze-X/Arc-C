using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004201 RID: 16897
	[Token(Token = "0x2004201")]
	public class SandboxV2DungeonExpeditionEffectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A135 RID: 106805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A135")]
		[Address(RVA = "0x12EAE30", Offset = "0x12E9A30", VA = "0x1812EAE30")]
		public void Render(string avatarId)
		{
		}

		// Token: 0x0601A136 RID: 106806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A136")]
		[Address(RVA = "0x12EAEE0", Offset = "0x12E9AE0", VA = "0x1812EAEE0")]
		public SandboxV2DungeonExpeditionEffectItemView()
		{
		}

		// Token: 0x04020D9E RID: 134558
		[Token(Token = "0x4020D9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x04020D9F RID: 134559
		[Token(Token = "0x4020D9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020DA0 RID: 134560
		[Token(Token = "0x4020DA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
