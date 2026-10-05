using System;
using Il2CppDummyDll;
using Torappu.UI.Friend;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F4C RID: 20300
	[Token(Token = "0x2004F4C")]
	public class EnemyDuelBattleFinishRankItemView : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x0601E39C RID: 123804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E39C")]
		[Address(RVA = "0x17E1530", Offset = "0x17E0130", VA = "0x1817E1530")]
		public void Render(SettlementRankItemModel model, int index)
		{
		}

		// Token: 0x0601E39D RID: 123805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E39D")]
		[Address(RVA = "0x17E1490", Offset = "0x17E0090", VA = "0x1817E1490", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601E39E RID: 123806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E39E")]
		[Address(RVA = "0x17E1F60", Offset = "0x17E0B60", VA = "0x1817E1F60")]
		private void _RenderAvatar(SettlementRankItemModel model)
		{
		}

		// Token: 0x0601E39F RID: 123807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E39F")]
		[Address(RVA = "0x17E2110", Offset = "0x17E0D10", VA = "0x1817E2110")]
		private void _RenderNameCardSkin(string skinId, int tmpl)
		{
		}

		// Token: 0x0601E3A0 RID: 123808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A0")]
		[Address(RVA = "0x17E1E00", Offset = "0x17E0A00", VA = "0x1817E1E00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E3A1 RID: 123809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A1")]
		[Address(RVA = "0x17E2220", Offset = "0x17E0E20", VA = "0x1817E2220")]
		public EnemyDuelBattleFinishRankItemView()
		{
		}

		// Token: 0x040284B3 RID: 165043
		[Token(Token = "0x40284B3")]
		private const string NICK_ID_FORMAT = "#{0}";

		// Token: 0x040284B4 RID: 165044
		[Token(Token = "0x40284B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _emptyToggle;

		// Token: 0x040284B5 RID: 165045
		[Token(Token = "0x40284B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _rank;

		// Token: 0x040284B6 RID: 165046
		[Token(Token = "0x40284B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _playerRankColor;

		// Token: 0x040284B7 RID: 165047
		[Token(Token = "0x40284B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _defaultRankColor;

		// Token: 0x040284B8 RID: 165048
		[Token(Token = "0x40284B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _name;

		// Token: 0x040284B9 RID: 165049
		[Token(Token = "0x40284B9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _nickId;

		// Token: 0x040284BA RID: 165050
		[Token(Token = "0x40284BA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _num;

		// Token: 0x040284BB RID: 165051
		[Token(Token = "0x40284BB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateToggle _iconToggle;

		// Token: 0x040284BC RID: 165052
		[Token(Token = "0x40284BC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoStateToggle _avatarToggle;

		// Token: 0x040284BD RID: 165053
		[Token(Token = "0x40284BD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x040284BE RID: 165054
		[Token(Token = "0x40284BE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _npcAvatar;

		// Token: 0x040284BF RID: 165055
		[Token(Token = "0x40284BF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x040284C0 RID: 165056
		[Token(Token = "0x40284C0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _playerFrame;

		// Token: 0x040284C1 RID: 165057
		[Token(Token = "0x40284C1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _arrowAnim;

		// Token: 0x040284C2 RID: 165058
		[Token(Token = "0x40284C2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _imageBG;

		// Token: 0x040284C3 RID: 165059
		[Token(Token = "0x40284C3")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x040284C4 RID: 165060
		[Token(Token = "0x40284C4")]
		[FieldOffset(Offset = "0xB8")]
		private PlayerAvatarView m_avatar;

		// Token: 0x040284C5 RID: 165061
		[Token(Token = "0x40284C5")]
		[FieldOffset(Offset = "0xC0")]
		private PlayerAvatarView.Params m_avatarParam;

		// Token: 0x040284C6 RID: 165062
		[Token(Token = "0x40284C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040284C7 RID: 165063
		[Token(Token = "0x40284C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x040284C8 RID: 165064
		[Token(Token = "0x40284C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderAvatar;

		// Token: 0x040284C9 RID: 165065
		[Token(Token = "0x40284C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderNameCardSkin;

		// Token: 0x040284CA RID: 165066
		[Token(Token = "0x40284CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040284CB RID: 165067
		[Token(Token = "0x40284CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
