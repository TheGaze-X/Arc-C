using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/ChapterDB")]
	[Serializable]
	public class ChapterDB : SimpleKVTable<ChapterData, ChapterDB>
	{
		// Token: 0x060060C6 RID: 24774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C6")]
		[Address(RVA = "0x1CE7C00", Offset = "0x1CE6800", VA = "0x181CE7C00")]
		public ChapterDB()
		{
		}

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
