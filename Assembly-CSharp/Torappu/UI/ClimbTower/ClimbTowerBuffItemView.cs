using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CE1 RID: 23777
	[Token(Token = "0x2005CE1")]
	public class ClimbTowerBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170050E7 RID: 20711
		// (get) Token: 0x060226B5 RID: 140981 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060226B6 RID: 140982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050E7")]
		public Action<ProfessionCategory> onBuffToggle
		{
			[Token(Token = "0x60226B5")]
			[Address(RVA = "0x1CCD8A0", Offset = "0x1CCC4A0", VA = "0x181CCD8A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60226B6")]
			[Address(RVA = "0x1CCD900", Offset = "0x1CCC500", VA = "0x181CCD900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060226B7 RID: 140983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226B7")]
		[Address(RVA = "0x1CCCFC0", Offset = "0x1CCBBC0", VA = "0x181CCCFC0")]
		public void Render(TacticalBuffModel tacticalBuffModel, bool canToggle)
		{
		}

		// Token: 0x060226B8 RID: 140984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226B8")]
		[Address(RVA = "0x1CCD6C0", Offset = "0x1CCC2C0", VA = "0x181CCD6C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060226B9 RID: 140985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226B9")]
		[Address(RVA = "0x1CCCE60", Offset = "0x1CCBA60", VA = "0x181CCCE60")]
		public void OnBuffToggle()
		{
		}

		// Token: 0x060226BA RID: 140986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226BA")]
		[Address(RVA = "0x1CCD830", Offset = "0x1CCC430", VA = "0x181CCD830")]
		public ClimbTowerBuffItemView()
		{
		}

		// Token: 0x0402F4EF RID: 193775
		[Token(Token = "0x402F4EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textProfession;

		// Token: 0x0402F4F0 RID: 193776
		[Token(Token = "0x402F4F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F4F1 RID: 193777
		[Token(Token = "0x402F4F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textBuffName;

		// Token: 0x0402F4F2 RID: 193778
		[Token(Token = "0x402F4F2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgProfession;

		// Token: 0x0402F4F3 RID: 193779
		[Token(Token = "0x402F4F3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _professionAtlas;

		// Token: 0x0402F4F4 RID: 193780
		[Token(Token = "0x402F4F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _toggleAnim;

		// Token: 0x0402F4F5 RID: 193781
		[Token(Token = "0x402F4F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgToggleBg;

		// Token: 0x0402F4F6 RID: 193782
		[Token(Token = "0x402F4F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _disableToggleAlpha;

		// Token: 0x0402F4F7 RID: 193783
		[Token(Token = "0x402F4F7")]
		[FieldOffset(Offset = "0x60")]
		private TacticalBuffModel m_tacticalBuffModel;

		// Token: 0x0402F4F8 RID: 193784
		[Token(Token = "0x402F4F8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0402F4F9 RID: 193785
		[Token(Token = "0x402F4F9")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_toggleSwitchTween;

		// Token: 0x0402F4FB RID: 193787
		[Token(Token = "0x402F4FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBuffToggle;

		// Token: 0x0402F4FC RID: 193788
		[Token(Token = "0x402F4FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBuffToggle;

		// Token: 0x0402F4FD RID: 193789
		[Token(Token = "0x402F4FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F4FE RID: 193790
		[Token(Token = "0x402F4FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F4FF RID: 193791
		[Token(Token = "0x402F4FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBuffToggle;

		// Token: 0x0402F500 RID: 193792
		[Token(Token = "0x402F500")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
