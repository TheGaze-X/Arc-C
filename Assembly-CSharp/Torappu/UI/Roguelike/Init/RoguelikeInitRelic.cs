using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057EE RID: 22510
	[Token(Token = "0x20057EE")]
	public class RoguelikeInitRelic : RoguelikeInitCardBase
	{
		// Token: 0x06020E9C RID: 134812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E9C")]
		[Address(RVA = "0x1B410F0", Offset = "0x1B3FCF0", VA = "0x181B410F0")]
		public void Setup(RoguelikeInitRelic.Model model)
		{
		}

		// Token: 0x06020E9D RID: 134813 RVA: 0x000B7C00 File Offset: 0x000B5E00
		[Token(Token = "0x6020E9D")]
		[Address(RVA = "0x1B41400", Offset = "0x1B40000", VA = "0x181B41400")]
		private Color _GetBgColor(RoguelikeInitRelic.NameBgColorType clrType)
		{
			return default(Color);
		}

		// Token: 0x06020E9E RID: 134814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E9E")]
		[Address(RVA = "0x1B414F0", Offset = "0x1B400F0", VA = "0x181B414F0")]
		public RoguelikeInitRelic()
		{
		}

		// Token: 0x0402CBC5 RID: 183237
		[Token(Token = "0x402CBC5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _underTex;

		// Token: 0x0402CBC6 RID: 183238
		[Token(Token = "0x402CBC6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402CBC7 RID: 183239
		[Token(Token = "0x402CBC7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402CBC8 RID: 183240
		[Token(Token = "0x402CBC8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _nameBg;

		// Token: 0x0402CBC9 RID: 183241
		[Token(Token = "0x402CBC9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeInitRelic.NameBgColor[] _nameBgColors;

		// Token: 0x0402CBCA RID: 183242
		[Token(Token = "0x402CBCA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402CBCB RID: 183243
		[Token(Token = "0x402CBCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0402CBCC RID: 183244
		[Token(Token = "0x402CBCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetBgColor;

		// Token: 0x0402CBCD RID: 183245
		[Token(Token = "0x402CBCD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057EF RID: 22511
		[Token(Token = "0x20057EF")]
		public struct Model
		{
			// Token: 0x0402CBCE RID: 183246
			[Token(Token = "0x402CBCE")]
			[FieldOffset(Offset = "0x0")]
			public Sprite underTex;

			// Token: 0x0402CBCF RID: 183247
			[Token(Token = "0x402CBCF")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;

			// Token: 0x0402CBD0 RID: 183248
			[Token(Token = "0x402CBD0")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0402CBD1 RID: 183249
			[Token(Token = "0x402CBD1")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeInitRelic.NameBgColorType nameBgColor;

			// Token: 0x0402CBD2 RID: 183250
			[Token(Token = "0x402CBD2")]
			[FieldOffset(Offset = "0x20")]
			public string desc;
		}

		// Token: 0x020057F0 RID: 22512
		[Token(Token = "0x20057F0")]
		public enum NameBgColorType
		{
			// Token: 0x0402CBD4 RID: 183252
			[Token(Token = "0x402CBD4")]
			NORMAL,
			// Token: 0x0402CBD5 RID: 183253
			[Token(Token = "0x402CBD5")]
			CURSE
		}

		// Token: 0x020057F1 RID: 22513
		[Token(Token = "0x20057F1")]
		[Serializable]
		public struct NameBgColor
		{
			// Token: 0x0402CBD6 RID: 183254
			[Token(Token = "0x402CBD6")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeInitRelic.NameBgColorType type;

			// Token: 0x0402CBD7 RID: 183255
			[Token(Token = "0x402CBD7")]
			[FieldOffset(Offset = "0x4")]
			public Color color;
		}
	}
}
