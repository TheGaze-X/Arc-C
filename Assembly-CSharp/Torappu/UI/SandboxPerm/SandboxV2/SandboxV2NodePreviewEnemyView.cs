using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200426D RID: 17005
	[Token(Token = "0x200426D")]
	public class SandboxV2NodePreviewEnemyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A354 RID: 107348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A354")]
		[Address(RVA = "0x131E5C0", Offset = "0x131D1C0", VA = "0x18131E5C0")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601A355 RID: 107349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A355")]
		[Address(RVA = "0x131E920", Offset = "0x131D520", VA = "0x18131E920")]
		public SandboxV2NodePreviewEnemyView()
		{
		}

		// Token: 0x04021281 RID: 135809
		[Token(Token = "0x4021281")]
		private const string REMAIN_ENEMY_FORMAT = "{0}%";

		// Token: 0x04021282 RID: 135810
		[Token(Token = "0x4021282")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _dungeonAtlasObject;

		// Token: 0x04021283 RID: 135811
		[Token(Token = "0x4021283")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlEnemyIconNone;

		// Token: 0x04021284 RID: 135812
		[Token(Token = "0x4021284")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlEnemyIconNormal;

		// Token: 0x04021285 RID: 135813
		[Token(Token = "0x4021285")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlEnemyIconRush;

		// Token: 0x04021286 RID: 135814
		[Token(Token = "0x4021286")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _btnEnemyDetail;

		// Token: 0x04021287 RID: 135815
		[Token(Token = "0x4021287")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlEnemyHp;

		// Token: 0x04021288 RID: 135816
		[Token(Token = "0x4021288")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _pnlEnemyHpBkg;

		// Token: 0x04021289 RID: 135817
		[Token(Token = "0x4021289")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _hpBar;

		// Token: 0x0402128A RID: 135818
		[Token(Token = "0x402128A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _hpBarBkg;

		// Token: 0x0402128B RID: 135819
		[Token(Token = "0x402128B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textEnemyHpRatio;

		// Token: 0x0402128C RID: 135820
		[Token(Token = "0x402128C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _sliderEnemyHpRatio;

		// Token: 0x0402128D RID: 135821
		[Token(Token = "0x402128D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2NodePreviewEnemyView.EnemyHpBarConfig[] _hpBarConfigs;

		// Token: 0x0402128E RID: 135822
		[Token(Token = "0x402128E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402128F RID: 135823
		[Token(Token = "0x402128F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200426E RID: 17006
		[Token(Token = "0x200426E")]
		[Serializable]
		private class EnemyHpBarConfig
		{
			// Token: 0x0601A356 RID: 107350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A356")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EnemyHpBarConfig()
			{
			}

			// Token: 0x04021290 RID: 135824
			[Token(Token = "0x4021290")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string hpBarSpriteName;

			// Token: 0x04021291 RID: 135825
			[Token(Token = "0x4021291")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public Color hpBarColor;
		}
	}
}
