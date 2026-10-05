using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005805 RID: 22533
	[Token(Token = "0x2005805")]
	public class RL03TotemEffectAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x06020EF4 RID: 134900 RVA: 0x000B7DC8 File Offset: 0x000B5FC8
		[Token(Token = "0x17004D52")]
		public override int count
		{
			[Token(Token = "0x6020EF4")]
			[Address(RVA = "0x1B33D90", Offset = "0x1B32990", VA = "0x181B33D90", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06020EF5 RID: 134901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020EF5")]
		[Address(RVA = "0x1B33BA0", Offset = "0x1B327A0", VA = "0x181B33BA0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06020EF6 RID: 134902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EF6")]
		[Address(RVA = "0x1B33D30", Offset = "0x1B32930", VA = "0x181B33D30")]
		public RL03TotemEffectAdapter()
		{
		}

		// Token: 0x0402CC7F RID: 183423
		[Token(Token = "0x402CC7F")]
		[FieldOffset(Offset = "0x20")]
		public List<string> descList;

		// Token: 0x0402CC80 RID: 183424
		[Token(Token = "0x402CC80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402CC81 RID: 183425
		[Token(Token = "0x402CC81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402CC82 RID: 183426
		[Token(Token = "0x402CC82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
