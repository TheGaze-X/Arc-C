using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061A8 RID: 25000
	[Token(Token = "0x20061A8")]
	public class BossRushSquadTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602414A RID: 147786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602414A")]
		[Address(RVA = "0x1EC1DF0", Offset = "0x1EC09F0", VA = "0x181EC1DF0")]
		public void Render(int index, string name, bool isSelected, bool isFreeTeam)
		{
		}

		// Token: 0x0602414B RID: 147787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602414B")]
		[Address(RVA = "0x1EC1D80", Offset = "0x1EC0980", VA = "0x181EC1D80")]
		public void EventOnTabClick()
		{
		}

		// Token: 0x0602414C RID: 147788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602414C")]
		[Address(RVA = "0x1EC1F70", Offset = "0x1EC0B70", VA = "0x181EC1F70")]
		public BossRushSquadTabView()
		{
		}

		// Token: 0x04032222 RID: 205346
		[Token(Token = "0x4032222")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04032223 RID: 205347
		[Token(Token = "0x4032223")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x04032224 RID: 205348
		[Token(Token = "0x4032224")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameUnselected;

		// Token: 0x04032225 RID: 205349
		[Token(Token = "0x4032225")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgSelect;

		// Token: 0x04032226 RID: 205350
		[Token(Token = "0x4032226")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgUnselect;

		// Token: 0x04032227 RID: 205351
		[Token(Token = "0x4032227")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _spriteTeamSelect;

		// Token: 0x04032228 RID: 205352
		[Token(Token = "0x4032228")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _spriteTeamUnselect;

		// Token: 0x04032229 RID: 205353
		[Token(Token = "0x4032229")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _spriteFreeTeamSelect;

		// Token: 0x0403222A RID: 205354
		[Token(Token = "0x403222A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite _spriteFreeTeamUnselect;

		// Token: 0x0403222B RID: 205355
		[Token(Token = "0x403222B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objFreeTeamDec;

		// Token: 0x0403222C RID: 205356
		[Token(Token = "0x403222C")]
		[FieldOffset(Offset = "0x68")]
		private int m_indexCache;

		// Token: 0x0403222D RID: 205357
		[Token(Token = "0x403222D")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<int> onTabClick;

		// Token: 0x0403222E RID: 205358
		[Token(Token = "0x403222E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403222F RID: 205359
		[Token(Token = "0x403222F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnTabClick;

		// Token: 0x04032230 RID: 205360
		[Token(Token = "0x4032230")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
