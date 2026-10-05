using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	internal static class InputInteraction
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x55DC950", Offset = "0x55DB550", VA = "0x1855DC950")]
		public static Type GetValueType(Type interactionType)
		{
			return null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x55DC850", Offset = "0x55DB450", VA = "0x1855DC850")]
		public static string GetDisplayName(string interaction)
		{
			return null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x55DC690", Offset = "0x55DB290", VA = "0x1855DC690")]
		public static string GetDisplayName(Type interactionType)
		{
			return null;
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x0")]
		public static TypeTable s_Interactions;
	}
}
