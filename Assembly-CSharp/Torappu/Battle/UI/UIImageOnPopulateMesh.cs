using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003387 RID: 13191
	[Token(Token = "0x2003387")]
	public class UIImageOnPopulateMesh : Image, IHotfixable
	{
		// Token: 0x14000074 RID: 116
		// (add) Token: 0x06015092 RID: 86162 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06015093 RID: 86163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000074")]
		public event Action<VertexHelper> onPopulateMesh
		{
			[Token(Token = "0x6015092")]
			[Address(RVA = "0xD776B0", Offset = "0xD762B0", VA = "0x180D776B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6015093")]
			[Address(RVA = "0xD777B0", Offset = "0xD763B0", VA = "0x180D777B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06015094 RID: 86164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015094")]
		[Address(RVA = "0xD775A0", Offset = "0xD761A0", VA = "0x180D775A0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x06015095 RID: 86165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015095")]
		[Address(RVA = "0xD77630", Offset = "0xD76230", VA = "0x180D77630")]
		public UIImageOnPopulateMesh()
		{
		}

		// Token: 0x06015096 RID: 86166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015096")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0401908C RID: 102540
		[Token(Token = "0x401908C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onPopulateMesh;

		// Token: 0x0401908D RID: 102541
		[Token(Token = "0x401908D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onPopulateMesh;

		// Token: 0x0401908E RID: 102542
		[Token(Token = "0x401908E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0401908F RID: 102543
		[Token(Token = "0x401908F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
