using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005537 RID: 21815
	[Token(Token = "0x2005537")]
	public class RoguelikeSquadView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020150 RID: 131408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020150")]
		[Address(RVA = "0x1A3D3C0", Offset = "0x1A3BFC0", VA = "0x181A3D3C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020151 RID: 131409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020151")]
		[Address(RVA = "0x1A3D090", Offset = "0x1A3BC90", VA = "0x181A3D090")]
		public void Render(int totalCount, int troopCount, List<RoguelikeCharCardViewModel> viewModelList)
		{
		}

		// Token: 0x06020152 RID: 131410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020152")]
		[Address(RVA = "0x1A3CFD0", Offset = "0x1A3BBD0", VA = "0x181A3CFD0")]
		public void InjectPlugin(IRoguelikeCharCardPlugin plugin, RoguelikeSquadItem.SquadPluginInputs inputs)
		{
		}

		// Token: 0x06020153 RID: 131411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020153")]
		[Address(RVA = "0x1A3D5B0", Offset = "0x1A3C1B0", VA = "0x181A3D5B0")]
		public RoguelikeSquadView()
		{
		}

		// Token: 0x0402B53F RID: 177471
		[Token(Token = "0x402B53F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeSquadItem _item;

		// Token: 0x0402B540 RID: 177472
		[Token(Token = "0x402B540")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> _itemContainer;

		// Token: 0x0402B541 RID: 177473
		[Token(Token = "0x402B541")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntStringEvent _onClickSkill;

		// Token: 0x0402B542 RID: 177474
		[Token(Token = "0x402B542")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIIntEvent _onCharClick;

		// Token: 0x0402B543 RID: 177475
		[Token(Token = "0x402B543")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIIntEvent _onPosClick;

		// Token: 0x0402B544 RID: 177476
		[Token(Token = "0x402B544")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _squadCount;

		// Token: 0x0402B545 RID: 177477
		[Token(Token = "0x402B545")]
		[FieldOffset(Offset = "0x48")]
		private List<RoguelikeSquadItem> m_itemList;

		// Token: 0x0402B546 RID: 177478
		[Token(Token = "0x402B546")]
		[FieldOffset(Offset = "0x50")]
		private List<IRoguelikeCharCardPlugin> m_plugins;

		// Token: 0x0402B547 RID: 177479
		[Token(Token = "0x402B547")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeSquadItem.SquadPluginInputs m_cachedInput;

		// Token: 0x0402B548 RID: 177480
		[Token(Token = "0x402B548")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0402B549 RID: 177481
		[Token(Token = "0x402B549")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B54A RID: 177482
		[Token(Token = "0x402B54A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B54B RID: 177483
		[Token(Token = "0x402B54B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x0402B54C RID: 177484
		[Token(Token = "0x402B54C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
