using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056EE RID: 22254
	[Token(Token = "0x20056EE")]
	public class RL04DungeonDetailNodeDialogView : RoguelikeDetailNodeDialog.View<RL04DungeonDetailNodeDialogView.Options>
	{
		// Token: 0x06020A48 RID: 133704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A48")]
		[Address(RVA = "0x1ABAF50", Offset = "0x1AB9B50", VA = "0x181ABAF50", Slot = "4")]
		public override void OnInit()
		{
		}

		// Token: 0x06020A49 RID: 133705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A49")]
		[Address(RVA = "0x1ABAFB0", Offset = "0x1AB9BB0", VA = "0x181ABAFB0", Slot = "6")]
		public override void Render(RL04DungeonDetailNodeDialogView.Options options)
		{
		}

		// Token: 0x06020A4A RID: 133706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A4A")]
		[Address(RVA = "0x1ABB060", Offset = "0x1AB9C60", VA = "0x181ABB060")]
		public RL04DungeonDetailNodeDialogView()
		{
		}

		// Token: 0x0402C46B RID: 181355
		[Token(Token = "0x402C46B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402C46C RID: 181356
		[Token(Token = "0x402C46C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402C46D RID: 181357
		[Token(Token = "0x402C46D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C46E RID: 181358
		[Token(Token = "0x402C46E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056EF RID: 22255
		[Token(Token = "0x20056EF")]
		public class Options : RoguelikeDetailNodeDialog.OptionBase
		{
			// Token: 0x06020A4B RID: 133707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020A4B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Options()
			{
			}

			// Token: 0x0402C46F RID: 181359
			[Token(Token = "0x402C46F")]
			[FieldOffset(Offset = "0x18")]
			public string desc;
		}
	}
}
