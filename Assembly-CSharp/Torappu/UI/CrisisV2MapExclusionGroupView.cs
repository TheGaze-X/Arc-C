using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A51 RID: 14929
	[Token(Token = "0x2003A51")]
	public class CrisisV2MapExclusionGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017996 RID: 96662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017996")]
		[Address(RVA = "0xFE3CD0", Offset = "0xFE28D0", VA = "0x180FE3CD0")]
		private void _SetPos(Vector2 pos, Vector2 size)
		{
		}

		// Token: 0x06017997 RID: 96663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017997")]
		[Address(RVA = "0xFE3BD0", Offset = "0xFE27D0", VA = "0x180FE3BD0")]
		public void Init(Vector2 pos, Vector2 size)
		{
		}

		// Token: 0x06017998 RID: 96664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017998")]
		[Address(RVA = "0xFE3DA0", Offset = "0xFE29A0", VA = "0x180FE3DA0")]
		public CrisisV2MapExclusionGroupView()
		{
		}

		// Token: 0x0401C7A3 RID: 116643
		[Token(Token = "0x401C7A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetPos;

		// Token: 0x0401C7A4 RID: 116644
		[Token(Token = "0x401C7A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401C7A5 RID: 116645
		[Token(Token = "0x401C7A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
