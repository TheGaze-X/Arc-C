using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033AE RID: 13230
	[Token(Token = "0x20033AE")]
	public class UIBattleSandboxConstructTopBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x060151D7 RID: 86487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151D7")]
		[Address(RVA = "0xD8AE40", Offset = "0xD89A40", VA = "0x180D8AE40")]
		public void Init(UIBattleSandboxConstructTopBar.Option option)
		{
		}

		// Token: 0x060151D8 RID: 86488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151D8")]
		[Address(RVA = "0xD8B160", Offset = "0xD89D60", VA = "0x180D8B160")]
		public void MoveWithAnim(bool isLeft)
		{
		}

		// Token: 0x060151D9 RID: 86489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151D9")]
		[Address(RVA = "0xD8B3E0", Offset = "0xD89FE0", VA = "0x180D8B3E0")]
		public UIBattleSandboxConstructTopBar()
		{
		}

		// Token: 0x04019285 RID: 103045
		[Token(Token = "0x4019285")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Image _icon;

		// Token: 0x04019286 RID: 103046
		[Token(Token = "0x4019286")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Sprite _baseIcon;

		// Token: 0x04019287 RID: 103047
		[Token(Token = "0x4019287")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public Sprite _portIcon;

		// Token: 0x04019288 RID: 103048
		[Token(Token = "0x4019288")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Text _lvlText;

		// Token: 0x04019289 RID: 103049
		[Token(Token = "0x4019289")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public Text _nameText;

		// Token: 0x0401928A RID: 103050
		[Token(Token = "0x401928A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public Text _uidText;

		// Token: 0x0401928B RID: 103051
		[Token(Token = "0x401928B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public UIAnimationLocation _location;

		// Token: 0x0401928C RID: 103052
		[Token(Token = "0x401928C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public UIAnimationLocation _locationOut;

		// Token: 0x0401928D RID: 103053
		[Token(Token = "0x401928D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public Ease _ease;

		// Token: 0x0401928E RID: 103054
		[Token(Token = "0x401928E")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_tween;

		// Token: 0x0401928F RID: 103055
		[Token(Token = "0x401928F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04019290 RID: 103056
		[Token(Token = "0x4019290")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MoveWithAnim;

		// Token: 0x04019291 RID: 103057
		[Token(Token = "0x4019291")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033AF RID: 13231
		[Token(Token = "0x20033AF")]
		public struct Option
		{
			// Token: 0x04019292 RID: 103058
			[Token(Token = "0x4019292")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04019293 RID: 103059
			[Token(Token = "0x4019293")]
			[FieldOffset(Offset = "0x8")]
			public string stageName;

			// Token: 0x04019294 RID: 103060
			[Token(Token = "0x4019294")]
			[FieldOffset(Offset = "0x10")]
			public bool isBase;
		}
	}
}
