using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x020045A2 RID: 17826
	[Token(Token = "0x20045A2")]
	public class RL05TopicEndingCopperItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B229 RID: 111145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B229")]
		[Address(RVA = "0x1453370", Offset = "0x1451F70", VA = "0x181453370")]
		public void Render(RoguelikeGameCopperItemViewModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601B22A RID: 111146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B22A")]
		[Address(RVA = "0x1453590", Offset = "0x1452190", VA = "0x181453590")]
		public RL05TopicEndingCopperItemView()
		{
		}

		// Token: 0x04022EC5 RID: 143045
		[Token(Token = "0x4022EC5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x04022EC6 RID: 143046
		[Token(Token = "0x4022EC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04022EC7 RID: 143047
		[Token(Token = "0x4022EC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _luckyIcon;

		// Token: 0x04022EC8 RID: 143048
		[Token(Token = "0x4022EC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04022EC9 RID: 143049
		[Token(Token = "0x4022EC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022ECA RID: 143050
		[Token(Token = "0x4022ECA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
