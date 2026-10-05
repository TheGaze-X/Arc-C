using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007936 RID: 31030
	[Token(Token = "0x2007936")]
	public class Act1ArcadeBadgeBookTierItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B898 RID: 178328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B898")]
		[Address(RVA = "0x276EF80", Offset = "0x276DB80", VA = "0x18276EF80")]
		public void Render(string actId, Act1ArcadeBadgeBookItemTierViewModel model)
		{
		}

		// Token: 0x0602B899 RID: 178329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B899")]
		[Address(RVA = "0x276F510", Offset = "0x276E110", VA = "0x18276F510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B89A RID: 178330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B89A")]
		[Address(RVA = "0x276F5B0", Offset = "0x276E1B0", VA = "0x18276F5B0")]
		public Act1ArcadeBadgeBookTierItemView()
		{
		}

		// Token: 0x0403EF4B RID: 257867
		[Token(Token = "0x403EF4B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _titleBackgroundImage;

		// Token: 0x0403EF4C RID: 257868
		[Token(Token = "0x403EF4C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _titleNormalColor;

		// Token: 0x0403EF4D RID: 257869
		[Token(Token = "0x403EF4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _titleLockedColor;

		// Token: 0x0403EF4E RID: 257870
		[Token(Token = "0x403EF4E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _tierIconImage;

		// Token: 0x0403EF4F RID: 257871
		[Token(Token = "0x403EF4F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0403EF50 RID: 257872
		[Token(Token = "0x403EF50")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _titleIconImage;

		// Token: 0x0403EF51 RID: 257873
		[Token(Token = "0x403EF51")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _hasUnlockedTitleIcon;

		// Token: 0x0403EF52 RID: 257874
		[Token(Token = "0x403EF52")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _hasPreservedTitleIcon;

		// Token: 0x0403EF53 RID: 257875
		[Token(Token = "0x403EF53")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _unlockDescText;

		// Token: 0x0403EF54 RID: 257876
		[Token(Token = "0x403EF54")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _unlockHighlightColor;

		// Token: 0x0403EF55 RID: 257877
		[Token(Token = "0x403EF55")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0403EF56 RID: 257878
		[Token(Token = "0x403EF56")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _showDescWhileLocked;

		// Token: 0x0403EF57 RID: 257879
		[Token(Token = "0x403EF57")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Color _descNormalColor;

		// Token: 0x0403EF58 RID: 257880
		[Token(Token = "0x403EF58")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Color _descLockedColor;

		// Token: 0x0403EF59 RID: 257881
		[Token(Token = "0x403EF59")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0403EF5A RID: 257882
		[Token(Token = "0x403EF5A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _unlockedPanel;

		// Token: 0x0403EF5B RID: 257883
		[Token(Token = "0x403EF5B")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_hasInited;

		// Token: 0x0403EF5C RID: 257884
		[Token(Token = "0x403EF5C")]
		[FieldOffset(Offset = "0xC0")]
		private ILoadAsset m_iAssetLoader;

		// Token: 0x0403EF5D RID: 257885
		[Token(Token = "0x403EF5D")]
		[FieldOffset(Offset = "0xC8")]
		private int m_cachedTier;

		// Token: 0x0403EF5E RID: 257886
		[Token(Token = "0x403EF5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EF5F RID: 257887
		[Token(Token = "0x403EF5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EF60 RID: 257888
		[Token(Token = "0x403EF60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
