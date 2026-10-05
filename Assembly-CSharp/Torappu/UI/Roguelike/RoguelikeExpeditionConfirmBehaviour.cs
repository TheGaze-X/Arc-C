using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052D0 RID: 21200
	[Token(Token = "0x20052D0")]
	public class RoguelikeExpeditionConfirmBehaviour
	{
		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x0601F452 RID: 128082 RVA: 0x000B15E8 File Offset: 0x000AF7E8
		[Token(Token = "0x1700495F")]
		protected virtual bool doEmptyBack
		{
			[Token(Token = "0x601F452")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F453 RID: 128083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F453")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public virtual void LoadData(string topicId)
		{
		}

		// Token: 0x0601F454 RID: 128084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F454")]
		[Address(RVA = "0x18FC310", Offset = "0x18FAF10", VA = "0x1818FC310", Slot = "6")]
		public virtual void OnConfirmClick(RoguelikeExpeditionModel model, Action<string> confirmServiceAction)
		{
		}

		// Token: 0x0601F455 RID: 128085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F455")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeExpeditionConfirmBehaviour()
		{
		}
	}
}
