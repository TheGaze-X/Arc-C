using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FB6 RID: 16310
	[Token(Token = "0x2003FB6")]
	public class SiracusaChatDecisionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x060194AC RID: 103596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060194AD RID: 103597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C73")]
		public Action<int> onClickedAction
		{
			[Token(Token = "0x60194AC")]
			[Address(RVA = "0x1208500", Offset = "0x1207100", VA = "0x181208500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60194AD")]
			[Address(RVA = "0x1208560", Offset = "0x1207160", VA = "0x181208560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060194AE RID: 103598 RVA: 0x0009D9E0 File Offset: 0x0009BBE0
		[Token(Token = "0x60194AE")]
		[Address(RVA = "0x1208280", Offset = "0x1206E80", VA = "0x181208280")]
		public TextGenerationSettings GenerateContentSettings()
		{
			return default(TextGenerationSettings);
		}

		// Token: 0x060194AF RID: 103599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194AF")]
		[Address(RVA = "0x12083A0", Offset = "0x1206FA0", VA = "0x1812083A0")]
		public void Render(int index, string content, bool selectable)
		{
		}

		// Token: 0x060194B0 RID: 103600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194B0")]
		[Address(RVA = "0x1208170", Offset = "0x1206D70", VA = "0x181208170")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060194B1 RID: 103601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194B1")]
		[Address(RVA = "0x12084A0", Offset = "0x12070A0", VA = "0x1812084A0")]
		public SiracusaChatDecisionItem()
		{
		}

		// Token: 0x0401F6A2 RID: 128674
		[Token(Token = "0x401F6A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _content;

		// Token: 0x0401F6A3 RID: 128675
		[Token(Token = "0x401F6A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _button;

		// Token: 0x0401F6A4 RID: 128676
		[Token(Token = "0x401F6A4")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedIndex;

		// Token: 0x0401F6A6 RID: 128678
		[Token(Token = "0x401F6A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickedAction;

		// Token: 0x0401F6A7 RID: 128679
		[Token(Token = "0x401F6A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickedAction;

		// Token: 0x0401F6A8 RID: 128680
		[Token(Token = "0x401F6A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateContentSettings;

		// Token: 0x0401F6A9 RID: 128681
		[Token(Token = "0x401F6A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F6AA RID: 128682
		[Token(Token = "0x401F6AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0401F6AB RID: 128683
		[Token(Token = "0x401F6AB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
