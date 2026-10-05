using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036A8 RID: 13992
	[Token(Token = "0x20036A8")]
	public class CutinTemplateDecoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060163DE RID: 91102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163DE")]
		[Address(RVA = "0xEB2550", Offset = "0xEB1150", VA = "0x180EB2550")]
		public void Render(DataBundle data)
		{
		}

		// Token: 0x060163DF RID: 91103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163DF")]
		[Address(RVA = "0xEB2280", Offset = "0xEB0E80", VA = "0x180EB2280")]
		public void Hide([Optional] Action callback)
		{
		}

		// Token: 0x060163E0 RID: 91104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163E0")]
		[Address(RVA = "0xEB2470", Offset = "0xEB1070", VA = "0x180EB2470")]
		public void OnDestroy()
		{
		}

		// Token: 0x060163E1 RID: 91105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163E1")]
		[Address(RVA = "0xEB24E0", Offset = "0xEB10E0", VA = "0x180EB24E0")]
		public void OnDisable()
		{
		}

		// Token: 0x060163E2 RID: 91106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163E2")]
		[Address(RVA = "0xEB2710", Offset = "0xEB1310", VA = "0x180EB2710")]
		public CutinTemplateDecoView()
		{
		}

		// Token: 0x0401ABE8 RID: 109544
		[Token(Token = "0x401ABE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0401ABE9 RID: 109545
		[Token(Token = "0x401ABE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0401ABEA RID: 109546
		[Token(Token = "0x401ABEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401ABEB RID: 109547
		[Token(Token = "0x401ABEB")]
		private const float ALPHA_ZERO = 0f;

		// Token: 0x0401ABEC RID: 109548
		[Token(Token = "0x401ABEC")]
		private const float HIDE_DURATION = 0.5f;

		// Token: 0x0401ABED RID: 109549
		[Token(Token = "0x401ABED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Tween m_cachedTw;

		// Token: 0x0401ABEE RID: 109550
		[Token(Token = "0x401ABEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_cachedName;

		// Token: 0x0401ABEF RID: 109551
		[Token(Token = "0x401ABEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401ABF0 RID: 109552
		[Token(Token = "0x401ABF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401ABF1 RID: 109553
		[Token(Token = "0x401ABF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401ABF2 RID: 109554
		[Token(Token = "0x401ABF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401ABF3 RID: 109555
		[Token(Token = "0x401ABF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
