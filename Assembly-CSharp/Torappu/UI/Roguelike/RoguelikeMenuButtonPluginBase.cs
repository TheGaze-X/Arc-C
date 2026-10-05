using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052F6 RID: 21238
	[Token(Token = "0x20052F6")]
	public abstract class RoguelikeMenuButtonPluginBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F537 RID: 128311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F537")]
		[Address(RVA = "0x190EEC0", Offset = "0x190DAC0", VA = "0x18190EEC0", Slot = "4")]
		public virtual void OnClickCancel()
		{
		}

		// Token: 0x0601F538 RID: 128312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F538")]
		[Address(RVA = "0x190EF30", Offset = "0x190DB30", VA = "0x18190EF30", Slot = "5")]
		public virtual void OnClickConfirm()
		{
		}

		// Token: 0x0601F539 RID: 128313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F539")]
		[Address(RVA = "0x190EFA0", Offset = "0x190DBA0", VA = "0x18190EFA0", Slot = "6")]
		public virtual void Render(RoguelikeMenuButtonPluginBase.Input config)
		{
		}

		// Token: 0x0601F53A RID: 128314
		[Token(Token = "0x601F53A")]
		public abstract void RenderPlugin(RoguelikeMenuButtonPluginBase.Input config);

		// Token: 0x0601F53B RID: 128315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F53B")]
		[Address(RVA = "0x190F0A0", Offset = "0x190DCA0", VA = "0x18190F0A0")]
		protected RoguelikeMenuButtonPluginBase()
		{
		}

		// Token: 0x0402A165 RID: 172389
		[Token(Token = "0x402A165")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlCancel;

		// Token: 0x0402A166 RID: 172390
		[Token(Token = "0x402A166")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlConfirm;

		// Token: 0x0402A167 RID: 172391
		[Token(Token = "0x402A167")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action onCancel;

		// Token: 0x0402A168 RID: 172392
		[Token(Token = "0x402A168")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action onConfirm;

		// Token: 0x0402A169 RID: 172393
		[Token(Token = "0x402A169")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickCancel;

		// Token: 0x0402A16A RID: 172394
		[Token(Token = "0x402A16A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickConfirm;

		// Token: 0x0402A16B RID: 172395
		[Token(Token = "0x402A16B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A16C RID: 172396
		[Token(Token = "0x402A16C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052F7 RID: 21239
		[Token(Token = "0x20052F7")]
		public class Input
		{
			// Token: 0x0601F53C RID: 128316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F53C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402A16D RID: 172397
			[Token(Token = "0x402A16D")]
			[FieldOffset(Offset = "0x10")]
			public Action onCancel;

			// Token: 0x0402A16E RID: 172398
			[Token(Token = "0x402A16E")]
			[FieldOffset(Offset = "0x18")]
			public Action onConfirm;

			// Token: 0x0402A16F RID: 172399
			[Token(Token = "0x402A16F")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeSelectCharViewModel selectCharViewModel;

			// Token: 0x0402A170 RID: 172400
			[Token(Token = "0x402A170")]
			[FieldOffset(Offset = "0x28")]
			public string topicId;
		}
	}
}
