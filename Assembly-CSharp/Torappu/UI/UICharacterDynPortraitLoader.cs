using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003534 RID: 13620
	[Token(Token = "0x2003534")]
	public class UICharacterDynPortraitLoader : PageAssetPool<UICharacterDynPortrait>
	{
		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x06015B59 RID: 88921 RVA: 0x0008D990 File Offset: 0x0008BB90
		[Token(Token = "0x17003393")]
		protected override bool enablePoolSizeLimit
		{
			[Token(Token = "0x6015B59")]
			[Address(RVA = "0xE4CFC0", Offset = "0xE4BBC0", VA = "0x180E4CFC0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015B5A RID: 88922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B5A")]
		[Address(RVA = "0xE4CC10", Offset = "0xE4B810", VA = "0x180E4CC10")]
		public UICharacterDynPortrait LoadChrPortrait(CharUISkinStruct skin, [Optional] Transform parent)
		{
			return null;
		}

		// Token: 0x06015B5B RID: 88923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B5B")]
		[Address(RVA = "0xE4CE40", Offset = "0xE4BA40", VA = "0x180E4CE40")]
		public void NotifyChrPortraitUsed(CharUISkinStruct skin)
		{
		}

		// Token: 0x06015B5C RID: 88924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B5C")]
		[Address(RVA = "0xE4CF50", Offset = "0xE4BB50", VA = "0x180E4CF50")]
		public UICharacterDynPortraitLoader()
		{
		}

		// Token: 0x0401A143 RID: 106819
		[Token(Token = "0x401A143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enablePoolSizeLimit;

		// Token: 0x0401A144 RID: 106820
		[Token(Token = "0x401A144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadChrPortrait;

		// Token: 0x0401A145 RID: 106821
		[Token(Token = "0x401A145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyChrPortraitUsed;

		// Token: 0x0401A146 RID: 106822
		[Token(Token = "0x401A146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
