using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E8B RID: 20107
	[Token(Token = "0x2004E8B")]
	public class FireworkCraftPage : StateEnginePage
	{
		// Token: 0x0601DFF6 RID: 122870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFF6")]
		[Address(RVA = "0x179EB70", Offset = "0x179D770", VA = "0x18179EB70")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601DFF7 RID: 122871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFF7")]
		[Address(RVA = "0x179ECF0", Offset = "0x179D8F0", VA = "0x18179ECF0")]
		public FireworkCraftPage()
		{
		}

		// Token: 0x04027DAF RID: 163247
		[Token(Token = "0x4027DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x04027DB0 RID: 163248
		[Token(Token = "0x4027DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E8C RID: 20108
		[Token(Token = "0x2004E8C")]
		public class Params
		{
			// Token: 0x0601DFF8 RID: 122872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DFF8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04027DB1 RID: 163249
			[Token(Token = "0x4027DB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04027DB2 RID: 163250
			[Token(Token = "0x4027DB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string stageId;
		}
	}
}
