using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052CE RID: 21198
	[Token(Token = "0x20052CE")]
	public abstract class RoguelikeExpeditionPluginContext : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x0601F447 RID: 128071
		[Token(Token = "0x1700495D")]
		public abstract GameObject charCardPrefab { [Token(Token = "0x601F447")] get; }

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x0601F448 RID: 128072
		[Token(Token = "0x1700495E")]
		public abstract RoguelikeExpeditionSelectingCharView selectingCharPrefab { [Token(Token = "0x601F448")] get; }

		// Token: 0x0601F449 RID: 128073
		[Token(Token = "0x601F449")]
		public abstract void LoadData(string topicId);

		// Token: 0x0601F44A RID: 128074
		[Token(Token = "0x601F44A")]
		public abstract string GetSelectDesc(RoguelikeExpeditionModel model);

		// Token: 0x0601F44B RID: 128075
		[Token(Token = "0x601F44B")]
		public abstract RoguelikeExpeditionPluginContext.RoguelikeExpeditionCharListSort GetExpeditionCharListSort(RoguelikeExpeditionModel expeditionModel);

		// Token: 0x0601F44C RID: 128076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F44C")]
		[Address(RVA = "0x18FDE60", Offset = "0x18FCA60", VA = "0x1818FDE60", Slot = "9")]
		public virtual RoguelikeExpeditionConfirmBehaviour GetConfirmBehaviour()
		{
			return null;
		}

		// Token: 0x0601F44D RID: 128077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F44D")]
		[Address(RVA = "0x18FDEF0", Offset = "0x18FCAF0", VA = "0x1818FDEF0")]
		protected RoguelikeExpeditionPluginContext()
		{
		}

		// Token: 0x04029FEA RID: 172010
		[Token(Token = "0x4029FEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetConfirmBehaviour;

		// Token: 0x04029FEB RID: 172011
		[Token(Token = "0x4029FEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052CF RID: 21199
		// (Invoke) Token: 0x0601F44F RID: 128079
		[Token(Token = "0x20052CF")]
		public delegate int RoguelikeExpeditionCharListSort(RoguelikeExpeditionCharCardViewModel lhs, RoguelikeExpeditionCharCardViewModel rhs);
	}
}
