using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004036 RID: 16438
	[Token(Token = "0x2004036")]
	public class SandboxV2ExpeditionEnsureItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060196FF RID: 104191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196FF")]
		[Address(RVA = "0x12208E0", Offset = "0x121F4E0", VA = "0x1812208E0")]
		public void Render(bool isSelected)
		{
		}

		// Token: 0x06019700 RID: 104192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019700")]
		[Address(RVA = "0x1220AC0", Offset = "0x121F6C0", VA = "0x181220AC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019701 RID: 104193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019701")]
		[Address(RVA = "0x1220C10", Offset = "0x121F810", VA = "0x181220C10")]
		public SandboxV2ExpeditionEnsureItemView()
		{
		}

		// Token: 0x0401FAED RID: 129773
		[Token(Token = "0x401FAED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _selectedChar;

		// Token: 0x0401FAEE RID: 129774
		[Token(Token = "0x401FAEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _unselectedChar;

		// Token: 0x0401FAEF RID: 129775
		[Token(Token = "0x401FAEF")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401FAF0 RID: 129776
		[Token(Token = "0x401FAF0")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_unselectedTween;

		// Token: 0x0401FAF1 RID: 129777
		[Token(Token = "0x401FAF1")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_selectedTween;

		// Token: 0x0401FAF2 RID: 129778
		[Token(Token = "0x401FAF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FAF3 RID: 129779
		[Token(Token = "0x401FAF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FAF4 RID: 129780
		[Token(Token = "0x401FAF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
