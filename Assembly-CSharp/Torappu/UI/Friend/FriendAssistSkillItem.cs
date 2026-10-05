using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DA2 RID: 19874
	[Token(Token = "0x2004DA2")]
	public class FriendAssistSkillItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DB9E RID: 121758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB9E")]
		[Address(RVA = "0x173D2C0", Offset = "0x173BEC0", VA = "0x18173D2C0")]
		public void Render(PlayerCharSkill charSkill, int mainSkillLvl, FriendAssistSkillItem.RenderOptions options)
		{
		}

		// Token: 0x0601DB9F RID: 121759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB9F")]
		[Address(RVA = "0x173D240", Offset = "0x173BE40", VA = "0x18173D240")]
		public void OnClick()
		{
		}

		// Token: 0x0601DBA0 RID: 121760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA0")]
		[Address(RVA = "0x173D610", Offset = "0x173C210", VA = "0x18173D610")]
		public FriendAssistSkillItem()
		{
		}

		// Token: 0x040274D0 RID: 160976
		[Token(Token = "0x40274D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x040274D1 RID: 160977
		[Token(Token = "0x40274D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconPanel;

		// Token: 0x040274D2 RID: 160978
		[Token(Token = "0x40274D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _slectedPanel;

		// Token: 0x040274D3 RID: 160979
		[Token(Token = "0x40274D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _noneSkillPanel;

		// Token: 0x040274D4 RID: 160980
		[Token(Token = "0x40274D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockSkillPanel;

		// Token: 0x040274D5 RID: 160981
		[Token(Token = "0x40274D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _detailPanel;

		// Token: 0x040274D6 RID: 160982
		[Token(Token = "0x40274D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _levelPanel;

		// Token: 0x040274D7 RID: 160983
		[Token(Token = "0x40274D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040274D8 RID: 160984
		[Token(Token = "0x40274D8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x040274D9 RID: 160985
		[Token(Token = "0x40274D9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _levelBg;

		// Token: 0x040274DA RID: 160986
		[Token(Token = "0x40274DA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _skillSpecializedLevelIcon;

		// Token: 0x040274DB RID: 160987
		[Token(Token = "0x40274DB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _skillLevelPanel;

		// Token: 0x040274DC RID: 160988
		[Token(Token = "0x40274DC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _skillSpecializedLevelPanel;

		// Token: 0x040274DD RID: 160989
		[Token(Token = "0x40274DD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x040274DE RID: 160990
		[Token(Token = "0x40274DE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _normalSkillBgColor;

		// Token: 0x040274DF RID: 160991
		[Token(Token = "0x40274DF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _limitSkillBgColor;

		// Token: 0x040274E0 RID: 160992
		[Token(Token = "0x40274E0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _unselectAlpha;

		// Token: 0x040274E1 RID: 160993
		[Token(Token = "0x40274E1")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public Action<string, FriendAssistItemFloatPanel.ItemType> onItemClicked;

		// Token: 0x040274E2 RID: 160994
		[Token(Token = "0x40274E2")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedSkillId;

		// Token: 0x040274E3 RID: 160995
		[Token(Token = "0x40274E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040274E4 RID: 160996
		[Token(Token = "0x40274E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040274E5 RID: 160997
		[Token(Token = "0x40274E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DA3 RID: 19875
		[Token(Token = "0x2004DA3")]
		public class RenderOptions
		{
			// Token: 0x0601DBA1 RID: 121761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DBA1")]
			[Address(RVA = "0x174F770", Offset = "0x174E370", VA = "0x18174F770")]
			public RenderOptions()
			{
			}

			// Token: 0x040274E6 RID: 160998
			[Token(Token = "0x40274E6")]
			[FieldOffset(Offset = "0x10")]
			public bool selected;

			// Token: 0x040274E7 RID: 160999
			[Token(Token = "0x40274E7")]
			[FieldOffset(Offset = "0x11")]
			public bool showDetail;

			// Token: 0x040274E8 RID: 161000
			[Token(Token = "0x40274E8")]
			[FieldOffset(Offset = "0x12")]
			public bool showLevel;

			// Token: 0x040274E9 RID: 161001
			[Token(Token = "0x40274E9")]
			[FieldOffset(Offset = "0x13")]
			public bool skillLimited;

			// Token: 0x040274EA RID: 161002
			[Token(Token = "0x40274EA")]
			[FieldOffset(Offset = "0x14")]
			public bool clickable;
		}
	}
}
