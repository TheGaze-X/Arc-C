using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001614 RID: 5652
	[Token(Token = "0x2001614")]
	[CSharpCallLua]
	internal static class LuaUIUtil
	{
		// Token: 0x06008067 RID: 32871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008067")]
		[Address(RVA = "0x2893920", Offset = "0x2892520", VA = "0x182893920")]
		public static GameObject GetChild(this GameObject go, string name)
		{
			return null;
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008068")]
		public static T GetUICtrl<T>(this GameObject go, string name) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008069")]
		[Address(RVA = "0x28938D0", Offset = "0x28924D0", VA = "0x1828938D0")]
		public static Button GetButton(this GameObject go, string name)
		{
			return null;
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600806A")]
		[Address(RVA = "0x2893A50", Offset = "0x2892650", VA = "0x182893A50")]
		public static Text GetText(this GameObject go, string name)
		{
			return null;
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600806B")]
		[Address(RVA = "0x2893960", Offset = "0x2892560", VA = "0x182893960")]
		public static Image GetImage(this GameObject go, string name)
		{
			return null;
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600806C")]
		[Address(RVA = "0x2893A00", Offset = "0x2892600", VA = "0x182893A00")]
		public static Slider GetSlider(this GameObject go, string name)
		{
			return null;
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600806D")]
		[Address(RVA = "0x28939B0", Offset = "0x28925B0", VA = "0x1828939B0")]
		public static ScrollRect GetScroller(this GameObject go, string name)
		{
			return null;
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600806E")]
		[Address(RVA = "0x2893780", Offset = "0x2892380", VA = "0x182893780")]
		public static void BindBackPressToButton(Button target)
		{
		}
	}
}
