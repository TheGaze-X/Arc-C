using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200703F RID: 28735
	[Token(Token = "0x200703F")]
	public class ActMultiV3PrepareMainCharSkillItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006065 RID: 24677
		// (get) Token: 0x06028CAB RID: 167083 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CAC RID: 167084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006065")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x6028CAB")]
			[Address(RVA = "0x24382E0", Offset = "0x2436EE0", VA = "0x1824382E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028CAC")]
			[Address(RVA = "0x2438340", Offset = "0x2436F40", VA = "0x182438340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028CAD RID: 167085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CAD")]
		[Address(RVA = "0x2438040", Offset = "0x2436C40", VA = "0x182438040")]
		public void Render(int cardId, bool isSelect, SkillItemViewModel skillModel)
		{
		}

		// Token: 0x06028CAE RID: 167086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CAE")]
		[Address(RVA = "0x2437F60", Offset = "0x2436B60", VA = "0x182437F60")]
		public void OnSkillSelect()
		{
		}

		// Token: 0x06028CAF RID: 167087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CAF")]
		[Address(RVA = "0x2438270", Offset = "0x2436E70", VA = "0x182438270")]
		public ActMultiV3PrepareMainCharSkillItem()
		{
		}

		// Token: 0x0403A299 RID: 238233
		[Token(Token = "0x403A299")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x0403A29A RID: 238234
		[Token(Token = "0x403A29A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403A29B RID: 238235
		[Token(Token = "0x403A29B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0403A29C RID: 238236
		[Token(Token = "0x403A29C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0403A29D RID: 238237
		[Token(Token = "0x403A29D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x0403A29E RID: 238238
		[Token(Token = "0x403A29E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSkillLv;

		// Token: 0x0403A29F RID: 238239
		[Token(Token = "0x403A29F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgSpecializeLv;

		// Token: 0x0403A2A0 RID: 238240
		[Token(Token = "0x403A2A0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite[] _skillLevelImages;

		// Token: 0x0403A2A1 RID: 238241
		[Token(Token = "0x403A2A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403A2A2 RID: 238242
		[Token(Token = "0x403A2A2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x0403A2A3 RID: 238243
		[Token(Token = "0x403A2A3")]
		[FieldOffset(Offset = "0x64")]
		private int m_cardId;

		// Token: 0x0403A2A4 RID: 238244
		[Token(Token = "0x403A2A4")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isSelect;

		// Token: 0x0403A2A5 RID: 238245
		[Token(Token = "0x403A2A5")]
		[FieldOffset(Offset = "0x70")]
		private SkillItemViewModel m_skillModel;

		// Token: 0x0403A2A7 RID: 238247
		[Token(Token = "0x403A2A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x0403A2A8 RID: 238248
		[Token(Token = "0x403A2A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x0403A2A9 RID: 238249
		[Token(Token = "0x403A2A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A2AA RID: 238250
		[Token(Token = "0x403A2AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSkillSelect;

		// Token: 0x0403A2AB RID: 238251
		[Token(Token = "0x403A2AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
