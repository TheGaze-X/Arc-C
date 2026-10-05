using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005919 RID: 22809
	[Token(Token = "0x2005919")]
	public class CrisisV2DiagramBgScoreHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004E01 RID: 19969
		// (get) Token: 0x060213E0 RID: 136160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E01")]
		public List<CrisisV2DiagramDescAndScoreItem> descAndScoreItems
		{
			[Token(Token = "0x60213E0")]
			[Address(RVA = "0x1B8DE20", Offset = "0x1B8CA20", VA = "0x181B8DE20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060213E1 RID: 136161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213E1")]
		[Address(RVA = "0x1B8DDC0", Offset = "0x1B8C9C0", VA = "0x181B8DDC0")]
		public CrisisV2DiagramBgScoreHolder()
		{
		}

		// Token: 0x0402D455 RID: 185429
		[Token(Token = "0x402D455")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CrisisV2DiagramDescAndScoreItem> _descAndScoreItems;

		// Token: 0x0402D456 RID: 185430
		[Token(Token = "0x402D456")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_descAndScoreItems;

		// Token: 0x0402D457 RID: 185431
		[Token(Token = "0x402D457")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
