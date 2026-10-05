using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057DF RID: 22495
	[Token(Token = "0x20057DF")]
	public class RoguelikeInitConfirmPanel : RoguelikeInitStepPanel<RoguelikeInitConfirmContext>
	{
		// Token: 0x06020E64 RID: 134756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E64")]
		[Address(RVA = "0x1B39490", Offset = "0x1B38090", VA = "0x181B39490", Slot = "8")]
		protected override void OnUpdateContext(bool isNew)
		{
		}

		// Token: 0x06020E65 RID: 134757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E65")]
		private void _UpdateItems<T>(RoguelikeInitConfirmPanel.ItemUpdatorImpl<T> itemImpl, bool isNew) where T : RoguelikeInitCardBase
		{
		}

		// Token: 0x06020E66 RID: 134758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E66")]
		[Address(RVA = "0x1B39400", Offset = "0x1B38000", VA = "0x181B39400")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06020E67 RID: 134759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E67")]
		[Address(RVA = "0x1B39C20", Offset = "0x1B38820", VA = "0x181B39C20")]
		public RoguelikeInitConfirmPanel()
		{
		}

		// Token: 0x0402CB4B RID: 183115
		[Token(Token = "0x402CB4B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0402CB4C RID: 183116
		[Token(Token = "0x402CB4C")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeInitConfirmPanel.ItemUpdatorImpl<RoguelikeInitChar> m_charCardImpl;

		// Token: 0x0402CB4D RID: 183117
		[Token(Token = "0x402CB4D")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeInitConfirmPanel.ItemUpdatorImpl<RoguelikeInitRelic> m_relicCardImpl;

		// Token: 0x0402CB4E RID: 183118
		[Token(Token = "0x402CB4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdateContext;

		// Token: 0x0402CB4F RID: 183119
		[Token(Token = "0x402CB4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateItems;

		// Token: 0x0402CB50 RID: 183120
		[Token(Token = "0x402CB50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0402CB51 RID: 183121
		[Token(Token = "0x402CB51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057E0 RID: 22496
		[Token(Token = "0x20057E0")]
		private class ItemUpdatorImpl<T> where T : MonoBehaviour
		{
			// Token: 0x06020E6C RID: 134764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020E6C")]
			public ItemUpdatorImpl()
			{
			}

			// Token: 0x0402CB52 RID: 183122
			[Token(Token = "0x402CB52")]
			[FieldOffset(Offset = "0x0")]
			public ItemPool<T> pool;

			// Token: 0x0402CB53 RID: 183123
			[Token(Token = "0x402CB53")]
			[FieldOffset(Offset = "0x0")]
			public int count;

			// Token: 0x0402CB54 RID: 183124
			[Token(Token = "0x402CB54")]
			[FieldOffset(Offset = "0x0")]
			public Func<T> creator;

			// Token: 0x0402CB55 RID: 183125
			[Token(Token = "0x402CB55")]
			[FieldOffset(Offset = "0x0")]
			public Action<int, T> updator;
		}
	}
}
