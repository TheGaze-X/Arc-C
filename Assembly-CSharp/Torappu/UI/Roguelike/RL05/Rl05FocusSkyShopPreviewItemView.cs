using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055D7 RID: 21975
	[Token(Token = "0x20055D7")]
	public class Rl05FocusSkyShopPreviewItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602041C RID: 132124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602041C")]
		[Address(RVA = "0x1A72060", Offset = "0x1A70C60", VA = "0x181A72060")]
		public void Render(RoguelikeTopicItemModel model, string topicId, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602041D RID: 132125 RVA: 0x000B5128 File Offset: 0x000B3328
		[Token(Token = "0x602041D")]
		[Address(RVA = "0x1A72450", Offset = "0x1A71050", VA = "0x181A72450")]
		private Color _GetBgColor(Rl05FocusSkyShopPreviewItemView.NameBgColorType clrType)
		{
			return default(Color);
		}

		// Token: 0x0602041E RID: 132126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602041E")]
		[Address(RVA = "0x1A72540", Offset = "0x1A71140", VA = "0x181A72540")]
		public Rl05FocusSkyShopPreviewItemView()
		{
		}

		// Token: 0x0402BA2F RID: 178735
		[Token(Token = "0x402BA2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _underTex;

		// Token: 0x0402BA30 RID: 178736
		[Token(Token = "0x402BA30")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL05ItemIconWithCopperLuck _icon;

		// Token: 0x0402BA31 RID: 178737
		[Token(Token = "0x402BA31")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402BA32 RID: 178738
		[Token(Token = "0x402BA32")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _nameBg;

		// Token: 0x0402BA33 RID: 178739
		[Token(Token = "0x402BA33")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rl05FocusSkyShopPreviewItemView.NameBgColor[] _nameBgColors;

		// Token: 0x0402BA34 RID: 178740
		[Token(Token = "0x402BA34")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402BA35 RID: 178741
		[Token(Token = "0x402BA35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BA36 RID: 178742
		[Token(Token = "0x402BA36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetBgColor;

		// Token: 0x0402BA37 RID: 178743
		[Token(Token = "0x402BA37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055D8 RID: 21976
		[Token(Token = "0x20055D8")]
		public enum NameBgColorType
		{
			// Token: 0x0402BA39 RID: 178745
			[Token(Token = "0x402BA39")]
			NORMAL,
			// Token: 0x0402BA3A RID: 178746
			[Token(Token = "0x402BA3A")]
			CURSE
		}

		// Token: 0x020055D9 RID: 21977
		[Token(Token = "0x20055D9")]
		[Serializable]
		public struct NameBgColor
		{
			// Token: 0x0402BA3B RID: 178747
			[Token(Token = "0x402BA3B")]
			[FieldOffset(Offset = "0x0")]
			public Rl05FocusSkyShopPreviewItemView.NameBgColorType type;

			// Token: 0x0402BA3C RID: 178748
			[Token(Token = "0x402BA3C")]
			[FieldOffset(Offset = "0x4")]
			public Color color;
		}
	}
}
