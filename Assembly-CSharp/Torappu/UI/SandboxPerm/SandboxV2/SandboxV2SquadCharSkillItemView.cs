using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200442C RID: 17452
	[Token(Token = "0x200442C")]
	public class SandboxV2SquadCharSkillItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x0601AA76 RID: 109174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA77 RID: 109175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F2E")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x601AA76")]
			[Address(RVA = "0x13C67C0", Offset = "0x13C53C0", VA = "0x1813C67C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA77")]
			[Address(RVA = "0x13C6820", Offset = "0x13C5420", VA = "0x1813C6820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AA78 RID: 109176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA78")]
		[Address(RVA = "0x13C6410", Offset = "0x13C5010", VA = "0x1813C6410")]
		public void Render(int instId, SandboxV2CharSkillModel skillModel, bool isSelect)
		{
		}

		// Token: 0x0601AA79 RID: 109177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA79")]
		[Address(RVA = "0x13C66B0", Offset = "0x13C52B0", VA = "0x1813C66B0")]
		private void _HideAll()
		{
		}

		// Token: 0x0601AA7A RID: 109178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA7A")]
		[Address(RVA = "0x13C6330", Offset = "0x13C4F30", VA = "0x1813C6330")]
		public void OnSkillSelect()
		{
		}

		// Token: 0x0601AA7B RID: 109179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA7B")]
		[Address(RVA = "0x13C6750", Offset = "0x13C5350", VA = "0x1813C6750")]
		public SandboxV2SquadCharSkillItemView()
		{
		}

		// Token: 0x04022054 RID: 139348
		[Token(Token = "0x4022054")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x04022055 RID: 139349
		[Token(Token = "0x4022055")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconSelectGo;

		// Token: 0x04022056 RID: 139350
		[Token(Token = "0x4022056")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x04022057 RID: 139351
		[Token(Token = "0x4022057")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x04022058 RID: 139352
		[Token(Token = "0x4022058")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x04022059 RID: 139353
		[Token(Token = "0x4022059")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x0402205A RID: 139354
		[Token(Token = "0x402205A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textSkillLv;

		// Token: 0x0402205B RID: 139355
		[Token(Token = "0x402205B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgSpecializeLv;

		// Token: 0x0402205C RID: 139356
		[Token(Token = "0x402205C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite[] _skillLevelImages;

		// Token: 0x0402205D RID: 139357
		[Token(Token = "0x402205D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402205E RID: 139358
		[Token(Token = "0x402205E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x0402205F RID: 139359
		[Token(Token = "0x402205F")]
		[FieldOffset(Offset = "0x6C")]
		private int m_instId;

		// Token: 0x04022060 RID: 139360
		[Token(Token = "0x4022060")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isSelect;

		// Token: 0x04022061 RID: 139361
		[Token(Token = "0x4022061")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2CharSkillModel m_skillModel;

		// Token: 0x04022063 RID: 139363
		[Token(Token = "0x4022063")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x04022064 RID: 139364
		[Token(Token = "0x4022064")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x04022065 RID: 139365
		[Token(Token = "0x4022065")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022066 RID: 139366
		[Token(Token = "0x4022066")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideAll;

		// Token: 0x04022067 RID: 139367
		[Token(Token = "0x4022067")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSkillSelect;

		// Token: 0x04022068 RID: 139368
		[Token(Token = "0x4022068")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
