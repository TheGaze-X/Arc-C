using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B3 RID: 13235
	[Token(Token = "0x20033B3")]
	public class UIBattleSandboxSysMenuStyle : MonoBehaviour, IHotfixable
	{
		// Token: 0x060151EF RID: 86511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151EF")]
		[Address(RVA = "0xD951C0", Offset = "0xD93DC0", VA = "0x180D951C0", Slot = "4")]
		public virtual void SetData(bool isEmergency, bool showEnemyInfo, SandboxBattleStyle style = SandboxBattleStyle.DEFAULT)
		{
		}

		// Token: 0x060151F0 RID: 86512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F0")]
		[Address(RVA = "0xD95150", Offset = "0xD93D50", VA = "0x180D95150", Slot = "5")]
		public virtual void Hide()
		{
		}

		// Token: 0x060151F1 RID: 86513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F1")]
		[Address(RVA = "0xD95720", Offset = "0xD94320", VA = "0x180D95720", Slot = "6")]
		public virtual void Show()
		{
		}

		// Token: 0x060151F2 RID: 86514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F2")]
		[Address(RVA = "0xD95790", Offset = "0xD94390", VA = "0x180D95790")]
		public UIBattleSandboxSysMenuStyle()
		{
		}

		// Token: 0x040192BB RID: 103099
		[Token(Token = "0x40192BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _mainTexture;

		// Token: 0x040192BC RID: 103100
		[Token(Token = "0x40192BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _confirmButtonImage;

		// Token: 0x040192BD RID: 103101
		[Token(Token = "0x40192BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _mainTitleText;

		// Token: 0x040192BE RID: 103102
		[Token(Token = "0x40192BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContentText;

		// Token: 0x040192BF RID: 103103
		[Token(Token = "0x40192BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _extraText;

		// Token: 0x040192C0 RID: 103104
		[Token(Token = "0x40192C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _enemyWidget;

		// Token: 0x040192C1 RID: 103105
		[Token(Token = "0x40192C1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _remainEnemyAmount;

		// Token: 0x040192C2 RID: 103106
		[Token(Token = "0x40192C2")]
		[FieldOffset(Offset = "0x50")]
		[Header("Config")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x040192C3 RID: 103107
		[Token(Token = "0x40192C3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _defaultTitle;

		// Token: 0x040192C4 RID: 103108
		[Token(Token = "0x40192C4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _emergencyTitle;

		// Token: 0x040192C5 RID: 103109
		[Token(Token = "0x40192C5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _defaultTextureName;

		// Token: 0x040192C6 RID: 103110
		[Token(Token = "0x40192C6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _emergencyTextureName;

		// Token: 0x040192C7 RID: 103111
		[Token(Token = "0x40192C7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _defaultButtonColor;

		// Token: 0x040192C8 RID: 103112
		[Token(Token = "0x40192C8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _emergencyButtonColor;

		// Token: 0x040192C9 RID: 103113
		[Token(Token = "0x40192C9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _defaultTextColor;

		// Token: 0x040192CA RID: 103114
		[Token(Token = "0x40192CA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _emergencyTextColor;

		// Token: 0x040192CB RID: 103115
		[Token(Token = "0x40192CB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _defaultExtraText;

		// Token: 0x040192CC RID: 103116
		[Token(Token = "0x40192CC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _emergencyExtraText;

		// Token: 0x040192CD RID: 103117
		[Token(Token = "0x40192CD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string[] _mainContentList;

		// Token: 0x040192CE RID: 103118
		[Token(Token = "0x40192CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040192CF RID: 103119
		[Token(Token = "0x40192CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040192D0 RID: 103120
		[Token(Token = "0x40192D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040192D1 RID: 103121
		[Token(Token = "0x40192D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
