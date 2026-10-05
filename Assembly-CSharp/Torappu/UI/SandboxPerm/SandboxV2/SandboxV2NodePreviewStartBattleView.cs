using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004274 RID: 17012
	[Token(Token = "0x2004274")]
	public class SandboxV2NodePreviewStartBattleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A367 RID: 107367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A367")]
		[Address(RVA = "0x131F8B0", Offset = "0x131E4B0", VA = "0x18131F8B0")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601A368 RID: 107368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A368")]
		[Address(RVA = "0x131FC80", Offset = "0x131E880", VA = "0x18131FC80")]
		public SandboxV2NodePreviewStartBattleView()
		{
		}

		// Token: 0x040212B6 RID: 135862
		[Token(Token = "0x40212B6")]
		private const string AP_COST_FORMAT = "-{0}";

		// Token: 0x040212B7 RID: 135863
		[Token(Token = "0x40212B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _dungeonAtlasObject;

		// Token: 0x040212B8 RID: 135864
		[Token(Token = "0x40212B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgStartBattle;

		// Token: 0x040212B9 RID: 135865
		[Token(Token = "0x40212B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorStartBattleLocked;

		// Token: 0x040212BA RID: 135866
		[Token(Token = "0x40212BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorStartBattleUnlocked;

		// Token: 0x040212BB RID: 135867
		[Token(Token = "0x40212BB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] _startBattleSpriteNames;

		// Token: 0x040212BC RID: 135868
		[Token(Token = "0x40212BC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlAp;

		// Token: 0x040212BD RID: 135869
		[Token(Token = "0x40212BD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textAp;

		// Token: 0x040212BE RID: 135870
		[Token(Token = "0x40212BE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textStartBattle;

		// Token: 0x040212BF RID: 135871
		[Token(Token = "0x40212BF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _pnlUnlocked;

		// Token: 0x040212C0 RID: 135872
		[Token(Token = "0x40212C0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x040212C1 RID: 135873
		[Token(Token = "0x40212C1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textLockedTip;

		// Token: 0x040212C2 RID: 135874
		[Token(Token = "0x40212C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040212C3 RID: 135875
		[Token(Token = "0x40212C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
