using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C1C RID: 23580
	[Token(Token = "0x2005C1C")]
	public class TemplateCharSelectShuffleProfessionListAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17005031 RID: 20529
		// (get) Token: 0x06022303 RID: 140035 RVA: 0x000BC928 File Offset: 0x000BAB28
		[Token(Token = "0x17005031")]
		public override int count
		{
			[Token(Token = "0x6022303")]
			[Address(RVA = "0x1CB2FF0", Offset = "0x1CB1BF0", VA = "0x181CB2FF0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06022304 RID: 140036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022304")]
		[Address(RVA = "0x1CB29D0", Offset = "0x1CB15D0", VA = "0x181CB29D0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06022305 RID: 140037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022305")]
		[Address(RVA = "0x1CB2F70", Offset = "0x1CB1B70", VA = "0x181CB2F70")]
		public TemplateCharSelectShuffleProfessionListAdapter()
		{
		}

		// Token: 0x0402EE4F RID: 192079
		[Token(Token = "0x402EE4F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<ProfessionCategory> PROFESSION_ORDER_LIST;

		// Token: 0x0402EE50 RID: 192080
		[Token(Token = "0x402EE50")]
		[FieldOffset(Offset = "0x20")]
		public Action<ProfessionCategory> onProfClick;

		// Token: 0x0402EE51 RID: 192081
		[Token(Token = "0x402EE51")]
		[FieldOffset(Offset = "0x28")]
		public ProfessionCategory currentProf;

		// Token: 0x0402EE52 RID: 192082
		[Token(Token = "0x402EE52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402EE53 RID: 192083
		[Token(Token = "0x402EE53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402EE54 RID: 192084
		[Token(Token = "0x402EE54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
