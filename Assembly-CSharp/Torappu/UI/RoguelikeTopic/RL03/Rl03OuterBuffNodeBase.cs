using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045CE RID: 17870
	[Token(Token = "0x20045CE")]
	public abstract class Rl03OuterBuffNodeBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x0601B2F2 RID: 111346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040C0")]
		public List<Rl03OuterBuffNodeSocket> sockets
		{
			[Token(Token = "0x601B2F2")]
			[Address(RVA = "0x1457C30", Offset = "0x1456830", VA = "0x181457C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x0601B2F3 RID: 111347 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B2F4 RID: 111348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040C1")]
		public string buffId
		{
			[Token(Token = "0x601B2F3")]
			[Address(RVA = "0x1457BD0", Offset = "0x14567D0", VA = "0x181457BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x601B2F4")]
			[Address(RVA = "0x1457C90", Offset = "0x1456890", VA = "0x181457C90")]
			set
			{
			}
		}

		// Token: 0x0601B2F5 RID: 111349
		[Token(Token = "0x601B2F5")]
		public new abstract Rl03OuterBuffViewType GetType();

		// Token: 0x0601B2F6 RID: 111350
		[Token(Token = "0x601B2F6")]
		public abstract void OnInit(Rl03OuterBuffNodeBaseViewModel model);

		// Token: 0x0601B2F7 RID: 111351
		[Token(Token = "0x601B2F7")]
		public abstract void OnRender(string selectedBuffId, Rl03OuterBuffNodeBaseViewModel model);

		// Token: 0x0601B2F8 RID: 111352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2F8")]
		[Address(RVA = "0x1457B20", Offset = "0x1456720", VA = "0x181457B20")]
		protected Rl03OuterBuffNodeBase()
		{
		}

		// Token: 0x04023066 RID: 143462
		[Token(Token = "0x4023066")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Rl03OuterBuffNodeSocket> _sockets;

		// Token: 0x04023067 RID: 143463
		[Token(Token = "0x4023067")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffId;

		// Token: 0x04023068 RID: 143464
		[Token(Token = "0x4023068")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<string> onNodeClick;

		// Token: 0x04023069 RID: 143465
		[Token(Token = "0x4023069")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sockets;

		// Token: 0x0402306A RID: 143466
		[Token(Token = "0x402306A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_buffId;

		// Token: 0x0402306B RID: 143467
		[Token(Token = "0x402306B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_buffId;

		// Token: 0x0402306C RID: 143468
		[Token(Token = "0x402306C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
