using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055AA RID: 21930
	[Token(Token = "0x20055AA")]
	public class RL05CopperPackageListPatternView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020342 RID: 131906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020342")]
		[Address(RVA = "0x1A4D5F0", Offset = "0x1A4C1F0", VA = "0x181A4D5F0")]
		public void Render(RL05CopperPackageListPatternView.PatternType ptype)
		{
		}

		// Token: 0x06020343 RID: 131907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020343")]
		[Address(RVA = "0x1A4D690", Offset = "0x1A4C290", VA = "0x181A4D690")]
		public RL05CopperPackageListPatternView()
		{
		}

		// Token: 0x0402B8C1 RID: 178369
		[Token(Token = "0x402B8C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _firstNode;

		// Token: 0x0402B8C2 RID: 178370
		[Token(Token = "0x402B8C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _midNode;

		// Token: 0x0402B8C3 RID: 178371
		[Token(Token = "0x402B8C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lastNode;

		// Token: 0x0402B8C4 RID: 178372
		[Token(Token = "0x402B8C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B8C5 RID: 178373
		[Token(Token = "0x402B8C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055AB RID: 21931
		[Token(Token = "0x20055AB")]
		public enum PatternType
		{
			// Token: 0x0402B8C7 RID: 178375
			[Token(Token = "0x402B8C7")]
			ONLY,
			// Token: 0x0402B8C8 RID: 178376
			[Token(Token = "0x402B8C8")]
			FIRST,
			// Token: 0x0402B8C9 RID: 178377
			[Token(Token = "0x402B8C9")]
			MID,
			// Token: 0x0402B8CA RID: 178378
			[Token(Token = "0x402B8CA")]
			LAST
		}
	}
}
