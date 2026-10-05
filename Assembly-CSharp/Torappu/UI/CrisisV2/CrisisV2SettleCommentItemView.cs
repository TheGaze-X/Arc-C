using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200592A RID: 22826
	[Token(Token = "0x200592A")]
	public class CrisisV2SettleCommentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602140A RID: 136202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602140A")]
		[Address(RVA = "0x1B93B00", Offset = "0x1B92700", VA = "0x181B93B00")]
		public void Render(CrisisV2SettleCommentItemViewModel itemViewModel)
		{
		}

		// Token: 0x0602140B RID: 136203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602140B")]
		[Address(RVA = "0x1B93C70", Offset = "0x1B92870", VA = "0x181B93C70")]
		public CrisisV2SettleCommentItemView()
		{
		}

		// Token: 0x0402D4E9 RID: 185577
		[Token(Token = "0x402D4E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtComment;

		// Token: 0x0402D4EA RID: 185578
		[Token(Token = "0x402D4EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNewTag;

		// Token: 0x0402D4EB RID: 185579
		[Token(Token = "0x402D4EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objOldTag;

		// Token: 0x0402D4EC RID: 185580
		[Token(Token = "0x402D4EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D4ED RID: 185581
		[Token(Token = "0x402D4ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
