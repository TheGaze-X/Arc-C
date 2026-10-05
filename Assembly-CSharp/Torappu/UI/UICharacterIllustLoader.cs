using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200353B RID: 13627
	[Token(Token = "0x200353B")]
	public class UICharacterIllustLoader : PageAssetPool<Image>, IUICharacterIllustLoader
	{
		// Token: 0x06015B94 RID: 88980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B94")]
		[Address(RVA = "0xE4EE60", Offset = "0xE4DA60", VA = "0x180E4EE60", Slot = "13")]
		public Image ControllerOnlyLoadChrIllust(CharUISkinStruct skin, [Optional] Transform parent)
		{
			return null;
		}

		// Token: 0x06015B95 RID: 88981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B95")]
		[Address(RVA = "0xE4F070", Offset = "0xE4DC70", VA = "0x180E4F070")]
		public Image ControllerOnlyLoadNpcIllust(UICharacterIllustController.NPCConfig npcConfig)
		{
			return null;
		}

		// Token: 0x06015B96 RID: 88982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B96")]
		[Address(RVA = "0xE4F2D0", Offset = "0xE4DED0", VA = "0x180E4F2D0")]
		public UICharacterIllustLoader()
		{
		}

		// Token: 0x0401A180 RID: 106880
		[Token(Token = "0x401A180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ControllerOnlyLoadChrIllust;

		// Token: 0x0401A181 RID: 106881
		[Token(Token = "0x401A181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ControllerOnlyLoadNpcIllust;

		// Token: 0x0401A182 RID: 106882
		[Token(Token = "0x401A182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
