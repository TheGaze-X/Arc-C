using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005485 RID: 21637
	[Token(Token = "0x2005485")]
	public abstract class RoguelikeSelectCharStashTicketButtonBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004AAA RID: 19114
		// (get) Token: 0x0601FD65 RID: 130405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AAA")]
		protected string topicId
		{
			[Token(Token = "0x601FD65")]
			[Address(RVA = "0x19FD140", Offset = "0x19FBD40", VA = "0x1819FD140")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AAB RID: 19115
		// (get) Token: 0x0601FD66 RID: 130406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AAB")]
		protected string ticketId
		{
			[Token(Token = "0x601FD66")]
			[Address(RVA = "0x19FD0E0", Offset = "0x19FBCE0", VA = "0x1819FD0E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FD67 RID: 130407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD67")]
		[Address(RVA = "0x19FCFA0", Offset = "0x19FBBA0", VA = "0x1819FCFA0", Slot = "4")]
		public virtual void Render(RoguelikeSelectCharStashTicketButtonBase.Input input)
		{
		}

		// Token: 0x0601FD68 RID: 130408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD68")]
		[Address(RVA = "0x19FCF40", Offset = "0x19FBB40", VA = "0x1819FCF40", Slot = "5")]
		public virtual void EventOnClickStash()
		{
		}

		// Token: 0x0601FD69 RID: 130409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD69")]
		[Address(RVA = "0x19FD080", Offset = "0x19FBC80", VA = "0x1819FD080")]
		protected RoguelikeSelectCharStashTicketButtonBase()
		{
		}

		// Token: 0x0402AE3C RID: 175676
		[Token(Token = "0x402AE3C")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onClickStash;

		// Token: 0x0402AE3D RID: 175677
		[Token(Token = "0x402AE3D")]
		[FieldOffset(Offset = "0x20")]
		private string m_topicId;

		// Token: 0x0402AE3E RID: 175678
		[Token(Token = "0x402AE3E")]
		[FieldOffset(Offset = "0x28")]
		private string m_ticketId;

		// Token: 0x0402AE3F RID: 175679
		[Token(Token = "0x402AE3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402AE40 RID: 175680
		[Token(Token = "0x402AE40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ticketId;

		// Token: 0x0402AE41 RID: 175681
		[Token(Token = "0x402AE41")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AE42 RID: 175682
		[Token(Token = "0x402AE42")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClickStash;

		// Token: 0x0402AE43 RID: 175683
		[Token(Token = "0x402AE43")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005486 RID: 21638
		[Token(Token = "0x2005486")]
		public struct Input
		{
			// Token: 0x0402AE44 RID: 175684
			[Token(Token = "0x402AE44")]
			[FieldOffset(Offset = "0x0")]
			public Action onClickStash;

			// Token: 0x0402AE45 RID: 175685
			[Token(Token = "0x402AE45")]
			[FieldOffset(Offset = "0x8")]
			public string topicId;

			// Token: 0x0402AE46 RID: 175686
			[Token(Token = "0x402AE46")]
			[FieldOffset(Offset = "0x10")]
			public string ticketId;
		}
	}
}
