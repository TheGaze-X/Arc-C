using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200684F RID: 26703
	[Token(Token = "0x200684F")]
	public class SixStarFogOnButton : StageFogOnButton
	{
		// Token: 0x06026390 RID: 156560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026390")]
		[Address(RVA = "0x21491A0", Offset = "0x2147DA0", VA = "0x1821491A0", Slot = "4")]
		public override void Render(StageFogInfo stageFogInfo)
		{
		}

		// Token: 0x06026391 RID: 156561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026391")]
		[Address(RVA = "0x2149250", Offset = "0x2147E50", VA = "0x182149250")]
		public SixStarFogOnButton()
		{
		}

		// Token: 0x04035E09 RID: 220681
		[Token(Token = "0x4035E09")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textLockInfo;

		// Token: 0x04035E0A RID: 220682
		[Token(Token = "0x4035E0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035E0B RID: 220683
		[Token(Token = "0x4035E0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
