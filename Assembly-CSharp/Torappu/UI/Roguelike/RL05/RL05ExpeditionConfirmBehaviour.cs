using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055CB RID: 21963
	[Token(Token = "0x20055CB")]
	public class RL05ExpeditionConfirmBehaviour : RoguelikeExpeditionConfirmBehaviour
	{
		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x060203F4 RID: 132084 RVA: 0x000B50B0 File Offset: 0x000B32B0
		[Token(Token = "0x17004B99")]
		protected override bool doEmptyBack
		{
			[Token(Token = "0x60203F4")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060203F5 RID: 132085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203F5")]
		[Address(RVA = "0x1A5E690", Offset = "0x1A5D290", VA = "0x181A5E690", Slot = "5")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x060203F6 RID: 132086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203F6")]
		[Address(RVA = "0x1A5E750", Offset = "0x1A5D350", VA = "0x181A5E750", Slot = "6")]
		public override void OnConfirmClick(RoguelikeExpeditionModel model, Action<string> confirmServiceAction)
		{
		}

		// Token: 0x060203F7 RID: 132087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203F7")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RL05ExpeditionConfirmBehaviour()
		{
		}

		// Token: 0x0402B9D3 RID: 178643
		[Token(Token = "0x402B9D3")]
		[FieldOffset(Offset = "0x10")]
		private string m_candledBuffId;
	}
}
