using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.RL04;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046BF RID: 18111
	[Token(Token = "0x20046BF")]
	public class RL04NodeUpgradeTypeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x0601B778 RID: 112504 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B779 RID: 112505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004166")]
		public Action<RoguelikeEventType> onClick
		{
			[Token(Token = "0x601B778")]
			[Address(RVA = "0x14CD960", Offset = "0x14CC560", VA = "0x1814CD960")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B779")]
			[Address(RVA = "0x14CD9C0", Offset = "0x14CC5C0", VA = "0x1814CD9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B77A RID: 112506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B77A")]
		[Address(RVA = "0x14CD660", Offset = "0x14CC260", VA = "0x1814CD660")]
		public void Render(RL04NodeUpgradeModel upgradeModel, RL04NodeUpgradeConfig currNodeConfig, bool isSelect)
		{
		}

		// Token: 0x0601B77B RID: 112507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B77B")]
		[Address(RVA = "0x14CD550", Offset = "0x14CC150", VA = "0x1814CD550")]
		public void EventOnBtnClick()
		{
		}

		// Token: 0x0601B77C RID: 112508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B77C")]
		[Address(RVA = "0x14CD900", Offset = "0x14CC500", VA = "0x1814CD900")]
		public RL04NodeUpgradeTypeItemView()
		{
		}

		// Token: 0x040238FD RID: 145661
		[Token(Token = "0x40238FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040238FE RID: 145662
		[Token(Token = "0x40238FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgSelect;

		// Token: 0x040238FF RID: 145663
		[Token(Token = "0x40238FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgUnselect;

		// Token: 0x04023900 RID: 145664
		[Token(Token = "0x4023900")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectPartGo;

		// Token: 0x04023901 RID: 145665
		[Token(Token = "0x4023901")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _unselectPartGo;

		// Token: 0x04023902 RID: 145666
		[Token(Token = "0x4023902")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeEventType m_nodeType;

		// Token: 0x04023904 RID: 145668
		[Token(Token = "0x4023904")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04023905 RID: 145669
		[Token(Token = "0x4023905")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04023906 RID: 145670
		[Token(Token = "0x4023906")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023907 RID: 145671
		[Token(Token = "0x4023907")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnClick;

		// Token: 0x04023908 RID: 145672
		[Token(Token = "0x4023908")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
