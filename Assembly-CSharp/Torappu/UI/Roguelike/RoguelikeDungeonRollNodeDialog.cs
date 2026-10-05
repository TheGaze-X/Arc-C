using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200527A RID: 21114
	[Token(Token = "0x200527A")]
	public class RoguelikeDungeonRollNodeDialog : UICustomDialog<RoguelikeDungeonRollNodeDialog.Options>
	{
		// Token: 0x0601F283 RID: 127619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F283")]
		[Address(RVA = "0x18E9480", Offset = "0x18E8080", VA = "0x1818E9480", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601F284 RID: 127620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F284")]
		[Address(RVA = "0x18E9620", Offset = "0x18E8220", VA = "0x1818E9620", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601F285 RID: 127621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F285")]
		[Address(RVA = "0x18E97E0", Offset = "0x18E83E0", VA = "0x1818E97E0", Slot = "7")]
		protected override void OnRender(RoguelikeDungeonRollNodeDialog.Options options)
		{
		}

		// Token: 0x0601F286 RID: 127622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F286")]
		[Address(RVA = "0x18E9580", Offset = "0x18E8180", VA = "0x1818E9580")]
		public void OnConfirm()
		{
		}

		// Token: 0x0601F287 RID: 127623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F287")]
		[Address(RVA = "0x18E94E0", Offset = "0x18E80E0", VA = "0x1818E94E0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601F288 RID: 127624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F288")]
		[Address(RVA = "0x18E9940", Offset = "0x18E8540", VA = "0x1818E9940")]
		public RoguelikeDungeonRollNodeDialog()
		{
		}

		// Token: 0x04029CE0 RID: 171232
		[Token(Token = "0x4029CE0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeDungeonRollNodeDialogPlugin _plugin;

		// Token: 0x04029CE1 RID: 171233
		[Token(Token = "0x4029CE1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x04029CE2 RID: 171234
		[Token(Token = "0x4029CE2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04029CE3 RID: 171235
		[Token(Token = "0x4029CE3")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeDungeonRollNodeDialog.Options m_options;

		// Token: 0x04029CE4 RID: 171236
		[Token(Token = "0x4029CE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04029CE5 RID: 171237
		[Token(Token = "0x4029CE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04029CE6 RID: 171238
		[Token(Token = "0x4029CE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04029CE7 RID: 171239
		[Token(Token = "0x4029CE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x04029CE8 RID: 171240
		[Token(Token = "0x4029CE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x04029CE9 RID: 171241
		[Token(Token = "0x4029CE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200527B RID: 21115
		[Token(Token = "0x200527B")]
		public struct Options
		{
			// Token: 0x04029CEA RID: 171242
			[Token(Token = "0x4029CEA")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04029CEB RID: 171243
			[Token(Token = "0x4029CEB")]
			[FieldOffset(Offset = "0x8")]
			public PlayerNodeRollInfo rollInfo;

			// Token: 0x04029CEC RID: 171244
			[Token(Token = "0x4029CEC")]
			[FieldOffset(Offset = "0x10")]
			public Func<bool> onConfirm;

			// Token: 0x04029CED RID: 171245
			[Token(Token = "0x4029CED")]
			[FieldOffset(Offset = "0x18")]
			public Func<bool> onCancel;

			// Token: 0x04029CEE RID: 171246
			[Token(Token = "0x4029CEE")]
			[FieldOffset(Offset = "0x20")]
			public ValueBundle extraData;
		}
	}
}
