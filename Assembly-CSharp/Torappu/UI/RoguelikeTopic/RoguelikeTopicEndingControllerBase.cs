using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C9 RID: 17609
	[Token(Token = "0x20044C9")]
	public abstract class RoguelikeTopicEndingControllerBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x0601AE31 RID: 110129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE32 RID: 110130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FD4")]
		public RoguelikeTopicEndingState state
		{
			[Token(Token = "0x601AE31")]
			[Address(RVA = "0x140BD20", Offset = "0x140A920", VA = "0x18140BD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AE32")]
			[Address(RVA = "0x140BE40", Offset = "0x140AA40", VA = "0x18140BE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x0601AE33 RID: 110131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE34 RID: 110132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FD5")]
		public string topicId
		{
			[Token(Token = "0x601AE33")]
			[Address(RVA = "0x140BDE0", Offset = "0x140A9E0", VA = "0x18140BDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AE34")]
			[Address(RVA = "0x140BF40", Offset = "0x140AB40", VA = "0x18140BF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x0601AE35 RID: 110133 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE36 RID: 110134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FD6")]
		public RoguelikeTopicEndingStyle style
		{
			[Token(Token = "0x601AE35")]
			[Address(RVA = "0x140BD80", Offset = "0x140A980", VA = "0x18140BD80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AE36")]
			[Address(RVA = "0x140BEC0", Offset = "0x140AAC0", VA = "0x18140BEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601AE37 RID: 110135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE37")]
		[Address(RVA = "0x140BA80", Offset = "0x140A680", VA = "0x18140BA80", Slot = "4")]
		public virtual void OnInit(RoguelikeTopicEndingState state, string topicId, RoguelikeTopicPage.SettleInfo settleInfo)
		{
		}

		// Token: 0x0601AE38 RID: 110136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE38")]
		[Address(RVA = "0x140B9C0", Offset = "0x140A5C0", VA = "0x18140B9C0", Slot = "5")]
		public virtual void OnEnter()
		{
		}

		// Token: 0x0601AE39 RID: 110137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE39")]
		[Address(RVA = "0x140BC60", Offset = "0x140A860", VA = "0x18140BC60", Slot = "6")]
		public virtual void OnResume()
		{
		}

		// Token: 0x0601AE3A RID: 110138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE3A")]
		[Address(RVA = "0x140BA20", Offset = "0x140A620", VA = "0x18140BA20", Slot = "7")]
		public virtual void OnExit()
		{
		}

		// Token: 0x0601AE3B RID: 110139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE3B")]
		[Address(RVA = "0x140B8C0", Offset = "0x140A4C0", VA = "0x18140B8C0")]
		public void NotifyNext()
		{
		}

		// Token: 0x0601AE3C RID: 110140
		[Token(Token = "0x601AE3C")]
		protected abstract bool OnNext();

		// Token: 0x0601AE3D RID: 110141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE3D")]
		[Address(RVA = "0x140BCC0", Offset = "0x140A8C0", VA = "0x18140BCC0")]
		protected RoguelikeTopicEndingControllerBase()
		{
		}

		// Token: 0x04022752 RID: 141138
		[Token(Token = "0x4022752")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x04022753 RID: 141139
		[Token(Token = "0x4022753")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x04022754 RID: 141140
		[Token(Token = "0x4022754")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04022755 RID: 141141
		[Token(Token = "0x4022755")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04022756 RID: 141142
		[Token(Token = "0x4022756")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_style;

		// Token: 0x04022757 RID: 141143
		[Token(Token = "0x4022757")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_style;

		// Token: 0x04022758 RID: 141144
		[Token(Token = "0x4022758")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04022759 RID: 141145
		[Token(Token = "0x4022759")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402275A RID: 141146
		[Token(Token = "0x402275A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402275B RID: 141147
		[Token(Token = "0x402275B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402275C RID: 141148
		[Token(Token = "0x402275C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NotifyNext;

		// Token: 0x0402275D RID: 141149
		[Token(Token = "0x402275D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
