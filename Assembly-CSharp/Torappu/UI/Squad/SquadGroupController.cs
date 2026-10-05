using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E21 RID: 15905
	[Token(Token = "0x2003E21")]
	public class SquadGroupController : DataBinder<SquadGroupViewProperty>, IHotfixable
	{
		// Token: 0x06018BB4 RID: 101300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BB4")]
		[Address(RVA = "0x113DF70", Offset = "0x113CB70", VA = "0x18113DF70")]
		public void InjectPlugin(SquadHomePlugin statePlugin)
		{
		}

		// Token: 0x06018BB5 RID: 101301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BB5")]
		[Address(RVA = "0x113E220", Offset = "0x113CE20", VA = "0x18113E220", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x06018BB6 RID: 101302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BB6")]
		[Address(RVA = "0x113EA40", Offset = "0x113D640", VA = "0x18113EA40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018BB7 RID: 101303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BB7")]
		[Address(RVA = "0x113EC40", Offset = "0x113D840", VA = "0x18113EC40")]
		private void _OnSquadMemberClick(int index)
		{
		}

		// Token: 0x06018BB8 RID: 101304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BB8")]
		[Address(RVA = "0x113EBC0", Offset = "0x113D7C0", VA = "0x18113EBC0")]
		private void _OnShowLeftArrow(bool isShow)
		{
		}

		// Token: 0x06018BB9 RID: 101305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BB9")]
		[Address(RVA = "0x113ECD0", Offset = "0x113D8D0", VA = "0x18113ECD0")]
		private void _RegisterFirstEmptySlotToAVG()
		{
		}

		// Token: 0x06018BBA RID: 101306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BBA")]
		[Address(RVA = "0x113EE60", Offset = "0x113DA60", VA = "0x18113EE60")]
		public SquadGroupController()
		{
		}

		// Token: 0x0401E614 RID: 124436
		[Token(Token = "0x401E614")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSquadTabs;

		// Token: 0x0401E615 RID: 124437
		[Token(Token = "0x401E615")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Show when the squad is not editable")]
		private GameObject _panelDisableLock;

		// Token: 0x0401E616 RID: 124438
		[Token(Token = "0x401E616")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Show when it's skillselectable predefined mode")]
		private GameObject _panelSkillSelectablePredefined;

		// Token: 0x0401E617 RID: 124439
		[Token(Token = "0x401E617")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SquadTabView[] _tabs;

		// Token: 0x0401E618 RID: 124440
		[Token(Token = "0x401E618")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SquadCardView[] _cards;

		// Token: 0x0401E619 RID: 124441
		[Token(Token = "0x401E619")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SquadGroupController.SquadMemberClickEvent _onSquadMemberClick;

		// Token: 0x0401E61A RID: 124442
		[Token(Token = "0x401E61A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _leftbtn;

		// Token: 0x0401E61B RID: 124443
		[Token(Token = "0x401E61B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _rightbtn;

		// Token: 0x0401E61C RID: 124444
		[Token(Token = "0x401E61C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _multiEditBtn;

		// Token: 0x0401E61D RID: 124445
		[Token(Token = "0x401E61D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _clearAllBtn;

		// Token: 0x0401E61E RID: 124446
		[Token(Token = "0x401E61E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _cardBanPrefab;

		// Token: 0x0401E61F RID: 124447
		[Token(Token = "0x401E61F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401E620 RID: 124448
		[Token(Token = "0x401E620")]
		[FieldOffset(Offset = "0x79")]
		private bool m_isCardClickable;

		// Token: 0x0401E621 RID: 124449
		[Token(Token = "0x401E621")]
		[FieldOffset(Offset = "0x80")]
		private SquadHomePlugin m_statePlugin;

		// Token: 0x0401E622 RID: 124450
		[Token(Token = "0x401E622")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x0401E623 RID: 124451
		[Token(Token = "0x401E623")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E624 RID: 124452
		[Token(Token = "0x401E624")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E625 RID: 124453
		[Token(Token = "0x401E625")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSquadMemberClick;

		// Token: 0x0401E626 RID: 124454
		[Token(Token = "0x401E626")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnShowLeftArrow;

		// Token: 0x0401E627 RID: 124455
		[Token(Token = "0x401E627")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterFirstEmptySlotToAVG;

		// Token: 0x0401E628 RID: 124456
		[Token(Token = "0x401E628")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E22 RID: 15906
		[Token(Token = "0x2003E22")]
		[Serializable]
		public class SquadMemberClickEvent : UnityEvent<int>
		{
			// Token: 0x06018BBB RID: 101307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018BBB")]
			[Address(RVA = "0x1149160", Offset = "0x1147D60", VA = "0x181149160")]
			public SquadMemberClickEvent()
			{
			}
		}
	}
}
